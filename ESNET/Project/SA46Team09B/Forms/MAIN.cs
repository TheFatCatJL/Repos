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
    public partial class MAIN : Form
    {
        
        public MAIN()
        {
            InitializeComponent();
            AvailabilityPurge();            
        }        

        private void AvailabilityPurge()
        {
            SA46Team09BEntities context = new SA46Team09BEntities();
            DateTime mydate = DateTime.Now.Date;
            var Query = from x in context.AvailabilityChecks where x.BookingDate < mydate select x;
            List<AvailabilityCheck> purgelist = Query.ToList<AvailabilityCheck>();
            if(purgelist.Any()) context.AvailabilityChecks.RemoveRange(purgelist);
            context.SaveChanges();
        }

        public void UpdateStatusLabel(string message)
        {
            toolStripStatusLabel.Text = message;
        }

        private void membersToolStripMenuMain_Click(object sender, EventArgs e)
        {
            MembersForm mform = new MembersForm();
            mform.ShowIcon = false;
            mform.TopLevel = false;
            mform.MdiParent = this;
            mform.Show();
            membersToolStripMenuMain.Enabled = false;
            UpdateStatusLabel("Members Management Form Open");
        }

        public void MemberButtonActivate()
        {
            membersToolStripMenuMain.Enabled = true;
        }

        private void facilitiesToolStripMenuMain_Click(object sender, EventArgs e)
        {
            FacilitiesForm Fform = new FacilitiesForm();
            Fform.ShowIcon = false;
            Fform.TopLevel = false;
            Fform.MdiParent = this;
            Fform.Show();
            facilitiesToolStripMenuMain.Enabled = false;
            UpdateStatusLabel("Facilities Management Form Open");
        }

        public void FacilitiesButtonActivate()
        {
            facilitiesToolStripMenuMain.Enabled = true;
        }

        private void homeToolStripMenuMain_Click(object sender, EventArgs e)
        {
            BookingForm Bform = new BookingForm();
            Bform.ShowIcon = false;
            Bform.TopLevel = false;
            Bform.MdiParent = this;
            Bform.Show();
            BookingToolStripMenuMain.Enabled = false;
            UpdateStatusLabel("Booking Form Open");
        }

        public void BookButtonActivate()
        {
            BookingToolStripMenuMain.Enabled = true;
        }

        private void cancellationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBooking Dform = new DeleteBooking();
            Dform.ShowIcon = false;
            Dform.TopLevel = false;
            Dform.MdiParent = this;
            Dform.Show();
            cancellationToolStripMenuItem.Enabled = false;
            UpdateStatusLabel("Cancellation Form Open");
        }
        public void CancelButtonActivate()
        {
            cancellationToolStripMenuItem.Enabled = true;
        }
                
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportingForm Rform = new ReportingForm();
            Rform.ShowIcon = false;
            Rform.TopLevel = false;
            Rform.MdiParent = this;
            Rform.Show();
            reportsToolStripMenuItem.Enabled = false;
            UpdateStatusLabel("Report Generation Form Open");
        }
        public void ReportButtonActivate()
        {
            reportsToolStripMenuItem.Enabled = true;
        }
        
        private void AvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailabilityForm Qform = new AvailabilityForm();
            Qform.ShowIcon = false;
            Qform.TopLevel = false;
            Qform.MdiParent = this;
            Qform.Show();
            AvailableToolStripMenuItem.Enabled = false;
            UpdateStatusLabel("Availability Checker Open");
        }
        public void AvailableButtonActivate()
        {
            AvailableToolStripMenuItem.Enabled = true;
        }

    }
}
