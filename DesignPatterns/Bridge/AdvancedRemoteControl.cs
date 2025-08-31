using System;

namespace DesignPatterns.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            _device.SetVolume(0);
            Console.WriteLine("Device muted");
        }

        public void SetVolume(int volume)
        {
            _device.SetVolume(volume);
        }

        public void SetChannel(int channel)
        {
            _device.SetChannel(channel);
        }
    }
}

