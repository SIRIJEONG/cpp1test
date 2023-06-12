using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace testconsole001
{
    public class CardGame

    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] lottos = new int[2];
            char[] card = new char[4];
            char[] number = new char[4];
            int[] lottos2 = new int[2];
            int[] computer = new int[2];
            int[] computer2 = new int[2];
            int userMoney = 500;





            while (true)
            {

                for (int i = 0; i < 2; i++)
                {

                    number[0] = 'A';
                    number[1] = 'J';
                    number[2] = 'Q';
                    number[3] = 'K';
                    lottos[i] = random.Next(0, 13);

                    if (lottos[i] % 13 == 1)
                    {
                        Console.Write("{0} ", number[0]);
                        continue;

                    }
                    else if (lottos[i] % 13 == 11)
                    {
                        Console.Write("{0} ", number[1]);

                        continue;

                    }
                    else if (lottos[i] % 13 == 12)
                    {
                        Console.Write("{0} ", number[2]);
                        continue;

                    }
                    else if (lottos[i] % 13 == 0)
                    {
                        Console.Write("{0} ", number[3]);
                        continue;

                    }
                    else
                    {

                        Console.Write("{0} ", lottos[i]);
                        continue;
                    }

                    break;

                }

                Console.WriteLine();




                for (int i = 0; i < 2; i++)
                {

                    card[0] = '♠';
                    card[1] = '◇';
                    card[2] = '♡';
                    card[3] = '♣';

                    lottos2[i] = random.Next(1, 52);

                    if (lottos2[i] % 4 == 0)
                    {
                        Console.Write("{0} ", card[0]);

                    }
                    else if (lottos2[i] % 4 == 1)
                    {
                        Console.Write("{0} ", card[1]);



                    }
                    else if (lottos2[i] % 4 == 2)
                    {
                        Console.Write("{0} ", card[2]);



                    }
                    else
                    {
                        Console.Write("{0} ", card[3]);



                    }

                }
                string userGambling = default;
                string userChoice = default;
                Console.WriteLine();

                Console.WriteLine("베팅금액은 고정 100만원입니다.");
                Console.WriteLine("베팅을 하시겠습니까?");
                Console.Write("베팅하려면 1 베팅하지않으려면 2 를 눌러주세요 : ");

                userChoice = Console.ReadLine();

                if(userChoice == "1")
                {
                    Console.WriteLine("100만원 배팅 되서 {0}만원 남았습니다. 플레이어의 카드가 공개됩니다. ", userMoney -= 100);
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("베팅하지 않고 다음턴으로 넘어갑니다.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    continue;

                }



                //중간ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
                //중간ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
                //중간ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();





                for (int i = 0; i < 1; i++)
                {

                    number[0] = 'A';
                    number[1] = 'J';
                    number[2] = 'Q';
                    number[3] = 'K';
                    computer[i] = random.Next(0, 13);

                    if (computer[i] % 13 == 1)
                    {
                        Console.Write("{0} ", number[0]);
                        continue;

                    }
                    else if (computer[i] % 13 == 11)
                    {
                        Console.Write("{0} ", number[1]);
                        continue;

                    }
                    else if (computer[i] % 13 == 12)
                    {
                        Console.Write("{0} ", number[2]);
                        continue;

                    }
                    else if (computer[i] % 13 == 0)
                    {
                        Console.Write("{0} ", number[3]);
                        continue;

                    }
                    else
                    {
                        Console.Write("{0} ", computer[i]);
                        continue;
                    }

                    break;

                }

                Console.WriteLine();




                for (int i = 0; i < 1; i++)
                {

                    card[0] = '♠';
                    card[1] = '◇';
                    card[2] = '♡';
                    card[3] = '♣';

                    computer2[i] = random.Next(1, 52);

                    if (computer2[i] % 4 == 0)
                    {
                        Console.Write("{0} ", card[0]);

                    }

                    else if (computer2[i] % 4 == 1)
                    {
                        Console.Write("{0} ", card[1]);

                    }

                    else if (computer2[i] % 4 == 2)
                    {
                        Console.Write("{0} ", card[2]);
                    }

                    else
                    {
                        Console.Write("{0} ", card[3]);
                    }


                    Console.WriteLine();


 
                    if ((lottos[0] <= computer[0] && computer[0] <= lottos[1]) || (lottos[1] <= computer[0] && computer[0] <= lottos[0]))
                    {
                        Console.WriteLine("배팅에 성공했습니다! 배팅금의 두배를 200만원을 얻어서 {0}원이 되었습니다.", userMoney += 200);
                    }
                    else
                    {
                        Console.WriteLine("배팅에 실패 했습니다. 배팅금을 잃습니다. 남은 베팅금은 {0}원 입니다." , userMoney);
                    }


                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();



                    if (0 < userMoney&& userMoney < 1000)
                    {
                        Console.WriteLine("다음 턴을 시작합니다.");
                        continue;
                    }
                    else if (userMoney >= 1000)
                    {
                        Console.WriteLine("플레이어 승리!");

                        break;

                    }
                    else if( 0 >= userMoney)
                    {
                        Console.WriteLine("플레이어 파산....");


                        break; 
                    }
                    else
                    {
                        break;

                    }

                    break;
                }
            }
        }
    }
}
