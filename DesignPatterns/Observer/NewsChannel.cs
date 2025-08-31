using System;

namespace DesignPatterns.Observer
{
    public class NewsChannel : IObserver
    {
        private readonly string _name;

        public NewsChannel(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received news: {message}");
        }
    }
}

