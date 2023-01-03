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
    public partial class LoadDataForm : Form
    {
        public LoadDataForm()
        {
            InitializeComponent();
        }

        private void LoadDataForm_Load(object sender, EventArgs e)
        {
            //Personal_InformationDL.deletealldataFromDataBase();
            //Personal_InformationDL.deleteRequestFromDataBase();
            // Personal_InformationDL.deleteuserFromdatabase();
            Personal_InformationDL.loadDataFromSQL_DataBase();
            Personal_InformationDL.loadFriendFromDataBase();
            Personal_InformationDL.loadFriendrequestFromDataBase();
            this.Hide();
            Form1 form=new Form1();
            form.Show();
        }
    }
}
