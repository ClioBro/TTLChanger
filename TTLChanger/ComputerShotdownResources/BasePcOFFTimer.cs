using System.Diagnostics;

namespace ClioOFF.ComputerShotdownControl
{
    public abstract class BasePcOFFTimer : IPcShutdown
    {
        private ulong _seconds;
        public ulong Seconds => _seconds;
        public IPcShutdown SetTimer(ulong seconds) 
        {
            _seconds = seconds;
            return this;
        }
        public abstract void StartProcess();
    }
}
