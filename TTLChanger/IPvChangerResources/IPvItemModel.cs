using PcTTLChanger.IPvChangerResources.interfaces;

namespace PcTTLChanger.IPvChangerResources
{
    public class IPvItemModel : BaseIPvItemModel 
    {
        public IPvItemModel(string name, IIPv ipvItem)
            : base(name: name, iPvItem: ipvItem)
        {

        }
    }
}
