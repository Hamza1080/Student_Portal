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
    public partial class Annoucement : Form
    {
        private List<Announcements> announcements;
        private int currentAnnouncementIndex = 0;
        public Annoucement()
        {
            InitializeComponent();
            LoadAnnouncements();
            DisplayAnnouncements();
        }

        private void LoadAnnouncements()
        {
            // Provide the path to your text file
            string filePath = "Announcement.txt";

            announcements = new List<Announcements>();
            string[] delimiter = { "---" };

            try
            {
                // Read the entire content of the text file
                string fileContent = File.ReadAllText(filePath);

                // Split content based on the delimiter
                string[] announcementSections = fileContent.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

                // Parse each announcement section
                foreach (string section in announcementSections)
                {
                    string[] lines = section.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                    if (lines.Length >= 2)
                    {
                        // First line is the title, and the rest is the content
                        string title = lines[0].Trim();
                        string content = string.Join(Environment.NewLine, lines[1..]).Trim();

                        announcements.Add(new Announcements { Title = title, Content = content });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading announcements file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAnnouncements()
        {
            // Display announcements in different TextBox controls
            SetAnnouncementText(label1, richTextBox6, 0);
            SetAnnouncementText(label2, richTextBox1, 1);
            SetAnnouncementText(label3, richTextBox2, 2);
            SetAnnouncementText(label4, richTextBox3, 3);
            SetAnnouncementText(label5, richTextBox4, 4);
            SetAnnouncementText(label6, richTextBox5, 5);

            richTextBox6.ReadOnly= true;
            richTextBox1.ReadOnly= true;
            richTextBox2.ReadOnly= true;
            richTextBox3.ReadOnly= true;
            richTextBox4.ReadOnly= true;
            richTextBox5.ReadOnly= true;

        }

        private void SetAnnouncementText(Label label, RichTextBox richTextBox, int index)
        {
            if (index < announcements.Count)
            {
                label.Text = announcements[index].Title;
                richTextBox.Text = announcements[index].Content;
            }
            else
            {
                // Clear the controls if there are no announcements at this index
                label.Text = "";
                richTextBox.Text = "";
            }
        }


        private void ClearTextBoxes()
        {
            // Clear all TextBox controls
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private class Announcements
        {
            public string Title { get; set; }
            public string Content { get; set; }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logoutbttn_Click(object sender, EventArgs e)
        {
            Login logpage = new Login();
            logpage.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void Chat_bttn_Click(object sender, EventArgs e)
        {
            Chat chatpage = new Chat();
            chatpage.Show();
            Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
