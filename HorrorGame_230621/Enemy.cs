using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorrorGame_230621
{
    public class Enemy
    {
        private int yPos = 0;
        private int xPos = 0;
        private const string user = "Ω";
        private const string wall = "■";
        private const string ENEMY_string = "∮";
        private const string GROUND_string = "ㆍ";

        Map mapCode2 = default;



        //! 적의 위치를 할당하는 함수
        public void SetPosition(int y, int x) 
        {
            yPos = y;
            xPos = x;
        }

        //public (int, int) GetPosition()
        //{
        //    return (xPos, yPos);
        //}

        public int GetPositionX()
        {
            return xPos;
        }
        public int GetPositionY()
        {
            return yPos;
        }

        public void CatchUser(ref List<int[]> enemyList, ref string[,] map, ref int userY, ref int userX)
        {

            while (true)
            {
                for (int i = 0; i < enemyList.Count; i++)
                {
                    if (enemyList[i][0] > userY)
                    {
                        switch (map[enemyList[i][0] - 1, enemyList[i][1]])
                        {
                            case user:
                                break;
                            case GROUND_string:
                                Swap(ref map[enemyList[i][0], xPos], ref map[enemyList[i][0] - 1, xPos]);
                                enemyList[i][0] -= 1;

                                break;

                        }
                    }
                    else if (enemyList[i][0] < userY)
                    {
                        switch (map[enemyList[i][0] + 1, enemyList[i][1]])
                        {
                            case user:
                                break;
                            case GROUND_string:
                                Swap(ref map[enemyList[i][0], xPos], ref map[enemyList[i][0] + 1, xPos]);
                                enemyList[i][0] += 1;
                                break;
                        }
                    }
                    else if (enemyList[i][1] < userX)
                    {
                        switch (map[enemyList[i][0], enemyList[i][1] + 1])
                        {
                            case user:
                                break;
                            case GROUND_string:
                                Swap(ref map[enemyList[i][0], xPos], ref map[enemyList[i][0], xPos + 1]);
                                enemyList[i][1] += 1;
                                break;
                        }
                    }
                    else if (enemyList[i][1] > userX)
                    {
                        switch (map[enemyList[i][0], enemyList[i][1] - 1])
                        {
                            case user:
                                break;
                            case GROUND_string:
                                Swap(ref map[enemyList[i][0], xPos], ref map[enemyList[i][0], xPos - 1]);
                                enemyList[i][1] -= 1;
                                break;
                        }
                    }
                }
            }
        }

        private void Swap(ref string firststring, ref string secondstring)   // 0 이동시 스왑하기 위한 함수
        {
            string temp = default;
            temp = firststring;
            firststring = secondstring;
            secondstring = temp;
        }
    }
}
