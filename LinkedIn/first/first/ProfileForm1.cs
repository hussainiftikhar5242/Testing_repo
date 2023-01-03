using first.Classes;
using Microsoft.VisualBasic;
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

namespace first
{
    public partial class ProfileForm1 : Form
    {
        Personal_Information information = new Personal_Information();
        public ProfileForm1(Personal_Information temp)
        {
            information = temp;
            InitializeComponent();
            firstName.Text = information.firstName;
            lastName.Text = information.lastName;
            
        }

        private void personalButton_Click(object sender, EventArgs e)
        {
            firstNameBox.Text = information.firstName;
            lastNameBox.Text = information.lastName;
            emailBox.Text = information.email;
            passWordBox.Text = information.passWord;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            information.firstName = firstNameBox.Text;
            information.lastName = lastNameBox.Text;
            information.email = emailBox.Text;
            information.passWord = passWordBox.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("Update Tabel set First_name=@First_name,Last_Name=@Last_Name,Password=@Password where Email = @Email", con);
            command.Parameters.AddWithValue("@Email", information.email);
            command.Parameters.AddWithValue("@First_name", firstNameBox.Text);
            command.Parameters.AddWithValue("@Last_Name", lastNameBox.Text);
            command.Parameters.AddWithValue("@Password", passWordBox.Text);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated SuccessFully");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchForm newForm = new SearchForm(information);
            newForm.Show();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FriendRequestForm friendForm = new FriendRequestForm(information.firstName, information.lastName, information.email, information.passWord);
            friendForm.Show();
        }

        private void connectionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllFriend form = new ShowAllFriend(information);
            form.Show();
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatForm chat = new ChatForm(information);
            chat.Show();
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            connectionForm connection = new connectionForm(information);
            connection.Show();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddFriendForm form = new AddFriendForm(information);
            form.Show();
        }

        private void matualButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MatualFriendForm form = new MatualFriendForm(information);
            form.Show();
        }
    }
}
