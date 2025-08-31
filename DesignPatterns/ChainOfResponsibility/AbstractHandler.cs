using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void Handle(int request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine($"No handler found for request: {request}");
            }
        }
    }
}

