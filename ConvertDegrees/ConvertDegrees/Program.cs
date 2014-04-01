using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Введите градусы в цельсиях: " );
            double degrees;
            Console.WriteLine( double.TryParse( Console.ReadLine(), out degrees ) ? ( 9*degrees/5+32 ).ToString() : "Error!" );
            Console.ReadKey();
        }
    }
}
