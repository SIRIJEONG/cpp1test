using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0621testconsole
{
    public class Button : IClickable
    {

        public void ClickThisObject(bool isClick)
        {
            //이제 에러가 없다.
        }
        public void TestFunc()
        {
            Console.WriteLine("함수 테스트");
        }
    }
}
