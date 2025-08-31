using System;

namespace DesignPatterns.Singleton
{
    public class Database
    {
        private static Database _instance;
        private static readonly object _lock = new object();

        private Database() { }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Database();
                    }
                }
            }
            return _instance;
        }

        public void Connect()
        {
            Console.WriteLine("Connected to database");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from database");
        }
    }
}
