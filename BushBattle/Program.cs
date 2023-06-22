using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushBattle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Map map1 = new Map();
            Console.CursorVisible = false;
            map1.map();
        }
    }
}
