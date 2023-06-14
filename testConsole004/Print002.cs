using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole004
{
    public static class Print002  //클래스의 접근 수준이 public
    {
        private static string message = default;

        public static void PrintMessage(string localMessage)           //접근수준도 public
        {
            message = localMessage;
            Console.WriteLine("이런걸 출력할 것 -> {0}" , message);
        } //PrintMessage()
    }
}
