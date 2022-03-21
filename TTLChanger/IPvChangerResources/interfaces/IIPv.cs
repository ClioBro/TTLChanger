namespace PcTTLChanger.IPvChangerResources.interfaces
{
    public interface IIPv
    {
        void Open();
        void ChangeTTL(short value);
        void Close();
    }
}
