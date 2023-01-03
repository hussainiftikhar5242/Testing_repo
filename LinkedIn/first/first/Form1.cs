using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using first.Classes;

namespace first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            bool checker = Personal_InformationDL.CheckUser(emailBox.Text, passwordBox.Text);
            Personal_Information temp = Personal_InformationDL.returnName(emailBox.Text, passwordBox.Text);
            if (checker == true)
            {
                ProfileForm1 profileform = new ProfileForm1(temp);
                this.Hide();
                profileform.Show();
            }
            else
            {
                MessageBox.Show("User Not Prsent");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinForm newForm = new JoinForm();
            newForm.Show();
        }
    }
}