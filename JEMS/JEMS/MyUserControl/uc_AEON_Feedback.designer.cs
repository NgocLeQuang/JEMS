namespace JEMS.MyUserControl
{
    partial class uc_AEON_Feedback
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uc_AEON3 = new JEMS.MyUserControl.uc_AEON();
            this.uc_AEON2 = new JEMS.MyUserControl.uc_AEON();
            this.uc_AEON1 = new JEMS.MyUserControl.uc_AEON();
            this.uc_PictureBox1 = new JEMS.MyUserControl.uc_PictureBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 8;
            // 
            // uc_AEON3
            // 
            this.uc_AEON3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_AEON3.Location = new System.Drawing.Point(1102, 3);
            this.uc_AEON3.Name = "uc_AEON3";
            this.uc_AEON3.Size = new System.Drawing.Size(365, 291);
            this.uc_AEON3.TabIndex = 12;
            // 
            // uc_AEON2
            // 
            this.uc_AEON2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_AEON2.Location = new System.Drawing.Point(734, 3);
            this.uc_AEON2.Name = "uc_AEON2";
            this.uc_AEON2.Size = new System.Drawing.Size(365, 291);
            this.uc_AEON2.TabIndex = 12;
            // 
            // uc_AEON1
            // 
            this.uc_AEON1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_AEON1.Location = new System.Drawing.Point(734, 298);
            this.uc_AEON1.Name = "uc_AEON1";
            this.uc_AEON1.Size = new System.Drawing.Size(365, 291);
            this.uc_AEON1.TabIndex = 12;
            // 
            // uc_PictureBox1
            // 
            this.uc_PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_PictureBox1.AutoSize = true;
            this.uc_PictureBox1.Location = new System.Drawing.Point(34, 3);
            this.uc_PictureBox1.Name = "uc_PictureBox1";
            this.uc_PictureBox1.Size = new System.Drawing.Size(694, 583);
            this.uc_PictureBox1.TabIndex = 11;
            // 
            // uc_AEON_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.uc_AEON3);
            this.Controls.Add(this.uc_AEON2);
            this.Controls.Add(this.uc_AEON1);
            this.Controls.Add(this.uc_PictureBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "uc_AEON_Feedback";
            this.Size = new System.Drawing.Size(1470, 592);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox1;
        public uc_PictureBox uc_PictureBox1;
        public uc_AEON uc_AEON1;
        public uc_AEON uc_AEON2;
        public uc_AEON uc_AEON3;
    }
}
