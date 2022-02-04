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
    public partial class LecturerLogin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public LecturerLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  //Runs the form in the middle of the screen
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\POE\Application\TestPortal\TestPortalDatabase.accdb; 
                                                        Persist Security Info = False;";
        }

        private void InputPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string password = @"C:\Users\KeoNt\Documents\V.C\Year 2\PROG\Assignments\13019459 - POE\Assignment 3\Application\TestPortal\Lecturer Details\Password.txt";

            try
            {
                if (File.Exists(password))
                {
                    StreamReader pass = new StreamReader(password);
                    password = pass.ReadLine();  //Reads the password from textfile
                }
                else
                {
                    MessageBox.Show("File Doesn't Exist!");
                }

                string entry;
                entry = txtPassword.Text;

                if (entry != password)
                {
                    MessageBox.Show("Password is INVALID! -_- \nPassword is 'Password1'");
                    txtPassword.Clear();
                }
                else
                {
                    LecturerOptions lec = new LecturerOptions();
                    lec.ShowDialog();
                    this.Hide();
                }
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LecturerLogin cancel = new LecturerLogin();
            this.Close();
            cancel.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Lecturer Login Password is \n'Password1'");
        }
    }
}
