namespace SportFacilitySystem
{
    partial class AvailabilityForm
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
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.comboBoxActivityQuery = new System.Windows.Forms.ComboBox();
            this.labelActivityQuery = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFromQuery = new System.Windows.Forms.DateTimePicker();
            this.buttonViewAllQuery = new System.Windows.Forms.Button();
            this.buttonSearchQuery = new System.Windows.Forms.Button();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerToQuery = new System.Windows.Forms.DateTimePicker();
            this.labelWarning = new System.Windows.Forms.Label();
            this.radioButtonAvailable = new System.Windows.Forms.RadioButton();
            this.radioButtonUnavailable = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewQuery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Location = new System.Drawing.Point(10, 152);
            this.dataGridViewQuery.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.RowTemplate.Height = 33;
            this.dataGridViewQuery.Size = new System.Drawing.Size(597, 385);
            this.dataGridViewQuery.TabIndex = 23;
            // 
            // comboBoxActivityQuery
            // 
            this.comboBoxActivityQuery.DropDownWidth = 121;
            this.comboBoxActivityQuery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActivityQuery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxActivityQuery.FormattingEnabled = true;
            this.comboBoxActivityQuery.Location = new System.Drawing.Point(242, 22);
            this.comboBoxActivityQuery.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxActivityQuery.Name = "comboBoxActivityQuery";
            this.comboBoxActivityQuery.Size = new System.Drawing.Size(205, 23);
            this.comboBoxActivityQuery.TabIndex = 36;
            // 
            // labelActivityQuery
            // 
            this.labelActivityQuery.AutoSize = true;
            this.labelActivityQuery.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivityQuery.Location = new System.Drawing.Point(162, 25);
            this.labelActivityQuery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivityQuery.Name = "labelActivityQuery";
            this.labelActivityQuery.Size = new System.Drawing.Size(58, 15);
            this.labelActivityQuery.TabIndex = 35;
            this.labelActivityQuery.Text = "Activity:";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFrom.Location = new System.Drawing.Point(162, 59);
            this.labelDateFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(72, 15);
            this.labelDateFrom.TabIndex = 39;
            this.labelDateFrom.Text = "Date From:";
            // 
            // dateTimePickerFromQuery
            // 
            this.dateTimePickerFromQuery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFromQuery.Location = new System.Drawing.Point(242, 53);
            this.dateTimePickerFromQuery.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFromQuery.Name = "dateTimePickerFromQuery";
            this.dateTimePickerFromQuery.Size = new System.Drawing.Size(85, 23);
            this.dateTimePickerFromQuery.TabIndex = 40;
            // 
            // buttonViewAllQuery
            // 
            this.buttonViewAllQuery.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonViewAllQuery.FlatAppearance.BorderSize = 3;
            this.buttonViewAllQuery.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAllQuery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonViewAllQuery.Location = new System.Drawing.Point(249, 115);
            this.buttonViewAllQuery.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewAllQuery.Name = "buttonViewAllQuery";
            this.buttonViewAllQuery.Size = new System.Drawing.Size(115, 33);
            this.buttonViewAllQuery.TabIndex = 54;
            this.buttonViewAllQuery.Text = "View All";
            this.buttonViewAllQuery.UseVisualStyleBackColor = false;
            this.buttonViewAllQuery.Click += new System.EventHandler(this.buttonViewAllQuery_Click);
            // 
            // buttonSearchQuery
            // 
            this.buttonSearchQuery.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchQuery.FlatAppearance.BorderSize = 3;
            this.buttonSearchQuery.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchQuery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearchQuery.Location = new System.Drawing.Point(130, 115);
            this.buttonSearchQuery.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchQuery.Name = "buttonSearchQuery";
            this.buttonSearchQuery.Size = new System.Drawing.Size(115, 33);
            this.buttonSearchQuery.TabIndex = 53;
            this.buttonSearchQuery.Text = "Search";
            this.buttonSearchQuery.UseVisualStyleBackColor = false;
            this.buttonSearchQuery.Click += new System.EventHandler(this.buttonSearchQuery_Click);
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTo.Location = new System.Drawing.Point(331, 57);
            this.labelDateTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(27, 15);
            this.labelDateTo.TabIndex = 55;
            this.labelDateTo.Text = "To:";
            // 
            // dateTimePickerToQuery
            // 
            this.dateTimePickerToQuery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToQuery.Location = new System.Drawing.Point(362, 53);
            this.dateTimePickerToQuery.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerToQuery.Name = "dateTimePickerToQuery";
            this.dateTimePickerToQuery.Size = new System.Drawing.Size(85, 23);
            this.dateTimePickerToQuery.TabIndex = 56;
            // 
            // labelWarning
            // 
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(463, 53);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(132, 59);
            this.labelWarning.TabIndex = 57;
            this.labelWarning.Text = "From date should be the same or lesser than To date";
            this.labelWarning.Visible = false;
            // 
            // radioButtonAvailable
            // 
            this.radioButtonAvailable.AutoSize = true;
            this.radioButtonAvailable.Checked = true;
            this.radioButtonAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAvailable.Location = new System.Drawing.Point(242, 84);
            this.radioButtonAvailable.Name = "radioButtonAvailable";
            this.radioButtonAvailable.Size = new System.Drawing.Size(83, 21);
            this.radioButtonAvailable.TabIndex = 58;
            this.radioButtonAvailable.TabStop = true;
            this.radioButtonAvailable.Text = "Available";
            this.radioButtonAvailable.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnavailable
            // 
            this.radioButtonUnavailable.AutoSize = true;
            this.radioButtonUnavailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUnavailable.Location = new System.Drawing.Point(349, 84);
            this.radioButtonUnavailable.Name = "radioButtonUnavailable";
            this.radioButtonUnavailable.Size = new System.Drawing.Size(98, 21);
            this.radioButtonUnavailable.TabIndex = 59;
            this.radioButtonUnavailable.Text = "Unavailable";
            this.radioButtonUnavailable.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.FlatAppearance.BorderSize = 3;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(368, 115);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 33);
            this.buttonExit.TabIndex = 60;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 551);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.radioButtonUnavailable);
            this.Controls.Add(this.radioButtonAvailable);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.dateTimePickerToQuery);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.buttonViewAllQuery);
            this.Controls.Add(this.buttonSearchQuery);
            this.Controls.Add(this.dateTimePickerFromQuery);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.comboBoxActivityQuery);
            this.Controls.Add(this.labelActivityQuery);
            this.Controls.Add(this.dataGridViewQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AvailabilityForm";
            this.Text = "Availability Checker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.ComboBox comboBoxActivityQuery;
        private System.Windows.Forms.Label labelActivityQuery;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromQuery;
        private System.Windows.Forms.Button buttonViewAllQuery;
        private System.Windows.Forms.Button buttonSearchQuery;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerToQuery;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.RadioButton radioButtonAvailable;
        private System.Windows.Forms.RadioButton radioButtonUnavailable;
        private System.Windows.Forms.Button buttonExit;
    }
}