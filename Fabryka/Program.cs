using System;
using System.Collections.Generic;
using System.Linq;

namespace Fabryka
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, ShapeType> dict_of_shapes = new Dictionary<int, ShapeType>();

            dict_of_shapes = Enum.GetValues(typeof(ShapeType))
                                 .Cast<ShapeType>()
                                 .ToDictionary(t=>(int)t);

            foreach (var shape in dict_of_shapes)
            {
                //var dKey = dict_of_shapes.FirstOrDefault(x => x.Value.ToString() == shape.ToString()).Key;
                Console.WriteLine($"{shape.Key+1} - {shape.Value}");
            }
            ConsoleKeyInfo selectedShape = Console.ReadKey();
            Console.Clear();


            foreach (var shape in dict_of_shapes)
            {
                int dKey = (shape.Key + 1);

                if (dKey.ToString() == selectedShape.KeyChar.ToString())
                {
                    var shapeFactory = new ShapeFactory();
                    var shapeToRender = shapeFactory.CreateShape(shape.Value);
                    shapeToRender.Render();
                }
            }

            
            
            //var shapeFactory = new ShapeFactory();

            //var circle = shapeFactory.CreateShape(ShapeType.Circle);

            //circle.Render();

            //var triangle = shapeFactory.CreateShape(ShapeType.Triangle);

            //triangle.Render();

        }
    }
}
