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
    public partial class TestQ3 : Form
    {
        private StreamWriter learner1Answer3;
        private StreamWriter learner2Answer3;
        private StreamWriter learner3Answer3;

        private StreamWriter Student1TestAnswer3;
        private StreamWriter Student2TestAnswer3;
        private StreamWriter Student3TestAnswer3;
        private StreamWriter Q3mark;
        private StreamWriter allMarks;

        public TestQ3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
        }

        private void TestQ3_Load(object sender, EventArgs e)
        {

            //Reads the Lecturers Q1 from the textfile and displays it in the Test
            string path = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ3.txt";
            try
            {
                if (File.Exists(path))
                {
                    StreamReader sr = new StreamReader(path);

                    txtQuestion3.Text = sr.ReadLine();
                    txtOptionA.Text = sr.ReadLine();
                    txtOptionB.Text = sr.ReadLine();
                    txtOptionC.Text = sr.ReadLine();
                }
                else
                {
                    MessageBox.Show("Path does not Exist!");
                }
            }
            catch(System.IO.IOException exc)
            {
                MessageBox.Show("Invalid Directory " + exc.Message);
            }

            //Save Learners Answer3 to textfile
            string username = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\Username Entry\username.txt";
            try
            {
                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string userLogin = sr.ReadLine();

                    if (userLogin == "13019459")
                    {
                        learner1Answer3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer3.txt");
                    }
                    else if (userLogin == "15019459")
                    {
                        learner2Answer3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer3.txt");
                    }
                    else if (userLogin == "16019459")
                    {
                        learner3Answer3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer3.txt");
                    }
                }

                //Path to saving students selected option for question3
                try
                {
                    if (File.Exists(username))
                    {
                        StreamReader sr = new StreamReader(username);
                        string userLogin = sr.ReadLine();

                        if (userLogin == "13019459")
                        {
                            Student1TestAnswer3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner1\Stu1Answer3.txt");
                        }
                        else if (userLogin == "15019459")
                        {
                            Student2TestAnswer3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner2\Stu2Answer3.txt");
                        }
                        else if (userLogin == "16019459")
                        {
                            Student3TestAnswer3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner3\Stu3Answer3.txt");
                        }
                    }
                }
                catch (DirectoryNotFoundException exc)
                {
                    MessageBox.Show("Invalid Directory" + exc.Message);
                }

                //Path to saving students mark for Q3
                try
                {
                    if (File.Exists(username))
                    {
                        StreamReader sr = new StreamReader(username);
                        string currentUser = sr.ReadLine();

                        if (currentUser == "13019459")
                        {
                            Q3mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\StuMarks3.txt");
                        }
                        else if (currentUser == "15019459")
                        {
                            Q3mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\StuMarks3.txt");
                        }
                        else if (currentUser == "16019459")
                        {
                            Q3mark = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\StuMarks3.txt");
                        }
                    }
                }
                catch (DirectoryNotFoundException exc)
                {
                    MessageBox.Show("Invalid Directory" + exc.Message);
                }

                //Path for saving Learners Total Marks for Memo
                try
                {
                    if (File.Exists(username))
                    {
                        StreamReader sr = new StreamReader(username);
                        string currentUser = sr.ReadLine();

                        if (currentUser == "13019459")
                        {
                            allMarks = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\TotalMarks1.txt");
                        }
                        else if (currentUser == "15019459")
                        {
                            allMarks = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\TotalMarks2.txt");
                        }
                        else if (currentUser == "16019459")
                        {
                            allMarks = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\TotalMarks3.txt");
                        }
                    }
                    
                }
                catch (DirectoryNotFoundException exc)
                {
                    MessageBox.Show("Invalid Directory" + exc.Message);
                }
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press the Complete Button when your done with the TEST.");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (!radOptionA.Checked && !radOptionB.Checked && !radOptionC.Checked)
            {
                MessageBox.Show("Please Select an Option!");
            }

            if (radOptionA.Checked || radOptionB.Checked || radOptionC.Checked)
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
                            learner1Answer3.WriteLine(A);
                            learner1Answer3.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student1TestAnswer3.WriteLine(txtBoxValue);
                            Student1TestAnswer3.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner1Answer3.WriteLine(B);
                            learner1Answer3.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student1TestAnswer3.WriteLine(txtBoxValue);
                            Student1TestAnswer3.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner1Answer3.WriteLine(C);
                            learner1Answer3.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student1TestAnswer3.WriteLine(txtBoxValue);
                            Student1TestAnswer3.Close();
                        }
                    }
                    else if (user == learner2)  //If learner 2s student num is == username ONLY student 2s answers are saved 
                    {
                        if (radOptionA.Checked)
                        {
                            string A = "A";
                            learner2Answer3.WriteLine(A);   //Writes the letter A to Textfile
                            learner2Answer3.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student2TestAnswer3.WriteLine(txtBoxValue);     //Writes textbox value to textfile
                            Student2TestAnswer3.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner2Answer3.WriteLine(B);   //Writes the letter B to Textfile
                            learner2Answer3.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student2TestAnswer3.WriteLine(txtBoxValue); //Writes textbox value to textfile
                            Student2TestAnswer3.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner2Answer3.WriteLine(C);   //Writes the letter A to Textfile
                            learner2Answer3.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student2TestAnswer3.WriteLine(txtBoxValue); //Writes textbox value to textfile
                            Student2TestAnswer3.Close();
                        }
                    }
                    else if (user == learner3)  //If learner 3s student num is == username ONLY student 3s answers are saved 
                    {
                        if (radOptionA.Checked)
                        {
                            string A = "A";
                            learner3Answer3.WriteLine(A);
                            learner3Answer3.Close();

                            txtBoxValue = txtOptionA.Text;
                            Student3TestAnswer3.WriteLine(txtBoxValue);
                            Student3TestAnswer3.Close();
                        }
                        else if (radOptionB.Checked)
                        {
                            string B = "B";
                            learner3Answer3.WriteLine(B);
                            learner3Answer3.Close();

                            txtBoxValue = txtOptionB.Text;
                            Student3TestAnswer3.WriteLine(txtBoxValue);
                            Student3TestAnswer3.Close();
                        }
                        else if (radOptionC.Checked)
                        {
                            string C = "C";
                            learner3Answer3.WriteLine(C);
                            learner3Answer3.Close();

                            txtBoxValue = txtOptionC.Text;
                            Student3TestAnswer3.WriteLine(txtBoxValue);
                            Student3TestAnswer3.Close();
                        }
                    }
                }

                //Reads Learners radio button answer
                string stu1Answer3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer3.txt";
                string stu2Answer3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer3.txt";
                string stu3Answer3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer3.txt";

                //Reads Lecturers radio button answer
                string correctAnswer3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer3.txt";

                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string user = sr.ReadLine();

                    if (user == "13019459")
                    {
                        if (File.Exists(stu1Answer3) && File.Exists(correctAnswer3))
                        {
                            StreamReader sr1 = new StreamReader(stu1Answer3);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer3);    //Lecturers correct answer

                            string stu1Answer = sr1.ReadLine();    //Reads the Learners 3rd Answer
                            string correctA3 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q3 - if learner 2 is logged in
                            if (stu1Answer == correctA3)
                            {
                                mark = 1;
                                Q3mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q3mark.WriteLine(mark); //Writes mark to the file
                            }
                        }
                    }
                    else if (user == "15019459")
                    {
                        if (File.Exists(stu2Answer3) && File.Exists(correctAnswer3))
                        {
                            StreamReader sr1 = new StreamReader(stu2Answer3);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer3);    //Lecturers correct answer

                            string stu2Answer = sr1.ReadLine();    //Reads the Learners 3rd Answer
                            string correctA3 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q3 - if learner 2 is logged in
                            if (stu2Answer == correctA3)
                            {
                                mark = 1;
                                Q3mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q3mark.WriteLine(mark); //Writes mark to the file
                            }
                        }
                    }
                    else if (user == "16019459")
                    {
                        if (File.Exists(stu3Answer3) && File.Exists(correctAnswer3))
                        {
                            StreamReader sr1 = new StreamReader(stu3Answer3);   //Learner 1s answer
                            StreamReader sr2 = new StreamReader(correctAnswer3);    //Lecturers correct answer

                            string stu3Answer = sr1.ReadLine();    //Reads the Learners 3rd Answer
                            string correctA3 = sr2.ReadLine();   //Reads the Correct Answer(Letter) from the Lecturer

                            int mark;

                            //Marking Q3 - if learner 3 is logged in
                            if (stu3Answer == correctA3)
                            {
                                mark = 1;
                                Q3mark.WriteLine(mark); //Writes mark to the file
                            }
                            else
                            {
                                mark = 0;
                                Q3mark.WriteLine(mark); //Writes mark to the file
                            }
                        }

                    }
                    try
                    {
                        Q3mark.Close(); //Closes the Q3 Mark file
                    }
                    catch
                    {
                        MessageBox.Show("File didnt Close!");
                    }

                    
                    //Read marks for Q1,2 & 3 for Learner1
                    string stu1MarkQ1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\StuMarks1.txt";
                    string stu1MarkQ2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\StuMarks2.txt";
                    string stu1MarkQ3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\13019459\StuMarks3.txt";

                    //Read marks for Q1,2 & 3 for Learner2
                    string stu2MarkQ1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\StuMarks1.txt";
                    string stu2MarkQ2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\StuMarks2.txt";
                    string stu2MarkQ3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\15019459\StuMarks3.txt";

                    //Read marks for Q1,2 & 3 for Learner3
                    string stu3MarkQ1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\StuMarks1.txt";
                    string stu3MarkQ2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\StuMarks2.txt";
                    string stu3MarkQ3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Marks\16019459\StuMarks3.txt";
                    

                    //Reads marks, converts them from string to int then adds them ALL up into 1 sum 
                    if(File.Exists(username))
                    {
                        StreamReader sr1 = new StreamReader(username);
                        string userLogin = sr1.ReadLine();

                        if (userLogin == "13019459")
                        {
                            if (File.Exists(stu1MarkQ1) && File.Exists(stu1MarkQ2) && File.Exists(stu1MarkQ3))
                            {
                                StreamReader Q1 = new StreamReader(stu1MarkQ1);
                                StreamReader Q2 = new StreamReader(stu1MarkQ2);
                                StreamReader Q3 = new StreamReader(stu1MarkQ3);

                                string mark1 = Q1.ReadLine();
                                string mark2 = Q2.ReadLine();
                                string mark3 = Q3.ReadLine();

                                int m1 = Convert.ToInt32(mark1);    //Converts from string to int
                                int m2 = Convert.ToInt32(mark2);     //Converts from string to int
                                int m3 = Convert.ToInt32(mark3);     //Converts from string to int

                                int total = m1 + m2 + m3;   //Sum of all the 3 questions marks

                                //Writes the total marks to "final mark" textfile, which will be displayed in the "View Marks" form
                                allMarks.WriteLine(total);

                            }
                        }
                        else if (userLogin == "15019459")
                        {
                            if (File.Exists(stu2MarkQ1) && File.Exists(stu2MarkQ2) && File.Exists(stu2MarkQ3))
                            {
                                StreamReader Q1 = new StreamReader(stu2MarkQ1);
                                StreamReader Q2 = new StreamReader(stu2MarkQ2);
                                StreamReader Q3 = new StreamReader(stu2MarkQ3);

                                string mark1 = Q1.ReadLine();
                                string mark2 = Q2.ReadLine();
                                string mark3 = Q3.ReadLine();

                                int m1 = Convert.ToInt32(mark1);
                                int m2 = Convert.ToInt32(mark2);
                                int m3 = Convert.ToInt32(mark3);

                                int total = m1 + m2 + m3;
                                //Writes the total marks to "final mark" textfile
                                allMarks.WriteLine(total);
                            }
                        }
                        else if (userLogin == "16019459")
                        {
                            if (File.Exists(stu3MarkQ1) && File.Exists(stu3MarkQ2) && File.Exists(stu3MarkQ3))
                            {
                                StreamReader Q1 = new StreamReader(stu3MarkQ1);
                                StreamReader Q2 = new StreamReader(stu3MarkQ2);
                                StreamReader Q3 = new StreamReader(stu3MarkQ3);

                                string mark1 = Q1.ReadLine();
                                string mark2 = Q2.ReadLine();
                                string mark3 = Q3.ReadLine();

                                int m1 = Convert.ToInt32(mark1);
                                int m2 = Convert.ToInt32(mark2);
                                int m3 = Convert.ToInt32(mark3);

                                int total = m1 + m2 + m3;
                                //Writes the total marks to "final mark" textfile
                                allMarks.WriteLine(total);
                            }
                        }

                        try
                        {
                            allMarks.Close();
                        }
                        catch
                        {
                            MessageBox.Show("File did not CLose!");
                        }

                        Message message = new Message("testMessage");


                        //Opens the current users student portal after tests 
                        if(username == "13019459")
                        {
                            StudentPortal1 portal1 = new StudentPortal1();
                            portal1.ShowDialog();
                            
                        }
                        else if(username == "15019459")
                        {
                            StudentPortal2 portal2 = new StudentPortal2();
                            portal2.ShowDialog();
                        }
                        else if (username == "16019459")
                        {
                            StudentPortal3 portal3 = new StudentPortal3();
                            portal3.ShowDialog();
                        }
                    }
                }
            }
        }
        private void radOptionA_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
