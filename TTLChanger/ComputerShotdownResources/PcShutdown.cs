using System.Diagnostics;

namespace ClioOFF.ComputerShotdownControl
{
    public class PcShutdown : BasePcOFFTimer
    {
        public override void StartProcess()
        {
            Process.Start($"shutdown", $"/s /t {Seconds}");
        }
    }
}
