using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Level3Support : AbstractHandler
    {
        public override void Handle(int request)
        {
            if (request > 50 && request <= 100)
            {
                Console.WriteLine($"Level 3 Support handled request: {request}");
            }
            else
            {
                base.Handle(request);
            }
        }
    }
}

