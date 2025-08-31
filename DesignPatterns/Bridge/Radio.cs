using System;

namespace DesignPatterns.Bridge
{
    public class Radio : IDevice
    {
        private bool _enabled = false;
        private int _volume = 30;
        private int _channel = 1;

        public bool IsEnabled()
        {
            return _enabled;
        }

        public void Enable()
        {
            _enabled = true;
            Console.WriteLine("Radio is now enabled");
        }

        public void Disable()
        {
            _enabled = false;
            Console.WriteLine("Radio is now disabled");
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int volume)
        {
            if (volume > 100) volume = 100;
            if (volume < 0) volume = 0;
            _volume = volume;
            Console.WriteLine($"Radio volume set to {_volume}");
        }

        public int GetChannel()
        {
            return _channel;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
            Console.WriteLine($"Radio channel set to {_channel}");
        }

        public void PrintStatus()
        {
            Console.WriteLine($"Radio - Enabled: {_enabled}, Volume: {_volume}, Channel: {_channel}");
        }
    }
}

