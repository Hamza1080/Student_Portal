namespace Iteration1
{
    partial class Forgotpop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            welback = new Label();
            forgotuser = new TextBox();
            panel1 = new Panel();
            forgotuserbttn = new Button();
            button1 = new Button();
            popuptimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // welback
            // 
            welback.AutoSize = true;
            welback.Font = new Font("Franklin Gothic Medium Cond", 11F, FontStyle.Regular, GraphicsUnit.Point);
            welback.ForeColor = Color.White;
            welback.Location = new Point(129, 47);
            welback.Margin = new Padding(2, 0, 2, 0);
            welback.Name = "welback";
            welback.Size = new Size(246, 28);
            welback.TabIndex = 3;
            welback.Text = "Please! Enter Your Username";
            welback.Click += welback_Click;
            // 
            // forgotuser
            // 
            forgotuser.BackColor = Color.FromArgb(240, 246, 255);
            forgotuser.BorderStyle = BorderStyle.None;
            forgotuser.Font = new Font("Franklin Gothic Book", 10F, FontStyle.Regular, GraphicsUnit.Point);
            forgotuser.ForeColor = Color.FromArgb(11, 48, 81);
            forgotuser.Location = new Point(129, 98);
            forgotuser.Margin = new Padding(2, 3, 2, 3);
            forgotuser.Multiline = true;
            forgotuser.Name = "forgotuser";
            forgotuser.PlaceholderText = "Username";
            forgotuser.Size = new Size(246, 30);
            forgotuser.TabIndex = 11;
            forgotuser.TextChanged += username_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 48, 51);
            panel1.Location = new Point(154, 156);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 10;
            // 
            // forgotuserbttn
            // 
            forgotuserbttn.BackColor = Color.FromArgb(11, 48, 81);
            forgotuserbttn.Cursor = Cursors.Hand;
            forgotuserbttn.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            forgotuserbttn.ForeColor = Color.White;
            forgotuserbttn.Location = new Point(129, 156);
            forgotuserbttn.Margin = new Padding(2, 3, 2, 3);
            forgotuserbttn.Name = "forgotuserbttn";
            forgotuserbttn.Size = new Size(246, 49);
            forgotuserbttn.TabIndex = 12;
            forgotuserbttn.Text = "Submit";
            forgotuserbttn.UseVisualStyleBackColor = false;
            forgotuserbttn.Click += Loginbutton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(240, 246, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(11, 48, 81);
            button1.Location = new Point(194, 218);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(106, 35);
            button1.TabIndex = 13;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // popuptimer
            // 
            popuptimer.Tick += popuptimer_Tick;
            // 
            // Forgotpop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 48, 81);
            ClientSize = new Size(498, 294);
            Controls.Add(button1);
            Controls.Add(forgotuserbttn);
            Controls.Add(forgotuser);
            Controls.Add(panel1);
            Controls.Add(welback);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forgotpop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgotpop";
            Load += Forgotpop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welback;
        private TextBox forgotuser;
        private Panel panel1;
        private Button forgotuserbttn;
        private Button button1;
        private System.Windows.Forms.Timer popuptimer;
    }
}