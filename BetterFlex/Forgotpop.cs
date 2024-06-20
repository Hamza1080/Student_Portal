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
    public partial class Forgotpop : Form
    {
        public Forgotpop()
        {
            InitializeComponent();
        }

        private void welback_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            functions fun = new functions();
            string a = fun.Forgot(forgotuser.Text);
            if(a=="na")
            {
                MessageBox.Show("Invalid Username");
            }
            else
            {
                MessageBox.Show("Your Password is " + a);
            }
        }



        private void popuptimer_Tick(object sender, EventArgs e)
        {
        }
        private void Forgotpop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
