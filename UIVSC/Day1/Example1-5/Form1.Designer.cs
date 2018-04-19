namespace Example1_5
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
            this.buttonRabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRabbit
            // 
            this.buttonRabbit.Image = ((System.Drawing.Image)(resources.GetObject("buttonRabbit.Image")));
            this.buttonRabbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRabbit.Location = new System.Drawing.Point(406, 193);
            this.buttonRabbit.Name = "buttonRabbit";
            this.buttonRabbit.Size = new System.Drawing.Size(70, 125);
            this.buttonRabbit.TabIndex = 0;
            this.buttonRabbit.Text = "Catch ME!";
            this.buttonRabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRabbit.UseVisualStyleBackColor = true;
            this.buttonRabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRabbit_MouseDown);
            this.buttonRabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRabbit_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonRabbit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRabbit;
    }
}

