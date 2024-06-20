namespace Iteration1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginpicture_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            functions f = new functions();
            if (f.Checkid(username.Text, password.Text) == true)
            {
                Homepage homepage = new Homepage();
                homepage.Show();
                Visible = false;
                
            }
            else
            {
                Errorlogin.ForeColor = Color.Red;
            }
            /*if (username.Text == "Username" && password.Text == "Password")
            {
                MessageBox.Show("Username");
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect");
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public static  int parentX,parentY;
        private void label2_Click_1(object sender, EventArgs e)
        {
            Form popbackground= new Form();
            using (Forgotpop forgotpop = new Forgotpop())
            {
                popbackground.StartPosition =FormStartPosition.CenterParent;
                popbackground.FormBorderStyle=FormBorderStyle.None;
                popbackground.Opacity = 0.50d;
                popbackground.BackColor= Color.White;
                popbackground.Location = this.Location;
                popbackground.ShowInTaskbar = false;
                forgotpop.Owner= popbackground;

                parentX=this.Location.X;
                parentY=this.Location.Y;

                forgotpop.ShowDialog();
                popbackground.Dispose();
            }
        }
    }
}