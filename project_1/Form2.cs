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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string link)
        {
            InitializeComponent();
            player.URL = link;
            // "C:\Users\Swajan\Downloads\testVideo.mp4"
        }



        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.play();
                play_btn.Hide();
                pause_btn.Show();

            }
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
                pause_btn.Hide();
                play_btn.Show();
            }
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
