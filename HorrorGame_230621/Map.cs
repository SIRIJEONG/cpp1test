using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorrorGame_230621
{
    public class Map
    {
        ConsoleKeyInfo key = default;
        public int mapY = 20, mapX = 40;
        public int userY = 10, userX = 10;
        public const string user = "Ω";
        public const string wall = "■";
        public const string ENEMY_string = "∮";
        public const string GROUND_string = "ㆍ";
        public int ranWallX = default;
        public int ranWallY = default;
        public int score = default;

        int[] stalker = new int[2];

        //public List<int> enemyX_List = new List<int>();
        //public List<int> enemyY_List= new List<int>();
        public List<int[]> enemyList = new List<int[]>();
        Enemy enemy_ = new Enemy();


        public void Print_Map()
        {
            string[,] map = new string[mapY, mapX];


            // 맵 배열에 값 넣기 {
            for (int y = 0; y < mapY; y++)
            {
                for (int x = 0; x < mapX; x++)
                {
                    if (x == userX && y == userY)
                    {
                        map[y, x] = user;
                        continue;
                    }

                    else if (x == 0 || x == (mapX - 1) || y == 0 || y == (mapY - 1))
                    {
                        map[y, x] = wall;
                        continue;
                    }

                    map[y, x] = GROUND_string;

                }
            }
            // } 맵 배열에 값 넣기

            // random wall 생성 {
            for (int i = 0; i < 70; i++)
            {
                Random randomWall = new Random();
                ranWallY = randomWall.Next(mapY);
                ranWallX = randomWall.Next(mapX);
                while (map[ranWallY, ranWallX] != GROUND_string)
                {
                    ranWallY = randomWall.Next(mapY);
                    ranWallX = randomWall.Next(mapX);
                }
                map[ranWallY, ranWallX] = wall;
            }
            // } random wall 생성

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("현재 스코어 : {0}\n", score);
                // map 출력 {
                for (int y = 0; y < mapY; y++)
                {
                    for (int x = 0; x < mapX; x++)
                    {
                        if (map[y, x] == user)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"{map[y, x]}");
                            Console.ResetColor();
                        }

                        else if (map[y, x] == wall)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write($"{map[y, x]}");
                            Console.ResetColor();
                        }

                        else if (map[y, x] == ENEMY_string)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{map[y, x]}");
                            Console.ResetColor();
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"{map[y, x]}");
                            Console.ResetColor();
                        }
                    }
                    Console.WriteLine();
                }
                // } map 출력

                // 이동 입력 {
                key = Console.ReadKey(true);

                if ('A' == key.KeyChar || 'a' == key.KeyChar)
                {
                    if (map[userY, userX - 1] == GROUND_string)
                    {
                        Swap(ref map[userY, userX], ref map[userY, userX - 1]);
                        userX -= 1;

                        score += 1;
                    }
                }

                else if ('D' == key.KeyChar || 'd' == key.KeyChar)
                {
                    if (map[userY, userX + 1] == GROUND_string)
                    {
                        Swap(ref map[userY, userX], ref map[userY, userX + 1]);
                        userX += 1;

                        score += 1;
                    }
                }

                else if ('W' == key.KeyChar || 'w' == key.KeyChar)
                {
                    if (map[userY - 1, userX] == GROUND_string)
                    {
                        Swap(ref map[userY, userX], ref map[userY - 1, userX]);
                        userY -= 1;

                        score += 1;
                    }
                }

                else if ('S' == key.KeyChar || 's' == key.KeyChar)
                {
                    if (map[userY + 1, userX] == GROUND_string)
                    {
                        Swap(ref map[userY, userX], ref map[userY + 1, userX]);
                        userY += 1;

                        score += 1;
                    }
                }
                // } 이동 입력

                // random enemy 출력 {
                if (score % 10 == 0)
                {
                    Random randomEnemy = new Random();
                    
                    enemy_.SetPosition(randomEnemy.Next(mapY), randomEnemy.Next(mapX));
                    //ranEnemyY = randomEnemy.Next(mapY);
                    //ranEnemyX = randomEnemy.Next(mapX);

                    //enemy_ = randomEnemy.Next();
                    //int x_ = 0;
                    //int y_ = 0;
                    //(x_, y_) = enemy_.GetPosition();

                    while (map[enemy_.GetPositionY(), enemy_.GetPositionX()] != 
                        GROUND_string)
                    {
                        //enemy_.SetPosition(mapX, mapY);
                        enemy_.SetPosition(randomEnemy.Next(mapY), randomEnemy.Next(mapX));
                        //ranEnemyY = randomEnemy.Next(mapY);
                        //ranEnemyX = randomEnemy.Next(mapX);
                    }
                    map[enemy_.GetPositionY(), enemy_.GetPositionX()] = 
                        ENEMY_string;
                    stalker[0] = enemy_.GetPositionY();
                    stalker[1] = enemy_.GetPositionX();

                    enemyList.Add(stalker);
                    stalker = new int[2];

                    //enemy_ = new Enemy();
                  
                    //enemyList.Add(new Enemy());
                    //enemyList[0].SetPosition(mapX, mapY);
                    //enemyY_List.Add(ranEnemyY);
                    //enemyX_List.Add(ranEnemyX);
                }
                // } random enemy 생성


                enemy_.CatchUser(ref enemyList, ref map, ref userY, ref userX);
            }
        }
        // Print_Map();
        private void Swap(ref string firststring, ref string secondstring)   // 0 이동시 스왑하기 위한 함수
        {
            string temp = default;
            temp = firststring;
            firststring = secondstring;
            secondstring = temp;
        }
    }
}


