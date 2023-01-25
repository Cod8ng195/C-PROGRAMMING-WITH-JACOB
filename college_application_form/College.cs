using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college_application_form
{
    public partial class College : Form
    {
        //we first give the dataTable a name, which is - "dtcourses/dtselectedcourses"
        private DataTable dtCourses = new DataTable();
        private DataTable dtSelectedCourses = new DataTable();

        public College()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fourth
            //we are calling a method as shown below
            FillCoursesTable();
            SelectedCourseTable();

            //this peace of code below allows us to desplay data in the listbox1
            listBox1.DataSource = dtCourses;
            listBox1.DisplayMember = "courseName";

            listBox2.DataSource = dtSelectedCourses;
            listBox2.DisplayMember = "courseName";
        }

        //secondly - we are going to create a method that adds columns and rows, as shown in the code below
        private void FillCoursesTable()
        {
            //WE ARE AT THIS POINT ADDING COLUMNS AS SHOWN BELOW
            //TAKE NOTE THAT; THE FIRST COULMN NAME WILL BE "CourseID", and the data type will be an int
            dtCourses.Columns.Add("CourseID", typeof(int));
            dtCourses.Columns.Add("courseName");//bear in mind thata by defult, the datatype for course name is a string 
            dtCourses.Columns.Add("courseDuration");

            //we are now going to create rows
            //
            dtCourses.Rows.Add(1, "Advanced OOP", "5 months");
            dtCourses.Rows.Add(2, "Databases", "4 months");
            dtCourses.Rows.Add(3, "Web Engineering", "6 months");
            dtCourses.Rows.Add(4, "Wed Designing", "6 months");
            dtCourses.Rows.Add(5, "Computer Architecture", "7 months");
            dtCourses.Rows.Add(6, "HTML AMD CSS", "5 months");
            dtCourses.Rows.Add(7, "Java", "4 months");
            dtCourses.Rows.Add(8, "Agile Development", "6 months");
            dtCourses.Rows.Add(9, "CyberSecurity", "6 months");
            dtCourses.Rows.Add(10, "Nteworking Concepts", "7 months");

        }

        //thirdly, since the user selects a course from the list box 1,
        //we will now create another table that will give the ability to figure when and how the table is going to contain columns
        private void SelectedCourseTable()
        {
            //change to dtSelectedCourses
            dtSelectedCourses.Columns.Add("CourseID", typeof(int));
            dtSelectedCourses.Columns.Add("courseName");
            dtSelectedCourses.Columns.Add("courseDuration");
        }
        //fifth
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //we write the if statement in order to check whether the list box1 has selected course or not
            if (listBox1.Items.Count > 0)
            {
                dtSelectedCourses.ImportRow(dtCourses.Rows[listBox1.SelectedIndex]);
                dtCourses.Rows[listBox1.SelectedIndex].Delete();
                //the delete btn removes the selected info from the listbox1/listbox2 once the btn is pressed
            }

        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dtCourses.ImportRow(dtSelectedCourses.Rows[listBox2.SelectedIndex]);
                dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
                //the delete btn removes the selected info from the listbox1/listbox2 once the btn is pressed
            }
        }

        private void cmdAdd_All_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                //the code below will retain the toatl number of rows and it will store the info in the count variable
                int Count = dtCourses.Rows.Count;

                //below we use a for loop
                for (int i = Count - 1; i >= 0; i--)//since we know that we always start counting from zero, the count variable will always be 1 less 
                {
                    dtSelectedCourses.ImportRow(dtCourses.Rows[listBox1.SelectedIndex]);
                    dtCourses.Rows[listBox2.SelectedIndex].Delete();
                }

                //the delete btn removes the selected info from the listbox1/listbox2 once the btn is pressed
            }
            //Generally the i in for loop stands for iterator, that's why most of programmers use i instead of other names

        }

        private void cmdRemove_All_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                //the code below will retain the toatl number of rows and it will store the info in the count variable
                int Count = dtSelectedCourses.Rows.Count;

                //below we use a for loop
                for (int i = Count - 1; i >= 0; i--)//since we know that we always start counting from zero, the count variable will always be 1 less 
                {
                    dtCourses.ImportRow(dtSelectedCourses.Rows[listBox2.SelectedIndex]);
                    dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
                }
            }
        }
        //the finalize btn is going to have a dialog, in do add data in the grid view
        private void cmdFinalize_Click(object sender, EventArgs e)
        {
            //we use the dialog result to get the values/entities in the data grid view
            DialogResult dialog = MessageBox.Show("Are you sure you want to finalize with the courses?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                dataGridView1.DataSource = dtSelectedCourses;
                dataGridView1.Enabled = false;//this peace of code inhibits the user to write any informatiom on the data grid view1

                //in oder for you to hide the ID column, write the code below
                dataGridView1.Columns[0].Visible = false;//we use the 0, "because we start counting from 0" heance the [0] is the value for the first Column
                dataGridView1.RowHeadersVisible = false;

                dataGridView1.Columns[1].Width = 350;//1 is for the second column
                dataGridView1.Columns[2].Width = 500;//2 is for the second column
            }
            else
            {
                MessageBox.Show("Please Select atleast one course", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
