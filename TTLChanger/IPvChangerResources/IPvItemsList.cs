using System.Collections.Generic;

namespace PcTTLChanger.IPvChangerResources.interfaces
{
    public class IPvItemsList : IIPvItemsList
    {
        private static List<IIPvItem> _IPvItems;
        public IPvItemsList()
        {
            _IPvItems = new List<IIPvItem>()
            {
                new IPvItemModel("Оба", new BothIPv()),
                new IPvItemModel("IPv4", new IPv4()),
                new IPvItemModel("IPv6", new IPv6())
            };
        }
        public IEnumerable<IIPvItem> IPvItems => _IPvItems;
    }
}
