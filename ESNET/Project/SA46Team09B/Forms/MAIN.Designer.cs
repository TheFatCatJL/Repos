namespace SportFacilitySystem
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BookingToolStripMenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.facilitiesToolStripMenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookingToolStripMenuMain,
            this.cancellationToolStripMenuItem,
            this.AvailableToolStripMenuItem,
            this.membersToolStripMenuMain,
            this.facilitiesToolStripMenuMain,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(675, 61);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BookingToolStripMenuMain
            // 
            this.BookingToolStripMenuMain.Image = ((System.Drawing.Image)(resources.GetObject("BookingToolStripMenuMain.Image")));
            this.BookingToolStripMenuMain.Name = "BookingToolStripMenuMain";
            this.BookingToolStripMenuMain.Size = new System.Drawing.Size(63, 51);
            this.BookingToolStripMenuMain.Text = "Booking";
            this.BookingToolStripMenuMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BookingToolStripMenuMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BookingToolStripMenuMain.ToolTipText = "To make new bookings";
            this.BookingToolStripMenuMain.Click += new System.EventHandler(this.homeToolStripMenuMain_Click);
            // 
            // cancellationToolStripMenuItem
            // 
            this.cancellationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancellationToolStripMenuItem.Image")));
            this.cancellationToolStripMenuItem.Name = "cancellationToolStripMenuItem";
            this.cancellationToolStripMenuItem.Size = new System.Drawing.Size(85, 51);
            this.cancellationToolStripMenuItem.Text = "Cancellation";
            this.cancellationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancellationToolStripMenuItem.ToolTipText = "To cancel bookings";
            this.cancellationToolStripMenuItem.Click += new System.EventHandler(this.cancellationToolStripMenuItem_Click);
            // 
            // AvailableToolStripMenuItem
            // 
            this.AvailableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AvailableToolStripMenuItem.Image")));
            this.AvailableToolStripMenuItem.Name = "AvailableToolStripMenuItem";
            this.AvailableToolStripMenuItem.Size = new System.Drawing.Size(77, 51);
            this.AvailableToolStripMenuItem.Text = "Availability";
            this.AvailableToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AvailableToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AvailableToolStripMenuItem.ToolTipText = "To check for available time-slots";
            this.AvailableToolStripMenuItem.Click += new System.EventHandler(this.AvailableToolStripMenuItem_Click);
            // 
            // membersToolStripMenuMain
            // 
            this.membersToolStripMenuMain.Image = ((System.Drawing.Image)(resources.GetObject("membersToolStripMenuMain.Image")));
            this.membersToolStripMenuMain.Name = "membersToolStripMenuMain";
            this.membersToolStripMenuMain.Size = new System.Drawing.Size(69, 51);
            this.membersToolStripMenuMain.Text = "Members";
            this.membersToolStripMenuMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.membersToolStripMenuMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.membersToolStripMenuMain.ToolTipText = "To manage members";
            this.membersToolStripMenuMain.Click += new System.EventHandler(this.membersToolStripMenuMain_Click);
            // 
            // facilitiesToolStripMenuMain
            // 
            this.facilitiesToolStripMenuMain.Image = ((System.Drawing.Image)(resources.GetObject("facilitiesToolStripMenuMain.Image")));
            this.facilitiesToolStripMenuMain.Name = "facilitiesToolStripMenuMain";
            this.facilitiesToolStripMenuMain.Size = new System.Drawing.Size(64, 51);
            this.facilitiesToolStripMenuMain.Text = "Facilities";
            this.facilitiesToolStripMenuMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.facilitiesToolStripMenuMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.facilitiesToolStripMenuMain.ToolTipText = "To manage facilities";
            this.facilitiesToolStripMenuMain.Click += new System.EventHandler(this.facilitiesToolStripMenuMain_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 51);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportsToolStripMenuItem.ToolTipText = "To generate reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(675, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel.Text = "Awaiting User Selection";
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(675, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MAIN";
            this.ShowIcon = false;
            this.Text = "SA46Team09B - Sports Facility Booking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BookingToolStripMenuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuMain;
        private System.Windows.Forms.ToolStripMenuItem facilitiesToolStripMenuMain;
        private System.Windows.Forms.ToolStripMenuItem AvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}