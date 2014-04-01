using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntoToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> test = new List<string>();
            int input;

            if (int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine();
                while (input != 0) 
                {                    
                    test.Add((input % 2) == 0 ? "0" : "1");
                    input >>= 1;
                }

                test.Reverse();
                test.ForEach(c => Console.Write(c));
            }
        }
    }
}
