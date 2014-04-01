using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2ndDayConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                sb.Append(i).Append(" ");
            }
            
            Console.WriteLine(sb.ToString());*/

            /*string a = "Test";
            var b = a.Clone();
            Console.WriteLine("ref equal: {0}, oftype: {1}\nA = {2}, B = {3}", object.ReferenceEquals(a,b), b.GetType(), a ,b);*/
            var test = Console.ReadLine();
            Console.WriteLine(test ?? "false");
            
            
        }
    }
}
