using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Security.Policy;
using System.Collections;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using Nancy.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Nancy;
using System.Windows.Forms;
using System.Web;

namespace first.Classes
{
    public  class Personal_InformationDL
    {
        public static string message = "";
        public static Dictionary<Personal_Information,List<Personal_Information>> rquestedFriend=new Dictionary<Personal_Information, List<Personal_Information>>();
        public static List<Personal_Information> informationList=new List<Personal_Information>();
        public static Dictionary<Personal_Information,List<Personal_Information>> friendGraph=new Dictionary<Personal_Information, List<Personal_Information>>();
        public static int counter=0;

        public static void addUser(string firstName,string lastName,string email,string password)
        {
            Personal_Information temp= new Personal_Information();
            temp.email = email;
            temp.firstName=firstName;
            temp.lastName=lastName;
            temp.passWord = password;
            informationList.Add(temp);
            counter++;
        }
        public static void addUserIntoFile(string firstName, string lastName, string email,string passWord)
        {
            StreamWriter temp = new StreamWriter("personal.txt",true);
            temp.WriteLine(firstName + "," + lastName + "," + email + "," + passWord);
            temp.Flush();
            temp.Close();
        }

        public static Personal_Information returnName(string email,string password)
        {
            foreach (Personal_Information temp in informationList)
            {
                if (temp.email == email && temp.passWord == password)
                {
                    return temp;
                }
            }
            return null;
        }
        public static void deletealldataFromDataBase()
        {
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con1.Open();
            SqlCommand command = new SqlCommand("DELETE FROM [FriendTable]", con1);
            command.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("Request Accept SuccessFully And Deleted From DataBase");
        }

