using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Med_Sys.DataAccess;
using System.Data.SqlClient;

namespace Med_Sys
{
    class receptionistLogic
    {
    
        private Connection con;
        public receptionistLogic()
        {
             con = new Connection();
            
        }

        public SqlDataReader getAppointmentIdReader()
        {
            string sqlcmd = "SELECT AppointmentId FROM Appointments";
            SqlCommand cmd = con.getSqlCommand(sqlcmd);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;

        }
        public SqlDataReader getpatientIdReader()
        {
            string sqlcmd = "Select PatientId From Appointments";
            SqlCommand cmd = con.getSqlCommand(sqlcmd);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;

        }
        public SqlDataReader getdoctordetails()
        {
            string sqlcmd = "select UserId from Login";
            SqlCommand cmd = con.getSqlCommand(sqlcmd);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;

        
        }
        public void enterAppointment(string patienId)
        {
            string str = "";

        }
    }
}
