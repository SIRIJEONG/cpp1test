using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0619tsetconsole
{
    public partial class Child : Parent
    {

        public  void PrintAnotherYhings()
        {

            Console.WriteLine("파일을 2개로 나누었다."+ "정말로 Child클래스에서 이 함수를 call 할수 있을까?" );
        }
    }
}
