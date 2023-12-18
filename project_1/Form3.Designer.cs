namespace project_1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.file_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.File_path = new System.Windows.Forms.TextBox();
            this.upload_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.poster_path = new System.Windows.Forms.TextBox();
            this.poster_upload_btn = new System.Windows.Forms.Button();
            this.poster_view_panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.animation_radioButton = new System.Windows.Forms.RadioButton();
            this.thiller_radioButton = new System.Windows.Forms.RadioButton();
            this.comedy_radioButton = new System.Windows.Forms.RadioButton();
            this.horror_radioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sifi_radioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload Media";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(66, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "File name";
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(171, 122);
            this.file_name.Multiline = true;
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(230, 20);
            this.file_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(75, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chose Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(66, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "File Path";
            // 
            // File_path
            // 
            this.File_path.Location = new System.Drawing.Point(170, 197);
            this.File_path.Multiline = true;
            this.File_path.Name = "File_path";
            this.File_path.Size = new System.Drawing.Size(230, 20);
            this.File_path.TabIndex = 9;
            // 
            // upload_btn
            // 
            this.upload_btn.BackColor = System.Drawing.Color.Red;
            this.upload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_btn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_btn.ForeColor = System.Drawing.Color.White;
            this.upload_btn.Location = new System.Drawing.Point(325, 236);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(75, 28);
            this.upload_btn.TabIndex = 10;
            this.upload_btn.Text = "Upload";
            this.upload_btn.UseVisualStyleBackColor = false;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(531, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Poster Path";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // poster_path
            // 
            this.poster_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poster_path.Location = new System.Drawing.Point(635, 324);
            this.poster_path.Multiline = true;
            this.poster_path.Name = "poster_path";
            this.poster_path.Size = new System.Drawing.Size(230, 20);
            this.poster_path.TabIndex = 12;
            // 
            // poster_upload_btn
            // 
            this.poster_upload_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poster_upload_btn.BackColor = System.Drawing.Color.Red;
            this.poster_upload_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.poster_upload_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poster_upload_btn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poster_upload_btn.ForeColor = System.Drawing.Color.White;
            this.poster_upload_btn.Location = new System.Drawing.Point(780, 356);
            this.poster_upload_btn.Name = "poster_upload_btn";
            this.poster_upload_btn.Size = new System.Drawing.Size(75, 28);
            this.poster_upload_btn.TabIndex = 13;
            this.poster_upload_btn.Text = "Upload";
            this.poster_upload_btn.UseVisualStyleBackColor = false;
            this.poster_upload_btn.Click += new System.EventHandler(this.poster_upload_btn_Click);
            // 
            // poster_view_panel
            // 
            this.poster_view_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poster_view_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poster_view_panel.Location = new System.Drawing.Point(535, 85);
            this.poster_view_panel.Name = "poster_view_panel";
            this.poster_view_panel.Size = new System.Drawing.Size(330, 194);
            this.poster_view_panel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(75, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Chose type";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.animation_radioButton);
            this.panel1.Controls.Add(this.thiller_radioButton);
            this.panel1.Controls.Add(this.comedy_radioButton);
            this.panel1.Controls.Add(this.horror_radioButton);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.sifi_radioButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.poster_view_panel);
            this.panel1.Controls.Add(this.poster_upload_btn);
            this.panel1.Controls.Add(this.poster_path);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.upload_btn);
            this.panel1.Controls.Add(this.File_path);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.file_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(173, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 596);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(724, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // animation_radioButton
            // 
            this.animation_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.animation_radioButton.AutoSize = true;
            this.animation_radioButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animation_radioButton.ForeColor = System.Drawing.Color.White;
            this.animation_radioButton.Location = new System.Drawing.Point(79, 490);
            this.animation_radioButton.Name = "animation_radioButton";
            this.animation_radioButton.Size = new System.Drawing.Size(91, 21);
            this.animation_radioButton.TabIndex = 26;
            this.animation_radioButton.TabStop = true;
            this.animation_radioButton.Text = "Animation";
            this.animation_radioButton.UseVisualStyleBackColor = true;
            this.animation_radioButton.CheckedChanged += new System.EventHandler(this.animation_radioButton_CheckedChanged);
            // 
            // thiller_radioButton
            // 
            this.thiller_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thiller_radioButton.AutoSize = true;
            this.thiller_radioButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thiller_radioButton.ForeColor = System.Drawing.Color.White;
            this.thiller_radioButton.Location = new System.Drawing.Point(79, 513);
            this.thiller_radioButton.Name = "thiller_radioButton";
            this.thiller_radioButton.Size = new System.Drawing.Size(66, 21);
            this.thiller_radioButton.TabIndex = 25;
            this.thiller_radioButton.TabStop = true;
            this.thiller_radioButton.Text = "Thiller";
            this.thiller_radioButton.UseVisualStyleBackColor = true;
            this.thiller_radioButton.CheckedChanged += new System.EventHandler(this.thiller_radioButton_CheckedChanged);
            // 
            // comedy_radioButton
            // 
            this.comedy_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comedy_radioButton.AutoSize = true;
            this.comedy_radioButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comedy_radioButton.ForeColor = System.Drawing.Color.White;
            this.comedy_radioButton.Location = new System.Drawing.Point(79, 536);
            this.comedy_radioButton.Name = "comedy_radioButton";
            this.comedy_radioButton.Size = new System.Drawing.Size(76, 21);
            this.comedy_radioButton.TabIndex = 24;
            this.comedy_radioButton.TabStop = true;
            this.comedy_radioButton.Text = "Comedy";
            this.comedy_radioButton.UseVisualStyleBackColor = true;
            this.comedy_radioButton.CheckedChanged += new System.EventHandler(this.comedy_radioButton_CheckedChanged);
            // 
            // horror_radioButton
            // 
            this.horror_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.horror_radioButton.AutoSize = true;
            this.horror_radioButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horror_radioButton.ForeColor = System.Drawing.Color.White;
            this.horror_radioButton.Location = new System.Drawing.Point(79, 559);
            this.horror_radioButton.Name = "horror_radioButton";
            this.horror_radioButton.Size = new System.Drawing.Size(67, 21);
            this.horror_radioButton.TabIndex = 23;
            this.horror_radioButton.TabStop = true;
            this.horror_radioButton.Text = "Horror";
            this.horror_radioButton.UseVisualStyleBackColor = true;
            this.horror_radioButton.CheckedChanged += new System.EventHandler(this.horror_radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(79, 444);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 21);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Action";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // sifi_radioButton
            // 
            this.sifi_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sifi_radioButton.AutoSize = true;
            this.sifi_radioButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifi_radioButton.ForeColor = System.Drawing.Color.White;
            this.sifi_radioButton.Location = new System.Drawing.Point(79, 467);
            this.sifi_radioButton.Name = "sifi_radioButton";
            this.sifi_radioButton.Size = new System.Drawing.Size(53, 21);
            this.sifi_radioButton.TabIndex = 21;
            this.sifi_radioButton.TabStop = true;
            this.sifi_radioButton.Text = "SI-FI";
            this.sifi_radioButton.UseVisualStyleBackColor = true;
            this.sifi_radioButton.CheckedChanged += new System.EventHandler(this.sifi_radioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(820, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Confirm Upload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(79, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Series";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(79, 340);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 21);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Movie";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1255, 689);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.form3_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox file_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox File_path;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox poster_path;
        private System.Windows.Forms.Button poster_upload_btn;
        private System.Windows.Forms.Panel poster_view_panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton animation_radioButton;
        private System.Windows.Forms.RadioButton thiller_radioButton;
        private System.Windows.Forms.RadioButton comedy_radioButton;
        private System.Windows.Forms.RadioButton horror_radioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton sifi_radioButton;
        private System.Windows.Forms.Button button2;
    }
}