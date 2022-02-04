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
    public partial class Student3 : Form
    {
        public Student3()
        {
            InitializeComponent();
        }

        private void Student3_Load(object sender, EventArgs e)
        {
            //Student 's Details from the textfile
            string path = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\16019459\AllDetails3.txt";

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

            //Student 3's Marks
            string totalMarks3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\TotalMarks3.txt";

            if (File.Exists(totalMarks3))
            {
                StreamReader sr = new StreamReader(totalMarks3);

                txtMarks.Text = sr.ReadLine();
            }
            else
            {
                MessageBox.Show("Path does not Exist!");
            }
        }

        private void lblStudentDetails_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student3 s2 = new Student3();
            this.Close();
            s2.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details regarding a student with the \nstudent number of: 16019459");
        }
    }
}
 