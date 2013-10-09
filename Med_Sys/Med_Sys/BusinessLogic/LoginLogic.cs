using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Med_Sys.DataAccess;

namespace Med_Sys.BusinessLogic
{
    class LoginLogic
    {
        
        Connection connection;
        public LoginLogic() 
        {
            connection = new Connection();
        }

        public bool check(string username,string pwrd)
        {

            string sqlcmd = "SELECT Position FROM Staff WHERE Id='"+username+"' AND Password='"+pwrd+"'";
                    
            if(connection.getConnectionCommand(sqlcmd).ExecuteScalar()!=null)
            {
                string position = getConnection.getConnectionCommand(sqlcmd).ExecuteScalar().ToString();
  
                if (position == "0")
                {
                    Receptionist form2 = new Receptionist();
                    form2.Show();
                }
                if (position == "1")
                {
                    GUI_Doctor form3 = new GUI_Doctor();
                    form3.Show();
                }

                if (position == "2")
                {
                    StoreKeeper form4 = new StoreKeeper();
                    form4.Show();
                }
                if (position == "3")
                {
                    PHARMACIST form5 = new PHARMACIST();
                    form5.Show();
                }
                if (position == "5")
                {
                    Admin formA = new Admin();
                    formA.Show();
                }

               
            }
            else
            {
                
                MessageBox.Show("Your userID or Password is Incorrect. Try again !!!");
            }
        
        }

    }
}
