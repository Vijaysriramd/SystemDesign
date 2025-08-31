using DesignPatterns.Factory.AbstractFactory.Components.Buttons;
using DesignPatterns.Factory.AbstractFactory.Components.Dropdowns;

namespace DesignPatterns.Factory.AbstractFactory
{
    public interface IUiFactory
    {
        IButton CreateButton();
        IDropdown CreateDropdown();
        SupportedPlatform HandlePlatformType();
    }
}
