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
        public Form1 f1;
        public Home_Page()
        {
            f1 = new Form1();
            InitializeComponent();
        }
        public Home_Page(Form1 f)
        {
            this.f1 = f;
            if (this.IsDisposed == true)
            {
                f.Dispose();
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Close();
        }
    }
}
