using System;

namespace DesignPatterns.Observer
{
    public class Client
    {
        public static void Demo()
        {
            Console.WriteLine("=== Observer Pattern Demo ===");

            var newsAgency = new NewsAgency();
            var cnn = new NewsChannel("CNN");
            var bbc = new NewsChannel("BBC");
            var fox = new NewsChannel("Fox News");

            newsAgency.Attach(cnn);
            newsAgency.Attach(bbc);
            newsAgency.Attach(fox);

            newsAgency.PublishNews("Breaking: New technology breakthrough!");
            Console.WriteLine();

            newsAgency.Detach(fox);
            newsAgency.PublishNews("Update: Fox News unsubscribed from updates");
        }
    }
}

