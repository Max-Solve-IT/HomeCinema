using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace project_1
{
    public partial class Form3 : Form
    {
        private MySqlConnection connection;
        private const string connectionString = "Server=localhost;Database=the_media_library;User ID=root;Password=toor;";
        private int category;
        public Home_Page home_page;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Home_Page h)
        {
            this.home_page = h;
            InitializeComponent();
        }

        public void form3_load(object sender, EventArgs e)
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

        private void upload_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.wmv;*.mov|All Files|*.*";
            openFileDialog.Title = "Select a Video File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string selectedFilePath = openFileDialog.FileName;

                // Check if the file exists before attempting to play it
                if (System.IO.File.Exists(selectedFilePath))
                {
                    file_name.Text = Path.GetFileName(selectedFilePath);

                    File_path.Text = selectedFilePath;
                }
                else
                {
                    MessageBox.Show("The selected video file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void poster_upload_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialog.Title = "Select a Image File";
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                // Check if the file exists before attempting to play it
                if (System.IO.File.Exists(selectedFilePath))
                {
                    string destinationFilePath = Path.Combine("C:\\Users\\pc\\Desktop\\server\\Poster", Path.GetFileName(selectedFilePath));
                    File.Copy(selectedFilePath, destinationFilePath, true);
                    poster_path.Text = destinationFilePath;
                    poster_view_panel.BackgroundImage = Image.FromFile(selectedFilePath);
                }
                else
                {
                    MessageBox.Show("The selected video file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO video (Title,videolink,AdminID,CategoryID,video_poster_link) VALUES (@title,@videolink,@AdminID,@CategoryID,@video_poster_link)";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                try
                {
                    //cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", this.file_name.Text);
                    cmd.Parameters.AddWithValue("@videolink",this.File_path.Text);
                    cmd.Parameters.AddWithValue("@AdminID",121);
                    cmd.Parameters.AddWithValue("@CategoryID",this.category);
                    cmd.Parameters.AddWithValue("@video_poster_link",this.poster_path.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account has been created successfully!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }

            /*
            string destinationFilePath = Path.Combine("C:\\Users\\Swajan\\Desktop\\server\\Media", Path.GetFileName(File_path.Text));
            string destinationPosterPath = Path.Combine("C:\\Users\\Swajan\\Desktop\\server\\Poster", Path.GetFileName(poster_path.Text));
            if (File_path.Text.Length>0 && poster_path.Text.Length > 0)
            {
                File.Copy(File_path.Text,destinationFilePath,true);
                File.Copy(poster_path.Text,destinationPosterPath,true);
                MessageBox.Show("File Uploaded");
            }
            else
            {
                MessageBox.Show("Select File");
            }*/
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 1;
        }

        private void sifi_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 6;
        }

        private void animation_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 9;
        }

        private void thiller_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 4;
        }

        private void comedy_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 2;
        }

        private void horror_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.category = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.home_page.Show();
            this.Close();



        }
    }
}
