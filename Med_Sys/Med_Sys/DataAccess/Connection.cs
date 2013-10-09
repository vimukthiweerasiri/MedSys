using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_Sys.DataAccess
{
    class Connection
    {
        protected SqlConnection sqlconnection;
        private SqlCommand command;
        
        public Connection()
        {
            sqlconnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dinal\Documents\GIThub\MedSys\Med_Sys\Med_Sys\Database1.mdf;Integrated Security=True");
            sqlconnection.Open();
        }

        public void conClose() 
        {
            sqlconnection.Close();
        }

        public SqlCommand getSqlCommand(string scom)
        {
            command = new SqlCommand(scom, sqlconnection);
            return command;
        }

        public SqlDataAdapter getSqlDataAdapter(string scom)
        { 
            SqlDataAdapter sqldataad = new SqlDataAdapter(scom, sqlconnection);
            return sqldataad;
        }
    
    }
    
}
