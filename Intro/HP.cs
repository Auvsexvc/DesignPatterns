using System;

namespace Intro
{
    public class HP : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine($"HP printing {content}");
        }
    }
}