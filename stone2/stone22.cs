using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Diagnostics.Eventing.Reader;

namespace stone2
{
    public class Stone22
    {

        //콘솔 맵에서 매 턴 랜덤한 곳에 숫자 1이 등장한다.
        //방향키 중 오른쪽 키를 입력하면 맵에 존재하는 모든 1이 오른쪽 끝으로 이동한다. 
        //만약 오른쪽 끝에 이미 1이 있는 경우 1이 더해진다. 
        //턴이라는 것은 1회의 입력을 말한다. 
        //맵에 매 턴 1일 랜덤한 3곳에 생성된다. (normal)

        //2방향만 구현할 것 가장 우측 열과 가장 아래쪽 행의 숫자는 이동하지 않는다 (herd)
        //오른쪽 아래로 입력 가능 


        #region 변수들
        int userx = 0;
        int usery = 0;
        int turn = 0;
        int stoney = 0;
        int stonex = 0;

        int stonex1 = 0;
        int stonex2 = 0;

        int stoney1 = 0;
        int stoney2 = 0;

        int score = 0;
        int userInput;
        System.ConsoleKeyInfo key = default;
        int pressKey = 0;
        #endregion




        public void numberPush()
        {


            Console.Write("배열의 갯수를 입력하세요 : ");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} ", userInput);
            Console.WriteLine();


            Random random = new Random();

            int[,] char2_ = new int[userInput, userInput];



            for (int y = 0; y < userInput; y++)
            {
                for (int x = 0; x < userInput; x++)
                {
                    char2_[y, x] = 0;
                }
            }

            while (true)
            {

                Console.SetCursorPosition(0, 0);

                //Console.ForegroundColor = ConsoleColor.Blue;

                //Console.WriteLine("현재 스코어 {0}", score);
                //Console.ResetColor();


                if ('z' == key.KeyChar || 'Z' == key.KeyChar)
                {

                    for (int i = 0; i < 3; i++)
                    {
                        stonex = random.Next(0, userInput - 1);
                        stoney = random.Next(0, userInput -1);


                        while (char2_[stoney, stonex] == 1)
                        {
                            stonex = random.Next(0, userInput - 1);
                            stoney = random.Next(0, userInput -1);
                        }


                        if (char2_[stoney, stonex] == 0)
                        {
                            char2_[stoney, stonex] = 1;

                        }

                    }


                }
                Console.WriteLine();


                for (int y = 0; y < userInput; y++)
                    {
                        for (int x = 0; x < userInput; x++)
                        {
                            if (char2_[y, x] > 0)
                            {

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("{0,4}", char2_[y, x]);
                                Console.ResetColor();

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("{0,4}", char2_[y, x]);
                                Console.ResetColor();

                            }
                        }
                        Console.WriteLine();
                    }


                    key = Console.ReadKey(true);




                    if ('d' == key.KeyChar || 'D' == key.KeyChar)
                    {
                        if (userx < userInput - 1)
                        {
                            for (int y = 0; y < userInput-1; y++)
                            {
                                for (int x = 0; x < userInput - 1; x++)
                                {

                                    if (char2_[y, x] == 1 && char2_[y, userInput - 1] == 0)
                                    {

                                        char2_[y, x] = 0;


                                        char2_[y, userInput - 1] = 1;
                                    }
                                    else if (char2_[y, x] == 1 && char2_[y, userInput - 1] > 0)
                                    {
                                        char2_[y, x] = 0;

                                        char2_[y, userInput - 1] += 1;
                                    }

                                }
                            }
                        }


                    }

            if ('s' == key.KeyChar || 'S' == key.KeyChar)
            {
                if (userx < userInput - 1)
                {
                    for (int y = 0; y < userInput - 1; y++)
                    {
                        for (int x = 0; x < userInput-1; x++)
                        {

                            if (char2_[y, x] == 1 && char2_[userInput - 1, x] == 0)
                            {

                                char2_[y, x] = 0;


                                char2_[userInput - 1, x] = 1;
                            }
                            else if (char2_[y, x] == 1 && char2_[userInput - 1, x] > 0)
                            {
                                char2_[y, x] = 0;

                                char2_[userInput - 1, x] += 1;
                            }

                        }
                    }
                }
            }

            }



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