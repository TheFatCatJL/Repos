using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFacilitySystem
{
    // Code by Noel-Noel, Subash and Jason
    public partial class DeleteBooking : Form
    {
        public DeleteBooking()
        {
            InitializeComponent();
        }
               
        // Search for all Bookings that DO NOT have a corresponding cancel entry (this is determined by the cancel ref property)
        private void buttonViewAllDeleteBooking_Click(object sender, EventArgs e)
        {
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                var query = from x in context.Transactions where x.TransactionType == "Book" && x.CancelRef == 0 select x;
                List<Transaction> QueryAllTransaction = query.ToList<Transaction>();
                dataGridViewDeleteBooking.DataSource = QueryAllTransaction;
                ((MAIN)MdiParent).UpdateStatusLabel("Query Completed");
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
            }
        }

        // Button will activate search base on NUSID / TransID
        private void buttonSearchDeleteBooking_Click(object sender, EventArgs e)
        {
            this.labelWarning.Visible = false;
            this.labelNusIDDeleteBooking.ForeColor = System.Drawing.Color.Black;
            DataChecker datacheck = new DataChecker();

            if (this.radioButtonNUSIDDeleteBooking.Checked == true)
            {
                SearchByNUSID(datacheck);
            }
            else
            {
                SearchByTransID(datacheck);
            }
        }

        // Query based on NUSID
        private void SearchByNUSID(DataChecker datacheck)
        {
            string searchinput = this.textBoxNusIDDeleteBooking.Text.Trim().ToUpper();
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                var querySearchByNUSID = from x in context.Transactions where x.NUSID.Contains(searchinput) && x.CancelRef == 0 select x;
                List<Transaction> ViewTransactionByNUSID = querySearchByNUSID.ToList<Transaction>();
                dataGridViewDeleteBooking.DataSource = ViewTransactionByNUSID;
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
            }
        }


        // Query based on Transaction ID
        private void SearchByTransID(DataChecker datacheck)
        {
            string searchinput = this.textBoxNusIDDeleteBooking.Text.Trim();

            if (datacheck.PositiveIntCheck(searchinput) == true)
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                int searchinputint = Convert.ToInt32(searchinput);
                var querySearchByTransID = from x in context.Transactions where x.TransactionID == searchinputint && x.CancelRef == 0 select x;
                List<Transaction> ViewTransactionByTransID = querySearchByTransID.ToList<Transaction>();
                dataGridViewDeleteBooking.DataSource = ViewTransactionByTransID;
                ((MAIN)MdiParent).UpdateStatusLabel("Query Completed");
            }
            else
            {
                this.labelWarning.Visible = true;
                this.labelNusIDDeleteBooking.ForeColor = System.Drawing.Color.Red;
                this.labelWarning.Text = "Please enter only positive integers for Transaction ID";
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
            }
        }

        // This allows populating of Booking transaction label fields area with row clicking 
        private void dataGridViewDeleteBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Transaction SelectedRow = (Transaction)dataGridViewDeleteBooking.CurrentRow.DataBoundItem;
            this.labelFillTransactionIDDeleteBooking.Text = SelectedRow.TransactionID.ToString();
            this.labelFillNusIDDeleteBooking.Text = SelectedRow.NUSID;
            this.labelFillFacilityIDDeleteBooking.Text = SelectedRow.FacilityID;
            this.labelFillActivityDeleteBooking.Text = SelectedRow.Activity;
            this.labelFillBookDateDeleteBooking.Text = SelectedRow.BookingDateTime.ToString("dd MMM yy");
            this.labelFillTransDateDeleteBooking.Text = SelectedRow.TransDateTime.ToString("dd MMM yy");
            this.labelFillTimeSlotDeleteBooking.Text = SelectedRow.TimeSlot.ToString();
            buttonDeleteBooking.Enabled = true;
        }

        //Delete booking codes
        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            int timeslot = Convert.ToInt32(this.labelFillTimeSlotDeleteBooking.Text);
            int transID = Convert.ToInt32(this.labelFillTransactionIDDeleteBooking.Text);
            int TempID = 0;

            //Creates an entry for Cancel booking record
            Transaction DeleteTrans = new Transaction();
            DeleteTrans.NUSID = this.labelFillNusIDDeleteBooking.Text;
            DeleteTrans.FacilityID = this.labelFillFacilityIDDeleteBooking.Text;
            DeleteTrans.Activity= this.labelFillActivityDeleteBooking.Text;
            DeleteTrans.BookingDateTime = DateTime.Parse(this.labelFillBookDateDeleteBooking.Text);
            DeleteTrans.TransDateTime = DateTime.Now;
            DeleteTrans.TimeSlot = timeslot;
            DeleteTrans.CancelRef = transID;
            DeleteTrans.TransactionType = "Cancel";

            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                context.Transactions.Add(DeleteTrans);
                context.SaveChanges();
                //This is to find and set the transaction ID for the new CANCEL entry to TempID 
                var RefTransQuery = from x in context.Transactions where x.CancelRef == transID select x;
                List<Transaction> RefTrans = RefTransQuery.ToList<Transaction>();
                TempID = RefTrans[0].TransactionID;

                // This is to find and set the Cancelref with the cancel booking trans ID
                // With this step done, the booking and cancellation will now have a CROSS-Reference and this can be used as a filter for refresh bookings in the cancellation screen (to ensure no records are deleted twice).

                var RefTransQuery2 = from x in context.Transactions where x.TransactionID == transID select x;
                List<Transaction> RefTrans2 = RefTransQuery2.ToList<Transaction>();
                RefTrans2[0].CancelRef = TempID;
                
                AvailabilityCheck DeleteAvail = (AvailabilityCheck)context.AvailabilityChecks.Where(M => M.TransactionID == transID).First();
                context.AvailabilityChecks.Remove(DeleteAvail);
                context.SaveChanges();
                resetscreen();
                ((MAIN)MdiParent).UpdateStatusLabel("Delete Transaction and Availability entry successfully added");
            }
            catch
            {
                MessageBox.Show("Deletion Error. Transaction ID probably did not existed or connection errors. Please check again.");
            }
        }

        // helper to reset the delete screen and to disable delete button. Ensuring the whole process of selecting valid records for deletion.
        private void resetscreen()
        {
            this.labelFillTransactionIDDeleteBooking.Text = "(Select)";
            this.labelFillNusIDDeleteBooking.Text = "(Select)";
            this.labelFillFacilityIDDeleteBooking.Text = "(Select)";
            this.labelFillActivityDeleteBooking.Text = "(Select)";
            this.labelFillBookDateDeleteBooking.Text = "(Select)";
            this.labelFillTransDateDeleteBooking.Text = "(Select)";
            this.labelFillTimeSlotDeleteBooking.Text = "(Select)";
            this.buttonDeleteBooking.Enabled = false;
        }

        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ((MAIN)MdiParent).CancelButtonActivate();
            ((MAIN)MdiParent).UpdateStatusLabel("Cancellation Form Closed");
            this.FindForm().Close();
        }
    }
}
