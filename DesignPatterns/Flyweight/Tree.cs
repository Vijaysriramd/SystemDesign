namespace DesignPatterns.Flyweight
{
    public class Tree
    {
        private readonly int _x;
        private readonly int _y;
        private readonly TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public void Plant()
        {
            _type.Plant(_x, _y);
        }
    }
}
