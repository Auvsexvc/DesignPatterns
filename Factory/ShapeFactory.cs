using System;

namespace Factory
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();

                case ShapeType.Rectangle:
                    return new Rectangle();

                case ShapeType.Triangle:
                    return new Triangle();

                case ShapeType.Oval:
                    return new Oval();

                default:
                    throw new Exception($"Shape typ {type} not handled");
            }
        }
    }
}