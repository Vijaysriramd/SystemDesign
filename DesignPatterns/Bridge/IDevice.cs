using System;

namespace DesignPatterns.Bridge
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int channel);
        void PrintStatus();
    }
}

