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
    public partial class user_info_form : Form
    {
        public Home_Page home_page;
        public Form1 log_in_page;
        public user usr;
        public user_info_form()
        {
            InitializeComponent();
        }
        public user_info_form(Home_Page h,Form1 f,user u)
        {
            this.usr = u;
            this.log_in_page = f;
            this.home_page = h;
            

            InitializeComponent();
        }

        public void user_info_load(object sender, EventArgs e)
        {
            this.user_info_user_name.Text = usr.name;
            this.user_info_user_gender.Text = usr.gender;
            this.user_info_date_of_birth.Text = usr.date_of_birth;
            this.user_info_user_email.Text = usr.email;
            this.user_info_user_gender.Text = usr.gender;
        }

        private void user_info_log_out_Click(object sender, EventArgs e)
        {
            this.FindForm().Show();
            this.log_in_page.Show();
            this.Close();
            this.home_page.Hide();
            this.user_info_user_name.Text = "Name";
            this.user_info_user_gender.Text = "gender";
            this.user_info_date_of_birth.Text = "Date of Birth";
            this.user_info_user_email.Text = "Email";

           /* this.user_info_user_name.Text = usr.name;
            this.user_info_user_gender.Text = usr.gender;
            this.user_info_date_of_birth.Text = usr.date_of_birth;
            this.user_info_user_email.Text = usr.email;
            this.user_info_user_gender.Text = usr.gender;
           */



        }
    }
}
