namespace PcTTLChanger.IPvChangerResources.interfaces
{
    public interface IIPvItem
    {
        int ID { get; }
        string Name { get; }
        IIPv IPv { get; }
    }
}
