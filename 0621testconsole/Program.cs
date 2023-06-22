using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0621testconsole
{
    internal class Program
    {
        public void Main(string[] args)
        {
            //Clickable clickableObeject = new Clickable(); //abstract를 해버리면 인스턴스를 할수 없다.
            Button clickableObeject = new Button();
            clickableObeject.ClickThisObject(true);

            TestFunc001();
        }


        ///// <summary>
        ///// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다.
        ///// </summary>
        ///// <param name="descStr">이 변수는 문자열로 이루어진 설명을 받아서 저장하는 변수</param>



        /// <summary>
        /// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다.
        /// </summary>
        /// <param name="descStr">이 변수는 문자열로 이루어진 설명을 받아서 저장하는 변수</param>
        /// <returns>함수가 정상 동작했을 때 true를 리턴합니다.</returns>
        static bool DescFunc002(string descStr)
        {
            Console.WriteLine("함수콜 , 매개변수 -> {0}" , descStr);
            return true;
        }


        //함수에는 타인이 읽을 수 있도록 설명을 추가할 수 있다.
        //두가지 방법 소개 할거임 
        //1번 방법 attribute 기능을 사용한 설명 추가 
        [Obsolete("\n 이 함수는 아무런 기능이 없는 test함수 입니다.")]
        static void TestFunc001()
        {
            Console.WriteLine("함수 콜");
        }
    }
}
