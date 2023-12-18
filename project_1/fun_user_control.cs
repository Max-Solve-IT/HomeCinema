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
    public partial class fun_user_control : UserControl
    {
        string picture_url;
        public fun_user_control()
        {
            InitializeComponent();
        }
        public fun_user_control(string url,string message)
        {
            this.messege_show.Text = message;
             this.picture_url =url;
             this.pictureBox.BackgroundImage = Image.FromFile(url);
            
            InitializeComponent();
        }

        private void messege_Click(object sender, EventArgs e)
        {

        }
    }
}
