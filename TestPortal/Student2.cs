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
    public partial class Student2 : Form
    {
        public Student2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student2 s3 = new Student2();
            this.Close();
            s3.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details regarding a student with the \nstudent number of: 15019459");
        }

        private void Student2_Load(object sender, EventArgs e)
        {
            //Student 2's Details from the textfile
            string path = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\15019459\AllDetails2.txt";

            if (File.Exists(path))
            {
                FileStream fileStream = File.OpenRead(path); 
                TextReader textReader = File.OpenText(path); 
                StreamReader sr = new StreamReader(path);

                txtName.Text = sr.ReadLine();
                txtSurname.Text = sr.ReadLine();
                txtStudentNum.Text = sr.ReadLine();
            }
            else
            {
                MessageBox.Show("Path does not Exist!");
            }

            //Student 2's Marks
            string totalMarks2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\TotalMarks2.txt";

            if (File.Exists(totalMarks2))
            {
                StreamReader sr = new StreamReader(totalMarks2);

                txtMarks.Text = sr.ReadLine();
            }
            else
            {
                MessageBox.Show("Path does not Exist!");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
