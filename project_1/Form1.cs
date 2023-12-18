using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_1
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private const string connectionString = "Server=localhost;Database=the_media_library;User ID=root;Password=toor;";
        public user new_user;
        public Form1()
        {
            //this.FormClosed += (s, args) => this.Close();
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_email_Enter(object sender, EventArgs e)
        {
            if (user_email.Text == "Email")
            {
                user_email.Text = "";

            }
        }

        private void user_email_Leave(object sender, EventArgs e)

        {
            if (user_email.Text == "")
            {
                user_email.Text = "Email";
            }

        }

        private void Password_field_Enter(object sender, EventArgs e)
        {
            if (Password_field.Text == "Password")
            {
                Password_field.Text = "";
            }
        }

        private void Password_field_Leave(object sender, EventArgs e)
        {
            if (Password_field.Text == "")
            {
                Password_field.Text = "Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            /*
            string admin_query = "SELECT * FROM Admin WHERE AdminEmail = @Email AND AdminPassword = @Password";
            string admin_email = this.user_email.Text;
            string admin_password = this.Password_field.Text;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(admin_query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", admin_email);
                    cmd.Parameters.AddWithValue("@Password", admin_password);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            flag = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }*/
                string query = "SELECT * FROM user WHERE user_email = @Email AND user_password = @Password";
                string email = this.user_email.Text;
                string password = this.Password_field.Text;

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                try
                                {
                                    reader.Read();
                                    this.new_user = new user();
                                    this.new_user.name = reader["user_name"].ToString();
                                    this.new_user.password = reader["user_password"].ToString();
                                    this.new_user.email = reader["user_email"].ToString();
                                    this.new_user.date_of_birth = reader["user_date_of_birth"].ToString();
                                    this.new_user.gender = reader["user_gender"].ToString();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"{ex.Message}");
                                }

                                //MessageBox.Show("Login successful!");
                                Home_Page home_Page = new Home_Page(this, this.new_user);

                                home_Page.Show();
                                this.Hide();

                                home_Page.FormClosed += (s, args) => this.Close();
                                this.user_email.Text = "";
                                this.Password_field.Text = "";
                            }
                            else
                            {
                            reader.Close();
                                string admin_query = "SELECT * FROM Admin WHERE AdminEmail = @Email2 AND AdminPassword = @Password2";
                                string admin_email = this.user_email.Text;
                                string admin_password = this.Password_field.Text;
                                try
                                {
                                    using (MySqlCommand cmd2 = new MySqlCommand(admin_query, connection))
                                    {
                                        cmd2.Parameters.AddWithValue("@Email2", admin_email);
                                        cmd2.Parameters.AddWithValue("@Password2", admin_password);
                                        using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                                        {
                                            if (reader2.HasRows)
                                            {
                                                //flag = true;
                                                try
                                                {
                                                    reader2.Read();
                                                    this.new_user = new user();
                                                    this.new_user.name = reader2["AdminUserName"].ToString();
                                                    this.new_user.password = reader2["AdminPassword"].ToString();
                                                    this.new_user.email = reader2["AdminEmail"].ToString();
                                                    this.new_user.date_of_birth = reader2["Admin_Date_of_birth"].ToString();
                                                    this.new_user.gender = reader2["Admin_gender"].ToString();
                                                    this.new_user.is_admin = true;
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show($"{ex.Message}");
                                                }

                                                //MessageBox.Show("Login successful!");
                                                Home_Page home_Page = new Home_Page(this, this.new_user);

                                                home_Page.Show();
                                                this.Hide();

                                                home_Page.FormClosed += (s, args) => this.Close();
                                                this.user_email.Text = "";
                                                this.Password_field.Text = "";
                                            }
                                            else
                                            {
                                                MessageBox.Show("Invalid email or password. Please try again.");
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"{ex.Message}");
                                }
                               

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
           



            /*
            if (user_email.Text == "admin" && Password_field.Text == "admin")
            {
                Home_Page home_Page = new Home_Page(this);

                home_Page.Show();
                this.Hide();

                home_Page.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Wrong");
            }*/
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
           // string link = user_email.Text;
            //Form2 obj = new Form2(link);
            //obj.Show();
            Sign_Up_form sign_up_page = new Sign_Up_form(this);
           sign_up_page.Show();
            this.Hide();
            sign_up_page.FormClosed += (s, args) => this.Close();

        }

        private void Password_field_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}