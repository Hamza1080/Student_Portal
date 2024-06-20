namespace Iteration1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Welcome = new Label();
            welback = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            Loginbutton = new Button();
            username = new TextBox();
            password = new TextBox();
            Errorlogin = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            Loginpicture = new PictureBox();
            checkBox1 = new CheckBox();
            forgotbutton = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Loginpicture).BeginInit();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Franklin Gothic Medium Cond", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Welcome.ForeColor = Color.FromArgb(11, 48, 81);
            Welcome.Location = new Point(911, 214);
            Welcome.Margin = new Padding(2, 0, 2, 0);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(178, 51);
            Welcome.TabIndex = 1;
            Welcome.Text = "Welcome ";
            Welcome.TextAlign = ContentAlignment.MiddleLeft;
            Welcome.Click += label1_Click;
            // 
            // welback
            // 
            welback.AutoSize = true;
            welback.Font = new Font("Franklin Gothic Medium Cond", 8F, FontStyle.Regular, GraphicsUnit.Point);
            welback.ForeColor = Color.FromArgb(11, 48, 81);
            welback.Location = new Point(911, 282);
            welback.Margin = new Padding(2, 0, 2, 0);
            welback.Name = "welback";
            welback.Size = new Size(187, 21);
            welback.TabIndex = 2;
            welback.Text = "Please! Enter Your Credientials";
            welback.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Icon;
            pictureBox1.Location = new Point(911, 368);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 48, 51);
            panel1.Location = new Point(956, 397);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 48, 51);
            panel2.Location = new Point(956, 482);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(911, 453);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.FromArgb(11, 48, 81);
            Loginbutton.Cursor = Cursors.Hand;
            Loginbutton.ForeColor = Color.White;
            Loginbutton.Location = new Point(911, 532);
            Loginbutton.Margin = new Padding(2, 3, 2, 3);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(291, 45);
            Loginbutton.TabIndex = 7;
            Loginbutton.Text = "LOGIN";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += button1_Click;
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(240, 246, 255);
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Franklin Gothic Book", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.FromArgb(11, 48, 81);
            username.Location = new Point(956, 368);
            username.Margin = new Padding(2, 3, 2, 3);
            username.Multiline = true;
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(236, 24);
            username.TabIndex = 8;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(240, 246, 255);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Franklin Gothic Book", 10F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.FromArgb(11, 48, 81);
            password.Location = new Point(956, 453);
            password.Margin = new Padding(2, 3, 2, 3);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.ScrollBars = ScrollBars.Vertical;
            password.Size = new Size(236, 24);
            password.TabIndex = 9;
            password.UseSystemPasswordChar = true;
            password.WordWrap = false;
            password.TextChanged += textBox1_TextChanged;
            // 
            // Errorlogin
            // 
            Errorlogin.AutoSize = true;
            Errorlogin.Font = new Font("Franklin Gothic Medium Cond", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Errorlogin.ForeColor = Color.FromArgb(240, 246, 245);
            Errorlogin.Location = new Point(911, 312);
            Errorlogin.Margin = new Padding(2, 0, 2, 0);
            Errorlogin.Name = "Errorlogin";
            Errorlogin.Size = new Size(186, 21);
            Errorlogin.TabIndex = 10;
            Errorlogin.Text = "Invalid username or password!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 48, 81);
            label1.Location = new Point(68, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 12;
            label1.Text = "BetterFlex";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 12);
            pictureBox3.Margin = new Padding(2, 3, 2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // Loginpicture
            // 
            Loginpicture.BackColor = Color.FromArgb(240, 246, 255);
            Loginpicture.BackgroundImageLayout = ImageLayout.None;
            Loginpicture.Image = Properties.Resources.image1;
            Loginpicture.Location = new Point(12, 59);
            Loginpicture.Margin = new Padding(2, 3, 2, 3);
            Loginpicture.Name = "Loginpicture";
            Loginpicture.Size = new Size(934, 643);
            Loginpicture.SizeMode = PictureBoxSizeMode.Zoom;
            Loginpicture.TabIndex = 0;
            Loginpicture.TabStop = false;
            Loginpicture.Click += Loginpicture_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1118, 447);
            checkBox1.Margin = new Padding(2, 3, 2, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 29);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Hide";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // forgotbutton
            // 
            forgotbutton.AutoSize = true;
            forgotbutton.Font = new Font("Franklin Gothic Medium", 8F, FontStyle.Regular, GraphicsUnit.Point);
            forgotbutton.ForeColor = Color.FromArgb(11, 48, 81);
            forgotbutton.Location = new Point(1070, 498);
            forgotbutton.Margin = new Padding(2, 0, 2, 0);
            forgotbutton.Name = "forgotbutton";
            forgotbutton.Size = new Size(130, 21);
            forgotbutton.TabIndex = 16;
            forgotbutton.Text = "Forgot Password?";
            forgotbutton.TextAlign = ContentAlignment.MiddleLeft;
            forgotbutton.Click += label2_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 246, 255);
            ClientSize = new Size(1258, 968);
            Controls.Add(forgotbutton);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(Errorlogin);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(Loginbutton);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(welback);
            Controls.Add(Welcome);
            Controls.Add(Loginpicture);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Loginpicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Welcome;
        private Label welback;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button Loginbutton;
        private TextBox username;
        private TextBox password;
        private Label Errorlogin;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox Loginpicture;
        private CheckBox checkBox1;
        private Label forgotbutton;
    }
}