using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class Forest
    {
        private readonly List<Tree> _trees = new List<Tree>();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType type = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new Tree(x, y, type);
            _trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var tree in _trees)
            {
                tree.Plant();
            }
        }
    }
}
