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
using first.Classes;
using Microsoft.VisualBasic.ApplicationServices;

namespace first
{
    public partial class ShowAllFriend : Form
    {
        Personal_Information friend = new Personal_Information();
        public ShowAllFriend(Personal_Information temp)
        {
            InitializeComponent();
            friend = temp;
            namelabel.Text = friend.firstName+" " + friend.lastName;
        }
        private void ShowAllFriend_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("first Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            for(int i=0;i<Personal_InformationDL.friendGraph.Count();i++)
            {
                var item=Personal_InformationDL.friendGraph.ElementAt(i);
                var itemkey=item.Key;
                var itemvalue=item.Value;
                if(itemkey.email == friend.email)
                {
                    for(int x=0;x<itemvalue.Count;x++)
                    {
                        table.Rows.Add(itemvalue[x].firstName, itemvalue[x].lastName, itemvalue[x].email);
                    }
                }
            }
            dataGV.DataSource = table;
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FriendRequestForm form = new FriendRequestForm(friend.firstName, friend.lastName, friend.email, friend.passWord);
            form.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm1 form = new ProfileForm1(friend);
            form.Show();
        }
    }
}
