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

namespace Med_Sys.GUIs
{
    public partial class Form1 : Form
    {
       
        receptionistLogic receptionistlogic;
        public Form1()
        {
            InitializeComponent();
            receptionistlogic = new receptionistLogic();
            FillPatientIdReader();
            FillAppointmentIdReader();
        }


        private void FillAppointmentIdReader()                                            //calling the appointment
        {
            SqlDataReader patientIds = receptionistlogic.getAppointmentIdReader();
            while (patientIds.Read())
            {
                comboBoxappointmentIds.Items.Add(patientIds[0]);
            }
            comboBoxappointmentIds.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxappointmentIds.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            patientIds.Close();

        }
        

        private void FillPatientIdReader()                                                    //getting the patient ID,by invoking the patientId reader
        {
            SqlDataReader patientIds =  receptionistlogic.getpatientIdReader();
            while (patientIds.Read())
            {
                comboBoxpatientId.Items.Add(patientIds[0]);
            }
            comboBoxpatientId.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxpatientId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            patientIds.Close();

        }

       
    }
}
