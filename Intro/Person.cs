using System;

namespace Intro
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
            Console.WriteLine($"Hello {Name} [{Id}]");
        }
    }
}