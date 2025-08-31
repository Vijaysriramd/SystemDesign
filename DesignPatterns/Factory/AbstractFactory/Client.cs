using System;

namespace DesignPatterns.Factory.AbstractFactory
{
    public class Client
    {
        public static void Demo()
        {
            var androidFactory = UiPlatformFactory.GetUiFactory(SupportedPlatform.Android);
            var androidButton = androidFactory.CreateButton();
            var androidDropdown = androidFactory.CreateDropdown();

            androidButton.Paint();
            androidDropdown.Paint();

            var iosFactory = UiPlatformFactory.GetUiFactory(SupportedPlatform.IOS);
            var iosButton = iosFactory.CreateButton();
            var iosDropdown = iosFactory.CreateDropdown();

            iosButton.Paint();
            iosDropdown.Paint();
        }
    }
}
