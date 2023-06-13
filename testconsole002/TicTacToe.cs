using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace testconsole002
{
    internal class TicTacToe
    {
        public void game()
        {
            Random random = new Random();
            int userChoice;
            int computerChoice = default;
            char[] number = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
            char userChoice1;
            string userChoice2;



            while (true)
            {
                //Console.Clear();

                Console.WriteLine("user : O computer : X 로 진행됩니다.");
                Console.Write("원하는 칸의 번호를 입력해 주세요 : ");
                userChoice2 = Console.ReadLine();

                int.TryParse(userChoice2, out userChoice);

                Console.WriteLine("{0}", userChoice);

                computerChoice = random.Next(0, 8);


                if (number[computerChoice] == 'O')
                {
                    continue;
                }



                if (number[userChoice] == number[computerChoice])
                {
                    continue;
                }
                else if (number[userChoice] != number[computerChoice])
                {
                    number[userChoice] = 'O';
                    //Thread.Sleep(1000);
                    number[computerChoice] = 'X';

                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();





                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("     {0}      |      {1}        |       {2}   ", number[0], number[1], number[2]);
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("     {0}      |      {1}        |       {2}   ", number[3], number[4], number[5]);
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("     {0}      |      {1}        |       {2}   ", number[6], number[7], number[8]);
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                for (int i = 0; i < 9; i++) {
                    if (number[i] == 'O')
                    {
                        if (number[0] == number[1] && number[1] == number[2])
                        {
                            Console.WriteLine("승리하였습니다.");
                            break;

                        }
                        else if (number[3] == number[4] && number[4] == number[5])
                        {
                            Console.WriteLine("승리하였습니다.");
                            break;

                        }
                        else if (number[6] == number[7] && number[7] == number[8])
                        {
                            Console.WriteLine("승리하였습니다.");
                            break;

                        }
                        else if (number[0] == number[3] && number[3] == number[6])
                        {
                            Console.WriteLine("승리하였습니다.");
                            break;

                        }
                        else if (number[1] == number[4] && number[4] == number[7])
                        {
                            Console.WriteLine("승리하였습니다.");
                            break;

                        }
                        else if (number[2] == number[5] && number[5] == number[8])
                        {
                            Console.WriteLine("승리하였습니다.");
                            break;

                        }
                        else if (number[0] == number[4] && number[4] == number[8])
                        {
                            Console.WriteLine("승리하였습니다.");
                            break;

                        }
                        else if (number[2] == number[4] && number[4] == number[6])
                        {
                            Console.WriteLine("승리하였습니다.");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    }
                }





                for (int i = 0; i < 9; i++)
                {
                    if (number[i] == 'x')
                    {
                        if (number[0] == number[1] && number[1] == number[2])
                        {
                            Console.WriteLine("패배하였습니다.");
                            break;

                        }
                        else if (number[3] == number[4] && number[4] == number[5])
                        {
                            Console.WriteLine("패배하였습니다.");
                            break;

                        }
                        else if (number[6] == number[7] && number[7] == number[8])
                        {
                            Console.WriteLine("패배하였습니다.");
                            break;

                        }
                        else if (number[0] == number[3] && number[3] == number[6])
                        {
                            Console.WriteLine("패배하였습니다.");
                            break;

                        }
                        else if (number[1] == number[4] && number[4] == number[7])
                        {
                            Console.WriteLine("패배하였습니다.");
                            break;

                        }
                        else if (number[2] == number[5] && number[5] == number[8])
                        {
                            Console.WriteLine("패배하였습니다.");
                            break;

                        }
                        else if (number[0] == number[4] && number[4] == number[8])
                        {
                            Console.WriteLine("패배하였습니다.");
                            break;

                        }
                        else if (number[2] == number[4] && number[4] == number[6])
                        {
                            Console.WriteLine("패배하였습니다.");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                        break;

                    }
                }


            }

        }
        }
    }

