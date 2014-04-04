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

        public static CompNumber operator +(CompNumber a, CompNumber b)
        {
            return new CompNumber((int)a.real + (int)b.abstr, (int)a.abstr + (int)b.abstr);
        }

        public static bool operator ==(CompNumber a, CompNumber b)
        {
            return a.real == b.real && a.abstr == b.abstr;
        }

        public static bool operator !=(CompNumber a, CompNumber b)
        {
            return !(a.real == b.real && a.abstr == b.abstr);
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
    public class OpOver
    {
        

        
    }
}
