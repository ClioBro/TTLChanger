using System.Diagnostics;

namespace ClioOFF.ComputerShotdownControl
{
    public class PcReboot : BasePcOFFTimer
    {
        public override void StartProcess()
        {
            Process.Start($"shutdown", $"/r /t {Seconds}");
        }
    }
}
