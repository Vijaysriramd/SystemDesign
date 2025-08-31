using System;

namespace DesignPatterns.Singleton
{
    public class Client
    {
        public static void Demo()
        {
            var db1 = Database.GetInstance();
            var db2 = Database.GetInstance();

            Console.WriteLine($"Are instances the same? {ReferenceEquals(db1, db2)}");

            db1.Connect();
            db2.Disconnect();
        }
    }
}
