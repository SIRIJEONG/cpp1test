using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0619tsetconsole
{
    public class Parent
    {
        protected int number = default;
        protected string strValue = default;

        public virtual void PrintFos()
        {
            strValue = "This is child";
            Console.WriteLine("Parent class -> numebr : {0} , strValue : {1}", number , strValue);
        }
    }
}
