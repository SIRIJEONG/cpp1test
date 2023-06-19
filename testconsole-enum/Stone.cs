using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Diagnostics.Eventing.Reader;

namespace testConsole003
{
    public class Stone
    {



        //플레이어로 부터 사이즈를 입력받아서 해당 사이즈 크기만큼 콘솔 맵을 구현한다.
        //플레이어는 wasd등 방향을 입력 받아서 콘솔 맵 안을 자유롭게 움직일 수 있다. 
        //콘솔 맵에는 일정 시간 or 일정 움직임 마다 돌 3개가 등장한다. (한 맵에 돌은 최대 3개 까지 존재할 수있다. )
        //플레이어는 돌을 밀 수 있다. 
        //한번 민 돌은 해당방향으로 끝까지 쭉 밀린다. ㄷ
        //어떤 방향으로든 돌이 연속으로 3개가 붙어있을 경우 돌은 사라지고 , 점수가 올라간다.
        //플레이어는 일정 점수를 획득하면 게임을 종료한다. 
        //R키를 눌러서 돌과 플레이어의 위치  그리고 점수를 초기화한다. 

        #region 변수들
        int userx = 0;
        int usery = 0;
        int turn = 0;
        int stoney = 0;
        int stonex = 0;
        int score = 0;
        int userInput;
        System.ConsoleKeyInfo key = default;
        int pressKey = 0;
        #endregion




        public void stonePush()
        {


            Console.Write("배열의 갯수를 입력하세요 : ");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} ", userInput);


            Random random = new Random();

            char[,] char2_ = new char[userInput, userInput];



            for (int y = 0; y < userInput; y++)
            {
                for (int x = 0; x < userInput; x++)
                {
                    if (x == 0 && y == 0)

                    {
                        char2_[y, x] = '0';
                        continue;
                    }
                    char2_[y, x] = '*';
                }
            }

