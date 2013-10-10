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
            fillDose();            
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
            string[] forms = {"Tablets" ,"Capsules" , "Syrup" , "Cream" , "Other"};
            for (int i = 0; i < forms.Length; i++)
            {
                 form.Items.Add(forms[i]);
            }
            form.AutoCompleteSource = AutoCompleteSource.ListItems;
            form.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void fillDose()
        {
            string[] forms = { "5", "10", "15", "20", "25","50","75","100" };
            for (int i = 0; i < forms.Length; i++)
            {
                dose.Items.Add(forms[i]);
            }
            dose.AutoCompleteSource = AutoCompleteSource.ListItems;
            dose.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            if (medname.Text !="" && form.Text !="" && dose.Text !="" && qty.Text != "")
            {
                if (datagridGRN.RowCount < 2)
                {
                string stockid = storekeeper.getStockID();
                string medid = storekeeper.getMedId(medname.Text);
                datagridGRN.Rows.Add(stockid,medid,medname.Text,form.Text,dose.Text,qty.Text,datepicker.Text);
                }
                 else
                {
                string stockid = (int.Parse(datagridGRN[0,datagridGRN.RowCount-2].Value.ToString())+1).ToString();
                string medid = storekeeper.getMedId(medname.Text);
                datagridGRN.Rows.Add(stockid, medid, medname.Text, form.Text, dose.Text, qty.Text, datepicker.Text);
                }
           
             }
            else
            {
                MessageBox.Show("Please enter valid values");
            }
          

            
        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            try
            {
                int rowbegin = datagridGRN.SelectedRows[0].Index;
                 datagridGRN.Rows.RemoveAt(datagridGRN.SelectedRows[0].Index);
                 int rowtotal = datagridGRN.RowCount-1;

                 for (int i = rowbegin; i < rowtotal; i++)
                 {
                     string stockid = (int.Parse(datagridGRN[0,i].Value.ToString())-1).ToString();
                     datagridGRN[0, i].Value = stockid;
                 }
                 
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select a row to remove");
            }
           
        }

        private void buttonfin_Click(object sender, EventArgs e)
        {
            int end = datagridGRN.RowCount-1;
            for (int i = 0; i < end; i++)
            {
                int stat = storekeeper.updateDB(datagridGRN[0,i].Value.ToString(),datagridGRN[1,i].Value.ToString(),datagridGRN[2,i].Value.ToString(),datagridGRN[3,i].Value.ToString(),datagridGRN[4,i].Value.ToString(),datagridGRN[5,i].Value.ToString(),datagridGRN[6,i].Value.ToString());
                if (stat>0)
	            {
		            MessageBox.Show("Added Successfully");
	            }
                else{
                    MessageBox.Show("Error Occured");
                }
            }
        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonexpirycheck_Click(object sender, EventArgs e)
        {
            new TobeExpired().Show();
        }

        private void form_SelectedValueChanged(object sender, EventArgs e)
        {
            if (form.Text == "Capsules" || form.Text == "Tablets")
            {
                qtyident.Text = "mg";
            }
            else if (form.Text == "Syrup")
            {
                qtyident.Text = "ml";
            }
            else
            {
                qtyident.Text = "";

            }
            
        }

        private void buttonstock_Click(object sender, EventArgs e)
        {

        }
    }
}
