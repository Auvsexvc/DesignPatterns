namespace Intro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("john@gmail.com", "test", "testowa wiadomosc");
        }
    }
}