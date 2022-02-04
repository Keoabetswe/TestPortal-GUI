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
    public partial class ViewMemo : Form
    {
        public ViewMemo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
        }

        private void ViewMemo_Load(object sender, EventArgs e)
        {
            //Reads QUESTIONS from the Textfile in order to display them in the memorandum  
            string Q1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ1.txt";
            string Q2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ2.txt";
            string Q3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ3.txt";

            try
            {
                if (File.Exists(Q1) && File.Exists(Q2) && File.Exists(Q3))
                {
                    StreamReader sr1 = new StreamReader(Q1);
                    StreamReader sr2 = new StreamReader(Q2);
                    StreamReader sr3 = new StreamReader(Q3);

                    txtQuestion1.Text = sr1.ReadLine();       //Memo Q1
                    txtQuestion2.Text = sr2.ReadLine();      //Memo Q2
                    txtQuestion3.Text = sr3.ReadLine();      //Memo Q3
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

            

            //Reads Lecturers CORRECT Option Selection
            string path1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer1.txt";
            string path2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer2.txt";
            string path3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer3.txt";

            try
            {
                if (File.Exists(path1) && File.Exists(path2) && File.Exists(path3))
                {
                    //FileStream fileStream = File.OpenRead(path1);
                    //TextReader textReader = File.OpenText(path2);
                    StreamReader sr1 = new StreamReader(path1);
                    StreamReader sr2 = new StreamReader(path2);
                    StreamReader sr3 = new StreamReader(path3);

                    txtCorrectOption1.Text = sr1.ReadLine(); //Memo CORRECT Option1
                    txtCorrectOption2.Text = sr2.ReadLine(); //Memo CORRECT Option2
                    txtCorrectOption3.Text = sr3.ReadLine(); //Memo CORRECT Option3
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

            
            //Reads Learner 1s Options Selection
            string stu1Answer1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer1.txt";
            string stu1Answer2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer2.txt";
            string stu1Answer3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner1\Stu1Answer3.txt";
            //Reads Learner 2s Options Selection
            string stu2Answer1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer1.txt";
            string stu2Answer2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer2.txt";
            string stu2Answer3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner2\Stu2Answer3.txt";

            //Reads Learner 1s Options Selection
            string stu3Answer1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer1.txt";
            string stu3Answer2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer2.txt";
            string stu3Answer3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Learner Answers\Learner3\Stu3Answer3.txt";

            string username = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\Username Entry\username.txt";

            try
            {
                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string user = sr.ReadLine();
                    if (user == "13019459")
                    {
                        if (File.Exists(stu1Answer1) && File.Exists(stu1Answer2) && File.Exists(stu1Answer3))
                        {
                            //FileStream fileStream = File.OpenRead(path1);
                            //TextReader textReader = File.OpenText(path2);
                            StreamReader sr1 = new StreamReader(stu1Answer1);
                            StreamReader sr2 = new StreamReader(stu1Answer2);
                            StreamReader sr3 = new StreamReader(stu1Answer3);

                            txtLearnerAnswer1.Text = sr1.ReadLine(); //Memo CORRECT Option1
                            txtLearnerAnswer2.Text = sr2.ReadLine(); //Memo CORRECT Option2
                            txtLearnerAnswer3.Text = sr3.ReadLine(); //Memo CORRECT Option3
                        }
                        else
                        {
                            MessageBox.Show("Path does not Exist!");
                        }
                    }
                    else if (user == "15019459")
                    {
                        if (File.Exists(stu2Answer1) && File.Exists(stu2Answer2) && File.Exists(stu2Answer3))
                        {
                            //FileStream fileStream = File.OpenRead(path1);
                            //TextReader textReader = File.OpenText(path2);
                            StreamReader sr1 = new StreamReader(stu2Answer1);
                            StreamReader sr2 = new StreamReader(stu2Answer2);
                            StreamReader sr3 = new StreamReader(stu2Answer3);

                            txtLearnerAnswer1.Text = sr1.ReadLine(); //Memo CORRECT Option1
                            txtLearnerAnswer2.Text = sr2.ReadLine(); //Memo CORRECT Option2
                            txtLearnerAnswer3.Text = sr3.ReadLine(); //Memo CORRECT Option3
                        }
                        else
                        {
                            MessageBox.Show("Path does not Exist!");
                        }
                    }
                    else if (user == "16019459")
                    {
                        if (File.Exists(stu3Answer1) && File.Exists(stu3Answer2) && File.Exists(stu3Answer3))
                        {
                            //FileStream fileStream = File.OpenRead(path1);
                            //TextReader textReader = File.OpenText(path2);
                            StreamReader sr1 = new StreamReader(stu3Answer1);
                            StreamReader sr2 = new StreamReader(stu3Answer2);
                            StreamReader sr3 = new StreamReader(stu3Answer3);

                            txtLearnerAnswer1.Text = sr1.ReadLine();
                            txtLearnerAnswer2.Text = sr2.ReadLine();
                            txtLearnerAnswer3.Text = sr3.ReadLine();
                        }
                        else
                        {
                            MessageBox.Show("Path does not Exist!");
                        }
                    }
                }
            }
            catch(System.IO.IOException exc)
            {
                MessageBox.Show("Invalid Directoty " + exc.Message);
            }
            

            //Reads the Learner 1s WHOLE Selected option from the textfile and displays them in the memo
            string stu1Option1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner1\Stu1Answer1.txt";
            string stu1Option2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner1\Stu1Answer2.txt";
            string stu1Option3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner1\Stu1Answer3.txt";

            //Reads the Learner 2s WHOLE Selected option from the textfile and displays them in the memo
            string stu2Option1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner2\Stu2Answer1.txt";
            string stu2Option2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner2\Stu2Answer2.txt";
            string stu2Option3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner2\Stu2Answer3.txt";

            //Reads the Learner 3s  WHOLE Selected option from the textfile and displays them in the memo
            string stu3Option1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner3\Stu3Answer1.txt";
            string stu3Option2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner3\Stu3Answer2.txt";
            string stu3Option3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Learner Answer\Selected Answer for Memo\Learner3\Stu3Answer3.txt";

            try
            {
                if (File.Exists(username))
                {
                    StreamReader sr = new StreamReader(username);
                    string user = sr.ReadLine();
                    if (user == "13019459")
                    {
                        if (File.Exists(stu1Option1) && File.Exists(stu1Option2) && File.Exists(stu1Option3))
                        {
                            StreamReader sr1 = new StreamReader(stu1Option1);
                            StreamReader sr2 = new StreamReader(stu1Option2);
                            StreamReader sr3 = new StreamReader(stu1Option3);

                            txtStuAnswer1.Text = sr1.ReadLine();      //Memo Q1
                            txtStuAnswer2.Text = sr2.ReadLine();      //Memo Q2
                            txtStuAnswer3.Text = sr3.ReadLine();      //Memo Q3
                        }
                        else
                        {
                            MessageBox.Show("Path does not Exist!");
                        }
                    }
                    else if (user == "15019459")
                    {
                        if (File.Exists(stu2Option1) && File.Exists(stu2Option2) && File.Exists(stu2Option3))
                        {
                            StreamReader sr1 = new StreamReader(stu2Option1);
                            StreamReader sr2 = new StreamReader(stu2Option2);
                            StreamReader sr3 = new StreamReader(stu2Option3);

                            txtStuAnswer1.Text = sr1.ReadLine();      //Memo Q1
                            txtStuAnswer2.Text = sr2.ReadLine();      //Memo Q2
                            txtStuAnswer3.Text = sr3.ReadLine();      //Memo Q3
                        }
                        else
                        {
                            MessageBox.Show("Path does not Exist!");
                        }
                    }
                    else if (user == "16019459")
                    {
                        if (File.Exists(stu3Option1) && File.Exists(stu3Option2) && File.Exists(stu3Option3))
                        {
                            StreamReader sr1 = new StreamReader(stu3Option1);
                            StreamReader sr2 = new StreamReader(stu3Option2);
                            StreamReader sr3 = new StreamReader(stu3Option3);

                            txtStuAnswer1.Text = sr1.ReadLine();      //Memo Q1
                            txtStuAnswer2.Text = sr2.ReadLine();      //Memo Q2
                            txtStuAnswer3.Text = sr3.ReadLine();      //Memo Q3
                        }
                        else
                        {
                            MessageBox.Show("Path does not Exist!");
                        }
                    }
                }
            }
            catch(System.IO.IOException exc)
            {
                MessageBox.Show("Invalid Directory " + exc.Message);
            }
            

            //Reads the Lecturers FULL answer from the textfile and displays them in the memo
            string FullAnswer1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Correct Full Answer\correctFullAnswer1.txt";
            string FullAnswer2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Correct Full Answer\correctFullAnswer2.txt";
            string FullAnswer3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Correct Full Answer\correctFullAnswer3.txt";

            try
            {
                if (File.Exists(FullAnswer1) && File.Exists(FullAnswer2) && File.Exists(FullAnswer3))
                {
                    StreamReader sr1 = new StreamReader(FullAnswer1);
                    StreamReader sr2 = new StreamReader(FullAnswer2);
                    StreamReader sr3 = new StreamReader(FullAnswer3);

                    txtAnswer1.Text = sr1.ReadLine();      //Correct Option Display for Q1
                    txtAnswer2.Text = sr2.ReadLine();      //Correct Option Display for Q2
                    txtAnswer3.Text = sr3.ReadLine();      //Correct Option Display for Q3
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
            

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMemo view = new ViewMemo();
            this.Close();
            view.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Memorandum shows the Lecturers correct answers and the Learners answers.");
        }

        private void txtLearnerAnswer1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
