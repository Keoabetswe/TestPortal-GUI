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
    public partial class TestSetUp1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private StreamWriter lecQuestion1;
        private StreamWriter correctAnswer1;
        private StreamWriter FullAnswer1;

        public TestSetUp1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\TestPortalDatabase.accdb; 
                                                        Persist Security Info = False;";
        }
        private void TestSetUp_Load(object sender, EventArgs e)
        {
            //Lecturer Questions Path
            this.Hide();
            try
            {
                lecQuestion1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Questions\LecturerQ1.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

            //lecturer Correct LETTER Answer1 Path
            try
            {
                correctAnswer1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Letter Correct Answer\Answer1.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }
            
            //lecturer Correct Full Answer1
            try
            {
                FullAnswer1 = new StreamWriter(@"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\Lecturer Answer\Correct Full Answer\correctFullAnswer1.txt");
            }   
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid Directory" + exc.Message);
            }

        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestSetUp1 setup1 = new TestSetUp1();
            this.Close();
            setup1.Close();
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextboxClear();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lecturer sets up question 1 for the Test \nThen concludes by pressing the Submit Button.");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Question1 set Q1 = '" + txtQuestion1.Text + "', optionA = '" + txtOptionA.Text + "', optionB = '" + txtOptionB.Text + "', optionC ='" + txtOptionC.Text + "', correctAnswer1 = '" + txtLecAnswer1.Text + "' where ID = " + 1 + "";
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

            TestSetUp2 test2 = new TestSetUp2(); //Opens Q2
            test2.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextboxClear()
        {
            txtQuestion1.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtLecAnswer1.Clear();
        }

        private void TestSetUp_Click(object sender, EventArgs e)
        {

        }

        private void TestSetUp_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {
            txtLecAnswer1.CharacterCasing = CharacterCasing.Upper; //Converts lower case input to Upper Case
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
