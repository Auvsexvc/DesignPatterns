using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("john@gmail.com", "test", "testowa wiadomosc");
        }
    }
}
