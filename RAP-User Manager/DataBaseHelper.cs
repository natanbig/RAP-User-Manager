using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RAP_User_Manager
{
    public class DataBaseHelper
    {
        private string configConnection;
        private SqlConnection connectionToSql;
        private SqlCommand sqlCommandLine;
        private SqlDataReader reader;
        private static bool instance=false;
        private Int64 numberOfNotRAPUsers = 0;
        private Int64 numberOfRAPUsers = 0;



        public DataBaseHelper (string DbIp, string DbUser, string DbPassword)
        {
            this.configConnection = String.Format(@"Data Source=" + DbIp.ToString() + ",1433;Network Library=DBMSSOCN;Initial Catalog=wbsn-data-security;User ID=" + DbUser.ToString() + ";Password=" + DbPassword.ToString());
        }



        public void StartSqlConnection()
        {
            if (!instance)
            {
                connectionToSql = new SqlConnection(configConnection);
                connectionToSql.Open();
                instance = true;
                numberOfNotRAPUsers = 0;
                numberOfRAPUsers = 0;
    }

            
        }
        internal void TranferAllUserToRAP()
        {
            sqlCommandLine = new SqlCommand(@"update pa_repo_users set RISK_LEVEL = '1' where RISK_LEVEL ='0'", connectionToSql);
            reader = sqlCommandLine.ExecuteReader();
            reader.Close();


        }

        internal void TranferAllUserToNotRAP()
        {
            sqlCommandLine = new SqlCommand(@"update pa_repo_users set RISK_LEVEL = '0' where RISK_LEVEL ='1'", connectionToSql);
            reader = sqlCommandLine.ExecuteReader();
            reader.Close();
        }
        public void TransferSelectedUsersToRap(HashSet<string> notRapUsersId)
        {
            foreach(string element in notRapUsersId)
            {
                sqlCommandLine = new SqlCommand(@"update pa_repo_users set RISK_LEVEL = '1' where id = '"+ element +"'",connectionToSql);
                reader = sqlCommandLine.ExecuteReader();
                reader.Close();
            }
        }

        internal void TranferSelectedUsersToNotRap(HashSet<string> rapUsersId)
        {
            foreach (string element in rapUsersId)
            {
                sqlCommandLine = new SqlCommand(@"update pa_repo_users set RISK_LEVEL = '0' where id = '" + element + "'", connectionToSql);
                reader = sqlCommandLine.ExecuteReader();
                reader.Close();
            }
        }

        public  void FindAllNotRAPUsers()
        {
            
            sqlCommandLine = new SqlCommand(@"select * from pa_repo_users where RISK_LEVEL='0'", connectionToSql);
            reader = sqlCommandLine.ExecuteReader();
           
        }

        public DataTable CreateNotRapUserTable()
        {
            numberOfNotRAPUsers = 0;
            FindAllNotRAPUsers();
            DataTable notRapUsers = new DataTable();
            notRapUsers.Columns.Add("Num", typeof(Int64));
            notRapUsers.Columns.Add("Name", typeof(string));
            notRapUsers.Columns.Add("Id", typeof(string));
            while (reader.Read())
            {
                if (reader.GetInt32(12) == 0)
                {
                    notRapUsers.Rows.Add(numberOfNotRAPUsers++, reader.GetString(9),reader.GetString(0));
                    
                }
            }
            reader.Close();
            
            return notRapUsers;
        }



        public void FindAllRAPUsers()
        {
            
            sqlCommandLine = new SqlCommand(@"select * from pa_repo_users where RISK_LEVEL!='0'", connectionToSql);   
            reader = sqlCommandLine.ExecuteReader();
         
        }

        

        public DataTable CreateRapUsersTable()
        {
            numberOfRAPUsers = 0;
            FindAllRAPUsers();
            DataTable rapUsers = new DataTable();
            rapUsers.Columns.Add("Num", typeof(Int64));
            rapUsers.Columns.Add("Name", typeof(string));
            rapUsers.Columns.Add("Risk Level", typeof(int));
            rapUsers.Columns.Add("IDs",typeof(string));
            while (reader.Read())
            {
                if (reader.GetInt32(12) == 1)
                {
                    rapUsers.Rows.Add(numberOfRAPUsers++,reader.GetString(9),reader.GetInt32(12),reader.GetString(0));
                    
                }
            }
            reader.Close();
            return rapUsers;

        }



        public void CloseConnection()
        {
            reader.Close();
            connectionToSql.Close();
            instance = false;
        }

        public long NumberOfNotRAPUsers
        {
            get
            {
                return numberOfNotRAPUsers;
            }
        }

        public long NumberOfRAPUsers
        {
            get
            {
                return numberOfRAPUsers;
            }
        }

    }
}

