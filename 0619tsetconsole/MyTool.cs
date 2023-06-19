using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0619tsetconsole
{
    public static class MyTool

    {
        public static void childPrint(this Child tempChild)
        {
            tempChild.PrintFos();
;        }
        public static int Plus(this int firstVlaue, int secondVaule)
        {
            return firstVlaue + secondVaule;
        }
        public static int PlusAndPrint(this int firstVlaue, int secondVaule)
        {
            Console.WriteLine("{0} + {1} + {2}", firstVlaue , secondVaule , firstVlaue + secondVaule );
            return firstVlaue + secondVaule;
        }
    }
}
