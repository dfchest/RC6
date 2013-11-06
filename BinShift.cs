using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RC6
{
    class BCS
    {
        public static UInt64 Shift(UInt64 number, int w, int shift)
        {
            if (shift == 0)
                return number;

            int sh = shift;

            if (shift < 0)
            {
                sh = -sh;
                switch (w)
                {
                    case 16 :
                        {
                            sh %= 16;
                            UInt16 num = (UInt16)number;
                            return (UInt64)(UInt16)(num << sh | ((num >> (16 - sh)) & ((1 << sh) - 1)));
                        }

                    case 32 :
                        {
                            sh %= 32;
                            UInt32 num = (UInt32)number;
                            return (UInt64)(UInt32)(num << sh | ((num >> (32 - sh)) & ((1 << sh) - 1)));
                        }

                    case 64 : default :
                        {
                            sh %= 64;
                            return (number << sh | ((number >> (64 - sh)) & (UInt64)((1 << sh) - 1)));
                        }
                }
            }
            else
            {
                switch (w)
                {
                    case 16 :
                        {
                            sh %= 16;
                            UInt16 num = (UInt16)number;
                            return (UInt64)(UInt16)(num >> sh | ((num << (16 - sh)) & ((1 >> sh) - 1)));
                        }

                    case 32 :
                        {
                            sh %= 32;
                            UInt32 num = (UInt32)number;
                            return (UInt64)(UInt32)(num >> sh | ((num << (32 - sh)) & ((1 >> sh) - 1)));
                        }

                    case 64 : default :
                        {
                            sh %= 64;
                            return (number >> sh | ((number << (64 - sh)) & (UInt64)((1 >> sh) - 1)));
                        }
                }
            }

        }
    }
}
