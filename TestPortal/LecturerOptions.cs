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
    public partial class LecturerOptions : Form
    {
        public LecturerOptions()
        {
            InitializeComponent();
        }

        private void LecturerOptions_Load(object sender, EventArgs e)
        {
                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerOptions lecturer = new LecturerOptions();
            this.Close();
            lecturer.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (!radStudentDetails.Checked && !radTestSetUp.Checked)   //Displays message if no radio button is selected
            {
                MessageBox.Show("Please Select an Option!");
            }
            else if (radTestSetUp.Checked)
            {
                TestSetUp1 test = new TestSetUp1();
                test.ShowDialog();
            }
            else if (radStudentDetails.Checked)
            {
                StudentDetails student = new StudentDetails();
                student.ShowDialog();
            }
        }
        private void radTestSetUp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radStudentDetails_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
