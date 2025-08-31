using System;

namespace DesignPatterns.Flyweight
{
    public class Client
    {
        public static void Demo()
        {
            var forest = new Forest();

            forest.PlantTree(1, 1, "Oak", "Green", "Rough");
            forest.PlantTree(2, 2, "Oak", "Green", "Rough");
            forest.PlantTree(3, 3, "Pine", "Dark Green", "Smooth");
            forest.PlantTree(4, 4, "Oak", "Green", "Rough");

            forest.Draw();
        }
    }
}
