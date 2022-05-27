using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class HP : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine($"HP printing {content}");
        }
    }
}
