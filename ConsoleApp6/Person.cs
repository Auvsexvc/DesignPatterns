using System;

namespace ConsoleApp6
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Person(string name, int Id)
        {
            Name = name;
            this.Id = Id;
        }
        public void SayHi()
        {
            Console.WriteLine($"Hello {this.Name} [{this.Id}]");
        }

    }
}
