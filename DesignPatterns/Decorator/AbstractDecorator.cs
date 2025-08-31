namespace DesignPatterns.Decorator
{
    public abstract class AbstractDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;

        protected AbstractDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }
    }
}
