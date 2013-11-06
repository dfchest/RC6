using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace RC6
{
    class RC6
    {
        private int w, r, l;

        public RC6()
        {
            w = 16;
            r = 20;
            l = 0;
        }

        public RC6(int _w, int _r, int _l)
        {
            w = _w;
            r = _r;
            l = _l;
        }

        public void Encription(BinaryReader inData, BinaryWriter outData)
        {
            
        }

        public void Decription(BinaryReader inData, BinaryWriter outData)
        {

        }
    }
}
