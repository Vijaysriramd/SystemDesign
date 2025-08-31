using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Level2Support : AbstractHandler
    {
        public override void Handle(int request)
        {
            if (request > 10 && request <= 50)
            {
                Console.WriteLine($"Level 2 Support handled request: {request}");
            }
            else
            {
                base.Handle(request);
            }
        }
    }
}

