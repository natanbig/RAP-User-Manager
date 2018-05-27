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
        TableHelper idsListOfUsers;
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
        private void refreshSummeryOfUsers()
        {
            sumOfNotRapusers.Text = dataBaseInstance.NumberOfNotRAPUsers.ToString();
            sumOfRpUsers.Text = dataBaseInstance.NumberOfRAPUsers.ToString();
        }


        private void refreshTables()
        {
            
            notRAPUserTable.DataSource = dataBaseInstance.CreateNotRapUserTable();
            rAPUserTable.DataSource = dataBaseInstance.CreateRapUsersTable();
            refreshSummeryOfUsers();
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
            //Application.Run(new ProgressBar());
            dataBaseInstance = new DataBaseHelper(dbIP.Text, dbUser.Text, dbPass.Text);
            dataBaseInstance.StartSqlConnection();
            refreshTables();
        }

        //private void notRAPUserTable_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (tableIdOfNotRapUsers==null)
        //        tableIdOfNotRapUsers = new TableHelper();           
        //    tableIdOfNotRapUsers.AddIdSelected(notRAPUserTable.Rows[e.RowIndex].Cells[2].Value.ToString());
        //}




        private void addSelectedusersToRap_Click(object sender, EventArgs e)
        {


        }

        private void addSelectedusersToRap_Click_1(object sender, EventArgs e)
        {
            for (int i= notRAPUserTable.RowCount-1; i>=0; i--)
            {
                DataGridViewRow row = notRAPUserTable.Rows[i];
                if (Convert.ToBoolean(row.Cells["selectedLeft"].Value))
                {
                    if (idsListOfUsers == null)
                        idsListOfUsers = new TableHelper();
                    idsListOfUsers.AddIdSelected(row.Cells[3].Value.ToString());
                }
            }
            dataBaseInstance.TransferSelectedUsersToRap(idsListOfUsers.IDs);
            refreshTables();
            idsListOfUsers = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = rAPUserTable.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = rAPUserTable.Rows[i];
                if (Convert.ToBoolean(row.Cells["selectedRigh"].Value))
                {
                    if (idsListOfUsers == null)
                        idsListOfUsers = new TableHelper();
                    idsListOfUsers.AddIdSelected(row.Cells[4].Value.ToString());
                }
            }
            dataBaseInstance.TranferSelectedUsersToNotRap(idsListOfUsers.IDs);
            refreshTables();
            idsListOfUsers = null;
        }
    }
}
