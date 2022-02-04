using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace TestPortal
{
    public partial class ViewMarks : Form
    {
        public ViewMarks()
        {
            InitializeComponent();
        }

        private void ViewMarks_Load(object sender, EventArgs e)
        {
            //Reads the Total Marks textfile
            string stu1Marks = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\TotalMarks1.txt";
            string stu2Marks = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\TotalMarks2.txt";
            string stu3Marks = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\TotalMarks3.txt";

            //Reads which user logged into the program
            string username = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\Username Entry\username.txt";

            try
            {
                if (File.Exists(username))
                {
                    StreamReader sr1 = new StreamReader(username);
                    string user = sr1.ReadLine();

                    if (user == "13019459")
                    {
                        StreamReader total = new StreamReader(stu1Marks);

                        //displays total marks
                        lblLearnerMark.Text = total.ReadLine();      //Reads learner 1s total marks
                    }
                    else if (user == "15019459")
                    {
                        StreamReader total = new StreamReader(stu2Marks);

                        //displays total marks
                        lblLearnerMark.Text = total.ReadLine();      //Reads learner 2s total marks
                    }
                    else if (user == "16019459")
                    {
                        StreamReader total = new StreamReader(stu3Marks);

                        //displays total marks
                        lblLearnerMark.Text = total.ReadLine();      //Reads learner 3s total marks
                    }
                }
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show("Invalid Directory " + exc.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
