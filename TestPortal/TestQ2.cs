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
    public partial class TestQ2 : Form
    {
        private StreamWriter learner1Answer2;
        private StreamWriter learner2Answer2;
        private StreamWriter learner3Answer2;

        private StreamWriter Student1TestAnswer2;
        private StreamWriter Student2TestAnswer2;
        private StreamWriter Student3TestAnswer2;

        private StreamWriter Q2mark;

        public TestQ2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
        }

        private void TestQ2_Load(object sender, EventArgs e)
        {
            //Reads the Lecturers Q2 from the textfile and displays it in the Test
            string path = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ2.txt";

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);

                txtQuestion2.Text = sr.ReadLine();
                txtOptionA.Text = sr.ReadLine();
                txtOptionB.Text = sr.ReadLine();
                txtOptionC.Text = sr.ReadLine();
            }
            else
            {
                MessageBox.Show("Path does not Exist!");
            }

            //Save Learners Answer2 to textfile
            string username = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\Username Entry\username.txt";
            try
            {
                if(File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string userLogin = sr.ReadLine();

                    if (userLogin == "13019459")
                    {
                        learner1Answer2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer2.txt");
                    }
                    else if (userLogin == "15019459")
                    {
                        learner2Answer2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer2.txt");
                    }
                    else if (userLogin == "16019459")
                    {
                        learner3Answer2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer2.txt");
                    }
                }
                
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            //Path to saving students selected option for question2
            try
            {
                if(File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string userLogin = sr.ReadLine();

                    if (userLogin == "13019459")
                    {
                        Student1TestAnswer2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner1\Stu1Answer2.txt");
                    }
                    else if (userLogin == "15019459")
                    {
                        Student2TestAnswer2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner2\Stu2Answer2.txt");
                    }
                    else if (userLogin == "16019459")
                    {
                        Student3TestAnswer2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner3\Stu3Answer2.txt");
                    }
                }
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            //Path to saving students mark for Q2
            try
            {
                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string currentUser = sr.ReadLine();

                    if (currentUser == "13019459")
                    {
                        Q2mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\StuMarks2.txt");
                    }
                    else if (currentUser == "15019459")
                    {
                        Q2mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\StuMarks2.txt");
                    }
                    else if (currentUser == "16019459")
                    {
                        Q2mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\StuMarks2.txt");
                    }
                }
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!radOptionA.Checked && !radOptionB.Checked && !radOptionC.Checked)
            {
                MessageBox.Show("Please Select an Option!");
            }
            else if (radOptionA.Checked || radOptionB.Checked || radOptionC.Checked)
            {

                string txtBoxValue; //holds textbox value
                string learner1 = "13019459";   //Learner 1s Student num
                string learner2 = "15019459";   //Learner 2s Student num
                string learner3 = "16019459";   //Learner 3s Student num

                string username = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\Username Entry\username.txt";
                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);

                    string user = sr.ReadLine();

                    if (user == learner1)   //If learner 1s student num is == username ONLY student 1s answers are saved 
                    {
                        if (radOptionA.Checked)
                        {
                            string A = "A";
                            learner1Answer2.WriteLine(A);
                            learner1Answer2.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student1TestAnswer2.WriteLine(txtBoxValue);
                            Student1TestAnswer2.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner1Answer2.WriteLine(B);
                            learner1Answer2.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student1TestAnswer2.WriteLine(txtBoxValue);
                            Student1TestAnswer2.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner1Answer2.WriteLine(C);
                            learner1Answer2.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student1TestAnswer2.WriteLine(txtBoxValue);
                            Student1TestAnswer2.Close();
                        }
                    }
                    else if (user == learner2)  //If learner 2s student num is == username ONLY student 2s answers are saved 
                    {
                        if (radOptionA.Checked)
                        {
                            string A = "A";
                            learner2Answer2.WriteLine(A);   //Writes the letter A to Textfile
                            learner2Answer2.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student2TestAnswer2.WriteLine(txtBoxValue);     //Writes textbox value to textfile
                            Student2TestAnswer2.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner2Answer2.WriteLine(B);   //Writes the letter B to Textfile
                            learner2Answer2.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student2TestAnswer2.WriteLine(txtBoxValue); //Writes textbox value to textfile
                            Student2TestAnswer2.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner2Answer2.WriteLine(C);   //Writes the letter A to Textfile
                            learner2Answer2.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student2TestAnswer2.WriteLine(txtBoxValue); //Writes textbox value to textfile
                            Student2TestAnswer2.Close();
                        }
                    }
                    else if (user == learner3)  //If learner 3s student num is == username ONLY student 3s answers are saved 
                    {
                        if (radOptionA.Checked)
                        {
                            string A = "A";
                            learner3Answer2.WriteLine(A);
                            learner3Answer2.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student3TestAnswer2.WriteLine(txtBoxValue);
                            Student3TestAnswer2.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner3Answer2.WriteLine(B);
                            learner3Answer2.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student3TestAnswer2.WriteLine(txtBoxValue);
                            Student3TestAnswer2.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner3Answer2.WriteLine(C);
                            learner3Answer2.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student3TestAnswer2.WriteLine(txtBoxValue);
                            Student3TestAnswer2.Close();
                        }
                    }
                }


                //Reads Learners radio button answer
                string stu1Answer2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer2.txt";
                string stu2Answer2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer2.txt";
                string stu3Answer2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer2.txt";

                //Reads Lecturers radio button answer
                string correctAnswer2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer2.txt";

                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string user = sr.ReadLine();

                    if (user == "13019459")
                    {
                        if (File.Exists(stu1Answer2) && File.Exists(correctAnswer2))
                        {
                            StreamReader sr1 = new StreamReader(stu1Answer2);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer2);    //Lecturers correct answer

                            string stu1Answer = sr1.ReadLine();    //Reads the Learners 3rd Answer
                            string correctA2 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q1 - if learner 1 is logged in
                            if (stu1Answer == correctA2)
                            {
                                mark = 1;
                                Q2mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q2mark.WriteLine(mark); //Writes mark to the file
                            }
                        }
                    }
                    else if (user == "15019459")
                    {
                        if (File.Exists(stu2Answer2) && File.Exists(correctAnswer2))
                        {
                            StreamReader sr1 = new StreamReader(stu2Answer2);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer2);    //Lecturers correct answer

                            string stu2Answer = sr1.ReadLine();    //Reads the Learners 1st Answer
                            string correctA2 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q1 - if learner 2 is logged in
                            if (stu2Answer == correctA2)
                            {
                                mark = 1;
                                Q2mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q2mark.WriteLine(mark); //Writes mark to the file
                            }
                        }
                    }
                    else if (user == "16019459")
                    {
                        if (File.Exists(stu3Answer2) && File.Exists(correctAnswer2))
                        {
                            StreamReader sr1 = new StreamReader(stu3Answer2);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer2);    //Lecturers correct answer

                            string stu3Answer = sr1.ReadLine();    //Reads the Learners 3rd Answer
                            string correctA2 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q1 - if learner 3 is logged in
                            if (stu3Answer == correctA2)
                            {
                                mark = 1;
                                Q2mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q2mark.WriteLine(mark); //Writes mark to the file
                            }
                        }
                    }
                }
                try
                {
                    Q2mark.Close(); //Closes the Q3 Mark file
                }
                catch
                {
                     MessageBox.Show("File didnt Close!");
                }

                    this.Hide();

                    TestQ3 q3 = new TestQ3();
                    q3.ShowDialog();
                }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("N/A");
        }

        private void radOptionA_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
