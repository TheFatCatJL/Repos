namespace SportFacilitySystem
{
    partial class FacilitiesForm
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
            this.dataGridViewFacilities = new System.Windows.Forms.DataGridView();
            this.groupBoxFacilityInfoFacilities = new System.Windows.Forms.GroupBox();
            this.labelWarningFacilities = new System.Windows.Forms.Label();
            this.textBoxLocationFacilities = new System.Windows.Forms.TextBox();
            this.labelInfoLocationFacilities = new System.Windows.Forms.Label();
            this.textBoxLocationTagFacilities = new System.Windows.Forms.TextBox();
            this.labelInfoLocationTagFacilities = new System.Windows.Forms.Label();
            this.buttonDeleteFacilities = new System.Windows.Forms.Button();
            this.buttonCancelFacilities = new System.Windows.Forms.Button();
            this.buttonConfirmChangesFacilities = new System.Windows.Forms.Button();
            this.buttonAddFacilities = new System.Windows.Forms.Button();
            this.textBoxRemarksFacilities = new System.Windows.Forms.TextBox();
            this.labelInfoRemarksFacilities = new System.Windows.Forms.Label();
            this.textBoxFacilityIDFacilities = new System.Windows.Forms.TextBox();
            this.labelInfoFacilityIDFacilities = new System.Windows.Forms.Label();
            this.labelInfoActivityFacilities = new System.Windows.Forms.Label();
            this.textBoxActivityFacilities = new System.Windows.Forms.TextBox();
            this.buttonViewAllFacilities = new System.Windows.Forms.Button();
            this.buttonSearchFacilities = new System.Windows.Forms.Button();
            this.comboBoxLocationFacilities = new System.Windows.Forms.ComboBox();
            this.labelLocationFacilities = new System.Windows.Forms.Label();
            this.comboBoxActivityFacilities = new System.Windows.Forms.ComboBox();
            this.labelActivityFacilities = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacilities)).BeginInit();
            this.groupBoxFacilityInfoFacilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFacilities
            // 
            this.dataGridViewFacilities.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewFacilities.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFacilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacilities.Location = new System.Drawing.Point(11, 134);
            this.dataGridViewFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFacilities.Name = "dataGridViewFacilities";
            this.dataGridViewFacilities.RowTemplate.Height = 33;
            this.dataGridViewFacilities.Size = new System.Drawing.Size(635, 214);
            this.dataGridViewFacilities.TabIndex = 15;
            this.dataGridViewFacilities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFacilities_CellContentClick);
            // 
            // groupBoxFacilityInfoFacilities
            // 
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.labelWarningFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.textBoxLocationFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.labelInfoLocationFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.textBoxLocationTagFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.labelInfoLocationTagFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.buttonDeleteFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.buttonCancelFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.buttonConfirmChangesFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.buttonAddFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.textBoxRemarksFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.labelInfoRemarksFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.textBoxFacilityIDFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.labelInfoFacilityIDFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.labelInfoActivityFacilities);
            this.groupBoxFacilityInfoFacilities.Controls.Add(this.textBoxActivityFacilities);
            this.groupBoxFacilityInfoFacilities.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFacilityInfoFacilities.Location = new System.Drawing.Point(12, 357);
            this.groupBoxFacilityInfoFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFacilityInfoFacilities.Name = "groupBoxFacilityInfoFacilities";
            this.groupBoxFacilityInfoFacilities.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFacilityInfoFacilities.Size = new System.Drawing.Size(635, 221);
            this.groupBoxFacilityInfoFacilities.TabIndex = 16;
            this.groupBoxFacilityInfoFacilities.TabStop = false;
            this.groupBoxFacilityInfoFacilities.Text = "FACILITY INFO";
            // 
            // labelWarningFacilities
            // 
            this.labelWarningFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarningFacilities.ForeColor = System.Drawing.Color.Red;
            this.labelWarningFacilities.Location = new System.Drawing.Point(351, 119);
            this.labelWarningFacilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWarningFacilities.Name = "labelWarningFacilities";
            this.labelWarningFacilities.Size = new System.Drawing.Size(213, 45);
            this.labelWarningFacilities.TabIndex = 33;
            this.labelWarningFacilities.Text = "* Denotes compulsory fields";
            this.labelWarningFacilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWarningFacilities.Visible = false;
            // 
            // textBoxLocationFacilities
            // 
            this.textBoxLocationFacilities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocationFacilities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxLocationFacilities.Location = new System.Drawing.Point(108, 141);
            this.textBoxLocationFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLocationFacilities.Name = "textBoxLocationFacilities";
            this.textBoxLocationFacilities.Size = new System.Drawing.Size(198, 23);
            this.textBoxLocationFacilities.TabIndex = 32;
            // 
            // labelInfoLocationFacilities
            // 
            this.labelInfoLocationFacilities.AutoSize = true;
            this.labelInfoLocationFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoLocationFacilities.Location = new System.Drawing.Point(8, 144);
            this.labelInfoLocationFacilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoLocationFacilities.Name = "labelInfoLocationFacilities";
            this.labelInfoLocationFacilities.Size = new System.Drawing.Size(63, 15);
            this.labelInfoLocationFacilities.TabIndex = 31;
            this.labelInfoLocationFacilities.Text = "Location:";
            // 
            // textBoxLocationTagFacilities
            // 
            this.textBoxLocationTagFacilities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocationTagFacilities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxLocationTagFacilities.Location = new System.Drawing.Point(108, 107);
            this.textBoxLocationTagFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLocationTagFacilities.Name = "textBoxLocationTagFacilities";
            this.textBoxLocationTagFacilities.Size = new System.Drawing.Size(198, 23);
            this.textBoxLocationTagFacilities.TabIndex = 30;
            // 
            // labelInfoLocationTagFacilities
            // 
            this.labelInfoLocationTagFacilities.AutoSize = true;
            this.labelInfoLocationTagFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoLocationTagFacilities.Location = new System.Drawing.Point(8, 110);
            this.labelInfoLocationTagFacilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoLocationTagFacilities.Name = "labelInfoLocationTagFacilities";
            this.labelInfoLocationTagFacilities.Size = new System.Drawing.Size(89, 15);
            this.labelInfoLocationTagFacilities.TabIndex = 29;
            this.labelInfoLocationTagFacilities.Text = "Location Tag:";
            // 
            // buttonDeleteFacilities
            // 
            this.buttonDeleteFacilities.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteFacilities.Enabled = false;
            this.buttonDeleteFacilities.FlatAppearance.BorderSize = 3;
            this.buttonDeleteFacilities.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFacilities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteFacilities.Location = new System.Drawing.Point(473, 38);
            this.buttonDeleteFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteFacilities.Name = "buttonDeleteFacilities";
            this.buttonDeleteFacilities.Size = new System.Drawing.Size(115, 33);
            this.buttonDeleteFacilities.TabIndex = 28;
            this.buttonDeleteFacilities.Text = "Delete Facility";
            this.buttonDeleteFacilities.UseVisualStyleBackColor = false;
            this.buttonDeleteFacilities.Click += new System.EventHandler(this.buttonDeleteFacilities_Click);
            // 
            // buttonCancelFacilities
            // 
            this.buttonCancelFacilities.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancelFacilities.FlatAppearance.BorderSize = 3;
            this.buttonCancelFacilities.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelFacilities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancelFacilities.Location = new System.Drawing.Point(473, 76);
            this.buttonCancelFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelFacilities.Name = "buttonCancelFacilities";
            this.buttonCancelFacilities.Size = new System.Drawing.Size(115, 33);
            this.buttonCancelFacilities.TabIndex = 23;
            this.buttonCancelFacilities.Text = "Exit";
            this.buttonCancelFacilities.UseVisualStyleBackColor = false;
            this.buttonCancelFacilities.Click += new System.EventHandler(this.buttonCancelFacilities_Click);
            // 
            // buttonConfirmChangesFacilities
            // 
            this.buttonConfirmChangesFacilities.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmChangesFacilities.Enabled = false;
            this.buttonConfirmChangesFacilities.FlatAppearance.BorderSize = 3;
            this.buttonConfirmChangesFacilities.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmChangesFacilities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirmChangesFacilities.Location = new System.Drawing.Point(354, 76);
            this.buttonConfirmChangesFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmChangesFacilities.Name = "buttonConfirmChangesFacilities";
            this.buttonConfirmChangesFacilities.Size = new System.Drawing.Size(115, 33);
            this.buttonConfirmChangesFacilities.TabIndex = 17;
            this.buttonConfirmChangesFacilities.Text = "Update Facility";
            this.buttonConfirmChangesFacilities.UseVisualStyleBackColor = false;
            this.buttonConfirmChangesFacilities.Click += new System.EventHandler(this.buttonConfirmChangesFacilities_Click);
            // 
            // buttonAddFacilities
            // 
            this.buttonAddFacilities.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddFacilities.FlatAppearance.BorderSize = 3;
            this.buttonAddFacilities.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFacilities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddFacilities.Location = new System.Drawing.Point(354, 38);
            this.buttonAddFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddFacilities.Name = "buttonAddFacilities";
            this.buttonAddFacilities.Size = new System.Drawing.Size(115, 33);
            this.buttonAddFacilities.TabIndex = 16;
            this.buttonAddFacilities.Text = "Add Facility";
            this.buttonAddFacilities.UseVisualStyleBackColor = false;
            this.buttonAddFacilities.Click += new System.EventHandler(this.buttonAddFacilities_Click);
            // 
            // textBoxRemarksFacilities
            // 
            this.textBoxRemarksFacilities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemarksFacilities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRemarksFacilities.Location = new System.Drawing.Point(108, 176);
            this.textBoxRemarksFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRemarksFacilities.Name = "textBoxRemarksFacilities";
            this.textBoxRemarksFacilities.Size = new System.Drawing.Size(198, 23);
            this.textBoxRemarksFacilities.TabIndex = 15;
            // 
            // labelInfoRemarksFacilities
            // 
            this.labelInfoRemarksFacilities.AutoSize = true;
            this.labelInfoRemarksFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoRemarksFacilities.Location = new System.Drawing.Point(8, 179);
            this.labelInfoRemarksFacilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoRemarksFacilities.Name = "labelInfoRemarksFacilities";
            this.labelInfoRemarksFacilities.Size = new System.Drawing.Size(62, 15);
            this.labelInfoRemarksFacilities.TabIndex = 14;
            this.labelInfoRemarksFacilities.Text = "Remarks:";
            // 
            // textBoxFacilityIDFacilities
            // 
            this.textBoxFacilityIDFacilities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFacilityIDFacilities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFacilityIDFacilities.Location = new System.Drawing.Point(108, 73);
            this.textBoxFacilityIDFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFacilityIDFacilities.Name = "textBoxFacilityIDFacilities";
            this.textBoxFacilityIDFacilities.Size = new System.Drawing.Size(198, 23);
            this.textBoxFacilityIDFacilities.TabIndex = 12;
            // 
            // labelInfoFacilityIDFacilities
            // 
            this.labelInfoFacilityIDFacilities.AutoSize = true;
            this.labelInfoFacilityIDFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoFacilityIDFacilities.Location = new System.Drawing.Point(8, 75);
            this.labelInfoFacilityIDFacilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoFacilityIDFacilities.Name = "labelInfoFacilityIDFacilities";
            this.labelInfoFacilityIDFacilities.Size = new System.Drawing.Size(70, 15);
            this.labelInfoFacilityIDFacilities.TabIndex = 7;
            this.labelInfoFacilityIDFacilities.Text = "Facility ID:";
            // 
            // labelInfoActivityFacilities
            // 
            this.labelInfoActivityFacilities.AutoSize = true;
            this.labelInfoActivityFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoActivityFacilities.Location = new System.Drawing.Point(8, 40);
            this.labelInfoActivityFacilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoActivityFacilities.Name = "labelInfoActivityFacilities";
            this.labelInfoActivityFacilities.Size = new System.Drawing.Size(58, 15);
            this.labelInfoActivityFacilities.TabIndex = 7;
            this.labelInfoActivityFacilities.Text = "Activity:";
            // 
            // textBoxActivityFacilities
            // 
            this.textBoxActivityFacilities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActivityFacilities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxActivityFacilities.Location = new System.Drawing.Point(108, 38);
            this.textBoxActivityFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxActivityFacilities.Name = "textBoxActivityFacilities";
            this.textBoxActivityFacilities.Size = new System.Drawing.Size(198, 23);
            this.textBoxActivityFacilities.TabIndex = 6;
            // 
            // buttonViewAllFacilities
            // 
            this.buttonViewAllFacilities.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonViewAllFacilities.FlatAppearance.BorderSize = 3;
            this.buttonViewAllFacilities.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAllFacilities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonViewAllFacilities.Location = new System.Drawing.Point(342, 79);
            this.buttonViewAllFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewAllFacilities.Name = "buttonViewAllFacilities";
            this.buttonViewAllFacilities.Size = new System.Drawing.Size(115, 33);
            this.buttonViewAllFacilities.TabIndex = 52;
            this.buttonViewAllFacilities.Text = "View All";
            this.buttonViewAllFacilities.UseVisualStyleBackColor = false;
            this.buttonViewAllFacilities.Click += new System.EventHandler(this.buttonViewAllFacilities_Click);
            // 
            // buttonSearchFacilities
            // 
            this.buttonSearchFacilities.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchFacilities.FlatAppearance.BorderSize = 3;
            this.buttonSearchFacilities.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchFacilities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchFacilities.Location = new System.Drawing.Point(207, 79);
            this.buttonSearchFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchFacilities.Name = "buttonSearchFacilities";
            this.buttonSearchFacilities.Size = new System.Drawing.Size(115, 33);
            this.buttonSearchFacilities.TabIndex = 51;
            this.buttonSearchFacilities.Text = "Search";
            this.buttonSearchFacilities.UseVisualStyleBackColor = false;
            this.buttonSearchFacilities.Click += new System.EventHandler(this.buttonSearchFacilities_Click);
            // 
            // comboBoxLocationFacilities
            // 
            this.comboBoxLocationFacilities.DropDownWidth = 121;
            this.comboBoxLocationFacilities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLocationFacilities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxLocationFacilities.FormattingEnabled = true;
            this.comboBoxLocationFacilities.Items.AddRange(new object[] {
            "Multi-Purpose Hall",
            "Sports Centre",
            "Outdoor"});
            this.comboBoxLocationFacilities.Location = new System.Drawing.Point(288, 50);
            this.comboBoxLocationFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLocationFacilities.Name = "comboBoxLocationFacilities";
            this.comboBoxLocationFacilities.Size = new System.Drawing.Size(168, 23);
            this.comboBoxLocationFacilities.TabIndex = 56;
            // 
            // labelLocationFacilities
            // 
            this.labelLocationFacilities.AutoSize = true;
            this.labelLocationFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationFacilities.Location = new System.Drawing.Point(207, 53);
            this.labelLocationFacilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocationFacilities.Name = "labelLocationFacilities";
            this.labelLocationFacilities.Size = new System.Drawing.Size(63, 15);
            this.labelLocationFacilities.TabIndex = 55;
            this.labelLocationFacilities.Text = "Location:";
            // 
            // comboBoxActivityFacilities
            // 
            this.comboBoxActivityFacilities.DropDownWidth = 121;
            this.comboBoxActivityFacilities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActivityFacilities.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxActivityFacilities.FormattingEnabled = true;
            this.comboBoxActivityFacilities.Items.AddRange(new object[] {
            "Badminton",
            "Basketball",
            "Squash",
            "Tennis"});
            this.comboBoxActivityFacilities.Location = new System.Drawing.Point(288, 20);
            this.comboBoxActivityFacilities.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxActivityFacilities.Name = "comboBoxActivityFacilities";
            this.comboBoxActivityFacilities.Size = new System.Drawing.Size(168, 23);
            this.comboBoxActivityFacilities.TabIndex = 54;
            // 
            // labelActivityFacilities
            // 
            this.labelActivityFacilities.AutoSize = true;
            this.labelActivityFacilities.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivityFacilities.Location = new System.Drawing.Point(207, 23);
            this.labelActivityFacilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivityFacilities.Name = "labelActivityFacilities";
            this.labelActivityFacilities.Size = new System.Drawing.Size(58, 15);
            this.labelActivityFacilities.TabIndex = 53;
            this.labelActivityFacilities.Text = "Activity:";
            // 
            // FacilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 587);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxLocationFacilities);
            this.Controls.Add(this.labelLocationFacilities);
            this.Controls.Add(this.comboBoxActivityFacilities);
            this.Controls.Add(this.labelActivityFacilities);
            this.Controls.Add(this.buttonViewAllFacilities);
            this.Controls.Add(this.buttonSearchFacilities);
            this.Controls.Add(this.groupBoxFacilityInfoFacilities);
            this.Controls.Add(this.dataGridViewFacilities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacilitiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facilities Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacilities)).EndInit();
            this.groupBoxFacilityInfoFacilities.ResumeLayout(false);
            this.groupBoxFacilityInfoFacilities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewFacilities;
        private System.Windows.Forms.GroupBox groupBoxFacilityInfoFacilities;
        private System.Windows.Forms.Button buttonDeleteFacilities;
        private System.Windows.Forms.Button buttonCancelFacilities;
        private System.Windows.Forms.Button buttonConfirmChangesFacilities;
        private System.Windows.Forms.Button buttonAddFacilities;
        private System.Windows.Forms.TextBox textBoxRemarksFacilities;
        private System.Windows.Forms.Label labelInfoRemarksFacilities;
        private System.Windows.Forms.TextBox textBoxFacilityIDFacilities;
        private System.Windows.Forms.Label labelInfoFacilityIDFacilities;
        private System.Windows.Forms.Label labelInfoActivityFacilities;
        private System.Windows.Forms.TextBox textBoxActivityFacilities;
        private System.Windows.Forms.TextBox textBoxLocationFacilities;
        private System.Windows.Forms.Label labelInfoLocationFacilities;
        private System.Windows.Forms.TextBox textBoxLocationTagFacilities;
        private System.Windows.Forms.Label labelInfoLocationTagFacilities;
        private System.Windows.Forms.Button buttonViewAllFacilities;
        private System.Windows.Forms.Button buttonSearchFacilities;
        private System.Windows.Forms.ComboBox comboBoxLocationFacilities;
        private System.Windows.Forms.Label labelLocationFacilities;
        private System.Windows.Forms.ComboBox comboBoxActivityFacilities;
        private System.Windows.Forms.Label labelActivityFacilities;
        private System.Windows.Forms.Label labelWarningFacilities;
    }
}