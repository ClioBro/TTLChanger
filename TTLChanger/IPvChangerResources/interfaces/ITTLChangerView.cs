namespace PcTTLChanger.IPvChangerResources.interfaces
{
    public interface ITTLChangerView : IIPvView, ITimeView
    {
        void ShowCurrentTTLStats(string stats);
    }
}
