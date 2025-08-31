using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Level1Support : AbstractHandler
    {
        public override void Handle(int request)
        {
            if (request <= 10)
            {
                Console.WriteLine($"Level 1 Support handled request: {request}");
            }
            else
            {
                base.Handle(request);
            }
        }
    }
}

