using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7DLogger
{
    public partial class pic : Form
    {
        string picloc;
        public pic()
        {
            InitializeComponent();
        }

        public string Picloc
        {
            get
            {
                return picloc;
            }
            set
            {
                this.picloc = value;
            }
        }

        private void pic_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Picloc;
        }
    }
}
