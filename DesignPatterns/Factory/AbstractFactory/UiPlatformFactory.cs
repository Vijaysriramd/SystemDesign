using System;

namespace DesignPatterns.Factory.AbstractFactory
{
    public class UiPlatformFactory
    {
        public static IUiFactory GetUiFactory(SupportedPlatform platform)
        {
            return platform switch
            {
                SupportedPlatform.Android => new AndroidUiFactory(),
                SupportedPlatform.IOS => new IosUiFactory(),
                _ => throw new ArgumentException($"Unsupported platform: {platform}")
            };
        }
    }
}
