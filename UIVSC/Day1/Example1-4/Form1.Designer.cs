namespace Example1_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRabbit
            // 
            this.buttonRabbit.Image = ((System.Drawing.Image)(resources.GetObject("buttonRabbit.Image")));
            this.buttonRabbit.Location = new System.Drawing.Point(794, 355);
            this.buttonRabbit.Name = "buttonRabbit";
            this.buttonRabbit.Size = new System.Drawing.Size(78, 107);
            this.buttonRabbit.TabIndex = 0;
            this.buttonRabbit.Text = "Rabbit";
            this.buttonRabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRabbit.UseVisualStyleBackColor = true;
            this.buttonRabbit.Click += new System.EventHandler(this.buttonRabbit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of times you caught the rabbit :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRabbit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRabbit;

        private void HideRabbit()
        {
            this.buttonRabbit.Text = "Game Over";
            this.buttonRabbit.Visible = false;
        }
    }
}

