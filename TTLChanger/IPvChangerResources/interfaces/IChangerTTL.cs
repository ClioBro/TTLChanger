namespace PcTTLChanger.IPvChangerResources.interfaces
{
    public interface IChangerTTL
    {
        IIPv IPv { get; set; }
        void ChangeTTL(short valueTTL);
    }
}
