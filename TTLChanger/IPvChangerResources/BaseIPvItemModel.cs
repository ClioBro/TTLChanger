using PcTTLChanger.IPvChangerResources.interfaces;

namespace PcTTLChanger.IPvChangerResources
{
    public abstract class BaseIPvItemModel : IIPvItem
    {
        private static int _gobalId;
        private int _id;
        private string _name;
        private IIPv _ipvItem;
        public BaseIPvItemModel(string name, IIPv iPvItem)
        {
            _id = _gobalId++;
            _name = name;
            _ipvItem = iPvItem;
        }
        public int ID => _id;
        public string Name => _name;
        public IIPv IPv => _ipvItem;
    }
}
