using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestPortal
{
    public partial class Student1 : Form
    {
        
        public Student1()
        {
            InitializeComponent();
        }

        private void Student1_Load(object sender, EventArgs e)
        {
            //Student 1's Details from the textfile
            string path = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\13019459\AllDetails1.txt";

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);

                txtName.Text = sr.ReadLine();
                txtSurname.Text = sr.ReadLine();
                txtStudentNum.Text = sr.ReadLine();
            }
            else
            {
                MessageBox.Show("Path does not Exist!");
            }
            //Student 1's Marks
            string totalMarks1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\TotalMarks1.txt";

            if (File.Exists(totalMarks1))
            {
                StreamReader sr = new StreamReader(totalMarks1);

                txtMarks.Text = sr.ReadLine();
            }
            else
            {
                MessageBox.Show("Path does not Exist!");
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student1 s1 = new Student1();
            this.Close();
            s1.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details regarding a student with the \nstudent number of: 13019459");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
