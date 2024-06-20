using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iteration1
{
    public partial class Assignment : Form
    {
        public Assignment()
        {
            InitializeComponent();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            Visible = false;
        }

        private void Annoucement_bttn_Click(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void Attendance_bttn_Click(object sender, EventArgs e)
        {
            Attendance attendancepage = new Attendance();
            attendancepage.Show();
            Visible = false;
        }

        private void Resource_bttn_Click(object sender, EventArgs e)
        {
            Resource resourcepage = new Resource();
            resourcepage.Show();
            Visible = false;
        }

        private void Marks_bttn_Click(object sender, EventArgs e)
        {
            Marks markspage = new Marks();
            markspage.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chat chatpage = new Chat();
            chatpage.Show();
            Visible = false;
        }

        private void Logoutbttn_Click(object sender, EventArgs e)
        {
            Login logpage = new Login();
            logpage.Show();
            Visible = false;
        }
    }
}
