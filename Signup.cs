using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passing_data_from_page_to_page
{
    public partial class Signup : Form
    {
        //since the data is to be tranfeered from one form to another, the easiest to do is to create statice as shown below
        public static string fName;
        public static string LName;
        public static string EmailAdress;
        //since checkboxes are either true or false i.e cheched or not checked, we therefore use the boolean datatype
        public static Boolean SMS_not;
        public static Boolean Reports;
        public static Boolean Trans;

        //after creating the second form, we therefore create an object for the new form, as shown below
       services s = new services();

        public Signup()
        {
            InitializeComponent();
        }

        private void cmdSignup_Click(object sender, EventArgs e)
        {
            //LETS FIRST GET THE NAMES FROM THE CHECK BOXES 
            // we assign text boxes to the corresponding variables

            fName = txtFName.Text;
            LName = txtLName.Text;
            EmailAdress = txtEmailAddress.Text;

            this.Hide();
            s.Show();

        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            //if this is true 
            if (chkSMS.Checked)
            {
                SMS_not = true;

                lblSMS_not.Text = "Service Charges may Apply for SMS Notifications";
            }
            //if this is not true/ false
            else
            {
                SMS_not = false;

                lblSMS_not.Text = "...........";
            }
        }

        private void chkTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrans.Checked)
            {
                Trans = true;

                lbl_Trans.Text = "Services charges may apply for Transaction Reports";
            }
            else
            {
                Trans = false;

                lbl_Trans.Text = "...........";
            }
        }

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {

            if (chkReports.Checked)
            {
                Reports = true;

               
            }
            else
            {
                Reports = false;

            }
        }

        private void lblSMS_not_Click(object sender, EventArgs e)
        {

        }
    }
}
