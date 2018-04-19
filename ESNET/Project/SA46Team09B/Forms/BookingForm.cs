using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SportFacilitySystem
{
    // Code by Noel-Noel and Jason
    public partial class BookingForm : Form
    {
        public List<BookingTableInitialisation> TransactionList { get; set; }
        public int BookingArrayRef {get;set;}
        

        public BookingForm()
        {
            InitializeComponent();
            dateTimePickerBooking.MinDate = DateTime.Now;
            dateTimePickerBooking.MaxDate = DateTime.Now.AddDays(7);
            dateTimePickerBooking.Format = DateTimePickerFormat.Custom;
            dateTimePickerBooking.CustomFormat = "dd MMM yyyy";
            comboBoxActivityBooking.Text = "Badminton";
            comboBoxActivityBooking.Text = "Multi-Purpose Hall";
        }

        
        private void buttonSearchBooking_Click(object sender, EventArgs e)
        {
            resetscreen();
            string Activity = this.comboBoxActivityBooking.Text;
            DateTime Date = DateTime.Parse(this.dateTimePickerBooking.Text);
            PopulateMain(Activity, Date);
        }
        
        /* PopulateMain will firstly populate the necessary rows (which is the facility ID determine by activity)
         * Then for each row, the obj behind each selection element (the labelled 1 to 6 buttons) will be generated.
         * Then base on the availability table, the button will be disabled for those unavailable timeslot
        */
        private void PopulateMain(string Activity, DateTime Date)
        {
            clearows();

            List<FacilityInformation> FindAllFacility = new List<FacilityInformation>();
            List<AvailabilityCheck> AvailList = new List<AvailabilityCheck>();
            int Maxcount = 0;
            int Maxcount2 = 0;

            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();

                var queryFacility = from x in context.FacilityInformations where x.Activity == Activity select x;
                FindAllFacility = queryFacility.ToList<FacilityInformation>();
                Maxcount = FindAllFacility.Count<FacilityInformation>();

                var BookingInitialisation = from x in context.BookingTableInitialisations select x;
                TransactionList = BookingInitialisation.ToList<BookingTableInitialisation>();

                var AvailQuery = from x in context.AvailabilityChecks where x.BookingDate == Date select x;
                AvailList = AvailQuery.ToList<AvailabilityCheck>();
                Maxcount2 = AvailList.Count<AvailabilityCheck>();
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
            }
            PopulateRows(Maxcount,FindAllFacility);
            GenerateTimeslotTransInfo(Maxcount, FindAllFacility, Maxcount2, AvailList);
            BlockOutUnavailable(Maxcount);
            ((MAIN)MdiParent).UpdateStatusLabel("Booking initialised");
        }
        
        /* PopulateRows basically show/hides pre-design rows elements
         * It also changes the label description base on the Facility Table (determined by the activity selection of user)
        */
        private void PopulateRows(int Maxcount, List<FacilityInformation> FacilityList)
        {
            Panel[] PanelArray = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6 };
            for (int i = 0; i < Maxcount; i++)
            {
                PanelArray[i].Visible = true;
            }

            Label[] RowLabelArray = new Label[] { labelRow1, labelRow2, labelRow3, labelRow4, labelRow5, labelRow6 };
            Label[] RowSubLabelArray = new Label[] { labelRow1Sub, labelRow2Sub, labelRow3Sub, labelRow4Sub, labelRow5Sub, labelRow6Sub };

            for (int j = 0; j < Maxcount; j++)
            {
                if (PanelArray[j].Visible == true)
                {
                    RowLabelArray[j].Text = FacilityList[j].FacilityID;
                    RowSubLabelArray[j].Text = FacilityList[j].Location;
                }
            }
        }

        /* GenerateTimeslotTransInfo creates the BookingTableInitialisation objs (time boxes) which will be tied to the respective row elements
         * It creation is based on the FacilityList (which basically infers the row data). Timeslot is hardcoded at the moment as a business scope consideration (where all facilities have common operation hours and timeslots for booking)
         * The BookingTableInitialisation objs is then cross checked with Availability Table and the available property is set to 0 (meaning not available) for each entry that matches. 
        */

        private void GenerateTimeslotTransInfo(int Maxcount, List<FacilityInformation> FacilityList, int Maxcount2, List<AvailabilityCheck> AvailList)
        {
            int k = 0;
            for (int i = 0; i < Maxcount; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    TransactionList[k].FacilityID = FacilityList[i].FacilityID;
                    TransactionList[k].Activity = FacilityList[i].Activity;
                    TransactionList[k].TimeSlot = j + 1;
                    TransactionList[k].TransactionType = "Book";
                    TransactionList[k].BookingDateTime = DateTime.Parse(dateTimePickerBooking.Text);
                    TransactionList[k].AvailableFlag = 1;
                    k++;
                }
            }

            for (int i = 0; i < Maxcount2; i++)
            {
                int availTimeSlot = AvailList[i].TimeSlot;
                string availFacilityID = AvailList[i].FacilityID;
                for (int j = 0; j < Maxcount * 6; j++)
                {
                    if (TransactionList[j].FacilityID == availFacilityID)
                    {
                        if (TransactionList[j].TimeSlot == availTimeSlot)
                        {
                            TransactionList[j].AvailableFlag = 0;
                        }
                    }
                }
            }
        }
        /* BlockOutUnavailable will then set the button objs according to the Available property. Booked timeslots will disabled (buttons disabled)
        */

        private void BlockOutUnavailable(int Maxcount)
        {
            Button[] AllTimeSlotButtons = new Button[]
            {
                this.buttonPosition11,this.buttonPosition12,this.buttonPosition13,this.buttonPosition14,this.buttonPosition15,this.buttonPosition16,
                this.buttonPosition21,this.buttonPosition22,this.buttonPosition23,this.buttonPosition24,this.buttonPosition25,this.buttonPosition26,
                this.buttonPosition31,this.buttonPosition32,this.buttonPosition33,this.buttonPosition34,this.buttonPosition35,this.buttonPosition36,
                this.buttonPosition41,this.buttonPosition42,this.buttonPosition43,this.buttonPosition44,this.buttonPosition45,this.buttonPosition46,
                this.buttonPosition51,this.buttonPosition52,this.buttonPosition53,this.buttonPosition54,this.buttonPosition55,this.buttonPosition56,
                this.buttonPosition61,this.buttonPosition62,this.buttonPosition63,this.buttonPosition64,this.buttonPosition65,this.buttonPosition66
            };
            for (int i = 0; i < Maxcount * 6; i++)
            {
                if (TransactionList[i].AvailableFlag == 1)
                {
                    AllTimeSlotButtons[i].Enabled = true;
                }
                else
                {
                    AllTimeSlotButtons[i].Enabled = false;
                }
            }
        }

        // This is part of the logic to prevent double booking on the same timeslot
        // The booking button is only refreshed if the user choose a date and activity.
        // The button is only finally enabled after the fields are set properly.
        private void BookingDetailsUpdate(BookingTableInitialisation UpdateTrans)
        {
            this.labelActivityStatusChange.Text = UpdateTrans.Activity;
            this.labelFacilityIDStatusChange.Text = UpdateTrans.FacilityID;
            this.labelBookDateStatusChange.Text = UpdateTrans.BookingDateTime.ToString("dd MMM yyyy");
            this.labelTransDateStatusChange.Text = DateTime.Now.ToString("dd MMM yyyy");
            this.labelTimeSlotStatusChange.Text = TimeSlotDescriptions(UpdateTrans.TimeSlot);
            this.buttonConfirmBooking.Enabled = true;
        }

        //small helper to reflect text for TimeSlots in the Booking Details
        private string TimeSlotDescriptions(int timeslot)
        {
            switch(timeslot)
            {
                case 1:
                    return "9am - 11am";
                case 2:
                    return "11am - 1pm";
                case 3:
                    return "1pm - 3pm";
                case 4:
                    return "3pm - 5pm";
                case 5:
                    return "5pm - 7pm";
                case 6:
                    return "7pm - 9pm";
                default:
                    return "No Slot";
            }
        }

        /* Button triggers the booking. Button can only be enable when a time slot element is CLICKED.
         * Otherwise, it is disabled (disabled at load of screen and after a booking)
        */
        private void buttonConfirmBooking_Click(object sender, EventArgs e)
        {
            string NUSID = this.textBoxNUSIDBooking.Text;
            this.labelWarning.Visible = false;
            this.labelNUSIDBooking.ForeColor = System.Drawing.Color.Black;
            this.labelNUSIDBooking.Text = "NUSID";
            DataChecker datacheck = new DataChecker();

            if (datacheck.NUSIDVerification(NUSID) == false)
            {
                this.labelWarning.Visible = true;
                this.labelNUSIDBooking.ForeColor = System.Drawing.Color.Red;
                this.labelNUSIDBooking.Text = "*NUSID";
            }
            else
            {
                BookingCreation(NUSID);
            }
            resetscreen();
        }

        
        // This is the block code for booking. The booking process creates an entry at the Transaction table (for recording) + an entry at AvailabilityCheck table (for tracking of availability).
        private void BookingCreation(string NUSID)
        {
            bool booksuccess = false;
            SA46Team09BEntities context = new SA46Team09BEntities();
            if (MemberCheck())             // Only allow a booking if user is member
            {
                if (CheckMemberBooking()==true)
                {
                    Transaction TempTransaction = new Transaction();
                    TempTransaction.NUSID = NUSID;
                    TempTransaction.Activity = TransactionList[BookingArrayRef].Activity.ToUpper();
                    TempTransaction.FacilityID = TransactionList[BookingArrayRef].FacilityID.ToUpper();
                    TempTransaction.BookingDateTime = TransactionList[BookingArrayRef].BookingDateTime;
                    TempTransaction.TransDateTime = DateTime.Now;
                    TempTransaction.TimeSlot = TransactionList[BookingArrayRef].TimeSlot;
                    TempTransaction.TransactionType = "Book";
                    TempTransaction.CancelRef = 0;
                   
                    try
                    {
                        context.Transactions.Add(TempTransaction);
                        context.SaveChanges();
                        booksuccess = true;
                    }
                    catch
                    {
                        MessageBox.Show("Booking Error. Please check again.");
                        ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
                        booksuccess = false;
                    }
                }
                //Thread.Sleep(2000);
                // Only create Availability Entry if the booking creation is successful
                if (booksuccess == true)        
                {
                    var queryTransactions = from x in context.Transactions select x;
                    List<Transaction> NewList = queryTransactions.ToList<Transaction>();
                    Transaction LastRecord = NewList.OrderByDescending(Transaction => Transaction.TransactionID).First();

                    AvailabilityCheck AvailabilityBlock = new AvailabilityCheck();
                    AvailabilityBlock.BookingDate = TransactionList[BookingArrayRef].BookingDateTime;
                    AvailabilityBlock.FacilityID = TransactionList[BookingArrayRef].FacilityID;
                    AvailabilityBlock.TimeSlot = TransactionList[BookingArrayRef].TimeSlot;
                    AvailabilityBlock.TransactionID = LastRecord.TransactionID;
                    AvailabilityBlock.Activity = TransactionList[BookingArrayRef].Activity;
                    AvailabilityBlock.NUSID = NUSID;

                    try
                    {
                        context.AvailabilityChecks.Add(AvailabilityBlock);
                        context.SaveChanges();
                        ((MAIN)MdiParent).UpdateStatusLabel("Transaction record and Availability entry Added");
                    }
                    catch
                    {
                        MessageBox.Show("Booking Error. Please check again.");
                        ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
                    }
                }
            }
        }

        //helper to check if the user has an active booking. Current scope is that we restrict the user to 1 booking per day
        // code by Noel-Noel Han
        public bool CheckMemberBooking()
        {
            bool temp = true;
            SA46Team09BEntities context = new SA46Team09BEntities();
            var data = (from transactions in context.Transactions
                        join availabilityChecks in context.AvailabilityChecks on transactions.NUSID equals availabilityChecks.NUSID
                        where availabilityChecks.BookingDate == transactions.BookingDateTime && availabilityChecks.Activity == transactions.Activity
                        select new { transactions, availabilityChecks });

            if (data.Any())
            {
                foreach (var v in data)
                {
                    if (v.availabilityChecks.NUSID == this.textBoxNUSIDBooking.Text.ToString() && v.availabilityChecks.BookingDate.Date == DateTime.Parse(this.dateTimePickerBooking.Text).Date && v.transactions.TransactionType == "Book")
                    {
                        MessageBox.Show("You can only make one booking per day.");
                        return false;
                    }
                }

            }
            return temp;
        }

        //Helper to check if NUSID is a registered member (lookup member table). True if registered member.
        // Coded by Noel-Noel Han
        public bool MemberCheck()
        {
            bool temp = false;
            SA46Team09BEntities context = new SA46Team09BEntities();
            var data = (from member in context.Members
                        select member);
            if (data.Any())
            {
                foreach (var v in data)
                {
                    if (v.NUSID == this.textBoxNUSIDBooking.Text.ToString())
                    {
                        temp = true;
                    }
                }
                if (temp == false)
                {
                    MessageBox.Show("Booking denied. Please register as a member first.");
                    return false;
                }
            }
            return true;
        }


        // Smaller helper to set visibility of row elements after booking
        private void clearows()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        // Smaller helper to clear booking details and disable booking button
        private void resetscreen()
        {
            this.labelActivityStatusChange.Text = "(Select)";
            this.labelBookDateStatusChange.Text = "(Select)";
            this.labelFacilityIDStatusChange.Text = "(Select)";
            this.labelTimeSlotStatusChange.Text = "(Select)";
            this.labelTransDateStatusChange.Text = "(Select)";
            this.buttonConfirmBooking.Enabled = false;
        }

        //TimeSlot Buttons codes (Hiding due to repetitive code for less clutter. To-do task in future: Maybe a way to dynamically point?)

        private void buttonPosition11_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[0]);
            BookingArrayRef = 0;
        }

        private void buttonPosition12_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[1]);
            BookingArrayRef = 1;
        }

        private void buttonPosition13_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[2]);
            BookingArrayRef = 2;
        }

        private void buttonPosition14_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[3]);
            BookingArrayRef = 3;
        }

        private void buttonPosition15_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[4]);
            BookingArrayRef = 4;
        }

        private void buttonPosition16_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[5]);
            BookingArrayRef = 5;
        }

        private void buttonPosition21_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[6]);
            BookingArrayRef = 6;
        }

        private void buttonPosition22_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[7]);
            BookingArrayRef = 7;
        }

        private void buttonPosition23_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[8]);
            BookingArrayRef = 8;
        }

        private void buttonPosition24_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[9]);
            BookingArrayRef = 9;
        }

        private void buttonPosition25_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[10]);
            BookingArrayRef = 10;
        }

        private void buttonPosition26_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[11]);
            BookingArrayRef = 11;
        }

        private void buttonPosition31_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[12]);
            BookingArrayRef = 12;
        }

        private void buttonPosition32_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[13]);
            BookingArrayRef = 13;
        }

        private void buttonPosition33_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[14]);
            BookingArrayRef = 14;
        }

        private void buttonPosition34_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[15]);
            BookingArrayRef = 15;
        }

        private void buttonPosition35_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[16]);
            BookingArrayRef = 16;
        }

        private void buttonPosition36_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[17]);
            BookingArrayRef = 17;
        }

        private void buttonPosition41_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[18]);
            BookingArrayRef = 18;
        }

        private void buttonPosition42_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[19]);
            BookingArrayRef = 19;
        }

        private void buttonPosition43_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[20]);
            BookingArrayRef = 20;
        }

        private void buttonPosition44_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[21]);
            BookingArrayRef = 21;
        }

        private void buttonPosition45_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[22]);
            BookingArrayRef = 22;
        }

        private void buttonPosition46_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[23]);
            BookingArrayRef = 23;
        }

        private void buttonPosition51_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[24]);
            BookingArrayRef = 24;
        }

        private void buttonPosition52_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[25]);
            BookingArrayRef = 25;
        }

        private void buttonPosition53_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[26]);
            BookingArrayRef = 26;
        }

        private void buttonPosition54_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[27]);
            BookingArrayRef = 27;
        }

        private void buttonPosition55_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[28]);
            BookingArrayRef = 28;
        }

        private void buttonPosition56_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[29]);
            BookingArrayRef = 29;
        }

        private void buttonPosition61_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[30]);
            BookingArrayRef = 30;
        }

        private void buttonPosition62_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[31]);
            BookingArrayRef = 31;
        }

        private void buttonPosition63_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[32]);
            BookingArrayRef = 32;
        }

        private void buttonPosition64_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[33]);
            BookingArrayRef = 33;
        }

        private void buttonPosition65_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[34]);
            BookingArrayRef = 34;
        }

        private void buttonPosition66_Click(object sender, EventArgs e)
        {
            BookingDetailsUpdate(TransactionList[35]);
            BookingArrayRef = 35;
        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ((MAIN)MdiParent).BookButtonActivate();
            ((MAIN)MdiParent).UpdateStatusLabel("Booking Form Closed");
            this.FindForm().Close();
        }
                
    }
}
