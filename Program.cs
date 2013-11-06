using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace RC6
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt16 a16 = 64;
            UInt32 a32 = 64;
            UInt64 a64 = 1;

            Console.WriteLine(a64);
            Console.WriteLine(BCS.Shift(a64, 64, 1));
            /*var FourWords = new FourWords();

            Console.WriteLine(FourWords.getA());
            Console.WriteLine(FourWords.getB());
            Console.WriteLine(FourWords.getC());
            Console.WriteLine(FourWords.getD());

            FourWords.ShiftRight();

            Console.WriteLine();

            Console.WriteLine(FourWords.getA());
            Console.WriteLine(FourWords.getB());
            Console.WriteLine(FourWords.getC());
            Console.WriteLine(FourWords.getD());


            BinaryReader inData = new BinaryReader(new FileStream("D:\\in.txt", FileMode.Open));
            BinaryWriter outData = new BinaryWriter(new FileStream("D:\\out.txt", FileMode.OpenOrCreate));

            Console.WriteLine(inData.ReadInt16());*/
        }
    }
}
