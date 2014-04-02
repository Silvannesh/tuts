using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            CompNumber c1 = new CompNumber(1, 1);
            CompNumber c2 = new CompNumber(1, 1);
            CompNumber result = c1.Summ(c2);
            Console.WriteLine("({0}; {1})", result.real, result.abstr);

            CompNumber c3 = new CompNumber(10, 10);
            
        }
    }
}
