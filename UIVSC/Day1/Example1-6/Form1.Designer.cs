namespace Example1_6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fishButton
            // 
            this.fishButton.Image = ((System.Drawing.Image)(resources.GetObject("fishButton.Image")));
            this.fishButton.Location = new System.Drawing.Point(399, 247);
            this.fishButton.Name = "fishButton";
            this.fishButton.Size = new System.Drawing.Size(120, 70);
            this.fishButton.TabIndex = 0;
            this.fishButton.UseVisualStyleBackColor = true;
            this.fishButton.MouseHover += new System.EventHandler(this.fishButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.fishButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fishButton;
    }
}

