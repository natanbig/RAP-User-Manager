using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAP_User_Manager
{
    public partial class MainTerminal : Form
    {
        DataBaseHelper dataBaseInstance;
        public MainTerminal()
        {
            InitializeComponent();
            dbPass.PasswordChar = '*';
        }


        private void addAllUsersButton_Click(object sender, EventArgs e)
        {
            dataBaseInstance.TranferAllUserToRAP();
            refreshTables();
        }

        private void refreshTables()
        {
            
            notRAPUserTable.DataSource = dataBaseInstance.CreateNotRapUserTable();
            rAPUserTable.DataSource = dataBaseInstance.CreateRapUsersTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBaseInstance.TranferAllUserToNotRAP();
            refreshTables();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshTables();
        }

        private void connectionButton_Click_1(object sender, EventArgs e)
        {
            dataBaseInstance = new DataBaseHelper(dbIP.Text, dbUser.Text, dbPass.Text);
            dataBaseInstance.StartSqlConnection();
            refreshTables();
        }
    }
}
