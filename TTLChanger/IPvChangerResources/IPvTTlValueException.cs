using System;

namespace PcTTLChanger.IPvChangerResources
{
    internal class IPvTTLValueException : ArgumentException
    {
        public short Value { get; }
        public IPvTTLValueException(string message, short value) : base(message)
        {
            Value = value;
        }
    }
}
