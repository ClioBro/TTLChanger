using PcTTLChanger.IPvChangerResources.interfaces;

namespace PcTTLChanger.IPvChangerResources
{
    internal class BothIPv : IIPv
    {
        private IIPv[] _IPvs;

        public BothIPv()
        {
            _IPvs = new IIPv[] { new IPv4(), new IPv6() };
        }
        public void ChangeTTL(short value)
        {
            foreach (IIPv iPv in _IPvs)
                iPv.ChangeTTL(value);
        }

        public void Close()
        {
            foreach (IIPv iPv in _IPvs)
                iPv.Close();
        }
        public void Open()
        {
            foreach (IIPv iPv in _IPvs)
                iPv.Open();
        }
    }
}
