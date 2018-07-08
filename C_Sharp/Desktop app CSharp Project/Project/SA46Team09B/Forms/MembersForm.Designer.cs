namespace SportFacilitySystem
{
    partial class MembersForm
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
            this.textBoxNusIDMembers = new System.Windows.Forms.TextBox();
            this.labelNusIDMembers = new System.Windows.Forms.Label();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.groupBoxMemberInfoMembers = new System.Windows.Forms.GroupBox();
            this.labelWarningMemberForm = new System.Windows.Forms.Label();
            this.radioButtonStaffMembers = new System.Windows.Forms.RadioButton();
            this.radioButtonStudentMembers = new System.Windows.Forms.RadioButton();
            this.labelInfoTypeMembers = new System.Windows.Forms.Label();
            this.buttonDeleteMembers = new System.Windows.Forms.Button();
            this.buttonCancelMembers = new System.Windows.Forms.Button();
            this.textBoxEmailMembers = new System.Windows.Forms.TextBox();
            this.labelInfoEmailMembers = new System.Windows.Forms.Label();
            this.buttonConfirmChangesMembers = new System.Windows.Forms.Button();
            this.buttonCreateMembers = new System.Windows.Forms.Button();
            this.textBoxPhoneMembers = new System.Windows.Forms.TextBox();
            this.labelInfoPhoneMembers = new System.Windows.Forms.Label();
            this.textBoxNameMembers = new System.Windows.Forms.TextBox();
            this.labelInfoNameMembers = new System.Windows.Forms.Label();
            this.labelInfoNusIDMembers = new System.Windows.Forms.Label();
            this.textBoxInfoNusIDMembers = new System.Windows.Forms.TextBox();
            this.buttonViewAllMembers = new System.Windows.Forms.Button();
            this.buttonSearchMembers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.groupBoxMemberInfoMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNusIDMembers
            // 
            this.textBoxNusIDMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNusIDMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNusIDMembers.Location = new System.Drawing.Point(288, 20);
            this.textBoxNusIDMembers.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNusIDMembers.Name = "textBoxNusIDMembers";
            this.textBoxNusIDMembers.Size = new System.Drawing.Size(168, 23);
            this.textBoxNusIDMembers.TabIndex = 0;
            // 
            // labelNusIDMembers
            // 
            this.labelNusIDMembers.AutoSize = true;
            this.labelNusIDMembers.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNusIDMembers.Location = new System.Drawing.Point(207, 21);
            this.labelNusIDMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNusIDMembers.Name = "labelNusIDMembers";
            this.labelNusIDMembers.Size = new System.Drawing.Size(53, 15);
            this.labelNusIDMembers.TabIndex = 1;
            this.labelNusIDMembers.Text = "NUS ID:";
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(12, 93);
            this.dataGridViewMembers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.RowTemplate.Height = 33;
            this.dataGridViewMembers.Size = new System.Drawing.Size(635, 227);
            this.dataGridViewMembers.TabIndex = 3;
            this.dataGridViewMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMembers_CellContentClick);
            // 
            // groupBoxMemberInfoMembers
            // 
            this.groupBoxMemberInfoMembers.Controls.Add(this.labelWarningMemberForm);
            this.groupBoxMemberInfoMembers.Controls.Add(this.radioButtonStaffMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.radioButtonStudentMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.labelInfoTypeMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.buttonDeleteMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.buttonCancelMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.textBoxEmailMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.labelInfoEmailMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.buttonConfirmChangesMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.buttonCreateMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.textBoxPhoneMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.labelInfoPhoneMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.textBoxNameMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.labelInfoNameMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.labelInfoNusIDMembers);
            this.groupBoxMemberInfoMembers.Controls.Add(this.textBoxInfoNusIDMembers);
            this.groupBoxMemberInfoMembers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMemberInfoMembers.Location = new System.Drawing.Point(12, 336);
            this.groupBoxMemberInfoMembers.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMemberInfoMembers.Name = "groupBoxMemberInfoMembers";
            this.groupBoxMemberInfoMembers.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMemberInfoMembers.Size = new System.Drawing.Size(635, 186);
            this.groupBoxMemberInfoMembers.TabIndex = 5;
            this.groupBoxMemberInfoMembers.TabStop = false;
            this.groupBoxMemberInfoMembers.Text = "MEMBER INFO";
            // 
            // labelWarningMemberForm
            // 
            this.labelWarningMemberForm.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarningMemberForm.ForeColor = System.Drawing.Color.Red;
            this.labelWarningMemberForm.Location = new System.Drawing.Point(359, 117);
            this.labelWarningMemberForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWarningMemberForm.Name = "labelWarningMemberForm";
            this.labelWarningMemberForm.Size = new System.Drawing.Size(213, 45);
            this.labelWarningMemberForm.TabIndex = 32;
            this.labelWarningMemberForm.Text = "* Denotes compulsory fields only acceptable in certain format";
            this.labelWarningMemberForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWarningMemberForm.Visible = false;
            // 
            // radioButtonStaffMembers
            // 
            this.radioButtonStaffMembers.AutoSize = true;
            this.radioButtonStaffMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStaffMembers.Location = new System.Drawing.Point(196, 57);
            this.radioButtonStaffMembers.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonStaffMembers.Name = "radioButtonStaffMembers";
            this.radioButtonStaffMembers.Size = new System.Drawing.Size(49, 19);
            this.radioButtonStaffMembers.TabIndex = 31;
            this.radioButtonStaffMembers.Text = "Staff";
            this.radioButtonStaffMembers.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudentMembers
            // 
            this.radioButtonStudentMembers.AutoSize = true;
            this.radioButtonStudentMembers.Checked = true;
            this.radioButtonStudentMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudentMembers.Location = new System.Drawing.Point(117, 57);
            this.radioButtonStudentMembers.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonStudentMembers.Name = "radioButtonStudentMembers";
            this.radioButtonStudentMembers.Size = new System.Drawing.Size(66, 19);
            this.radioButtonStudentMembers.TabIndex = 30;
            this.radioButtonStudentMembers.TabStop = true;
            this.radioButtonStudentMembers.Text = "Student";
            this.radioButtonStudentMembers.UseVisualStyleBackColor = true;
            // 
            // labelInfoTypeMembers
            // 
            this.labelInfoTypeMembers.AutoSize = true;
            this.labelInfoTypeMembers.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoTypeMembers.Location = new System.Drawing.Point(8, 58);
            this.labelInfoTypeMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoTypeMembers.Name = "labelInfoTypeMembers";
            this.labelInfoTypeMembers.Size = new System.Drawing.Size(94, 15);
            this.labelInfoTypeMembers.TabIndex = 29;
            this.labelInfoTypeMembers.Text = "Member Type:";
            this.labelInfoTypeMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonDeleteMembers
            // 
            this.buttonDeleteMembers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteMembers.FlatAppearance.BorderSize = 3;
            this.buttonDeleteMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteMembers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteMembers.Location = new System.Drawing.Point(484, 25);
            this.buttonDeleteMembers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteMembers.Name = "buttonDeleteMembers";
            this.buttonDeleteMembers.Size = new System.Drawing.Size(115, 33);
            this.buttonDeleteMembers.TabIndex = 28;
            this.buttonDeleteMembers.Text = "Delete Member";
            this.buttonDeleteMembers.UseVisualStyleBackColor = false;
            this.buttonDeleteMembers.Click += new System.EventHandler(this.buttonDeleteMembers_Click);
            // 
            // buttonCancelMembers
            // 
            this.buttonCancelMembers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancelMembers.FlatAppearance.BorderSize = 3;
            this.buttonCancelMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelMembers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancelMembers.Location = new System.Drawing.Point(484, 62);
            this.buttonCancelMembers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelMembers.Name = "buttonCancelMembers";
            this.buttonCancelMembers.Size = new System.Drawing.Size(115, 33);
            this.buttonCancelMembers.TabIndex = 23;
            this.buttonCancelMembers.Text = "Exit";
            this.buttonCancelMembers.UseVisualStyleBackColor = false;
            this.buttonCancelMembers.Click += new System.EventHandler(this.buttonCancelMembers_Click);
            // 
            // textBoxEmailMembers
            // 
            this.textBoxEmailMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxEmailMembers.Location = new System.Drawing.Point(117, 147);
            this.textBoxEmailMembers.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmailMembers.Name = "textBoxEmailMembers";
            this.textBoxEmailMembers.Size = new System.Drawing.Size(198, 23);
            this.textBoxEmailMembers.TabIndex = 19;
            // 
            // labelInfoEmailMembers
            // 
            this.labelInfoEmailMembers.AutoSize = true;
            this.labelInfoEmailMembers.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoEmailMembers.Location = new System.Drawing.Point(8, 150);
            this.labelInfoEmailMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoEmailMembers.Name = "labelInfoEmailMembers";
            this.labelInfoEmailMembers.Size = new System.Drawing.Size(96, 15);
            this.labelInfoEmailMembers.TabIndex = 18;
            this.labelInfoEmailMembers.Text = "Email Address:";
            this.labelInfoEmailMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonConfirmChangesMembers
            // 
            this.buttonConfirmChangesMembers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmChangesMembers.FlatAppearance.BorderSize = 3;
            this.buttonConfirmChangesMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmChangesMembers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConfirmChangesMembers.Location = new System.Drawing.Point(362, 62);
            this.buttonConfirmChangesMembers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmChangesMembers.Name = "buttonConfirmChangesMembers";
            this.buttonConfirmChangesMembers.Size = new System.Drawing.Size(115, 33);
            this.buttonConfirmChangesMembers.TabIndex = 17;
            this.buttonConfirmChangesMembers.Text = "Update Member";
            this.buttonConfirmChangesMembers.UseVisualStyleBackColor = false;
            this.buttonConfirmChangesMembers.Click += new System.EventHandler(this.buttonConfirmChangesMembers_Click);
            // 
            // buttonCreateMembers
            // 
            this.buttonCreateMembers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateMembers.FlatAppearance.BorderSize = 3;
            this.buttonCreateMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateMembers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCreateMembers.Location = new System.Drawing.Point(362, 25);
            this.buttonCreateMembers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateMembers.Name = "buttonCreateMembers";
            this.buttonCreateMembers.Size = new System.Drawing.Size(115, 33);
            this.buttonCreateMembers.TabIndex = 16;
            this.buttonCreateMembers.Text = "Create Member";
            this.buttonCreateMembers.UseVisualStyleBackColor = false;
            this.buttonCreateMembers.Click += new System.EventHandler(this.buttonCreateMembers_Click);
            // 
            // textBoxPhoneMembers
            // 
            this.textBoxPhoneMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPhoneMembers.Location = new System.Drawing.Point(117, 117);
            this.textBoxPhoneMembers.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhoneMembers.Name = "textBoxPhoneMembers";
            this.textBoxPhoneMembers.Size = new System.Drawing.Size(198, 23);
            this.textBoxPhoneMembers.TabIndex = 15;
            // 
            // labelInfoPhoneMembers
            // 
            this.labelInfoPhoneMembers.AutoSize = true;
            this.labelInfoPhoneMembers.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoPhoneMembers.Location = new System.Drawing.Point(8, 120);
            this.labelInfoPhoneMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoPhoneMembers.Name = "labelInfoPhoneMembers";
            this.labelInfoPhoneMembers.Size = new System.Drawing.Size(101, 15);
            this.labelInfoPhoneMembers.TabIndex = 14;
            this.labelInfoPhoneMembers.Text = "Phone Number:";
            this.labelInfoPhoneMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNameMembers
            // 
            this.textBoxNameMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNameMembers.Location = new System.Drawing.Point(117, 87);
            this.textBoxNameMembers.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameMembers.Name = "textBoxNameMembers";
            this.textBoxNameMembers.Size = new System.Drawing.Size(198, 23);
            this.textBoxNameMembers.TabIndex = 12;
            // 
            // labelInfoNameMembers
            // 
            this.labelInfoNameMembers.AutoSize = true;
            this.labelInfoNameMembers.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoNameMembers.Location = new System.Drawing.Point(8, 90);
            this.labelInfoNameMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoNameMembers.Name = "labelInfoNameMembers";
            this.labelInfoNameMembers.Size = new System.Drawing.Size(46, 15);
            this.labelInfoNameMembers.TabIndex = 7;
            this.labelInfoNameMembers.Text = "Name:";
            this.labelInfoNameMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInfoNusIDMembers
            // 
            this.labelInfoNusIDMembers.AutoSize = true;
            this.labelInfoNusIDMembers.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoNusIDMembers.Location = new System.Drawing.Point(8, 30);
            this.labelInfoNusIDMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoNusIDMembers.Name = "labelInfoNusIDMembers";
            this.labelInfoNusIDMembers.Size = new System.Drawing.Size(53, 15);
            this.labelInfoNusIDMembers.TabIndex = 7;
            this.labelInfoNusIDMembers.Text = "NUS ID:";
            this.labelInfoNusIDMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxInfoNusIDMembers
            // 
            this.textBoxInfoNusIDMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfoNusIDMembers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxInfoNusIDMembers.Location = new System.Drawing.Point(117, 25);
            this.textBoxInfoNusIDMembers.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInfoNusIDMembers.Name = "textBoxInfoNusIDMembers";
            this.textBoxInfoNusIDMembers.Size = new System.Drawing.Size(198, 23);
            this.textBoxInfoNusIDMembers.TabIndex = 6;
            // 
            // buttonViewAllMembers
            // 
            this.buttonViewAllMembers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonViewAllMembers.FlatAppearance.BorderSize = 3;
            this.buttonViewAllMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAllMembers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonViewAllMembers.Location = new System.Drawing.Point(341, 49);
            this.buttonViewAllMembers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewAllMembers.Name = "buttonViewAllMembers";
            this.buttonViewAllMembers.Size = new System.Drawing.Size(115, 33);
            this.buttonViewAllMembers.TabIndex = 54;
            this.buttonViewAllMembers.Text = "View All";
            this.buttonViewAllMembers.UseVisualStyleBackColor = false;
            this.buttonViewAllMembers.Click += new System.EventHandler(this.buttonViewAllMembers_Click);
            // 
            // buttonSearchMembers
            // 
            this.buttonSearchMembers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchMembers.FlatAppearance.BorderSize = 3;
            this.buttonSearchMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchMembers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchMembers.Location = new System.Drawing.Point(210, 49);
            this.buttonSearchMembers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchMembers.Name = "buttonSearchMembers";
            this.buttonSearchMembers.Size = new System.Drawing.Size(115, 33);
            this.buttonSearchMembers.TabIndex = 53;
            this.buttonSearchMembers.Text = "Search";
            this.buttonSearchMembers.UseVisualStyleBackColor = false;
            this.buttonSearchMembers.Click += new System.EventHandler(this.buttonSearchMembers_Click);
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(657, 561);
            this.ControlBox = false;
            this.Controls.Add(this.buttonViewAllMembers);
            this.Controls.Add(this.buttonSearchMembers);
            this.Controls.Add(this.groupBoxMemberInfoMembers);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.labelNusIDMembers);
            this.Controls.Add(this.textBoxNusIDMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MembersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Member Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.groupBoxMemberInfoMembers.ResumeLayout(false);
            this.groupBoxMemberInfoMembers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNusIDMembers;
        private System.Windows.Forms.Label labelNusIDMembers;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.GroupBox groupBoxMemberInfoMembers;
        private System.Windows.Forms.TextBox textBoxNameMembers;
        private System.Windows.Forms.Label labelInfoNameMembers;
        private System.Windows.Forms.Label labelInfoNusIDMembers;
        private System.Windows.Forms.TextBox textBoxInfoNusIDMembers;
        private System.Windows.Forms.Button buttonConfirmChangesMembers;
        private System.Windows.Forms.Button buttonCreateMembers;
        private System.Windows.Forms.TextBox textBoxPhoneMembers;
        private System.Windows.Forms.Label labelInfoPhoneMembers;
        private System.Windows.Forms.TextBox textBoxEmailMembers;
        private System.Windows.Forms.Label labelInfoEmailMembers;
        private System.Windows.Forms.Button buttonCancelMembers;
        private System.Windows.Forms.Button buttonDeleteMembers;
        private System.Windows.Forms.Label labelInfoTypeMembers;
        private System.Windows.Forms.RadioButton radioButtonStaffMembers;
        private System.Windows.Forms.RadioButton radioButtonStudentMembers;
        private System.Windows.Forms.Button buttonViewAllMembers;
        private System.Windows.Forms.Button buttonSearchMembers;
        private System.Windows.Forms.Label labelWarningMemberForm;
        
    }
}

