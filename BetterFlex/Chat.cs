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
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

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

        private void Assignment_bttn_Click(object sender, EventArgs e)
        {
            Assignment assignmentpage = new Assignment();
            assignmentpage.Show();
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

        private void Logoutbttn_Click(object sender, EventArgs e)
        {
            Login logpage = new Login();
            logpage.Show();
            Visible = false;
        }
    }
}
