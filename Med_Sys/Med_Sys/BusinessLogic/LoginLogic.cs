using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void check(string username,string pwrd)
        {

            string sqlcmd = "SELECT level FROM login WHERE UserId='"+username+"' AND psw='"+pwrd+"'";
                    
            if(connection.getSqlCommand(sqlcmd).ExecuteScalar()!=null)
            {
                string position = connection.getSqlCommand(sqlcmd).ExecuteScalar().ToString();
  
                if (position == "0")
                {
                    MessageBox.Show("0");
                }
                if (position == "1")
                {
                    
                }

                if (position == "2")
                {
                    
                }
                if (position == "3")
                {
                   
                }
                if (position == "5")
                {
                   
                }

               
            }
            else
            {
                
                MessageBox.Show("Your userID or Password is Incorrect");
            }
        
        }

    }
}
