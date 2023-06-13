using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole002
{
    public class SecretCodeGame
    {

        public void ComputerCode()
        {

            Random random = new Random();
            char code;
            char userChoice = default;
            int round = 0;

            code = (char)random.Next(65, 90);

            while (true)
            {
                Console.Write("대문자영어를 입력하세요 : ");
                userChoice = Console.ReadLine()[0];


                userChoice = Convert.ToChar(userChoice);

                if (userChoice < code)
                {
                    Console.WriteLine("입력값보다 높습니다 현재 라운드는 {0}", round++);
                    continue;

                }
                else if (userChoice > code)
                {
                    Console.WriteLine("입력값보다 낮습니다현재 라운드는 {0}", round++);
                    continue;

                }
                else if (userChoice == code)
                {
                    Console.Write("정답입니다.");
                    break;
                }
                break;


            }
        }

    }
}
