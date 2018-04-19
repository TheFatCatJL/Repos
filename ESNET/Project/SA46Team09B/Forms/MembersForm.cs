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
    // Code by Noel-Noel, Subash, and Jason
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
        }

        // [Member Form - Data Integrity Checking codes]

        private int MobileNumCheck(DataChecker datacheck, string Mobile)
        {
            if (datacheck.PositiveIntCheck(Mobile) == false)
            {
                labelInfoPhoneMembers.ForeColor = System.Drawing.Color.Red;
                labelInfoPhoneMembers.Text = "*Phone Number:";
                textBoxPhoneMembers.Text = "Only local phone number w/o +";
                labelWarningMemberForm.Visible = true;
                return 0;
            }
            else
            {
                labelInfoPhoneMembers.ForeColor = System.Drawing.Color.Black;
                labelInfoPhoneMembers.Text = "Phone Number:";
                return Convert.ToInt32(Mobile);
            }
        }

        private void NUSIDCheck(DataChecker datacheck, string NUSID)
        {
            if (datacheck.NUSIDVerification(NUSID) == false)
            {
                labelInfoNusIDMembers.ForeColor = System.Drawing.Color.Red;
                labelInfoNusIDMembers.Text = "*NUS ID:";
                textBoxInfoNusIDMembers.Text = "Enter in the format of A123456B";
                labelWarningMemberForm.Visible = true;
            }
            else
            {
                labelInfoNusIDMembers.ForeColor = System.Drawing.Color.Black;
                labelInfoNusIDMembers.Text = "NUS ID:";

            }
        }

        private string MemberTypeCheck()
        {
            if (radioButtonStudentMembers.Checked == true) return "Student";
            else return "Staff";
        }

        // [Member Form - Search Button codes]
        private void buttonViewAllMembers_Click(object sender, EventArgs e)
        {
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                var queryViewAllMembers = from x in context.Members select x;
                List<Member> ViewAllMemberList = queryViewAllMembers.ToList<Member>();
                dataGridViewMembers.DataSource = ViewAllMemberList;
                ((MAIN)MdiParent).UpdateStatusLabel("Query Completed");
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
            }
        }

        private void buttonSearchMembers_Click(object sender, EventArgs e)
        {
            string searchinput = this.textBoxNusIDMembers.Text.Trim().ToUpper();
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                var queryViewAllMembers = from x in context.Members where x.NUSID.Contains(searchinput) select x;
                List<Member> ViewAllMemberList = queryViewAllMembers.ToList<Member>();
                dataGridViewMembers.DataSource = ViewAllMemberList;
                ((MAIN)MdiParent).UpdateStatusLabel("Query Completed");
            }
            catch
            {
                MessageBox.Show("Connection fail. Please try again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
            }
        }
        // Dynamic searching and populating of text boxes for update & delete
        private void dataGridViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Member SelectedRow = (Member)dataGridViewMembers.CurrentRow.DataBoundItem;
            textBoxInfoNusIDMembers.Text = SelectedRow.NUSID;
            textBoxNameMembers.Text = SelectedRow.Name;
            textBoxPhoneMembers.Text = Convert.ToString(SelectedRow.Mobile);
            textBoxEmailMembers.Text = SelectedRow.Email;
            string membertype = SelectedRow.MemberType;
            if (membertype == "Student") radioButtonStudentMembers.Checked = true;
            else radioButtonStaffMembers.Checked = true;
        }
        
        // [Member Form - Create Button codes]
        private void buttonCreateMembers_Click(object sender, EventArgs e)
        {
            // Form Obj initialisation
            DataChecker datacheck = new DataChecker();

            //Form vairables initialisation
            labelWarningMemberForm.Visible = false;
            string NUSID = this.textBoxInfoNusIDMembers.Text.Trim().ToUpper();
            string MemberType = MemberTypeCheck();
            string Name = this.textBoxNameMembers.Text.Trim();
            int Mobile = MobileNumCheck(datacheck, this.textBoxPhoneMembers.Text.Trim());
            string Email = this.textBoxEmailMembers.Text.Trim();
            NUSIDCheck(datacheck, NUSID);
            
            // Member creation - using warning label as bool flag decider
            if (labelWarningMemberForm.Visible == false)
            {
                Member NewMember = new Member
                { NUSID = NUSID, MemberType = MemberType,Name = Name, Mobile = Mobile, Email = Email };
                CreateMember(NewMember);                             
            }
        }

        // [Member Form - Create Button codes]
        private void CreateMember(Member NewMember)
        {
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                context.Members.Add(NewMember);
                context.SaveChanges();
                ((MAIN)MdiParent).UpdateStatusLabel("Member record successfully added");
            }
            catch
            {
                MessageBox.Show("Creation Error. NUSID probably existed. Please check again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
            }
        }
       
        
        // [Member Form - Delete Button codes]
        private void buttonDeleteMembers_Click(object sender, EventArgs e)
        {
            // Form Obj initialisation
            DataChecker datacheck = new DataChecker();
            labelWarningMemberForm.Visible = false;
            string NUSID = this.textBoxInfoNusIDMembers.Text.Trim().ToUpper();
            NUSIDCheck(datacheck, NUSID);

            if (labelWarningMemberForm.Visible == false)
            {
                DeleteMember(NUSID);
            }
        }

        private bool DeleteMember(string NUSID)
        {
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                Member DeleteMember = (Member)context.Members.Where(M => M.NUSID == NUSID).First();
                context.Members.Remove(DeleteMember);
                context.SaveChanges();
                ((MAIN)MdiParent).UpdateStatusLabel("Member record successfully deleted");
            }
            catch
            {
                MessageBox.Show("Deletion Error. NUSID probably did not existed. Please check again.");
                ((MAIN)MdiParent).UpdateStatusLabel("Error encounter in last transaction...");
                return false;
            }
            return true;
        }

        // [Member Form - Update Button codes]

        private void buttonConfirmChangesMembers_Click(object sender, EventArgs e)
        {
            DataChecker datacheck = new DataChecker();
            labelWarningMemberForm.Visible = false;
            string NUSID = this.textBoxInfoNusIDMembers.Text.Trim().ToUpper();
            string MemberType = MemberTypeCheck();
            string Name = this.textBoxNameMembers.Text.Trim();
            int Mobile = MobileNumCheck(datacheck, this.textBoxPhoneMembers.Text.Trim());
            string Email = this.textBoxEmailMembers.Text.Trim();
            NUSIDCheck(datacheck, NUSID);

            // using warning label as bool flag decider
            if (labelWarningMemberForm.Visible == false)
            {
                Member NewMember = new Member
                { NUSID = NUSID, MemberType = MemberType, Name = Name, Mobile = Mobile, Email = Email };
                bool flag = DeleteMember(NUSID);
                if (flag == true) CreateMember(NewMember);
                ((MAIN)MdiParent).UpdateStatusLabel("Member record successfully updated");
            }
        }
        private void buttonCancelMembers_Click(object sender, EventArgs e)
        {
            ((MAIN)MdiParent).MemberButtonActivate();
            ((MAIN)MdiParent).UpdateStatusLabel("Member Management closed");
            this.FindForm().Close();
        }

    }
}
