using System.Net.NetworkInformation;

namespace PcTTLChanger.IPvChangerResources
{
    public class IPv4 : BaseIPv
    {
        public IPv4() : base(paths: @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters")
        {

        }

        public override int GetDefaultTTL()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPGlobalStatistics ipstat1 = properties.GetIPv4GlobalStatistics();
            return ipstat1.DefaultTtl;
        }
    }
}
