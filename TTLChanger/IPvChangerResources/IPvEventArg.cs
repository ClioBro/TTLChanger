using System;

namespace PcTTLChanger.IPvChangerResources
{
    public class IPvEventArg : EventArgs
    {
        public IPvEventArg(string message, object value, params string[] paths)
        {
            Message = message;
            Path = paths;
            Value = value;
        }
        public string[] Path { get; private set; }
        public object Value { get; private set; }
        public string Message { get; private set; }
    }
}
