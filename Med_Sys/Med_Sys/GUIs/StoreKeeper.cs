using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Med_Sys.BusinessLogic;

namespace Med_Sys.GUIs
{
    public partial class StoreKeeper : Form
    {
        StoreKeeperLogic storekeeper;

        public StoreKeeper()
        {
            InitializeComponent();
            storekeeper = new StoreKeeperLogic();
            FillMedicineNames();
            fillForm();
            
        }

        private void FillMedicineNames()
        {
            SqlDataReader mednames = storekeeper.getMedicineNames();
            while (mednames.Read())
            {
                medname.Items.Add(mednames[0]);
            }
            medname.AutoCompleteSource = AutoCompleteSource.ListItems;
            medname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            mednames.Close();
        }

        private void fillForm()
        {
            string[] forms = {"Tablets" ,"Capsules" , "Sysrup" , "Cream" , "Other"};
            for (int i = 0; i < forms.Length; i++)
            {
                 form.Items.Add(forms[i]);
            }
           
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
           string stockid = storekeeper.getStockID();
           string medid = storekeeper.getMedId(medname.Text);

           datagridGRN.Rows.Add(stockid,medid,medname.Text,form.Text,dose.Text,qty.Text,datepicker.Text);

            
        }
    }
}
