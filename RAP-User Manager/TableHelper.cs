using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAP_User_Manager
{
    class TableHelper
    {

        private HashSet<string> notRapUsersId = new HashSet<string>();



        public void AddIdSelected(string Id)
        {
            notRapUsersId.Add(Id);

 
        }

        public HashSet<string> IDs
        {
            get
            {
                return notRapUsersId;
            }
        }

        ~TableHelper()
        {
            notRapUsersId.Clear();
        }

    }
}
