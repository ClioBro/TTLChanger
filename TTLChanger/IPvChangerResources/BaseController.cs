using PcTTLChanger.IPvChangerResources.interfaces;

namespace PcTTLChanger.IPvChangerResources
{
    public abstract class BaseController
    {
        protected virtual ITTLChangerView View { get; set; }
        protected virtual IIPvOperator IPvOperator { get; set; }
        public abstract void ChangeTTL();
        public abstract void ShowTTLStats();
    }
}
