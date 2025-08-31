using System;

namespace DesignPatterns.Bridge
{
    public class Client
    {
        public static void Demo()
        {
            Console.WriteLine("=== Bridge Pattern Demo ===");

            // Create devices
            var tv = new Tv();
            var radio = new Radio();

            // Create basic remote controls
            var tvRemote = new RemoteControl(tv);
            var radioRemote = new RemoteControl(radio);

            Console.WriteLine("\n--- Basic Remote Control with TV ---");
            tvRemote.TogglePower();
            tvRemote.VolumeUp();
            tvRemote.ChannelUp();
            tvRemote.PrintStatus();

            Console.WriteLine("\n--- Basic Remote Control with Radio ---");
            radioRemote.TogglePower();
            radioRemote.VolumeDown();
            radioRemote.ChannelDown();
            radioRemote.PrintStatus();

            // Create advanced remote controls
            var advancedTvRemote = new AdvancedRemoteControl(tv);
            var advancedRadioRemote = new AdvancedRemoteControl(radio);

            Console.WriteLine("\n--- Advanced Remote Control with TV ---");
            advancedTvRemote.SetVolume(50);
            advancedTvRemote.SetChannel(5);
            advancedTvRemote.Mute();
            advancedTvRemote.PrintStatus();

            Console.WriteLine("\n--- Advanced Remote Control with Radio ---");
            advancedRadioRemote.SetVolume(75);
            advancedRadioRemote.SetChannel(10);
            advancedRadioRemote.PrintStatus();

            Console.WriteLine("\nBridge Pattern demonstrates:");
            Console.WriteLine("- Abstraction (RemoteControl) is separated from Implementation (Device)");
            Console.WriteLine("- Both can vary independently");
            Console.WriteLine("- New devices can be added without changing remote controls");
            Console.WriteLine("- New remote types can be added without changing devices");
        }
    }
}

