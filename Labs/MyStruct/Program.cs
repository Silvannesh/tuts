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

            CompNumber summ = c1 + c3;

            Console.WriteLine("Summ ({0}, {1})", summ.real, summ.abstr);

            Console.WriteLine("C1 {0} C2\nC1 {1} C2", 
                c1 == c2 ? "равно" : "не равно",
                c1 != c3 ? "не равно" : "равно");
            
        }
    }
}
