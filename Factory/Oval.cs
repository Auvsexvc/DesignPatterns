using System;

namespace Factory
{
    public class Oval : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Rendering oval");
        }
    }
}