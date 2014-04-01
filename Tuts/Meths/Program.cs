using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meths
{
    class Program
    {
        static void Main(string[] args)
        {
#region For REF

            int a;
            ChangeByRef(ref a);

#endregion  
            
#region For OUT

            int b; //не инициализирована
            ChangeByOut(out b); //теперь инициализирована. Удобно, если неизвестно по условию, нужна ли она (напр.: по условию if).
            /*
             If(a>20)
                ChangeByOut(out b);
             
             Если а меньше 20, то b не инициализируется и не займет место*/

#endregion  
        }

        //ref
        static void ChangeByRef(ref int param)
        {
            param++;
        }

        //out
        static void ChangeByOut(out int b)
        {
                b = 10;
        }

    }
}
