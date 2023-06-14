using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole004
{
    internal class Print001  //클래스의 접근 수준이 public
    {

        public static string staticMessage = default;


        private string message = "인스턴스 필드에 미리 넣어둔 값";

        public void PrintMessage(string localMessage)           //접근수준도 public
        {
            message = localMessage;
            Console.WriteLine("이런걸 출력할 것 -> {0}" , message);
        } //PrintMessage()

        public static void PrintMessage()
        {
            //Print002.PrintMessage("Print002를 더 늦게 만들었는데 이게 왜 됨?");
            //Console.WriteLine("static 메서드에서 인스턴스 필드를 찍어볼 수 있을까? -> {0}" , message); // 안댄다 
        }
    }
}
