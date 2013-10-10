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

namespace Med_Sys.GUIs
{
    public partial class TobeExpired : Form
    {
        MedicineToExpire medex;
        public TobeExpired()
        {
            InitializeComponent();
            medex = new MedicineToExpire();
            dataGridtobeexpired.DataSource = medex.getExpirelist();
            
        }
        

    }
}
