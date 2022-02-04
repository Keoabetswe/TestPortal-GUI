using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //To use form functions such as MessageBox

namespace TestPortal
{
    class Message
    {
        string testMessage;
        public Message(string msg)
        {
            testMessage = msg;
            MessageBox.Show("You've completed the Test!"); //This message is inherited and displayed on the form

        }
    }
    class helpMessage
    {
        string helpMsg;

        public helpMessage()
        {
        }

        public helpMessage(string msg)
        {
            helpMsg = msg;
            MessageBox.Show("Login Instructions \nPlease Enter one of the following student number: \n"
                            + "13019459 \n16019459 \n15019459 \nAnd Enter the following password:"
                            + "\n'Password1'");     //This message is inherited and displayed on the form

        }
    }
}
