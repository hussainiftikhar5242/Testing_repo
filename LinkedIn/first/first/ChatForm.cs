using first.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace first
{
    public partial class ChatForm : Form
    {
        string temp = "";
        string path="";
        string path1 = "";
        Personal_Information name1=new Personal_Information();
        public ChatForm(Personal_Information name)
        {
            InitializeComponent();
            name1 = name;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageWriteBox.Text;
            temp = temp + message + ":" + name1.firstName + Environment.NewLine;
            messageShowBox.Text = temp;
            Personal_InformationDL.storeMessageIntoFile(path, temp);
            Personal_InformationDL.storeMessageIntoFile(path1, temp);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string name=Personal_InformationDL.returnName(email);
            chatlabel1.Text = name;
            path = name + name1.firstName + ".txt";
            path1 = name1.firstName + name + ".txt";
            if(Personal_InformationDL.loadMessageFromFile(path) == true)
            {

            }
            else
            {
                Personal_InformationDL.loadMessageFromFile(path1);
            }

            temp = Personal_InformationDL.message;
            messageShowBox.Text = temp;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm1 profile = new ProfileForm1(name1);
            profile.Show();
        }
    }
}
