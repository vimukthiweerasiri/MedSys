using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Med_Sys.BusinessLogic;

namespace Med_Sys
{
    public partial class LoginGUI : Form
    {
        LoginLogic loginlogic;
        public LoginGUI()
        {
            InitializeComponent();
            loginlogic = new LoginLogic();
            password.PasswordChar = '*';
            
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            loginlogic.check(uname.Text,password.Text);

        }




    }
}
