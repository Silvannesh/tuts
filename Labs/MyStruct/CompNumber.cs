using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStruct
{
    public struct CompNumber
    {
        public double real;
        public double abstr;

        public CompNumber(int real, int abstr)
        {
                this.real = real;
                this.abstr = abstr;
        }
    }

    public static class CNMath
    {
        public static CompNumber Summ(this CompNumber source, CompNumber addition)
        {
            source.real += addition.real;
            source.abstr += addition.abstr;
            return source;
        }
    }
}
