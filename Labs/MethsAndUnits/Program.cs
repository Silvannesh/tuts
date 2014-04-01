using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethsAndUnits
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( FindDelim( 5, 3 ) );
            Console.ReadKey();

        }

        public static int FindDelim( int a, int b )
        {
            int _dFirst, _dSecond;
            int _result;

            if ( a > b ) { Console.WriteLine( "A>B" ); _dFirst = a; _dSecond = b; }
            else { Console.WriteLine( "B>A" ); _dFirst = b; _dSecond = a; }

            _result = _dFirst % _dSecond;
            
            while ( _result >= 1 || _result > 0 )
            {
                _dFirst = _dSecond; _dSecond = _result;
                _result = _dFirst % _dSecond;
            }
            return _dSecond;
        }
    }
}
