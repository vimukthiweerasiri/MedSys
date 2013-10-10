using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Med_Sys.DataAccess;

namespace Med_Sys.BusinessLogic
{
    class MedicineToExpire
    {
        Connection connection;

        public MedicineToExpire()
        {
            connection = new Connection();

        }

        public DataTable getExpirelist()
        {
            connection.conOpen();
            DateTime today = DateTime.Today;
            today.AddMonths(1);
            string day = today.ToString("MM/dd/yyyy");
            string sqlcmd = "select * from MedicineStock where ExDate <= '"+day+"';";
            SqlCommand cmd = connection.getSqlCommand(sqlcmd);
            DataTable dt = new DataTable();
            connection.getSqlDataAdapter(sqlcmd).Fill(dt);

            return dt;

            
        }

    }
}
