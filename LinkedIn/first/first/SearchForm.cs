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

namespace first
{
    public partial class SearchForm : Form
    {
        Personal_Information temp=new Personal_Information();
        public SearchForm(Personal_Information request)
        {
            InitializeComponent();
            temp = request;
        }
        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string name = searchBox.Text;
            bool check = false;
            DataTable table = new DataTable();
            table.Columns.Add("first Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            for(int i=0;i<Personal_InformationDL.informationList.Count;i++)
            {
                if (name == Personal_InformationDL.informationList[i].firstName)
                {
                    table.Rows.Add(Personal_InformationDL.informationList[i].firstName, Personal_InformationDL.informationList[i].lastName, Personal_InformationDL.informationList[i].email);
                    check = true;
                }
            }
            dataGV.DataSource = table;
            if(check == false)
            {
                MessageBox.Show("No user Found");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddFriendForm frindForm = new AddFriendForm(temp);
            frindForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileForm1 form = new ProfileForm1(temp);
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