        public static void deleteuserFromdatabase()
        {
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con1.Open();
            SqlCommand command = new SqlCommand("DELETE FROM [Tabel]", con1);
            command.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("Request Accept SuccessFully And Deleted From DataBase");

        }
        public static void loadDataFromSQL_DataBase()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from Tabel", con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string name = row["First_Name"].ToString();
                string lastName = row["Last_Name"].ToString();
                string email = row["Email"].ToString();
                email = email.Trim();
                string passWord = row["Password"].ToString();
                addUser(name, lastName, email, passWord);
            }
        }
        public static void deleteUserFromRequestList(Personal_Information user,Personal_Information deleteduser)
        {
            foreach(KeyValuePair<Personal_Information,List<Personal_Information>> friend in rquestedFriend)
            {
                if(friend.Key.email == user.email)
                {
                    for(int i=0;i<friend.Value.Count();i++)
                    {
                        if (friend.Value[i].email == deleteduser.email)
                        {
                            friend.Value.RemoveAt(i);
                        }
                    }
                }
            }
            foreach (KeyValuePair<Personal_Information, List<Personal_Information>> friend in rquestedFriend)
            {
                if (friend.Key.email == deleteduser.email)
                {
                    for (int i = 0; i < friend.Value.Count(); i++)
                    {
                        if (friend.Value[i].email == user.email)
                        {
                            friend.Value.RemoveAt(i);
                        }
                    }
                }
            }
        }
        public static void deleteRequestFromDataBase()
        {
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con1.Open();
            SqlCommand command = new SqlCommand("DELETE FROM [RequestTable]", con1);
            command.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("Request Accept SuccessFully And Deleted From DataBase");
        }
        public static void storeRequestIntoDataBase()
        {
            foreach(KeyValuePair<Personal_Information,List<Personal_Information>> againrequest in rquestedFriend)
            {
                Personal_Information t1 = new Personal_Information();
                t1 = againrequest.Key;
                foreach(Personal_Information var in againrequest.Value)
                {
                    Personal_Information t2 = new Personal_Information();
                    t2 = var;
                    storeFriendRequestIntoDataBase(t1, t2);

                }
            }
        }

        public static bool isFriend(Personal_Information check,Personal_Information frind)
        {
            foreach(KeyValuePair<Personal_Information , List<Personal_Information>> t in friendGraph)
            {
                if(check.email == t.Key.email)
                {
                    foreach(Personal_Information var in t.Value)
                    {
                        if(var.email == frind.email)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static bool isRequestSendAlready(Personal_Information check, Personal_Information frind)
        {
            foreach (KeyValuePair<Personal_Information, List<Personal_Information>> t in rquestedFriend)
            {
                if (check.email == t.Key.email)
                {
                    foreach (Personal_Information var in t.Value)
                    {
                        if (var.email == frind.email)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static void storeFriendRequestIntoDataBase(Personal_Information user,Personal_Information request)
        {
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con1.Open();
            SqlCommand command = new SqlCommand("insert into [RequestTable] values (@kName,@kLastName,@kEmail,@kPassword,@vName,@vLastName,@vEmail,@vPassword) ", con1);
            command.Parameters.AddWithValue("@kName", user.firstName);
            command.Parameters.AddWithValue("@kLastName", user.lastName);
            command.Parameters.AddWithValue("@kEmail", user.email);
            command.Parameters.AddWithValue("@kPassword", user.passWord);
            command.Parameters.AddWithValue("@vName", request.firstName);
            command.Parameters.AddWithValue("@vLastName", request.lastName);
            command.Parameters.AddWithValue("@vEmail", request.email);
            command.Parameters.AddWithValue("@vPassword", request.passWord);
            command.ExecuteNonQuery();
            con1.Close();
        }
        public static bool CheckUser(string Name, string Password)
        {
            foreach (Personal_Information temp in informationList)
            {
                if (temp.email == Name && temp.passWord == Password)
                {
                    return true;
                }
            }
            return false;
        }
        public static void addFriendIntoDataBase(Personal_Information user1,Personal_Information user2)
        {
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con1.Open();
            SqlCommand command = new SqlCommand("insert into [FriendTable] values (@FName,@FLastName,@FEmail,@FPassword,@RName,@RLastName,@REmail,@RPassword) ", con1);
            command.Parameters.AddWithValue("@FName", user1.firstName);
            command.Parameters.AddWithValue("@FLastName", user1.lastName);
            command.Parameters.AddWithValue("@FEmail", user1.email);
            command.Parameters.AddWithValue("@FPassword", user1.passWord);
            command.Parameters.AddWithValue("@RName", user2.firstName);
            command.Parameters.AddWithValue("@RLastName", user2.lastName);
            command.Parameters.AddWithValue("@REmail", user2.email);
            command.Parameters.AddWithValue("@RPassword", user2.passWord);
            command.ExecuteNonQuery();
            con1.Close();
        }
        public static void loadFriendFromDataBase()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from FriendTable", con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string fname = row["FName"].ToString();
                string flastName = row["FLastName"].ToString();
                string femail = row["FEmail"].ToString();
                femail = femail.Trim();
                string passWord = row["FPassword"].ToString();
                string rname = row["RName"].ToString();
                string rlastName = row["RLastName"].ToString();
                string remail = row["REmail"].ToString();
                remail = remail.Trim();
                string rpassWord = row["RPassword"].ToString();
                Personal_Information temp=new Personal_Information();
                temp.firstName = fname;
                temp.lastName = flastName;
                temp.email=femail;
                temp.passWord = passWord;
                Personal_Information temp1 = new Personal_Information();
                temp1.firstName = rname;
                temp1.lastName = rlastName;
                temp1.email = remail;
                temp1.passWord = rpassWord;
                if (!friendGraph.ContainsKey(temp))
                    friendGraph.Add(temp, new List<Personal_Information>());
                if (!friendGraph.ContainsKey(temp1))
                    friendGraph.Add(temp1, new List<Personal_Information>());
                friendGraph[temp].Add(temp1);
            }
        }
        public static void loadFriendrequestFromDataBase()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D4TTB52;Initial Catalog=msdb;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select * from RequestTable", con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table1 = new DataTable();
            data.Fill(table1);
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                DataRow row = table1.Rows[i];
                string fname = row["kName"].ToString();
                string flastName = row["kLastName"].ToString();
                string femail = row["kEmail"].ToString();
                femail = femail.Trim();
                string passWord = row["kPassword"].ToString();
                string rname = row["vName"].ToString();
                string rlastName = row["vLastName"].ToString();
                string remail = row["vEmail"].ToString();
                remail = remail.Trim();
                string rpassWord = row["vPassword"].ToString();
                Personal_Information temp = new Personal_Information();
                temp.firstName = fname;
                temp.lastName = flastName;
                temp.email = femail;
                temp.passWord = passWord;
                Personal_Information temp1 = new Personal_Information();
                temp1.firstName = rname;
                temp1.lastName = rlastName;
                temp1.email = remail;
                temp1.passWord = rpassWord;
                if (!rquestedFriend.ContainsKey(temp))
                    rquestedFriend.Add(temp, new List<Personal_Information>());
                if (!rquestedFriend.ContainsKey(temp1))
                    rquestedFriend.Add(temp1, new List<Personal_Information>());
                rquestedFriend[temp1].Add(temp);
                //rquestedFriend[temp].Add(temp1);

            }
        }
        public static void storeMessageIntoFile(string path, string Message)
        {
            StreamWriter temp = new StreamWriter(path);
            temp.WriteLine(Message);
            temp.Close();
        }

        public static bool loadMessageFromFile(string path)
        {
            message = "";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    message = message + record + Environment.NewLine;
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        public static string returnName(string email)
        {
            foreach (Personal_Information temp in informationList)
            {
                if (temp.email == email )
                {
                    return temp.firstName;
                }
            }
            return null;
        }
        public static Personal_Information returnUser(string email)
        {
            foreach (Personal_Information temp in informationList)
            {
                if (temp.email == email)
                {
                    return temp;
                }
            }
            return null;
        }
    }
}
