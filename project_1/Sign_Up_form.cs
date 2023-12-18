using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_1
{
    public partial class Sign_Up_form : Form
    {
        public Form1 login_page;
        private MySqlConnection connection;
        private const string connectionString = "Server=localhost;Database=the_media_library;User ID=root;Password=toor;";
        public string gender;

        public Sign_Up_form()
        {
            InitializeComponent();
        }
        public Sign_Up_form(Form1 f)
        {
            this.login_page = f;
            InitializeComponent();
        }

        public void Sign_Up_form_Load(object sender , EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
               // MessageBox.Show("Ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_in_btn_Click(object sender, EventArgs e)
        {
            this.login_page.Show();
            this.Hide();
        }

        private void Get_started_Click(object sender, EventArgs e)
        {
            string name = this.first_name_text_box.Text+" "+this.last_name_textBox.Text;
            string email = this.email_textBox.Text;
            string password = this.password_textBox.Text;
            string confir_password = this.confirm_password_textBox.Text;
            string dateOfBirthString = this.date_of_birth.Value.ToString("MM/dd/yyyy");
            //int id = 3445;
            string gender = this.gender;
            if(password.Length > 6 && password==confir_password) {
                    password = confir_password;
                string query = "INSERT INTO user (user_name,user_email,user_password,user_date_of_birth,user_gender) VALUES (@name,@email,@password,@dateOfBirthString,@gender)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        //cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@dateOfBirthString", dateOfBirthString);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account has been created successfully!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.login_page.Show();
                        this.Hide();
                        this.first_name_text_box.Text = "";
                        this.last_name_textBox.Text = "";
                        this.email_textBox.Text = "";
                        this.password_textBox.Text = "";
                        this.confirm_password_textBox.Text = "";
                        this.date_of_birth.Value = DateTime.Now;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                   
                }
            }
            else
            {

                MessageBox.Show("Password Do not match !! ");
                this.password_textBox.Text ="";
                this.confirm_password_textBox.Text = "";
            }

            //this.login_page.Show();
            //this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.gender = "female";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.gender = "other";

        }
    }
}
