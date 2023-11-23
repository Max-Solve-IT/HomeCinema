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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
                   File_path.Text = selectedFilePath;
                }
                else
                {
                    MessageBox.Show("The selected video file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
