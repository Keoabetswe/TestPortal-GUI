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
    public partial class StudentPortal3 : Form
    {
        public StudentPortal3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!radTakeTest.Checked && !radViewMarks.Checked && !radViewMemo.Checked)
            {
                MessageBox.Show("Please Select an Option!");
            }
            else if (radTakeTest.Checked)
            {
                TestQ1 test = new TestQ1();
                test.ShowDialog();

                //Enables the view mark button for use after test
                radViewMemo.Enabled = true;
            }
            else if (radViewMarks.Checked)
            {
                ViewMarks marks = new ViewMarks();
                marks.ShowDialog();
            }
            else if (radViewMemo.Checked)
            {
                ViewMemo memo = new ViewMemo();
                memo.ShowDialog();
            }
        }

        private void radTakeTest_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Learner can decide to take their test \nView their marks \nor even view the memorandum");
        }

        private void StudentPortal3_Load(object sender, EventArgs e)
        {
            radViewMemo.Enabled = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student3 stu3 = new Student3();
            this.Close();
            stu3.Close();
        }
    }
}
