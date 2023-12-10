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
    public partial class Home_Page : Form
    {
        public Form1 login_page;
       
        public Home_Page()
        {
           //login_page = new Form1();
            InitializeComponent();
        }
        public Home_Page(Form1 f)
        {

            this.login_page = f;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            //f1.Close();
        }

        private void Log_out_btn_Click(object sender, EventArgs e)
        {
            
            this.login_page.Show();
            this.Hide();

        }
    }
}
