using LibrarySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarSystem
{
    public partial class Entry_Form : Form
    {
        public Entry_Form()
        {
            InitializeComponent();
        }

        
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
        

        int startpoint = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpoint += 1;
            guna2CircleProgressBar1.Value = startpoint;
            if (guna2CircleProgressBar1.Value == 100)
            {
                guna2CircleProgressBar1.Value = 0;
                timer1.Stop();
                LoginForm log = new LoginForm();
                log.Show();
                this.Hide();
            }
        }

    }
}
