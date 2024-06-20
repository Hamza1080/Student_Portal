using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Iteration1
{
    public partial class Resource : Form
    {
        public Resource()
        {
            InitializeComponent();

            Button downloadFileButton = new Button();
            downloadFileButton.Text = "Download File";
            downloadFileButton.Click += button6_Click;
            Controls.Add(downloadFileButton);
        }


        private void Annoucement1_Paint(object sender, PaintEventArgs e)
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

        private void Marks_bttn_Click(object sender, EventArgs e)
        {
            Marks markspage = new Marks();
            markspage.Show();
            Visible = false;
        }

        private void Chat_bttn_Click(object sender, EventArgs e)
        {
            Chat chatpage = new Chat();
            chatpage.Show();
            Visible = false;
        }

        private void Logoutbttn_Click(object sender, EventArgs e)
        {
            Chat chatpage = new Chat();
            chatpage.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Replace "https://www.example.com" with the actual URL you want to open
            string url = "https://www.youtube.com/@FakharStemSphere";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
