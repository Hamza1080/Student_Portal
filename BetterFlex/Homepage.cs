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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resource resourcepage = new Resource();
            resourcepage.Show();
            Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Sidebartimer_tick(object sender, EventArgs e)
        {

        }

        private void Annoucement_bttn_MouseHover(object sender, EventArgs e)
        {
            Annoucement_bttn.BackColor = Color.FromArgb(7, 34, 57);
        }

        private void Assignment_bttn_MouseHover(object sender, EventArgs e)
        {
            Assignment_bttn.BackColor = Color.FromArgb(7, 34, 57);
        }

        private void Attendance_bttn_MouseHover(object sender, EventArgs e)
        {
            Attendance_bttn.BackColor = Color.FromArgb(7, 34, 57);
        }

        private void Resource_bttn_MouseHover(object sender, EventArgs e)
        {
            Resource_bttn.BackColor = Color.FromArgb(7, 34, 57);
        }

        private void Chat_bttn_Click(object sender, EventArgs e)
        {
            Chat chatpage = new Chat();
            chatpage.Show();
            Visible = false;
        }

        private void Chat_bttn_MouseHover(object sender, EventArgs e)
        {
            Chat_bttn.BackColor = Color.FromArgb(7, 34, 57);
        }

        private void Annoucement_bttn_MouseLeave(object sender, EventArgs e)
        {
            Annoucement_bttn.BackColor = Color.FromArgb(11, 48, 81);
        }

        private void Assignment_bttn_MouseLeave(object sender, EventArgs e)
        {
            Assignment_bttn.BackColor = Color.FromArgb(11, 48, 81);
        }

        private void Attendance_bttn_MouseLeave(object sender, EventArgs e)
        {
            Attendance_bttn.BackColor = Color.FromArgb(11, 48, 81);
        }

        private void Resource_bttn_MouseLeave(object sender, EventArgs e)
        {
            Resource_bttn.BackColor = Color.FromArgb(11, 48, 81);
        }

        private void Chat_bttn_MouseLeave(object sender, EventArgs e)
        {
            Chat_bttn.BackColor = Color.FromArgb(11, 48, 81);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void circularbutton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            Visible = false;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void Home_student_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void circularbutton14_Click(object sender, EventArgs e)
        {

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

        private void Marks_bttn_Click(object sender, EventArgs e)
        {
            Marks markspage = new Marks();
            markspage.Show();
            Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Annoucement annoucementpage = new Annoucement();
            annoucementpage.Show();
            Visible = false;
        }
    }
}
