using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWall
{
    public class WallRun
    {


            char[,] char2_ = new char[20, 30];

            int userx = 0;
            int usery = 0;
            int turn = 0;
            int wally = 0;
            int wallx = 0;
            int enemyy = 0;
            int enemyx = 0;

        public void Wall()
        {


            Random random = new Random();

            int score = 0;
            System.ConsoleKeyInfo key = default;




            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    if (x ==0 && y == 0)
                    {
                        char2_[y, x] = '●';
                        continue;
                    }
                    char2_[y, x] = '□';
                }
            }

            //랜덤 벽 생성
            for (int i = 0; i < 75; i++)
            {
                wallx = random.Next(1, 30);
                wally = random.Next(1, 20);
                if (char2_[wally, wallx] == char2_[usery, userx])
                {

                    continue;
                }
                if (char2_[enemyy, enemyx] == char2_[wally, wallx])
                {

                    continue;
                }
                char2_[wally, wallx] = '■';

            }
            while (true)
            {

                Console.SetCursorPosition(0, 0);

                Console.WriteLine("SCORE : {0}", score);




                //15턴마다 적생성
                if (turn % 15 == 0)
                {
                    enemyx = random.Next(1, 30);
                    enemyy = random.Next(1, 20);
                    if (char2_[enemyy, enemyx] == char2_[usery, userx])
                    {

                        continue;

                    }
                    if (char2_[enemyy, enemyx] == char2_[wally, wallx])
                    {

                        continue;
                    }
                    char2_[enemyy, enemyx] = '◈';


                }





                for (int y = 0; y < 20; y++)
                {
                    for (int x = 0; x < 30; x++)
                    {
                        if (char2_[y, x] == '■')
                        {

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();

                        }
                        else if (char2_[y, x] == '●')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();
                        }
                        else if (char2_[y, x] == '◈')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
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


                bool die = false; 

                if ('a' == key.KeyChar || 'A' == key.KeyChar)
                {
                    if (userx > 0)
                    {

                        if (char2_[usery, userx - 1] == '■')
                        {
                            continue;
                        }
                        swap(ref char2_[usery, userx], ref char2_[usery, userx - 1]);
                        userx -= 1;
                        turn++;
                        score++;

                    }
                    die = EnemyMove();

                    //if (char2_[usery, userx - 1] == '◈' || char2_[usery, userx + 1] == '◈' || char2_[usery + 1, userx] == '◈' || char2_[usery - 1, userx] == '◈')
                    //{
                    //    break;
                    //}
                }





                else if ('d' == key.KeyChar || 'D' == key.KeyChar)
                {
                    if (userx < 29)
                    {
                        if (char2_[usery, userx + 1] == '■')
                        {
                            continue;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery, userx + 1]);
                        userx += 1;
                        turn++;
                        score++;
                    }

                    die = EnemyMove();
                    //if (char2_[usery, userx - 1] == '◈' || char2_[usery, userx + 1] == '◈' || char2_[usery + 1, userx] == '◈' || char2_[usery - 1, userx] == '◈')
                    //{
                    //    break;
                    //}
                }





                else if ('s' == key.KeyChar || 'S' == key.KeyChar)
                {
                    if (usery < 19)
                    {
                        if (char2_[usery + 1, userx] == '■')
                        {
                            continue;

                        }
                        swap(ref char2_[usery, userx], ref char2_[usery + 1, userx]);
                        usery += 1;
                        turn++;
                        score++;

                    }
                    die = EnemyMove();
                    //if (char2_[usery, userx - 1] == '◈' || char2_[usery, userx + 1] == '◈' || char2_[usery + 1, userx] == '◈' || char2_[usery - 1, userx] == '◈')
                    //{
                    //    break;
                    //}
                }





                else if ('w' == key.KeyChar || 'W' == key.KeyChar)
                {
                    if (usery > 0)
                    {
                        if (char2_[usery - 1, userx] == '■')
                        {
                            continue;


                        }
                        swap(ref char2_[usery, userx], ref char2_[usery - 1, userx]);
                        usery -= 1;
                        turn++;
                        score++;

                    }
                    die = EnemyMove();
                    //if (char2_[usery, userx - 1] == '◈' || char2_[usery, userx + 1] == '◈' || char2_[usery + 1, userx] == '◈' || char2_[usery - 1, userx] == '◈')
                    //{
                    //    break;
                    //}
                }

                if (die == true)
                {
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


        public bool EnemyMove()
        {
            bool die = false;
            for (int y = 0;  y < 20; y++)
            { 
                for (int x = 0; x < 30; x++) 
                {
                    if (char2_[y,x] == '◈')
                    {
                        int ydif = usery - y;
                        int xdif = userx - x;

                        if(ydif * ydif > xdif * xdif)
                        {
                            if (ydif > 0)
                            {
                                if(char2_[y + 1, x] == '□')
                                {
                                    swap(ref char2_[y + 1, x], ref char2_[y, x]);
                                    if(y + 1 < 19)
                                    {
                                        y += 1;
                                    }

                                }
                                else if(char2_[y + 1, x] == '●')
                                {
                                    Console.WriteLine("죽었습니다.");
                                    die = true;
                                    break;
                                }
                            }
                            else if (ydif < 0) 
                            {
                                if (char2_[y - 1, x] == '□')
                                {
                                    swap(ref char2_[y - 1, x], ref char2_[y, x]);

                                }
                                else if (char2_[y - 1, x] == '●')
                                {
                                    Console.WriteLine("죽었습니다.");
                                    die = true;
                                    break;
                                }
                            }

                        }

                        if (ydif * ydif < xdif * xdif || ydif * ydif == xdif * xdif)
                        {
                            if(xdif > 0)
                            {
                                if (char2_[y,x+1] == '□')
                                {
                                    swap(ref char2_[y , x + 1], ref char2_[y, x]);
                                    if (x + 1 < 19)
                                    {
                                        x += 1;
                                    }
                                }
                                else if (char2_[y, x + 1] == '●')
                                {
                                    Console.WriteLine("죽었습니다.");
                                    die = true;
                                    break;
                                }
                            }
                            else if (xdif<0)
                            {
                                if(char2_[y , x - 1] == '□')
                                {
                                    swap(ref char2_[y , x - 1], ref char2_[y, x]);

                                }
                                else if (char2_[y, x -1 ] == '●')
                                {
                                    Console.WriteLine("죽었습니다.");
                                    die = true;
                                    break;
                                }
                            }
                        }

                    }
                }
                if(die == true)
                {
                    break;
                }
            } //for y ()
            return die;
        } // EnemyMover
    }
}
