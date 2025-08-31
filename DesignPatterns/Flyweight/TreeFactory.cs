using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class TreeFactory
    {
        private static readonly Dictionary<string, TreeType> _treeTypeMap = new Dictionary<string, TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            string key = $"{name}_{color}_{texture}";

            if (!_treeTypeMap.ContainsKey(key))
            {
                _treeTypeMap[key] = new TreeType(name, color, texture);
            }
            return _treeTypeMap[key];
        }
    }
}
