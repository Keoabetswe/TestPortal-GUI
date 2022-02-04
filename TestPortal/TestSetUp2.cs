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
    public partial class TestSetUp2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private StreamWriter lecQuestion2;
        private StreamWriter correctAnswer2;
        private StreamWriter FullAnswer2;

        public TestSetUp2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\TestPortalDatabase.accdb; 
                                                        Persist Security Info = False;";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Question2 set Q2 = '" + txtQuestion2.Text + "', optionA = '" + txtOptionA.Text + "', optionB = '" + txtOptionB.Text + "', optionC ='" + txtOptionC.Text + "', correctAnswer2 = '" + txtLecAnswer2.Text + "' where ID = " + 1 + "";
                command.CommandText = query;
                MessageBox.Show(query);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved!");
                connection.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error " + exc.Message);
            }
            

            TestSetUp3 test3 = new TestSetUp3(); //Opens Q3
            test3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TestSetUp2_Load(object  sender, EventArgs e)
        {
            //Path to save Test Question2
            try
            {
                lecQuestion2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ2.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            //Lecturer Correct LETTER Answer2 Path
            try
            {
                correctAnswer2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer2.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            //lecturer Correct Full Answer1
            try
            {
                FullAnswer2 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Correct Full Answer\correctFullAnswer2.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lecturer sets up question 2 for the Test \nThen concludes by pressing the Submit Button.");
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            txtLecAnswer2.CharacterCasing = CharacterCasing.Upper; //Converts lower case input to Upper Case
        }
    }
}
