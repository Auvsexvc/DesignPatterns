using System;

namespace Intro
{
    public class EmailSender
    {
        private void ConnectToSmtpServer()
        {
            Console.WriteLine("Connecting to smtp server");
        }

        private void InsertCredentials()
        {
            Console.WriteLine("Inserting credentials");
        }

        public void SendEmail(string to, string title, string content)
        {
            ConnectToSmtpServer();
            InsertCredentials();
            Console.WriteLine($"Sending email to : {to}, {title} {content}");
            Disconnect();
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting form smtp server");
        }
    }
}