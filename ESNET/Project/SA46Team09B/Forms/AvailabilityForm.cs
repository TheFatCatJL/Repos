using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFacilitySystem
{
    // Code by Janelle and Jason
    public partial class AvailabilityForm : Form
    {
        private List<TimeSlotBox> MyBoxes = new List<TimeSlotBox>();
        public AvailabilityForm()
        {
            InitializeComponent();
            InitialiseBoxes();          //Initialise combo box items
            InitialiseDTPickers();      //Initialise DateTimePicker - constraont dates
            InitialiseTimeBoxes();      //Initialise the timeslot objs
        }

        // Restricting User picking of dates to 7 days (inclusive of today) as a limit to scope
        private void InitialiseDTPickers()
        {
            dateTimePickerToQuery.MinDate = DateTime.Now;
            dateTimePickerToQuery.MaxDate = DateTime.Now.AddDays(7);
            dateTimePickerToQuery.Format = DateTimePickerFormat.Custom;
            dateTimePickerToQuery.CustomFormat = "dd MMM yyyy";
            dateTimePickerFromQuery.MinDate = DateTime.Now;
            dateTimePickerFromQuery.MaxDate = DateTime.Now.AddDays(7);
            dateTimePickerFromQuery.Format = DateTimePickerFormat.Custom;
            dateTimePickerFromQuery.CustomFormat = "dd MMM yyyy";
        }

        // Auto-Populated combo-boxes from datasource
        private void InitialiseBoxes()
        {
            List<string> Array1 = new List<string>();
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                var ActivityQuery = from x in context.FacilityInformations group x by x.Activity into y orderby y.Key select y;
                foreach (var x in ActivityQuery)
                {
                    Array1.Add(x.Key.ToString());
                }
                this.comboBoxActivityQuery.DataSource = Array1;

            }
            catch
            {
                MessageBox.Show("Connection error. Please try again.");
            }
            
        }

        // Creation of TimeSlotBox class which will be used as a datasource for availability checking
        private void InitialiseTimeBoxes()
        {
            List<AvailabilityCheck> AvailList = new List<AvailabilityCheck>();
            List<FacilityInformation> FacilityList = new List<FacilityInformation>();
            int Availcount = 0; 
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                var Query = from x in context.AvailabilityChecks select x;
                AvailList = Query.ToList<AvailabilityCheck>();
                Availcount = AvailList.Count<AvailabilityCheck>();

                var Query2 = from x in context.FacilityInformations select x;
                FacilityList = Query2.ToList<FacilityInformation>();
            }
            catch
            {
                MessageBox.Show("Connection error. Please try again.");
            }
            // First create the timebox regardless of availability - This creation is mainly to initiate the class objs.
            DateTime TodayDate = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                foreach (FacilityInformation x in FacilityList)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        TimeSlotBox newbox = new TimeSlotBox();
                        newbox.Activity = x.Activity;
                        newbox.FacilityID = x.FacilityID;
                        newbox.Timeslot = j + 1;
                        newbox.Bookdate = TodayDate.Date.AddDays(i);
                        newbox.Available = true;
                        MyBoxes.Add(newbox);
                    }
                }
            }

            //Then using availability table, set the timeboxes obj available property
            if (Availcount != 0)
            {
                foreach (TimeSlotBox x in MyBoxes)
                {
                    foreach (AvailabilityCheck y in AvailList)
                    {
                        if (x.FacilityID == y.FacilityID)
                        {
                            if (x.Bookdate == y.BookingDate)
                            {
                                if (x.Timeslot == y.TimeSlot)
                                {
                                    x.Available = false;
                                }
                            }
                        }
                    }
                }
            }            
        }

        //Search all timeboxes, return all create timeboxes regardless of activity, availability, and all dates within the scope (7 days)
        private void buttonViewAllQuery_Click(object sender, EventArgs e)
        {
            if (radioButtonAvailable.Checked == true) dataGridViewQuery.DataSource = MyBoxes;
            else
            {
                List<TimeSlotBox> filterboxlist = new List<TimeSlotBox>();
                foreach (TimeSlotBox x in MyBoxes)
                {
                    if (x.Available == false)
                    {
                        filterboxlist.Add(x);
                    }
                }
                dataGridViewQuery.DataSource = filterboxlist;
            }
            ((MAIN)MdiParent).UpdateStatusLabel("Query Completed");
        }

        // base on filters, compare to timeboxes properties, and return only those timeboxes objs list based on the filters.
        private void buttonSearchQuery_Click(object sender, EventArgs e)
        {
            DateChecker();
            DateTime fromdate = DateTime.Parse(dateTimePickerFromQuery.Text);
            DateTime todate = DateTime.Parse(dateTimePickerToQuery.Text);
            bool Avail = true;
            if (radioButtonAvailable.Checked == true) Avail = true;
            else Avail = false;
            string Activity = comboBoxActivityQuery.Text;

            List<TimeSlotBox> filterboxlist = new List<TimeSlotBox>();

            if (labelWarning.Visible == false)
            {
                foreach (TimeSlotBox x in MyBoxes)
                {
                    if (x.Bookdate >= fromdate && x.Bookdate <= todate)
                    {
                        if(x.Activity==Activity)
                        {
                            if(x.Available == Avail)
                            {
                                filterboxlist.Add(x);
                            }
                        }
                    }
                }
            }

            dataGridViewQuery.DataSource = filterboxlist;
            ((MAIN)MdiParent).UpdateStatusLabel("Query Completed");
        }

        // Just to ensure the from to date make sense
        private void DateChecker()
        {
            labelWarning.Visible = false;
            labelDateFrom.ForeColor = System.Drawing.Color.Black;
            labelDateTo.ForeColor = System.Drawing.Color.Black;
            DateTime FromDate = DateTime.Parse(dateTimePickerFromQuery.Text);
            DateTime ToDate = DateTime.Parse(dateTimePickerToQuery.Text);
            int DateValue = ToDate.CompareTo(FromDate);
            if (DateValue==-1)
            {
                labelWarning.Visible = true;
                labelDateFrom.ForeColor = System.Drawing.Color.Red;
                labelDateTo.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ((MAIN)MdiParent).AvailableButtonActivate();
            ((MAIN)MdiParent).UpdateStatusLabel("Availability Checker Closed");
            this.FindForm().Close();

        }
               
    }
}
