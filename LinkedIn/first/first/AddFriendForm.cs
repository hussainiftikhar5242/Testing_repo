using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using first.Classes;
using Microsoft.VisualBasic.ApplicationServices;

namespace first
{
    
    public partial class AddFriendForm : Form
    {
        Personal_Information information = new Personal_Information();
        public AddFriendForm(Personal_Information temp)
        {
            InitializeComponent();
            information = temp;
            nameLabel.Text = information.firstName+" "+information.lastName;
        }

        private void AddFriendForm_Load(object sender, EventArgs e)
        {

        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            foreach(Personal_Information personal in Personal_InformationDL.informationList)
            {
                if(personal.email == emailBox.Text)
                {
                    if (!Personal_InformationDL.rquestedFriend.ContainsKey(personal))
                        Personal_InformationDL.rquestedFriend.Add(personal, new List<Personal_Information>());
                    if(Personal_InformationDL.isFriend(personal,information) == true || Personal_InformationDL.isFriend(information, personal)==true)
                    {
                        if (Personal_InformationDL.isRequestSendAlready(personal, information) == true)
                        {
                            Personal_InformationDL.rquestedFriend[personal].Add(information);
                            Personal_InformationDL.storeFriendRequestIntoDataBase(information, personal);
                            MessageBox.Show("Request Send Successfully ");
                        }
                        else
                        {
                            MessageBox.Show("You have already send request to this user so you are no longer available to send request again thanks");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This user is already your friend you are no longer available to send request again thanks");
                    }
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm form = new SearchForm(information);
            form.Show();
        }
    }
}
