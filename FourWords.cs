using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RC6
{
    class FourWords
    {
        private List<UInt64> words;

        public FourWords()
        {
            words = new List<UInt64>();

            words.Add(1);
            words.Add(2);
            words.Add(3);
            words.Add(4);
        }

        public UInt64 getA() { return words[0]; }
        public UInt64 getB() { return words[1]; }
        public UInt64 getC() { return words[2]; }
        public UInt64 getD() { return words[3]; }

        public void setA(UInt64 _a) { words[0] = _a; }
        public void setB(UInt64 _b) { words[1] = _b; }
        public void setC(UInt64 _c) { words[2] = _c; }
        public void setD(UInt64 _d) { words[3] = _d; }

        public void ShiftLeft()
        {
            words.Insert(words.Count(), words[0]);
            words.RemoveRange(0, 1);
        }

        public void ShiftRight()
        {
            words.Insert(0, words[words.Count()-1]);
            words.RemoveRange(words.Count()-1, 1);
        }
    }
}
