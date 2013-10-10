using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Med_Sys.DataAccess;

namespace Med_Sys.BusinessLogic
{
    class StoreKeeperLogic
    {
        Connection connection;

        public StoreKeeperLogic()
        {
            connection = new Connection();
        }


        public string getStockID() 
        {
            connection.conOpen();
            string sqlquery = "select Max(stkID) from MedicineStock";
            int max = int.Parse(connection.getSqlCommand(sqlquery).ExecuteScalar().ToString());            
            connection.conClose();
            return (max + 1).ToString();
        }

        public string getMedId(string name)
        {
            connection.conOpen();
            string sqlquery = "select MedId from MedicineStock where medname='"+name+ "'";
            string medID = connection.getSqlCommand(sqlquery).ExecuteScalar().ToString();
            connection.conClose();
            return medID;
        }

        public SqlDataReader getMedicineNames()
        {
            string sqlcmd = "SELECT medname FROM medicineStock";
            SqlCommand cmd = connection.getSqlCommand(sqlcmd);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public int updateDB(string stkId,string medID,string Medname,string form,string dose,string qty,string exdate)
        {
            
            connection.conOpen();
            string sqlcmd = "insert into MedicineStock values ('"+stkId+"','"+medID+"','"+Medname+"','"+form+"','"+dose+"',"+qty+",'"+exdate+"',0);";
            SqlCommand cmd = connection.getSqlCommand(sqlcmd);
            int stat = cmd.ExecuteNonQuery();
            return stat;
        }




    }
}
