using System.Collections.Generic;

namespace PcTTLChanger.IPvChangerResources.interfaces
{
    public interface IIPvItemsList
    {
        IEnumerable<IIPvItem> IPvItems { get; }
    }
}