            while (true)
            {

                Console.SetCursorPosition(0, 0);

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("현재 스코어 {0}", score);
                Console.ResetColor();


                if (turn < 1)
                {
                    stonex = random.Next(1, userInput);
                    stoney = random.Next(1, userInput);
                    if (char2_[stoney, stonex] == char2_[usery, userx])
                    {
                        continue;
                    }
                    char2_[stoney, stonex] = 'ⓒ';
                    char2_[stoney, stonex] = 'ⓒ';
                    char2_[stoney, stonex] = 'ⓒ';


                }

                for (int y = 0; y < userInput; y++)
                {
                    for (int x = 0; x < userInput; x++)
                    {
                        if (char2_[y, x] == 'ⓒ')
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


                        if (char2_[usery, userx - 1] == 'ⓒ' && char2_[usery, 0] != 'ⓒ')
                        {
                            char2_[usery, userx - 1] = '*';
                            char2_[usery, 0] = 'ⓒ';


                        }

                        else if (char2_[usery, userx - 1] == 'ⓒ' && char2_[usery, 0] == 'ⓒ')
                        {
                            char2_[usery, userx - 1] = '*';
                            char2_[usery, 1] = 'ⓒ';


                        }
                        else if (char2_[usery, userx - 1] == 'ⓒ' && char2_[usery, 1] == 'ⓒ')
                        {
                            char2_[usery, userx - 1] = '*';
                            char2_[usery, 2] = 'ⓒ';
                        }


                        Console.WriteLine("{0}{1}", char2_[usery, 1], char2_[usery, 0]);

                        if (char2_[usery, 1] == '0' && char2_[usery, 0] == 'ⓒ')
                        {
                            continue;
                        }
                        else if (char2_[usery, 2] == '0' && char2_[usery, 1] == 'ⓒ')
                        {
                            continue;
                        }
                        else if (char2_[usery, 3] == '0' && char2_[usery, 2] == 'ⓒ')
                        {
                            continue;
                        }
                        else
                        {
                            swap(ref char2_[usery, userx], ref char2_[usery, userx - 1]);
                            userx -= 1;
                            turn++;
                            if (char2_[stoney, stonex] == char2_[usery, userx])
                            {

                                char2_[stoney, stonex] = '0';


                            }
                        }
                    }
                }





                else if ('d' == key.KeyChar || 'D' == key.KeyChar)
                {
                    if (userx < userInput - 1)
                    {
                        if (char2_[usery, userx + 1] == 'ⓒ' && char2_[usery, userInput - 1] != 'ⓒ')
                        {
                            char2_[usery, userx + 1] = '*';
                            char2_[usery, userInput - 1] = 'ⓒ';


                        }

                        else if (char2_[usery, userx + 1] == 'ⓒ' && char2_[usery, userInput - 1] == 'ⓒ')
                        {
                            char2_[usery, userx + 1] = '*';
                            char2_[usery, userInput - 2] = 'ⓒ';


                        }
                        else if (char2_[usery, userx + 1] == 'ⓒ' && char2_[usery, userInput - 2] == 'ⓒ')
                        {
                            char2_[usery, userx + 1] = '*';
                            char2_[usery, userInput - 3] = 'ⓒ';

                        }


                        Console.WriteLine("{0}{1}", char2_[usery, userInput - 2], char2_[usery, userInput - 1]);
                        if (char2_[usery, userInput - 2] == '0' && char2_[usery, userInput - 1] == 'ⓒ')
                        {
                            Console.WriteLine("내옆에 돌이있다.");
                            break;
                        }
                        else if (char2_[usery, userInput - 3] == '0' && char2_[usery, userInput - 2] == 'ⓒ')
                        {
                            continue;
                        }
                        else if (char2_[usery, userInput - 4] == '0' && char2_[usery, userInput - 3] == 'ⓒ')
                        {
                            continue;
                        }
                        else
                        {
                            swap(ref char2_[usery, userx], ref char2_[usery, userx + 1]);
                            userx += 1;
                            if (char2_[stoney, stonex] == char2_[usery, userx])
                            {
                                char2_[stoney, stonex] = '0';


                            }
                        }
                    }

                }





                else if ('s' == key.KeyChar || 'S' == key.KeyChar)
                {
                    if (userInput - 1 > usery)
                    {
                        if (char2_[usery + 1, userx] == 'ⓒ' && char2_[userInput - 1, userx] != 'ⓒ')
                        {
                            char2_[usery + 1, userx] = '*';
                            char2_[userInput - 1, userx] = 'ⓒ';

                        }

                        else if (char2_[usery + 1, userx] == 'ⓒ' && char2_[userInput - 1, userx] == 'ⓒ')
                        {
                            char2_[usery + 1, userx] = '*';
                            char2_[userInput - 2, userx] = 'ⓒ';


                        }
                        else if (char2_[usery + 1, userx] == 'ⓒ' && char2_[userInput - 2, userx] == 'ⓒ')
                        {
                            char2_[usery + 1, userx] = '*';
                            char2_[userInput - 3, userx] = 'ⓒ';
                        }


                    }

                    if (char2_[userInput - 2, userx] == '0' && char2_[userInput - 1, userx] == 'ⓒ')
                    {
                        continue;
                    }
                    else if (char2_[userInput - 3, userx] == '0' && char2_[userInput - 2, userx] == 'ⓒ')
                    {
                        continue;
                    }
                    else if (char2_[userInput - 4, userx] == '0' && char2_[userInput - 3, userx] == 'ⓒ')
                    {
                        continue;
                    }

                    else
                    {
                        swap(ref char2_[usery, userx], ref char2_[usery + 1, userx]);
                        usery += 1;
                        turn++;
                        if (char2_[stoney, stonex] == char2_[usery, userx])
                        {
                            char2_[stoney, stonex] = '0';


                        }
                    }
                }






                else if ('w' == key.KeyChar || 'W' == key.KeyChar)
                {
                    if (usery > 0)
                    {
                        if (char2_[usery - 1, userx] == 'ⓒ' && char2_[0, userx] != 'ⓒ')
                        {
                            char2_[usery - 1, userx] = '*';
                            char2_[0, userx] = 'ⓒ';



                        }

                        else if (char2_[usery - 1, userx] == 'ⓒ' && char2_[0, userx] == 'ⓒ')
                        {
                            char2_[usery - 1, userx] = '*';
                            char2_[1, userx] = 'ⓒ';


                        }
                        else if (char2_[usery - 1, userx] == 'ⓒ' && char2_[1, userx] == 'ⓒ')
                        {
                            char2_[usery - 1, userx] = '*';
                            char2_[2, userx] = 'ⓒ';


                        }





                        if (char2_[1, userx] == '0' && char2_[0, userx] == 'ⓒ')
                        {
                            continue;
                        }

                        else if (char2_[2, userx] == '0' && char2_[1, userx] == 'ⓒ')
                        {
                            continue;
                        }

                        else if (char2_[3, userx] == '0' && char2_[2, userx] == 'ⓒ')
                        {
                            continue;
                        }

                        else
                        {
                            swap(ref char2_[usery, userx], ref char2_[usery - 1, userx]);
                            usery -= 1;
                            turn++;
                            if (char2_[stoney, stonex] == char2_[usery, userx])
                            {
                                char2_[stoney, stonex] = '0';

                            }
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



//public static bool IsStone(ref char[,] board , int x , int y)
//{
//    //보드가 정상적인 초기화가 되지 않은 경우
//    if (board == null || board.Length <= 0) { return false; }
//    //x값이 좌측으로 과도하게 넘어간 경우
//    if(x < 0) { return false; }
//    //y값이 위쪽으로 과도하게 넘어간 경우
//    if (y < 0) { return false; }

//    return board[x, y] == STONE_SHAPE;
//}