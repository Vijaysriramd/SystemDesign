using System;

namespace DesignPatterns.Flyweight
{
    public class TreeType
    {
        private readonly string _name;
        private readonly string _color;
        private readonly string _texture;

        public TreeType(string name, string color, string texture)
        {
            _name = name;
            _color = color;
            _texture = texture;
        }

        public void Plant(int x, int y)
        {
            Console.WriteLine($"Planting {_name} at {x}, {y}");
        }
    }
}
