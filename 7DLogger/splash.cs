using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _7DLogger
{
    public partial class splash : Form
    {
        public splash()
        {    

            InitializeComponent();
        }
        int LeftTime;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LeftTime > 0)
            {
                LeftTime--;
            }
            else
            {
                timer1.Stop();
                MainForm mf = new MainForm();
                this.Hide();
                mf.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            LeftTime = 15;
            timer1.Start();
        }
    }
}

        
