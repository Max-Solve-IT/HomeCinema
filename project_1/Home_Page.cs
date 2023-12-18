using MySql.Data.MySqlClient;
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
using System.IO;

namespace project_1
{
    public partial class Home_Page : Form
    {
        public Form1 login_page;
        public Form3 upload_page;
        public user usr;
        private MySqlConnection connection;
        private const string connectionString = "Server=localhost;Database=the_media_library;User ID=root;Password=toor;";
        public Home_Page()
        {
           //login_page = new Form1();
            InitializeComponent();
            si_fi_flowLayoutPane.FlowDirection = FlowDirection.LeftToRight;
            si_fi_flowLayoutPane.WrapContents = false;

        }
        public Home_Page(Form1 f)
        {

            this.login_page = f;
            InitializeComponent();
            si_fi_flowLayoutPane.FlowDirection = FlowDirection.RightToLeft;

        }
        public Home_Page(Form1 f , user u)
        {

            this.usr = u;
            this.login_page = f;
            InitializeComponent();
            // Action_flowLayoutPane.FlowDirection = FlowDirection.RightToLeft;
            si_fi_flowLayoutPane.FlowDirection = FlowDirection.LeftToRight;
            si_fi_flowLayoutPane.WrapContents = false;
            if(this.usr.is_admin==true) {
                this.upload_picture.Show();
            }
            else
            {
                this.upload_picture.Hide();    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            //f1.Close();
        }

        private void Log_out_btn_Click(object sender, EventArgs e)
        {

         //   this.login_page.Show();
            //this.Hide();
            //iteams();
            

        }
        public void home_page_load(object sender,EventArgs e)
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
            si_fi_iteams();
            action_iteams();
        }


        private void si_fi_iteams()
        {
            action_flowLayoutPanel.Controls.Clear();
            Media_Box[] media_Boxes = new Media_Box[20];
            string query = "SELECT title, videolink, video_poster_link FROM video WHERE CategoryID = 1";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int index = 0;
                    while (reader.Read() && index < media_Boxes.Length)
                    {
                        // Initialize Media_Box objects with data from the database
                        media_Boxes[index] = new Media_Box();
                        media_Boxes[index].title = Path.GetFileNameWithoutExtension(reader["title"].ToString());
                        media_Boxes[index].poster_path = reader["video_poster_link"].ToString();
                        media_Boxes[index].video_utl = reader["videolink"].ToString() ;
                        string s = media_Boxes[index].poster_path;
                        Image img = Image.FromFile(@s);
                        media_Boxes[index].poster.Image = img;

                        // Add Media_Box to the FlowLayoutPanel
                        action_flowLayoutPanel.Controls.Add(media_Boxes[index]);

                        index++;
                    }
                }
            }

            /*
            Media_Box[] media_Boxes = new Media_Box[20];
            for(int i =0;i<media_Boxes.Length;i++)
            {
                media_Boxes[i] = new Media_Box();
                media_Boxes[i].title = "video " +Convert.ToString(i);
                media_Boxes[i].poster_path = @"C:\Users\pc\Desktop\server\Poster\bg_image.jpg";
                
                Action_flowLayoutPane.Controls.Add(media_Boxes[i]);
            }*/
        }
        private void action_iteams()
        {
            si_fi_flowLayoutPane.Controls.Clear();  
            Media_Box[] media_Boxes = new Media_Box[20];
            string query = "SELECT title, videolink, video_poster_link FROM video WHERE CategoryID = 6";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int index = 0;
                    while (reader.Read() && index < media_Boxes.Length)
                    {
                        // Initialize Media_Box objects with data from the database
                        media_Boxes[index] = new Media_Box();
                        media_Boxes[index].title = Path.GetFileNameWithoutExtension(reader["title"].ToString());
                        media_Boxes[index].poster_path = reader["video_poster_link"].ToString();
                        media_Boxes[index].video_utl = reader["videolink"].ToString();
                        string s = media_Boxes[index].poster_path;
                        Image img = Image.FromFile(@s);
                        media_Boxes[index].poster.Image = img;

                        // Add Media_Box to the FlowLayoutPanel
                        si_fi_flowLayoutPane.Controls.Add(media_Boxes[index]);

                        index++;
                    }
                }
            }
        }
        private void anime_iteams()
        {
            anime_flowLayoutPanel.Controls.Clear();
            Media_Box[] media_Boxes = new Media_Box[20];
            string query = "SELECT title, videolink, video_poster_link FROM video WHERE CategoryID = 9";


            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int index = 0;
                    while (reader.Read() && index < media_Boxes.Length)
                    {
                        // Initialize Media_Box objects with data from the database
                        media_Boxes[index] = new Media_Box();
                        media_Boxes[index].title = Path.GetFileNameWithoutExtension(reader["title"].ToString());
                        media_Boxes[index].poster_path = reader["video_poster_link"].ToString();
                        media_Boxes[index].video_utl = reader["videolink"].ToString();
                        string s = media_Boxes[index].poster_path;
                        Image img = Image.FromFile(@s);
                        media_Boxes[index].poster.Image = img;

                        // Add Media_Box to the FlowLayoutPanel
                        anime_flowLayoutPanel.Controls.Add(media_Boxes[index]);

                        index++;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try 
            {
                user_info_form user_info = new user_info_form(this, this.login_page, this.usr);
                user_info.ShowDialog();
                //MessageBox.Show(this.usr.name);
            }catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void upload_picture_Click(object sender, EventArgs e)
        {
            upload_page = new Form3(this);
            upload_page.ShowDialog();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
