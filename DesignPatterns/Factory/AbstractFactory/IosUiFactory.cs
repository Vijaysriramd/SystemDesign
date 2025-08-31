using DesignPatterns.Factory.AbstractFactory.Components.Buttons;
using DesignPatterns.Factory.AbstractFactory.Components.Dropdowns;

namespace DesignPatterns.Factory.AbstractFactory
{
    public class IosUiFactory : IUiFactory
    {
        public IButton CreateButton()
        {
            return new IosButton();
        }

        public IDropdown CreateDropdown()
        {
            return new IosDropdown();
        }

        public SupportedPlatform HandlePlatformType()
        {
            return SupportedPlatform.IOS;
        }
    }
}
