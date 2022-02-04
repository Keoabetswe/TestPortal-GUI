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
    public partial class LearnerLogin : Form
    {
        private StreamWriter usernamePath;
        private OleDbConnection connection = new OleDbConnection();
        public LearnerLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\TestPortalDatabase.accdb; 
                                                        Persist Security Info = False;";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Path to Password and students usernames 
            /*string password = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Passwords\Password.txt";  //Reads path for Password which is shared by all students
            string stu1 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\13019459\Username1.txt"; //path for student number: 13019459
            string stu2 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\15019459\Username2.txt"; //path for student number: 15019459
            string stu3 = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\16019459\Username3.txt"; //path student number: 16019459*/
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select studentNum,Password from StudentDetails where Username = '" + txtStudentNum.Text + "'  and Password = '" + txtPassword.Text + "' ";

                string stuNum = txtStudentNum.Text;
                string pass = txtPassword.Text;

                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;


                while (reader.Read())
                {
                    count = count + 1;
                }

                if (stuNum == "13019459" && pass == "Password1")
                {
                    MessageBox.Show("Username and Password is correct");
                    StudentPortal1 login1 = new StudentPortal1();
                    login1.ShowDialog();
                }
                else if (stuNum == "15019459" && pass == "Password1")
                {
                    MessageBox.Show("Username and Password is correct");
                    StudentPortal2 login2 = new StudentPortal2();
                    login2.ShowDialog();
                }
                else if (stuNum == "16019459" && pass == "Password1")
                {
                    MessageBox.Show("Username and Password is correct");
                    StudentPortal3 login3 = new StudentPortal3();
                    login3.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password");
                }
                else
                {
                    MessageBox.Show("Username and Password is NOT correct");
                }

                connection.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
            
            /*try
            {
                if (File.Exists(password) && File.Exists(stu1) && File.Exists(stu2) && File.Exists(stu3))
                {
                    StreamReader pass = new StreamReader(password);
                    StreamReader sr1 = new StreamReader(stu1);
                    StreamReader sr2 = new StreamReader(stu2);
                    StreamReader sr3 = new StreamReader(stu3);

                    password = pass.ReadLine();  //Reads the password from textfile
                    stu1 = sr1.ReadLine();      //Reads student num: 13019459 from textfile
                    stu2 = sr2.ReadLine();      //Reads student num: 13019459 from textfile
                    stu3 = sr3.ReadLine();      //Reads student num: 13019459 from textfile
                }
                else
                {
                    MessageBox.Show("File Doesn't Exist!");
                }

                string userPassword;
                string StudentNum;

                userPassword = txtPassword.Text;
                StudentNum = txtStudentNum.Text;

               
                //Saves username for future use
                usernamePath.WriteLine(txtStudentNum.Text);
                txtStudentNum.Text = "";
                txtStudentNum.Focus();


               usernamePath.Close(); //Closes the Textfile that stores the entered student number for future use
             



                //Student LogIn (If-Statements)
                if (userPassword != password && StudentNum != stu1 && StudentNum != stu2 && StudentNum != stu3) //Incorect student number and Password
                {
                    MessageBox.Show("Student Number and Password are INVALID! -_- \nPlease Click 'About' for further login instructions");
                    txtPassword.Clear();
                    txtStudentNum.Clear();
                }
                else if (StudentNum != stu1 && StudentNum != stu2 & StudentNum != stu3) //Incorrect Student nUmber
                {
                    MessageBox.Show("Student Number is INVALID! -_- \nType in one of the following \n\n13019459 \n16019459 \n15019459");
                    txtStudentNum.Clear();
                }
                else if (userPassword != password)
                {
                    MessageBox.Show("Password is INVALID! -_- \nPassword is 'Password1'"); //Incorrect Password
                    txtPassword.Clear();
                }

                else if (StudentNum == stu1 && userPassword == password)    //Student Number 13019459 : Password1
                {
                    LearnerLogin login = new LearnerLogin();
                    this.Hide();
                    login.Hide();


                    StudentPortal1 sp1 = new StudentPortal1();
                    sp1.ShowDialog();
                }
                else if (StudentNum == stu2 && userPassword == password)   //Student Number 16019459 : Password1
                {
                    LearnerLogin login = new LearnerLogin();
                    this.Hide();
                    login.Hide();

                    StudentPortal2 sp2 = new StudentPortal2();
                    sp2.ShowDialog();
                }
                else if (StudentNum == stu3 && userPassword == password)  //Student Number 15019459 : Password1
                {
                    LearnerLogin login = new LearnerLogin();
                    this.Hide();
                    login.Hide();

                    StudentPortal3 sp3 = new StudentPortal3();
                    sp3.ShowDialog();
                }
            }
            catch(System.IO.IOException exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }*/
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LearnerLogin cancel = new LearnerLogin();
            this.Close();
            cancel.Close();
        }

        private void LearnerLogin_Load(object sender, EventArgs e)
        {/*
           try
            {
               usernamePath = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Student Details\Usernames\Username Entry\username.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }*/
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpMessage help = new helpMessage("help Message");
        }

        private void txtStudentNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
