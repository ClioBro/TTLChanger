using System.Net.NetworkInformation;
using PcTTLChanger.IPvChangerResources.interfaces;

namespace PcTTLChanger
{
    public partial class IPvOperator : IIPvOperator
    {
        public IIPv IPv { get; set; }

        public void ChangeTTL(short valueTTL)
        {
            IPv.Open();
            IPv.ChangeTTL(valueTTL);
            IPv.Close();
        }

        public string GetTTLStats()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPGlobalStatistics ipv4stat = properties.GetIPv4GlobalStatistics();
            IPGlobalStatistics ipv6stat = properties.GetIPv6GlobalStatistics();
            return $"IPv4-TTL:{ipv4stat.DefaultTtl}\nIPv6-TTL:{ipv6stat.DefaultTtl}";
        }
    }
}
