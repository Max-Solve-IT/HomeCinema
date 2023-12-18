namespace project_1
{
    partial class fun_user_control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.messege_show = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.messege_show);
            this.panel1.Location = new System.Drawing.Point(3, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 27);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(459, 215);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // messege_show
            // 
            this.messege_show.AutoSize = true;
            this.messege_show.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messege_show.Location = new System.Drawing.Point(122, 0);
            this.messege_show.Name = "messege_show";
            this.messege_show.Size = new System.Drawing.Size(187, 21);
            this.messege_show.TabIndex = 0;
            this.messege_show.Text = "Password do not match";
            this.messege_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messege_show.Click += new System.EventHandler(this.messege_Click);
            // 
            // fun_user_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "fun_user_control";
            this.Size = new System.Drawing.Size(465, 254);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label messege_show;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
