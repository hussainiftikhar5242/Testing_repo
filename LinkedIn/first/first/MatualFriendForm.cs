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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml;

namespace first
{
    public partial class MatualFriendForm : Form
    {
        Personal_Information information = new Personal_Information();
        public MatualFriendForm(Personal_Information temp)
        {
            InitializeComponent();
            information = temp;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm1 form = new ProfileForm1(information);
            form.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            Personal_Information key = new Personal_Information();
            key = Personal_InformationDL.returnUser(email);
            DataTable table = new DataTable();
            table.Columns.Add("first Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            bool check = false;
            foreach (KeyValuePair<Personal_Information, List<Personal_Information>> user in Personal_InformationDL.friendGraph)
            {
                if (user.Key.email == key.email)
                {
                    nameLabel.BackColor = Color.Gray;
                    nameLabel.ForeColor = Color.White;
                    nameLabel.Text = user.Key.firstName + " " + user.Key.lastName;
                    for (int i = 0; i < user.Value.Count(); i++)
                    {
                        foreach(KeyValuePair<Personal_Information,List<Personal_Information>> matual in Personal_InformationDL.friendGraph)
                        {
                            if(information.email == matual.Key.email)
                            {
                                for(int x=0;x<matual.Value.Count;x++)
                                {
                                    if (matual.Value[x].email == user.Value[i].email)
                                    {
                                        table.Rows.Add(user.Value[i].firstName, user.Value[i].lastName, user.Value[i].email);
                                        check = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            matualGV.DataSource = table;
            if(check ==false)
            {
                MessageBox.Show("There is No Matual Connection Between these user please try again");
            }
        }
    }
}
