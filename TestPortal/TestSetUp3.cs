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
    public partial class TestSetUp3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private StreamWriter lecQuestion3;
        private StreamWriter correctAnswer3;
        private StreamWriter FullAnswer3;
        
        public TestSetUp3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\TestPortalDatabase.accdb; 
                                                        Persist Security Info = False;";
        }

        private void TestSetUp3_Load(object sender, EventArgs e)
        {
            try
            {
                lecQuestion3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ3.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            //lecturer Correct LETTER Answer3 Path
            try
            {
                correctAnswer3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer3.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            //lecturer Correct Full Answer1
            try
            {
                FullAnswer3 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Correct Full Answer\correctFullAnswer3.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Question3 set Q3 = '" + txtQuestion3.Text + "', optionA = '" + txtOptionA.Text + "', optionB = '" + txtOptionB.Text + "', optionC ='" + txtOptionC.Text + "', correctAnswer3 = '" + txtLecAnswer3.Text + "' where ID = " + 1 + "";
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
              
            MessageBox.Show("Your Test has been saved to the DATABASE! \nLearners can now access it.");
            
    }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lecturer sets up question 3 for the Test \nThen concludes by pressing the Submit Button.");
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {
            txtLecAnswer3.CharacterCasing = CharacterCasing.Upper;  //Converts lower case input to Upper Case
        }
    }
}
