using System.Net.NetworkInformation;

namespace PcTTLChanger.IPvChangerResources
{
    public class IPv6 : BaseIPv
    {
        public IPv6() : base(paths: @"SYSTEM\CurrentControlSet\Services\Tcpip6\Parameters")
        {

        }

        public override int GetDefaultTTL()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPGlobalStatistics ipstat1 = properties.GetIPv6GlobalStatistics();
            return ipstat1.DefaultTtl;
        }
    }
}
