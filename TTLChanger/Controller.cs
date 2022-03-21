using PcTTLChanger.IPvChangerResources;
using PcTTLChanger.IPvChangerResources.interfaces;

namespace PcTTLChanger
{
    public class Controller : BaseController
    {
        public Controller(ITTLChangerView view, IIPvOperator iPvOperator)
        {
            View = view;
            IPvOperator = iPvOperator;
        }
        public override void ChangeTTL()
        {
            IPvOperator.IPv = View.IPvItem.IPv;
            IPvOperator.ChangeTTL(View.TTL);
        }
        public override void ShowTTLStats()
        {
            View.ShowCurrentTTLStats(IPvOperator.GetTTLStats());
        }
    }
}
