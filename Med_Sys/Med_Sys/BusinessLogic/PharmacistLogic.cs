using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Med_Sys.BusinessLogic;
using Med_Sys.DataAccess;
using Med_Sys.Properties;


namespace Med_Sys.BusinessLogic
{
    class PharmacistLogic
    {
        private Connection con;
        public PharmacistLogic()
        {
             con = new Connection();
            
        }

        public SqlDataReader getPatientIdReader()
        {
            string sqlcmd = "SELECT PatientId FROM Prescription";
            SqlCommand cmd = con.getSqlCommand(sqlcmd);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;

        }

        public DataSet getDataSet(string patientID)
        {
                    
                 string st = "select * from Prescription where PatientId = " + patientID + " and issued = 0";
                 SqlDataAdapter sda = con.getSqlDataAdapter(st);
                 DataSet DS = new DataSet();
                 sda.Fill(DS);
                 return DS;
            

          
            
            }
        public void reduceFromtheDatabase(string medicineID, string quantity)
        {
            string st = "Update MedicineStock SET Qty = Qty -  "+quantity+" , ReservedAmount = ReservedAmount - "+quantity+" where MedID ="+medicineID+"";
            SqlCommand cmd = con.getSqlCommand(st);
            cmd.ExecuteNonQuery();
            MessageBox.Show("medicine was given to " +medicineID);

        }
    }
}
