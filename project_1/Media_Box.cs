using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Media_Box : UserControl
    {
        private string _title;
        private string _poster_path;
        private string _video_url;
        private Timer timer;
        private Form videoDetailsForm;
        public Media_Box()
        {
            InitializeComponent();
            InitializeTimer();
            InitializeVideoDetailsForm();
        }
        #region
        public string title
        {
            get { return _title; }
            set { _title = value; Title_lable.Text = value; }
        }
        public string video_utl
        {
            get { return (string)_video_url; }
            set { _video_url = value; }
        }
        public string poster_path
        {
            set { _poster_path = value; }//  Image image = Image.FromFile(value); poster.Image = image;}
            get { return _poster_path; }

        }
        private void TimerTickHandler(object sender, EventArgs e)
        {
            timer.Stop();
            ShowVideoDetails();
        }
        public void Mouse_leave(object sender, EventArgs e)
        {
           
            this.BackColor = System.Drawing.SystemColors.Highlight;
            timer.Stop();
           



        }
        public void Mouse_click(object sender, MouseEventArgs e)
        {
            //this.video_utl = @"C:\Users\pc\Desktop\server\Media\Interstellar.mp4";
            //MessageBox.Show("media box clicked");
            Form2 play = new Form2(this.video_utl);
            play.Show();

        }
        #endregion

        private void Mouse_endter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
          //  MessageBox.Show("Swajan");
            timer.Start();

        }
        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (videoDetailsForm != null)
            {
                videoDetailsForm.Close();
            }
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 3000; // 10 seconds
            timer.Tick += TimerTickHandler;

        }
        private void InitializeVideoDetailsForm()
        {
            videoDetailsForm = new Form();
            videoDetailsForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            videoDetailsForm.StartPosition = FormStartPosition.Manual;
            videoDetailsForm.ShowInTaskbar = false;
            videoDetailsForm.Size = new Size(200, 100);
            videoDetailsForm.TopMost = true;
            videoDetailsForm.Opacity = 0.95;
            videoDetailsForm.MouseMove += MouseMoveHandler;
            videoDetailsForm.MouseLeave += VideoDetailsFormMouseLeave;
            
        }
        private void ShowVideoDetails()
        {
            // Display video details in a MessageBox-like form
            videoDetailsForm.Location = this.PointToScreen(new Point(0, 0));
            Label label = new Label();
            label.Text = $"Title: {title}";
            label.Dock = DockStyle.Fill;
            videoDetailsForm.Controls.Add(label);
            videoDetailsForm.ShowDialog();
        }
        private void VideoDetailsFormMouseLeave(object sender, EventArgs e)
        {
            // Close the videoDetailsForm when the mouse leaves the form
            if (videoDetailsForm != null)
            {
                videoDetailsForm.Close();
            }
        }
    }
}
