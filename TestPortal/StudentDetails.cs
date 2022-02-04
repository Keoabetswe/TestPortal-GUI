using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPortal
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails details = new StudentDetails();
            this.Close();
            details .Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The lecturer can select a particular radio button" 
                    +"\nin order to view a certain students details and marks");
        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!radStudent1.Checked && !radStudent2.Checked && !radStudent3.Checked)
            {
                MessageBox.Show("Please Select an Option! -_-");
            }
            else if(radStudent1.Checked)
            {
                Student1 s1 = new Student1();
                s1.ShowDialog();
            }
            else if(radStudent2.Checked)
            {
                Student2 s2 = new Student2();
                s2.ShowDialog();
            }
            else if(radStudent3.Checked)
            {
                Student3 s3 = new Student3();
                s3.ShowDialog();
            }
        }

        private void radStudent2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
