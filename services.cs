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
    

    public partial class services : Form
    {


        public services()
        {
            InitializeComponent();
        }

        private void services_Load(object sender, EventArgs e)
        {
           

            lblFname.Text = Signup.fName;
            lblLastN.Text = Signup.LName;
            lblE_Address.Text = Signup.EmailAdress;

            //these being attributes 
            if (Signup.SMS_not)
            {
                lbl_SMS.Text = " ✓";
            }
            if (Signup.Reports)
            {
                lblReports.Text = " ✓";
            }
            if (Signup.Trans)
            {
                lblTrans.Text = " ✓";
            }

        }

        private void cmdSignup_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SMS_Click(object sender, EventArgs e)
        {

        }
    }
}
