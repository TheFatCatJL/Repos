namespace SportFacilitySystem
{
    partial class ReportingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFacilityInformation = new System.Windows.Forms.Button();
            this.buttonMemberList = new System.Windows.Forms.Button();
            this.crystalReportViewerReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonTransaction = new System.Windows.Forms.Button();
            this.buttonWeeklyUsage = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDailyOperations = new System.Windows.Forms.Label();
            this.labelMgtReporting = new System.Windows.Forms.Label();
            this.buttonBookingReceipt = new System.Windows.Forms.Button();
            this.comboBoxTransID = new System.Windows.Forms.ComboBox();
            this.labelTransID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFacilityInformation
            // 
            this.buttonFacilityInformation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFacilityInformation.FlatAppearance.BorderSize = 3;
            this.buttonFacilityInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacilityInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFacilityInformation.Location = new System.Drawing.Point(615, 35);
            this.buttonFacilityInformation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFacilityInformation.Name = "buttonFacilityInformation";
            this.buttonFacilityInformation.Size = new System.Drawing.Size(137, 29);
            this.buttonFacilityInformation.TabIndex = 43;
            this.buttonFacilityInformation.Text = "Facility Information";
            this.buttonFacilityInformation.UseVisualStyleBackColor = false;
            this.buttonFacilityInformation.Click += new System.EventHandler(this.buttonFacilityInformation_Click);
            // 
            // buttonMemberList
            // 
            this.buttonMemberList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMemberList.FlatAppearance.BorderSize = 3;
            this.buttonMemberList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemberList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMemberList.Location = new System.Drawing.Point(474, 35);
            this.buttonMemberList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMemberList.Name = "buttonMemberList";
            this.buttonMemberList.Size = new System.Drawing.Size(137, 29);
            this.buttonMemberList.TabIndex = 42;
            this.buttonMemberList.Text = "Member List";
            this.buttonMemberList.UseVisualStyleBackColor = false;
            this.buttonMemberList.Click += new System.EventHandler(this.buttonMemberList_Click);
            // 
            // crystalReportViewerReport
            // 
            this.crystalReportViewerReport.ActiveViewIndex = -1;
            this.crystalReportViewerReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerReport.Location = new System.Drawing.Point(12, 69);
            this.crystalReportViewerReport.Name = "crystalReportViewerReport";
            this.crystalReportViewerReport.Size = new System.Drawing.Size(1160, 630);
            this.crystalReportViewerReport.TabIndex = 44;
            // 
            // buttonTransaction
            // 
            this.buttonTransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTransaction.FlatAppearance.BorderSize = 3;
            this.buttonTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransaction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTransaction.Location = new System.Drawing.Point(756, 35);
            this.buttonTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTransaction.Name = "buttonTransaction";
            this.buttonTransaction.Size = new System.Drawing.Size(137, 29);
            this.buttonTransaction.TabIndex = 45;
            this.buttonTransaction.Text = "Transactions List";
            this.buttonTransaction.UseVisualStyleBackColor = false;
            this.buttonTransaction.Click += new System.EventHandler(this.buttonTransaction_Click);
            // 
            // buttonWeeklyUsage
            // 
            this.buttonWeeklyUsage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonWeeklyUsage.FlatAppearance.BorderSize = 3;
            this.buttonWeeklyUsage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeeklyUsage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWeeklyUsage.Location = new System.Drawing.Point(15, 35);
            this.buttonWeeklyUsage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWeeklyUsage.Name = "buttonWeeklyUsage";
            this.buttonWeeklyUsage.Size = new System.Drawing.Size(137, 29);
            this.buttonWeeklyUsage.TabIndex = 46;
            this.buttonWeeklyUsage.Text = "Daily Usage";
            this.buttonWeeklyUsage.UseVisualStyleBackColor = false;
            this.buttonWeeklyUsage.Click += new System.EventHandler(this.buttonWeeklyUsage_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.FlatAppearance.BorderSize = 3;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(1035, 35);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(137, 29);
            this.buttonExit.TabIndex = 47;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDailyOperations
            // 
            this.labelDailyOperations.AutoSize = true;
            this.labelDailyOperations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDailyOperations.Location = new System.Drawing.Point(12, 16);
            this.labelDailyOperations.Name = "labelDailyOperations";
            this.labelDailyOperations.Size = new System.Drawing.Size(112, 17);
            this.labelDailyOperations.TabIndex = 48;
            this.labelDailyOperations.Text = "Daily Operations";
            // 
            // labelMgtReporting
            // 
            this.labelMgtReporting.AutoSize = true;
            this.labelMgtReporting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgtReporting.Location = new System.Drawing.Point(471, 16);
            this.labelMgtReporting.Name = "labelMgtReporting";
            this.labelMgtReporting.Size = new System.Drawing.Size(154, 17);
            this.labelMgtReporting.TabIndex = 49;
            this.labelMgtReporting.Text = "Management Reporting";
            // 
            // buttonBookingReceipt
            // 
            this.buttonBookingReceipt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBookingReceipt.FlatAppearance.BorderSize = 3;
            this.buttonBookingReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookingReceipt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBookingReceipt.Location = new System.Drawing.Point(156, 35);
            this.buttonBookingReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBookingReceipt.Name = "buttonBookingReceipt";
            this.buttonBookingReceipt.Size = new System.Drawing.Size(137, 29);
            this.buttonBookingReceipt.TabIndex = 50;
            this.buttonBookingReceipt.Text = "Receipts";
            this.buttonBookingReceipt.UseVisualStyleBackColor = false;
            this.buttonBookingReceipt.Click += new System.EventHandler(this.buttonBookingReceipt_Click);
            // 
            // comboBoxTransID
            // 
            this.comboBoxTransID.FormattingEnabled = true;
            this.comboBoxTransID.Location = new System.Drawing.Point(353, 39);
            this.comboBoxTransID.Name = "comboBoxTransID";
            this.comboBoxTransID.Size = new System.Drawing.Size(66, 21);
            this.comboBoxTransID.TabIndex = 51;
            // 
            // labelTransID
            // 
            this.labelTransID.AutoSize = true;
            this.labelTransID.Location = new System.Drawing.Point(303, 43);
            this.labelTransID.Name = "labelTransID";
            this.labelTransID.Size = new System.Drawing.Size(45, 13);
            this.labelTransID.TabIndex = 52;
            this.labelTransID.Text = "TransID";
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.ControlBox = false;
            this.Controls.Add(this.labelTransID);
            this.Controls.Add(this.comboBoxTransID);
            this.Controls.Add(this.buttonBookingReceipt);
            this.Controls.Add(this.labelMgtReporting);
            this.Controls.Add(this.labelDailyOperations);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWeeklyUsage);
            this.Controls.Add(this.buttonTransaction);
            this.Controls.Add(this.crystalReportViewerReport);
            this.Controls.Add(this.buttonFacilityInformation);
            this.Controls.Add(this.buttonMemberList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportingForm";
            this.Text = "Report Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFacilityInformation;
        private System.Windows.Forms.Button buttonMemberList;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerReport;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Button buttonWeeklyUsage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDailyOperations;
        private System.Windows.Forms.Label labelMgtReporting;
        private System.Windows.Forms.Button buttonBookingReceipt;
        private System.Windows.Forms.ComboBox comboBoxTransID;
        private System.Windows.Forms.Label labelTransID;
    }
}