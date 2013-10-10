using Med_Sys.BusinessLogic;
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

namespace Med_Sys
{
    public partial class Form2 : Form
    {
        PharmacistLogic pharmacistlogic;
        public Form2()
        {
            InitializeComponent();
            pharmacistlogic = new PharmacistLogic();
            FillPatientId();
        }

        private void FillPatientId()
        {
            SqlDataReader patientIds = pharmacistlogic.getPatientIdReader();
            while (patientIds.Read())
            {
                combopatientID.Items.Add(patientIds[0]);
            }
            combopatientID.AutoCompleteSource = AutoCompleteSource.ListItems;
            combopatientID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            patientIds.Close();

        }

        private void check_Click(object sender, EventArgs e)
        {
            if (combopatientID.Text == "")
            {
                MessageBox.Show("please enter a correct patient ID");
            }
            else
            {
                DataSet dataset = pharmacistlogic.getDataSet(combopatientID.Text);
                pharmacyPrescription.DataSource = dataset.Tables[0];   //linking the datasource with the datagrid
            }
            }
        private void issue_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pharmacyPrescription.RowCount-1; i++)
            {
                pharmacistlogic.reduceFromtheDatabase(pharmacyPrescription[5, i].Value.ToString(), pharmacyPrescription[10, i].Value.ToString());        
            }
        }

       

    }
}
