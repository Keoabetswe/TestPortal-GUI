using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;   //Added a new Reference

namespace TestPortal
{
    public partial class TestPortal : Form
    {
        public TestPortal()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLecturer_Click(object sender, EventArgs e)  //Lecturer Login Button
        {
            LecturerLogin password = new LecturerLogin();
            password.ShowDialog();

        }

        private void btnLearner_Click(object sender, EventArgs e) //Learner Login Button
        {
            LearnerLogin password = new LearnerLogin();
            password.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestPortal portal = new TestPortal();
            this.Close();
            portal.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Portal is a program that helps link lecturers and learners to student details, tests and results. \n\n"
                            + "The 'Lecturer button' will open a window that will give you an option of \n"
                            + "viewing students details or setting up a test. \n\n"
                            + "The 'Learner button' opens a new window that will give you the following options: \n"
                            + "Take a test, view your marks or the memorandum.");
        }
    }
}
 