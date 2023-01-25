using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPurchase_Click(object sender, EventArgs e)
        {
            // We use the "\n" to denot that the text we are writing is going to be in the next line
            // in our MessageBox, we use the "" to give the Messagebox a Title
            // Reminder: what we put in our message box are called parametters
            DialogResult dr = MessageBox.Show("1: To Purchase Item, Press = Yes. \n 2: To not Purchase the item, Press = No \n 3: Cancel Purchase", "Purchase Item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if(dr == DialogResult.Yes)
            {
                lblYesNo.Text = "Your Order has been recieved, thanks for shoping with us";
            }
            //we use this method to desplay numerous messages on the same lebel
            if (dr == DialogResult.No)
            {
                lblYesNo.Text = "You have chosen not to purchase, thank you for visiting the website";
            }
            if (dr == DialogResult.Cancel)
            {
                lblYesNo.Text = "You have Canceled the Order";
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1: To Purchase Item, Press = Yes. \n 2: To not Purchase the item, Press = No \n 3: Cancel Purchase", "Purchase Item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
               label2.Text = "Your Order has been recieved, thanks for shoping with us";
            }
            //we use this method to desplay numerous messages on the same lebel
            if (dr == DialogResult.No)
            {
                label2.Text = "You have chosen not to purchase, thank you for visiting the website";
            }
            if (dr == DialogResult.Cancel)
            {
                label1.Text = "You have Canceled the Order";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1: To Purchase Item, Press = Yes. \n 2: To not Purchase the item, Press = No \n 3: Cancel Purchase", "Purchase Item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                label6.Text = "Your Order has been recieved, thanks for shoping with us";
            }
            //we use this method to desplay numerous messages on the same lebel
            if (dr == DialogResult.No)
            {
                label6.Text = "You have chosen not to purchase, thank you for visiting the website";
            }
            if (dr == DialogResult.Cancel)
            {
                label5.Text = "You have Canceled the Order";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1: To Purchase Item, Press = Yes. \n 2: To not Purchase the item, Press = No \n 3: Cancel Purchase", "Purchase Item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                label4.Text = "Your Order has been recieved, thanks for shoping with us";
            }
            //we use this method to desplay numerous messages on the same lebel
            if (dr == DialogResult.No)
            {
                label4.Text = "You have chosen not to purchase, thank you for visiting the website";
            }
            if (dr == DialogResult.Cancel)
            {
                label3.Text = "You have Canceled the Order";
            }

        }

        private void lblExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
