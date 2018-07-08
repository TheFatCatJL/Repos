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
    public partial class FacilitiesForm : Form
    {
        public FacilitiesForm()
        {
            InitializeComponent();
        }

        // Search all button code
        private void buttonViewAllFacilities_Click(object sender, EventArgs e)
        {
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                var queryViewAllFacilities = from x in context.FacilityInformations select x;
                List<FacilityInformation> ViewAllFacilitiesList = queryViewAllFacilities.ToList<FacilityInformation>();
                dataGridViewFacilities.DataSource = ViewAllFacilitiesList;
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
            }
        }

        // Search by Activity / Location / Both 
        private void buttonSearchFacilities_Click(object sender, EventArgs e)
        {
            string userActivity = this.comboBoxActivityFacilities.Text;
            string userLocation = this.comboBoxLocationFacilities.Text;
            if (userActivity != null)
            {
                if (userLocation != null) searchByActivityLocation();
                else searchByActivity();
            }
            else searchByLocation();
                       
        }

        // Search by Location 
        private void searchByLocation()
        {
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                string userlocation = this.comboBoxLocationFacilities.Text;
                var queryViewLocation = from x in context.FacilityInformations where x.LocationTag == userlocation select x;
                List<FacilityInformation> ViewLocationList = queryViewLocation.ToList<FacilityInformation>();
                dataGridViewFacilities.DataSource = ViewLocationList;
                ((MAIN)MdiParent).UpdateStatusLabel("Query Completed");
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");

            }
        }

        // Search By Activity
        private void searchByActivity()
        {
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                string useractivity = this.comboBoxActivityFacilities.Text;
                var queryViewActivity = from x in context.FacilityInformations where x.Activity == useractivity select x;
                List<FacilityInformation> ViewActivityList = queryViewActivity.ToList<FacilityInformation>();
                dataGridViewFacilities.DataSource = ViewActivityList;
                ((MAIN)MdiParent).UpdateStatusLabel("Query Completed");
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
            }
        }

        // Search by both activity and location
        private void searchByActivityLocation()
        {
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                string useractivity = this.comboBoxActivityFacilities.Text;
                var queryViewActivity = from x in context.FacilityInformations where x.Activity == useractivity select x;
                List<FacilityInformation> ViewActivityList = queryViewActivity.ToList<FacilityInformation>();
                string userlocation = this.comboBoxLocationFacilities.Text;
                var queryViewLocation = from x in ViewActivityList where x.LocationTag == userlocation select x;
                List<FacilityInformation> ViewActivityLocationList = queryViewLocation.ToList<FacilityInformation>();
                dataGridViewFacilities.DataSource = ViewActivityLocationList;
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
            }
        }

        //Dynamic Update of datafield for update and delete (selecting row from DataGridView)
        private void dataGridViewFacilities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FacilityInformation SelectedRow = (FacilityInformation)dataGridViewFacilities.CurrentRow.DataBoundItem;
            textBoxActivityFacilities.Text = SelectedRow.Activity;
            textBoxFacilityIDFacilities.Text = SelectedRow.FacilityID;
            textBoxLocationTagFacilities.Text = SelectedRow.LocationTag;
            textBoxLocationFacilities.Text = SelectedRow.Location;
            textBoxRemarksFacilities.Text = SelectedRow.Remarks;
            buttonConfirmChangesFacilities.Enabled = true;
            buttonDeleteFacilities.Enabled = true;
        }


        // Add Button code - preparation of FacilityInformation obj before calling for facility creation

        private void buttonAddFacilities_Click(object sender, EventArgs e)
        {
            string Activity = this.textBoxActivityFacilities.Text.Trim();
            string FacilityID = this.textBoxFacilityIDFacilities.Text.Trim().ToUpper();
            string LocationTag = this.textBoxLocationTagFacilities.Text.Trim();
            string Location = this.textBoxLocationFacilities.Text.Trim();
            string Remarks = this.textBoxRemarksFacilities.Text.Trim();

            if (Activity == "" || FacilityID == "" || LocationTag == "" || Location == "")
            {
                MessageBox.Show("Please enter data into required fields.");
                return;
            }               

            FacilityInformation NewFacility = new FacilityInformation()
            { Activity = Activity, FacilityID = FacilityID, LocationTag = LocationTag, Location = Location, Remarks = Remarks };
            createFacility(NewFacility);
        }

        // Facility Creation  - actual Entity action
        private void createFacility(FacilityInformation NewFacility)
        {
            try
            {
                using (SA46Team09BEntities context = new SA46Team09BEntities())
                {
                    context.FacilityInformations.Add(NewFacility);
                    context.SaveChanges();
                    ((MAIN)MdiParent).UpdateStatusLabel("Facilities record successfully added");
                }
            }
            catch
            {
                MessageBox.Show("Creation Error. FacilityID probably existed. Please check again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
            }
        }


        // Delete button code - checking and preparing data before calling for deletion
        private void buttonDeleteFacilities_Click(object sender, EventArgs e)
        {
            this.labelWarningFacilities.Visible = false;
            this.labelInfoFacilityIDFacilities.ForeColor = System.Drawing.Color.Black;
            this.labelInfoFacilityIDFacilities.Text = "FacilityID:";

            if (this.textBoxFacilityIDFacilities.Text == "")
            {
                this.labelWarningFacilities.Visible = true;
                this.labelInfoFacilityIDFacilities.ForeColor = System.Drawing.Color.Red;
                this.labelInfoFacilityIDFacilities.Text = "*FacilityID:";
            }
            else
            {
                string FacilityID = this.textBoxFacilityIDFacilities.Text.Trim().ToUpper();
                DeleteFacility(FacilityID);
            }
        }
        // delete facility - actual Entity action
        private bool DeleteFacility(string FacilityID)
        {
            try
            {
                using (SA46Team09BEntities context = new SA46Team09BEntities())
                {
                    FacilityInformation DeleteFacility = (FacilityInformation)context.FacilityInformations.Where(F => F.FacilityID == FacilityID).First();
                    context.FacilityInformations.Remove(DeleteFacility);
                    context.SaveChanges();
                    ((MAIN)MdiParent).UpdateStatusLabel("Facilities successfully deleted");
                }
            }
            catch
            {
                MessageBox.Show("Deletion Error. FacilityID probably did not existed. Please check again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
                return false;
            }
            return true;
        }

        // Updates to facility information - currently programmed as a create and delete operation
        private void buttonConfirmChangesFacilities_Click(object sender, EventArgs e)
        {
            string Activity = this.textBoxActivityFacilities.Text.Trim();
            string FacilityID = this.textBoxFacilityIDFacilities.Text.Trim().ToUpper();
            string LocationTag = this.textBoxLocationTagFacilities.Text.Trim();
            string Location = this.textBoxLocationFacilities.Text.Trim();
            string Remarks = this.textBoxRemarksFacilities.Text.Trim();
            FacilityInformation NewFacility = new FacilityInformation()
            { Activity = Activity, FacilityID = FacilityID, LocationTag = LocationTag, Location = Location, Remarks = Remarks };
            bool flag = DeleteFacility(FacilityID);
            if (flag == true) createFacility(NewFacility);
        }


        private void buttonCancelFacilities_Click(object sender, EventArgs e)
        {
            ((MAIN)MdiParent).FacilitiesButtonActivate();
            ((MAIN)MdiParent).UpdateStatusLabel("Facilities Management closed");
            this.FindForm().Close();
        }

    }
}
