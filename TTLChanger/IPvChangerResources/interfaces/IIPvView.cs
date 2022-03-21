namespace PcTTLChanger.IPvChangerResources.interfaces
{
    public interface IIPvView
    {
        short TTL { get; }
        IIPvItem IPvItem { get; }
    }
}
