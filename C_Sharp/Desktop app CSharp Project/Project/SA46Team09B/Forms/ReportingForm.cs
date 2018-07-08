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
    public partial class ReportingForm : Form
    {
        public ReportingForm()
        {
            InitializeComponent();
            TransIDUpdate();
        }
        // Crystal Report Generation codes
        // Coded by Janelle

        private void TransIDUpdate()
        {
            List<string> Array1 = new List<string>();
            try
            {
                SA46Team09BEntities context = new SA46Team09BEntities();
                var ActivityQuery = from x in context.Transactions select x;
                foreach (var x in ActivityQuery)
                {
                    Array1.Add(x.TransactionID.ToString());
                }
                this.comboBoxTransID.DataSource = Array1;

            }
            catch
            {
                MessageBox.Show("Connection error. Please try again.");
            }

        }
        private void buttonMemberList_Click(object sender, EventArgs e)
        {
            SA46Team09BEntities context = new SA46Team09BEntities();
            MemberManagement CR = new MemberManagement();
            CR.SetDataSource(context.Members);
            crystalReportViewerReport.ReportSource = CR;
            ((MAIN)MdiParent).UpdateStatusLabel("Report Generated");
        }

        private void buttonFacilityInformation_Click(object sender, EventArgs e)
        {
            SA46Team09BEntities context = new SA46Team09BEntities();
            FacilitiesInfo CR = new FacilitiesInfo();
            CR.SetDataSource(context.FacilityInformations);
            crystalReportViewerReport.ReportSource = CR;
            ((MAIN)MdiParent).UpdateStatusLabel("Report Generated");
        }

        private void buttonWeeklyUsage_Click(object sender, EventArgs e)
        {
            SA46Team09BEntities context = new SA46Team09BEntities();
            DateTime mydate = DateTime.Now.Date;
            DailyUsageRate CR = new DailyUsageRate();
            var Query = from x in context.Transactions where x.CancelRef == 0 && x.BookingDateTime >= mydate select x;
            List<Transaction> Translist = Query.ToList<Transaction>();
            CR.Database.Tables[0].SetDataSource(context.FacilityInformations);
            CR.Database.Tables[1].SetDataSource(Translist);
            crystalReportViewerReport.ReportSource = CR;
            ((MAIN)MdiParent).UpdateStatusLabel("Report Generated");
        }
                
        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            SA46Team09BEntities context = new SA46Team09BEntities();
            TransactionsList CR = new TransactionsList();
            CR.Database.Tables[0].SetDataSource(context.Transactions);
            CR.Database.Tables[1].SetDataSource(context.Members);
            crystalReportViewerReport.ReportSource = CR;
            ((MAIN)MdiParent).UpdateStatusLabel("Report Generated");
        }

        private void buttonBookingReceipt_Click(object sender, EventArgs e)
        {
 
            List<Transaction> Translist = new List<Transaction>();
            TransactionsList CR = new TransactionsList();
            List<Member> Memlist = new List<Member>();
            
            SA46Team09BEntities context = new SA46Team09BEntities();
            int transid = Convert.ToInt32(this.comboBoxTransID.Text);
            var Query = from x in context.Transactions where x.TransactionID == transid select x;
            Translist = Query.ToList<Transaction>();
            string NUSID = Translist[0].NUSID;


            var Query2 = from x in context.Members where x.NUSID == NUSID select x;
            Memlist = Query2.ToList<Member>();                      

            CR.Database.Tables[0].SetDataSource(Translist);
            CR.Database.Tables[1].SetDataSource(Memlist);

            crystalReportViewerReport.ReportSource = CR;
            ((MAIN)MdiParent).UpdateStatusLabel("Report Generated");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ((MAIN)MdiParent).ReportButtonActivate();
            ((MAIN)MdiParent).UpdateStatusLabel("Report Generation Form closed");
            this.FindForm().Close();
        }
    }
}
