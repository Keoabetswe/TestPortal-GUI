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
using System.Data.OleDb;

namespace TestPortal
{
    public partial class TestQ1 : Form 
    {
        private StreamWriter learner1Answer1;
        private StreamWriter learner2Answer1;
        private StreamWriter learner3Answer1;

        private StreamWriter Student1TestAnswer1;
        private StreamWriter Student2TestAnswer1;
        private StreamWriter Student3TestAnswer1;
        private StreamWriter Q1mark;

        public TestQ1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This a window that displays the multiple choice test that was created by the lecturer."
                            + "\nYou have to select an option then click the next button to move over to the next question"
                            + "\nAnd ONLY one option is correct."
                            + "\n\nNOTE: You CANNOT go back to the previous page until you've completed the TEST.");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!radOptionA.Checked && !radOptionB.Checked && !radOptionC.Checked)
            {
                MessageBox.Show("Please Select an Option!");
            }
            else if (radOptionA.Checked || radOptionB.Checked || radOptionC.Checked)
            {
                this.Hide();

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
                            learner1Answer1.WriteLine(A);
                            learner1Answer1.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student1TestAnswer1.WriteLine(txtBoxValue);
                            Student1TestAnswer1.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner1Answer1.WriteLine(B);
                            learner1Answer1.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student1TestAnswer1.WriteLine(txtBoxValue);
                            Student1TestAnswer1.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner1Answer1.WriteLine(C);
                            learner1Answer1.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student1TestAnswer1.WriteLine(txtBoxValue);
                            Student1TestAnswer1.Close();
                        }
                    }
                    else if (user == learner2)  //If learner 2s student num is == username ONLY student 2s answers are saved 
                    {
                        if (radOptionA.Checked)
                        {
                            string A = "A";
                            learner2Answer1.WriteLine(A);   //Writes the letter A to Textfile
                            learner2Answer1.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student2TestAnswer1.WriteLine(txtBoxValue);     //Writes textbox value to textfile
                            Student2TestAnswer1.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner2Answer1.WriteLine(B);   //Writes the letter B to Textfile
                            learner2Answer1.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student2TestAnswer1.WriteLine(txtBoxValue); //Writes textbox value to textfile
                            Student2TestAnswer1.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner2Answer1.WriteLine(C);   //Writes the letter A to Textfile
                            learner2Answer1.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student2TestAnswer1.WriteLine(txtBoxValue); //Writes textbox value to textfile
                            Student2TestAnswer1.Close();
                        }
                    }
                    else if (user == learner3)  //If learner 3s student num is == username ONLY student 3s answers are saved 
                    {
                        if (radOptionA.Checked)
                        {
                            string A = "A";
                            learner3Answer1.WriteLine(A);
                            learner3Answer1.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student3TestAnswer1.WriteLine(txtBoxValue);
                            Student3TestAnswer1.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner3Answer1.WriteLine(B);
                            learner3Answer1.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student3TestAnswer1.WriteLine(txtBoxValue);
                            Student3TestAnswer1.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner3Answer1.WriteLine(C);
                            learner3Answer1.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student3TestAnswer1.WriteLine(txtBoxValue);
                            Student3TestAnswer1.Close();
                        }
                    }
                }

                //Reads Learners radio button answer
                string stu1Answer1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer1.txt";
                string stu2Answer1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer1.txt";
                string stu3Answer1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer1.txt";

                //Reads Lecturers radio button answer
               string correctAnswer1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer1.txt";

                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string user = sr.ReadLine();

                    if (user == "13019459")
                    {
                        if (File.Exists(stu1Answer1) && File.Exists(correctAnswer1))
                        {
                            StreamReader sr1 = new StreamReader(stu1Answer1);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer1);    //Lecturers correct answer

                            string stu1Answer = sr1.ReadLine();    //Reads the Learners 3rd Answer
                            string correctA1 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q1 - if learner 1 is logged in
                            if (stu1Answer == correctA1)
                            {
                                mark = 1;
                                Q1mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q1mark.WriteLine(mark); //Writes mark to the file
                            }
                        }
                    }
                    else if (user == "15019459")
                    {
                        if (File.Exists(stu2Answer1) && File.Exists(correctAnswer1))
                        {
                            StreamReader sr1 = new StreamReader(stu2Answer1);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer1);    //Lecturers correct answer

                            string stu2Answer = sr1.ReadLine();    //Reads the Learners 1st Answer
                            string correctA1 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q1 - if learner 2 is logged in
                            if (stu2Answer == correctA1)
                            {
                                mark = 1;
                                Q1mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q1mark.WriteLine(mark); //Writes mark to the file
                            }
                        }
                    }
                    else if (user == "16019459")
                    {
                        if (File.Exists(stu3Answer1) && File.Exists(correctAnswer1))
                        {
                            StreamReader sr1 = new StreamReader(stu3Answer1);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer1);    //Lecturers correct answer

                            string stu3Answer = sr1.ReadLine();    //Reads the Learners 3rd Answer
                            string correctA1 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q1 - if learner 3 is logged in
                            if (stu3Answer == correctA1)
                            {
                                mark = 1;
                                Q1mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q1mark.WriteLine(mark); //Writes mark to the file
                            }
                        }

                    }
                    try
                    {
                         Q1mark.Close(); //Closes the Q1 Mark file
                    }
                    catch
                    {
                          MessageBox.Show("File didnt Close!");
                    }

                  
                    TestQ2 q2 = new TestQ2();
                    q2.ShowDialog();
                }
            }
        }
        private void TestQ1_Load(object sender, EventArgs e)
        {
            //Reads the Lecturers Q1 from the textfile and displays it in the Test
            string path = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ1.txt";

            if(File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);

                txtQuestion1.Text = sr.ReadLine();  //Reads 1st line
                txtOptionA.Text = sr.ReadLine();    //Reads 2nd line
                txtOptionB.Text = sr.ReadLine();    //Reads 3rd line
                txtOptionC.Text = sr.ReadLine();    //Reads 4th line
            }
            else
            {
                MessageBox.Show("Path does not Exist!");
            }

            //Save Learners Answer1 to textfile
            string username = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\Username Entry\username.txt";
            try
            {
                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string userLogin = sr.ReadLine();

                    if (userLogin == "13019459")
                    {
                        learner1Answer1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer1.txt");
                    }
                    else if (userLogin == "15019459")
                    {
                        learner2Answer1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer1.txt");
                    }
                    else if (userLogin == "16019459")
                    {
                        learner3Answer1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer1.txt");
                    }
                }

            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            //Path to saving students selected option for question1
            try
            {
                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string userLogin = sr.ReadLine();

                    if (userLogin == "13019459")
                    {
                        Student1TestAnswer1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner1\Stu1Answer1.txt");
                    }
                    else if (userLogin == "15019459")
                    {
                        Student2TestAnswer1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner2\Stu2Answer1.txt");
                    }
                    else if (userLogin == "16019459")
                    {
                        Student3TestAnswer1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner3\Stu3Answer1.txt");
                    }
                }
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }


            //Path to saving students mark for Q1
            try
            {
                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string currentUser = sr.ReadLine();

                    if (currentUser == "13019459")
                    {
                        Q1mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\StuMarks1.txt");
                    }
                    else if (currentUser == "15019459")
                    {
                        Q1mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\StuMarks1.txt");
                    }
                    else if (currentUser == "16019459")
                    {
                        Q1mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\StuMarks1.txt");
                    }
                }
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            this.Hide();
        }

        private void txtSetQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
