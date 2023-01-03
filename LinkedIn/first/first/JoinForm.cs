using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using first.Classes;
using System.Data.OleDb;

namespace first
{
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
            MessageBox.Show("Please Enter a unique Email TO join Up OtherWise you will not be able to join");
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            string firstName=FirstNameBox.Text;
            firstName=firstName.Trim();
            string lastName=lastNameBox.Text;
            lastName=lastName.Trim();
            string email=emailBox.Text;
            email = email.Trim();
            string passWord=passWordBox.Text;
            passWord=passWord.Trim();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into Tabel values (@First_name,@Last_Name,@Email,@Password) ", con);
            command.Parameters.AddWithValue("@First_Name", FirstNameBox.Text);
            command.Parameters.AddWithValue("@Last_Name", lastNameBox.Text);
            try
            {
                command.Parameters.AddWithValue("@Email", emailBox.Text);
                email = emailBox.Text;
            }
            catch
            {
                MessageBox.Show("PLease Enter a Unique Email");
            }
            command.Parameters.AddWithValue("@Password", passWordBox.Text);
            command.ExecuteNonQuery();
            con.Close();
            Personal_InformationDL.addUser(firstName, lastName, email, passWord);
            MessageBox.Show("User Added SuccessFully");
            this.Close();
            Form1 exit = new Form1();
            exit.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from Tabel", con);
            SqlDataAdapter data=new SqlDataAdapter(command);
            DataTable table= new DataTable();
            data.Fill(table);
            UserDG.DataSource= table;
            for(int i=0;i<table.Rows.Count;i++)
            {
                DataRow row = table.Rows[i];
                string name = row["First_Name"].ToString();
                string lastName = row["Last_Name"].ToString();
                string email = row["Email"].ToString();
                string passWord = row["Password"].ToString();
                Personal_InformationDL.addUser(name,lastName, email, passWord); 
            }
        }
    }
}
