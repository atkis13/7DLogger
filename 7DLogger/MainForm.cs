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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            

        }
        string previous = Form_methods.Mainlog();

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form_methods.ReadPDFLog("done", out_done);
                Form_methods.ReadPDFLog("toDo", out_todo);
                pictureBox1.ImageLocation = Application.StartupPath + @"\\images\\img.jpg";
            }
            catch(Exception ex)
            {
                MessageBox.Show("no logs found, please create" + ex.Message);
            }
            
        }

        private void add_done_Click(object sender, EventArgs e)
        {
            Form_methods.CreateNewLog(date_done.Text, in_done.Text, "done");
            Form_methods.EditLog(date_done.Text, previous, in_done.Text);
            Form_methods.ReadPDFLog("done", out_done);



        }

        private void add_todo_Click(object sender, EventArgs e)
        {
            Form_methods.CreateNewLog(date_todo.Text, in_todo.Text, "toDo");
            Form_methods.EditLog(date_todo.Text, previous, in_todo.Text);
            Form_methods.ReadPDFLog("toDo", out_todo);

        }

        private void selectPic_Click(object sender, EventArgs e)
        {
            Form_methods.selectImg(piclabel, pictureBox1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + @"\\images\\noimage.jpg";
        }

        private void addPic_Click(object sender, EventArgs e)
        {
            
            Form_methods.addImgPicbox(piclabel);
            pictureBox1.ImageLocation = Application.StartupPath + @"\\images\\img.jpg";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
