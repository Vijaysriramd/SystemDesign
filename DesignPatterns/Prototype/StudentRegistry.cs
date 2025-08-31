using System.Collections.Generic;

namespace DesignPatterns.Prototype
{
    public class StudentRegistry
    {
        private readonly Dictionary<string, Student> _registry = new Dictionary<string, Student>();

        public void Register(string key, Student student)
        {
            _registry[key] = student;
        }

        public Student Get(string key)
        {
            return _registry.ContainsKey(key) ? _registry[key].Clone() : null;
        }
    }
}
