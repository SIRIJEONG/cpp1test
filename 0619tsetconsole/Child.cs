using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0619tsetconsole
{
    public partial class Child : Parent
    {
        string strChild = default;

        public override void PrintFos()
        {
            //base.PrintFos();   // 부모의 virtual funs를 찾아간다. 

            number = 10;
            strValue = "This is child";
            strChild = "Stntences of child added";

            Console.WriteLine("Parent class -> numebr : {0} , strValue : {1} , strChild : {2}", this.number, this.strValue , this.strChild);
        }
    }
}
