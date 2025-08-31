using DesignPatterns.Factory.AbstractFactory.Components.Buttons;
using DesignPatterns.Factory.AbstractFactory.Components.Dropdowns;

namespace DesignPatterns.Factory.AbstractFactory
{
    public class AndroidUiFactory : IUiFactory
    {
        public IButton CreateButton()
        {
            return new AndroidButton();
        }

        public IDropdown CreateDropdown()
        {
            return new AndroidDropdown();
        }

        public SupportedPlatform HandlePlatformType()
        {
            return SupportedPlatform.Android;
        }
    }
}
