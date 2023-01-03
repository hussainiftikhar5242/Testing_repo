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

namespace first
{
    public partial class connectionForm : Form
    {
        Personal_Information user1 = new Personal_Information();
        public connectionForm(Personal_Information temp)
        {
            InitializeComponent();
            user1 = temp;
        }

        private void searchConnection_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            Personal_Information key = new Personal_Information();
            key=Personal_InformationDL.returnUser(email);
            DataTable table = new DataTable();
            table.Columns.Add("first Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            foreach (KeyValuePair<Personal_Information, List<Personal_Information>> user in Personal_InformationDL.friendGraph)
            {
                if (user.Key.email == key.email)
                {
                    namelabel.BackColor = Color.Gray;
                    namelabel.Text=user.Key.firstName+" "+user.Key.lastName;
                    for (int i = 0; i < user.Value.Count(); i++)
                    {
                        if (user.Value[i].email != user1.email)
                        table.Rows.Add(user.Value[i].firstName, user.Value[i].lastName, user.Value[i].email);
                    }
                }
            }
            connectionGV.DataSource = table;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm1 form = new ProfileForm1(user1);
            form.Show();
        }
    }
}
