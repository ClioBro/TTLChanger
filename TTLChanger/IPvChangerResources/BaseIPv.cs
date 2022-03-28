using Microsoft.Win32;
using System;
using PcTTLChanger.IPvChangerResources.interfaces;

namespace PcTTLChanger.IPvChangerResources
{
    public abstract class BaseIPv : IIPv
    {
        private const string DefaultTTL = "DefaultTTL";
        private const short MaxTTL = 255;
        private const short MinTTL = 0;
        private protected readonly string _paths;
        private protected RegistryKey _currentKey;
        
        public BaseIPv(string paths)
        {
            _paths = paths;
        }
        public void ChangeTTL(short ttlValue)
        {
            if (ValidTTL(ttlValue) is false)
            {
                throw new IPvTTLValueException("TTLValue is not valid. Min and Max value = 1 - 255.", ttlValue);
            }
            _currentKey?.SetValue(DefaultTTL, Convert.ToInt32(ttlValue));
        }
        public void Close() => _currentKey?.Close();
        public void Open()
        {
            RegistryKey machine = Registry.LocalMachine;
            _currentKey = machine.OpenSubKey(_paths, true);
        }
        public abstract int GetDefaultTTL();
        private bool ValidTTL(short ttlValue) => ttlValue > MinTTL && ttlValue <= MaxTTL;
    }
}
