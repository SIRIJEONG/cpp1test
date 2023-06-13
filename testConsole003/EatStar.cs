using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Diagnostics.Eventing.Reader;

namespace testConsole003
{
    public class EatStar
    {


        

            //사용자에게서 사이즈를 입력받아서 * 배열을 초기화 한다. 단 입력은 (5~15 사이의 값)
            // ex)사용자가 5를 입력한 경우 
            //* * * * *
            //* * * * *
            //* * * * *
            //* * * * *
            //* * * * *
            //wasd로 플레이어가 4방향으로 이동한다. 
            //무작위로 일정 시간마다 코인이 등장한다. 
            //플레이어가 코인을 먹을 수 있다. 
            //플레이어가 코인을 먹는 경우 스코어가 올라간다. 
            //일정 스코어를 달성하면 게임을 종료한다. 
        int userx = 0;
        int usery = 0;
        int turn = 0;
        int coiny = 0;
        int coinx = 0;
        int score = 0;
            System.ConsoleKeyInfo key = default;
            
            int pressKey = 0;
            char[,] char2_ = new char[5,5];

        public void FindStar()
        {

            Random random = new Random();




            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (x == 0 && y == 0)
                    {
                        char2_[y,x] = '0';
                        continue;
                    }
                    char2_[y,x] = '*';
                }
            }

            while (true) 
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("현재 스코어 {0}", score);
                Console.ResetColor();


                if (turn % 6 == 0)
                {
                    coinx = random.Next(1, 5);
                    coiny = random.Next(1, 5);
                    if(char2_[coiny, coinx] == char2_[usery, userx])
                    {
                        continue;
                    }
                    char2_[coiny, coinx] = 'ⓒ';


                }

                for (int y = 0; y < 5; y++)
                {
                    for(int  x = 0; x < 5; x++)
                    {
                        if(char2_[y, x] == 'ⓒ')
                        {
                            
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.Write("{0} " , char2_[y,x]);
                            Console.ResetColor();

                        }
                    }
                    Console.WriteLine();
                }

               key = Console.ReadKey(true);
                Console.Clear();





                if ('a' == key.KeyChar || 'A' == key.KeyChar)
                {
                    if (userx > 0)
                    {

                        if (char2_[usery, userx - 1] == 'ⓒ')
                        {
                            char2_[usery, userx - 1] = '*';
                            score++;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery, userx - 1]);
                        userx -= 1;
                        turn++;
                        if (char2_[coiny, coinx] == char2_[usery, userx])
                        {

                            char2_[coiny, coinx] = '0';


                        }
                    }
                }





                else if ('d' == key.KeyChar || 'D' == key.KeyChar)
                {
                    if (userx < 4)
                    {
                        if (char2_[usery, userx + 1] == 'ⓒ')
                        {
                            char2_[usery, userx + 1] = '*';
                            score++;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery, userx + 1]);
                        userx += 1;
                        if (char2_[coiny, coinx] == char2_[usery, userx])
                        {
                            char2_[coiny, coinx] = '0';


                        }
                    }

                }





                else if ('s' == key.KeyChar || 'S' == key.KeyChar)
                {
                    if (usery < 4)
                    {
                        if (char2_[usery + 1, userx] == 'ⓒ')
                        {
                            char2_[usery + 1, userx] = '*';
                            score++;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery + 1, userx]);
                        usery += 1;
                        turn++;
                        if (char2_[coiny, coinx] == char2_[usery, userx])
                        {
                            char2_[coiny, coinx] = '0';


                        }
                    }
                }





                else if ('w' == key.KeyChar || 'W' == key.KeyChar)
                {
                    if (usery > 0)
                    {
                        if (char2_[usery - 1, userx] == 'ⓒ')
                        {
                            char2_[usery - 1, userx] = '*';
                            score++;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery - 1, userx]);
                        usery -= 1;
                        turn++;
                        if (char2_[coiny, coinx] == char2_[usery, userx])
                        {
                            char2_[coiny, coinx] = '0';

                        }
                    }

                }




                if (score == 10)
                {
                    break;
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



////Console.BackgroundColor = ConsoleColor.Green;
//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine("ⓒ");