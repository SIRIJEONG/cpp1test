using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BushBattle
{
    public class Map
    {
        public void map()
        {
            Battle battle = new Battle();


            char[,] char2_ = new char[10, 20];

            int userx = 0;
            int usery = 0;
            string key1;
            int qPoint = 0;
            int qcount = 0;
            //int bushy = 0;
            //int bustx = 0;
            int randomBattle = 0;
            int hogam = 3;




            Random random = new Random();

            System.ConsoleKeyInfo key = default;






            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    if (x == 0 && y == 0)
                    {
                        char2_[y, x] = '●';
                        continue;
                    }
                    char2_[y, x] = '□';
                }
            }


            for (int y = 5; y < 10; y++)
            {
                for (int x = 12; x < 20; x++)
                {
                    char2_[y, x] = '■';

                }

            }


            char2_[3, 3] = '★';




            while (true)
            {

                Console.SetCursorPosition(0, 0);


                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 20; x++)
                    {
                        if (char2_[y, x] == '●')
                        {

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();

                        }
                        else if (char2_[y, x] == '■')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();
                        }
                        else if (char2_[y, x] == '★')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();

                        }
                    }
                    Console.WriteLine();
                }




                key = Console.ReadKey(true);



                if ('a' == key.KeyChar || 'A' == key.KeyChar)
                {
                    if (userx > 0)
                    {

                        if (char2_[usery, userx - 1] == '■')
                        {
                            char2_[usery, userx - 1] = '■';

                            randomBattle = random.Next(1, 100);

                            if (randomBattle < 20)
                            {
                                battle.monsterBattle();
                                qcount++;
                            }

                        }
                        if (char2_[usery, userx - 1] == '★')
                        {
                            Console.WriteLine("퀘스트를 받겠습니까? 받으시려면 Y 거절하시려면 N을 입력해주세요");
                            key1 = Console.ReadLine();
                            if (key1 == "y" || key1 == "Y")
                            {
                                Console.WriteLine("숲에 가서 몬스터와 5번 싸우세요");
                                Console.WriteLine("보상 : 현우에게 아샷추를 사줄 기회");
                                qcount = 0;

                                Thread.Sleep(2000);
                                Console.Clear();
                                qPoint += 1;
                            }
                            else if (key1 == "n" || key1 == "N")
                            {
                                Console.WriteLine("npc와의 관계가 하락했습니다.");
                                Thread.Sleep(2000);
                                hogam--;
                                Console.Clear();

                            }

                            continue;


                        }
                        swap(ref char2_[usery, userx], ref char2_[usery, userx - 1]);
                        userx -= 1;


                        if (char2_[5, 11] == '■' || char2_[6, 11] == '■' || char2_[7, 11] == '■' || char2_[8, 11] == '■' || char2_[9, 11] == '■' ||
char2_[4, 12] == '■' || char2_[4, 13] == '■' || char2_[4, 14] == '■' || char2_[4, 15] == '■' || char2_[4, 16] == '■' ||
char2_[4, 17] == '■' || char2_[4, 18] == '■' || char2_[4, 19] == '■')
                        {
                            char2_[5, 11] = '□';
                            char2_[6, 11] = '□';
                            char2_[7, 11] = '□';
                            char2_[8, 11] = '□';
                            char2_[9, 11] = '□';

                            char2_[4, 12] = '□';
                            char2_[4, 13] = '□';
                            char2_[4, 14] = '□';
                            char2_[4, 15] = '□';
                            char2_[4, 16] = '□';

                            char2_[4, 17] = '□';
                            char2_[4, 18] = '□';
                            char2_[4, 19] = '□';
                        }

                        if (char2_[5, 12] == '□' || char2_[6, 12] == '□' || char2_[7, 12] == '□' || char2_[8, 12] == '□' || char2_[9, 12] == '□' ||
 char2_[5, 13] == '□' || char2_[5, 14] == '□' || char2_[5, 15] == '□' || char2_[5, 16] == '□' ||char2_[5, 17] == '□' || char2_[5, 18] == '□' || char2_[5, 19] == '□')
                        {
                            char2_[5, 12] = '■';
                            char2_[6, 12] = '■';
                            char2_[7, 12] = '■';
                            char2_[8, 12] = '■';
                            char2_[9, 12] = '■';

                            char2_[5, 13] = '■';
                            char2_[5, 14] = '■';
                            char2_[5, 15] = '■';
                            char2_[5, 16] = '■';

                            char2_[5, 17] = '■';
                            char2_[5, 18] = '■';
                            char2_[5, 19] = '■';
                        }


                    }

                }





                else if ('d' == key.KeyChar || 'D' == key.KeyChar)
                {
                    if (userx < 19)
                    {
                        if (char2_[usery, userx + 1] == '■')
                        {
                            char2_[usery, userx + 1] = '■';
                            randomBattle = random.Next(1, 100);

                            if (randomBattle < 20)
                            {
                                battle.monsterBattle();
                                qcount++;

                            }

                        }
                        if (char2_[usery, userx + 1] == '★')
                        {
                            Console.WriteLine("퀘스트를 받겠습니까? 받으시려면 Y 거절하시려면 N을 입력해주세요");
                            key1 = Console.ReadLine();
                            if (key1 == "y" || key1 == "Y")
                            {
                                Console.WriteLine("숲에 가서 몬스터와 5번 싸우세요");
                                Console.WriteLine("보상 : 현우에게 아샷추를 사줄 기회");
                                qcount = 0;

                                Thread.Sleep(2000);
                                Console.Clear();
                                qPoint += 1;
                            }
                            else if (key1 == "n" || key1 == "N")
                            {
                                Console.WriteLine("npc와의 관계가 하락했습니다.");
                                Thread.Sleep(2000);
                                hogam--;

                                Console.Clear();

                            }
                            continue;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery, userx + 1]);
                        userx += 1;

                        if (char2_[5, 11] == '■' || char2_[6, 11] == '■' || char2_[7, 11] == '■' || char2_[8, 11] == '■' || char2_[9, 11] == '■' ||
                       char2_[4, 12] == '■' || char2_[4, 13] == '■' || char2_[4, 14] == '■' || char2_[4, 15] == '■' || char2_[4, 16] == '■' ||
                       char2_[4, 17] == '■' || char2_[4, 18] == '■' || char2_[4, 19] == '■')
                        {
                            char2_[5, 11] = '□';
                            char2_[6, 11] = '□';
                            char2_[7, 11] = '□';
                            char2_[8, 11] = '□';
                            char2_[9, 11] = '□';

                            char2_[4, 12] = '□';
                            char2_[4, 13] = '□';
                            char2_[4, 14] = '□';
                            char2_[4, 15] = '□';
                            char2_[4, 16] = '□';

                            char2_[4, 17] = '□';
                            char2_[4, 18] = '□';
                            char2_[4, 19] = '□';
                        }


                        if (char2_[5, 12] == '□' || char2_[6, 12] == '□' || char2_[7, 12] == '□' || char2_[8, 12] == '□' || char2_[9, 12] == '□' ||
char2_[5, 13] == '□' || char2_[5, 14] == '□' || char2_[5, 15] == '□' || char2_[5, 16] == '□' || char2_[5, 17] == '□' || char2_[5, 18] == '□' || char2_[5, 19] == '□')
                        {
                            char2_[5, 12] = '■';
                            char2_[6, 12] = '■';
                            char2_[7, 12] = '■';
                            char2_[8, 12] = '■';
                            char2_[9, 12] = '■';

                            char2_[5, 13] = '■';
                            char2_[5, 14] = '■';
                            char2_[5, 15] = '■';
                            char2_[5, 16] = '■';

                            char2_[5, 17] = '■';
                            char2_[5, 18] = '■';
                            char2_[5, 19] = '■';
                        }


                    }


                }





                else if ('s' == key.KeyChar || 'S' == key.KeyChar)
                {
                    if (usery < 9)
                    {
                        if (char2_[usery + 1, userx] == '■')
                        {
                            char2_[usery + 1, userx] = '■';
                            randomBattle = random.Next(1, 100);

                            if (randomBattle < 20)
                            {
                                battle.monsterBattle();
                                qcount++;

                            }

                        }
                        if (char2_[usery + 1, userx] == '★')
                        {
                            Console.WriteLine("퀘스트를 받겠습니까? 받으시려면 Y 거절하시려면 N을 입력해주세요");
                            key1 = Console.ReadLine();
                            if (key1 == "y" || key1 == "Y")
                            {
                                Console.WriteLine("숲에 가서 몬스터와 5번 싸우세요");
                                Console.WriteLine("보상 : 현우에게 아샷추를 사줄 기회");
                                qcount = 0;

                                Thread.Sleep(2000);
                                Console.Clear();
                                qPoint += 1;
                            }
                            else if (key1 == "n" || key1 == "N")
                            {
                                Console.WriteLine("npc와의 관계가 하락했습니다.");
                                Thread.Sleep(2000);
                                hogam--;

                                Console.Clear();

                            }
                            continue;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery + 1, userx]);
                        usery += 1;
                        if (char2_[5, 11] == '■' || char2_[6, 11] == '■' || char2_[7, 11] == '■' || char2_[8, 11] == '■' || char2_[9, 11] == '■' ||
char2_[4, 12] == '■' || char2_[4, 13] == '■' || char2_[4, 14] == '■' || char2_[4, 15] == '■' || char2_[4, 16] == '■' ||
char2_[4, 17] == '■' || char2_[4, 18] == '■' || char2_[4, 19] == '■')
                        {
                            char2_[5, 11] = '□';
                            char2_[6, 11] = '□';
                            char2_[7, 11] = '□';
                            char2_[8, 11] = '□';
                            char2_[9, 11] = '□';

                            char2_[4, 12] = '□';
                            char2_[4, 13] = '□';
                            char2_[4, 14] = '□';
                            char2_[4, 15] = '□';
                            char2_[4, 16] = '□';

                            char2_[4, 17] = '□';
                            char2_[4, 18] = '□';
                            char2_[4, 19] = '□';
                        }


                        if (char2_[5, 12] == '□' || char2_[6, 12] == '□' || char2_[7, 12] == '□' || char2_[8, 12] == '□' || char2_[9, 12] == '□' ||
char2_[5, 13] == '□' || char2_[5, 14] == '□' || char2_[5, 15] == '□' || char2_[5, 16] == '□' || char2_[5, 17] == '□' || char2_[5, 18] == '□' || char2_[5, 19] == '□')
                        {
                            char2_[5, 12] = '■';
                            char2_[6, 12] = '■';
                            char2_[7, 12] = '■';
                            char2_[8, 12] = '■';
                            char2_[9, 12] = '■';

                            char2_[5, 13] = '■';
                            char2_[5, 14] = '■';
                            char2_[5, 15] = '■';
                            char2_[5, 16] = '■';

                            char2_[5, 17] = '■';
                            char2_[5, 18] = '■';
                            char2_[5, 19] = '■';
                        }



                    }

                }





                else if ('w' == key.KeyChar || 'W' == key.KeyChar)
                {
                    if (usery > 0)
                    {
                        if (char2_[usery - 1, userx] == '■')
                        {
                            char2_[usery - 1, userx] = '■';
                            randomBattle = random.Next(1, 100);

                            if (randomBattle < 20)
                            {
                                battle.monsterBattle();
                                qcount++;


                            }


                        }
                        if (char2_[usery - 1, userx] == '★')
                        {
                            Console.WriteLine("퀘스트를 받겠습니까? 받으시려면 Y 거절하시려면 N을 입력해주세요");
                            key1 = Console.ReadLine();
                            if (key1 == "y" || key1 == "Y")
                            {
                                Console.WriteLine("숲에 가서 몬스터와 5번 싸우세요");
                                Console.WriteLine("보상 : 현우에게 아샷추를 사줄 기회");
                                qcount = 0;

                                Thread.Sleep(2000);
                                Console.Clear();
                                qPoint += 1;
                            }
                            else if (key1 == "n" || key1 == "N")
                            {
                                Console.WriteLine("npc와의 관계가 하락했습니다.");
                                Thread.Sleep(2000);
                                hogam--;

                                Console.Clear();

                            }
                            continue;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery - 1, userx]);
                        usery -= 1;
                        if (char2_[5, 11] == '■' || char2_[6, 11] == '■' || char2_[7, 11] == '■' || char2_[8, 11] == '■' || char2_[9, 11] == '■' ||
char2_[4, 12] == '■' || char2_[4, 13] == '■' || char2_[4, 14] == '■' || char2_[4, 15] == '■' || char2_[4, 16] == '■' ||
char2_[4, 17] == '■' || char2_[4, 18] == '■' || char2_[4, 19] == '■')
                        {
                            char2_[5, 11] = '□';
                            char2_[6, 11] = '□';
                            char2_[7, 11] = '□';
                            char2_[8, 11] = '□';
                            char2_[9, 11] = '□';

                            char2_[4, 12] = '□';
                            char2_[4, 13] = '□';
                            char2_[4, 14] = '□';
                            char2_[4, 15] = '□';
                            char2_[4, 16] = '□';

                            char2_[4, 17] = '□';
                            char2_[4, 18] = '□';
                            char2_[4, 19] = '□';
                        }


                        if (char2_[5, 12] == '□' || char2_[6, 12] == '□' || char2_[7, 12] == '□' || char2_[8, 12] == '□' || char2_[9, 12] == '□' ||
char2_[5, 13] == '□' || char2_[5, 14] == '□' || char2_[5, 15] == '□' || char2_[5, 16] == '□' || char2_[5, 17] == '□' || char2_[5, 18] == '□' || char2_[5, 19] == '□')
                        {
                            char2_[5, 12] = '■';
                            char2_[6, 12] = '■';
                            char2_[7, 12] = '■';
                            char2_[8, 12] = '■';
                            char2_[9, 12] = '■';

                            char2_[5, 13] = '■';
                            char2_[5, 14] = '■';
                            char2_[5, 15] = '■';
                            char2_[5, 16] = '■';

                            char2_[5, 17] = '■';
                            char2_[5, 18] = '■';
                            char2_[5, 19] = '■';
                        }



                    }

                }

                
                if (qPoint > 0)
                {
                    Console.WriteLine("Quset");
                    Console.WriteLine("숲에 가서 몬스터와 5번 싸우세요");
                    Console.WriteLine("몬스터와 싸운 횟수 {0}" , qcount);
                    Console.WriteLine("보상 : 현우에게 아샷추를 사줄 기회");

                }

                Console.WriteLine();
                if (qcount == 5)
                {
                    Console.WriteLine("퀘스트를 완료했습니다!");
                    qcount = 0;
                    qPoint = 0;
                    Thread.Sleep(3000);
                    Console.Clear();
                }

                if (hogam == 0)
                {
                    Console.WriteLine("npc에게 살해당했습니다!!!!!!!!!!!!!!!!");
                    Console.WriteLine("npc에게 살해당했습니다!!!!!!!!!!!!!!!!");
                    Console.WriteLine("npc에게 살해당했습니다!!!!!!!!!!!!!!!!");
                    Console.WriteLine("npc에게 살해당했습니다!!!!!!!!!!!!!!!!");
                    Console.WriteLine("npc에게 살해당했습니다!!!!!!!!!!!!!!!!");
                    Console.WriteLine("npc에게 살해당했습니다!!!!!!!!!!!!!!!!");
                    return;
                }






            }
        }
        public void swap(ref char firstChar, ref char secondChar)
        {
            char temp = '0';
            temp = (firstChar);
            (firstChar) = (secondChar);
            (secondChar) = temp;
        }
    }
}
