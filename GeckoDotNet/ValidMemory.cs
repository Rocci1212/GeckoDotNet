using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeckoDotNet
{
    public static class ValidMemory
    {
        public static bool addressDebug = false;

        public static readonly AddressRange[] ValidAreas = new AddressRange[7] {
             new AddressRange(AddressType.UncachedMem1,0x80000000,0x81800000),
             new AddressRange(AddressType.UncachedMem2,0x90000000,0x93400000),
             new AddressRange(AddressType.CachedMem1,  0xC0000000,0xC1800000),
             new AddressRange(AddressType.CachedMem2,  0xD0000000,0xD3400000),
             new AddressRange(AddressType.EFBBuffer,   0xC8000000,0xCC000000),
             new AddressRange(AddressType.XFBBuffer,   0xCC000000,0xCC008000),
             new AddressRange(AddressType.HardwareRegs,0xCD000000,0xCD008000),
        };

        public static AddressType rangeCheck(UInt32 address)
        {
            int id = rangeCheckId(address);
            if (id == -1)
                return AddressType.Unknown;
            else
                return ValidAreas[id].description;
        }

        public static int rangeCheckId(UInt32 address)
        {
            for (int i = 0; i < ValidAreas.Length; i++)
            {
                AddressRange range = ValidAreas[i];
                if (address >= range.low && address < range.high)
                    return i;
            }
            return -1;
        }

        public static bool validAddress(UInt32 address, bool debug)
        {
            if (debug)
                return true;
            return (rangeCheckId(address) >= 0);
        }

        public static bool validAddress(UInt32 address)
        {
            return validAddress(address, addressDebug);
        }

        public static bool validRange(UInt32 low, UInt32 high, bool debug)
        {
            if (debug)
                return true;
            return (rangeCheckId(low) == rangeCheckId(high - 1));
        }

        public static bool validRange(UInt32 low, UInt32 high)
        {
            return validRange(low, high, addressDebug);
        }

        public static void setMEM2Upper(UInt32 upper)
        {
            ValidAreas[1] = new AddressRange(AddressType.UncachedMem2, 0x90000000, upper);
        }
    }
}
