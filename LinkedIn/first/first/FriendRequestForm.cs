using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using first.Classes;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace first
{
    public partial class FriendRequestForm : Form
    {
        Personal_Information temp=new Personal_Information();
        Personal_Information temp2=new Personal_Information();
        DataTable table;
        public FriendRequestForm(string name,string lastName,string email,string passWord)
        {
            InitializeComponent();
            temp.firstName = name;
            temp.lastName = lastName;
            temp.email = email;
            temp.passWord = passWord;
        }

        private void FriendRequestForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("first Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            foreach(KeyValuePair<Personal_Information,List<Personal_Information>> user in Personal_InformationDL.rquestedFriend)
            {
                if(user.Key.email == temp.email)
                {
                    foreach(Personal_Information val in user.Value)
                    {
                        table.Rows.Add(val.firstName, val.lastName, val.email);
                    }
                }
            }
            dataGV.DataSource = table;
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            foreach(Personal_Information user in Personal_InformationDL.informationList)
            {
                if( user.email == emailBox.Text )
                {
                    if (!Personal_InformationDL.friendGraph.ContainsKey(temp))
                        Personal_InformationDL.friendGraph.Add(temp, new List<Personal_Information>());
                    if (Personal_InformationDL.friendGraph.ContainsKey(temp))
                    {
                       
                        if(Personal_InformationDL.isFriend(temp,user) == true)
                        {
                            Personal_InformationDL.friendGraph[temp].Add(user);
                            MessageBox.Show("Friend Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show("There are already friend ");
                        }

                    }
                    if (!Personal_InformationDL.friendGraph.ContainsKey(user))
                        Personal_InformationDL.friendGraph.Add(user, new List<Personal_Information>());
                    if (Personal_InformationDL.friendGraph.ContainsKey(user))
                    {
                        
                        if (Personal_InformationDL.isFriend(user, temp) == true)
                        {
                            Personal_InformationDL.friendGraph[user].Add(temp);
                            MessageBox.Show("Friend Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show("There are already friend ");

                        }
                    }
                    Personal_InformationDL.addFriendIntoDataBase(temp, user);
                    Personal_InformationDL.addFriendIntoDataBase(user, temp);
                    Personal_InformationDL.deleteUserFromRequestList(temp, user);
                    Personal_InformationDL.deleteRequestFromDataBase();
                    Personal_InformationDL.storeRequestIntoDataBase();
                }
            }
            this.Close();
            FriendRequestForm form = new FriendRequestForm(temp.firstName, temp.lastName, temp.email, temp.passWord);
            form.Show();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllFriend friend = new ShowAllFriend(temp);
            friend.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach(Personal_Information user in Personal_InformationDL.informationList)
            {
                if(emailBox.Text == user.email)
                {
                    Personal_InformationDL.deleteUserFromRequestList(temp, user);
                    Personal_InformationDL.deleteRequestFromDataBase();
                    Personal_InformationDL.storeRequestIntoDataBase();
                }
            }
            this.Hide();
            FriendRequestForm again = new FriendRequestForm(temp.firstName,temp.lastName,temp.email,temp.passWord);
            again.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm1 form = new ProfileForm1(temp);
            form.Show();
        }
    }
}
