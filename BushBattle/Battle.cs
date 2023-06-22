using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BushBattle
{
    public class Battle
    {
        public void monsterBattle()
        {
            Random random = new Random();
            int randomPlace = 0;
            int choice;
            int randomBoss = 0;


            //배틀 코드
            int PlayerDamage = 105;
            const int DiabloDamage = 7;
            int probability = 0;
            int Diablo = 1200;
            int Player = 50;
            float Playercritical = (PlayerDamage * 1.5f);
            int heal = 4;





                randomPlace = random.Next(1, 100);
                // 1~100까지 랜덤 숫자를 나오게 하여 randomPlace 확률 결정

                if (0 <= randomPlace && randomPlace <= 50)                             // randomPlace 50%확률 조건식
                {
                    Console.WriteLine("아케인 생츄어리로 이동합니다.\n");

                    randomBoss = random.Next(1, 100);                              //1~100까지 랜덤숫자를 나오게 하여 randomBoss 확률 결정

                    if (0 <= randomBoss && randomBoss <= 100)                                            //40% 확률로 몬스터 출현
                    {
                        Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                        Console.WriteLine("| 디아블로를 만났습니다  |\n");
                        Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                        Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                        while (true)  //무한루프
                        {
                            Thread.Sleep(500);  //출력시간 조정
                            probability = random.Next(1, 100);  //크리티컬 확률 결정


                            if (probability > 60 && Diablo > 0 && Player > 0)  //40% 확률로 크리티컬 그리고 플레이어와 몬스터가 살아있을 경우 실행
                            {
                                Console.WriteLine("플레이어가 공격을 합니다. \n크리티컬입니다! 디아블로가 정신못차립니다..\n{0}의 데미지를 입혔습니다.\n\n", Playercritical);
                                Console.WriteLine("디아블로가 공격을 합니다.\n{0}의 데미지를 받았습니다. \n\n", DiabloDamage);



                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                Console.WriteLine("| 디아블로 남은체력 {0}  |\n", Diablo -= (int)Playercritical);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                continue;
                            }
                            else if (probability <= 60 && Diablo > 0 && Player > 0)  // 60% 확률로 기본공격 그리고 플레이어와 몬스터가 살아있을 경우
                            {
                                Console.WriteLine("플레이어가 공격을 합니다.\n{0}의 데미지를 입혔습니다.\n\n", PlayerDamage);
                                Console.WriteLine("디아블로가 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);
                                Console.WriteLine("물약을 먹었습니다. hp를 {0} 회복했습니다.\n\n", heal, Player += heal);  //힐

                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                Console.WriteLine("| 디아블로 남은체력 {0}  |\n", Diablo -= (int)Playercritical);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                continue;
                            }
                            else if (Player > 0 && Diablo <= 0)  //플레이어 hp 0이상이고 몬스터 hp가 0이거나 0보다 작을 때 몬스터 처치 
                            {
                                /*system("cls");*/
                                Console.WriteLine("디아블로를 처치했습니다.");
                            Console.Clear();

                            return;
                        }
                        else if (Player <= 0 && Diablo <= 0)  //플레이어와 몬스터 둘다 hp가 0이거나 0보다 작을때 플레이어 사망 
                            {
                                Console.WriteLine("사망했습니다.");
                            Console.Clear();

                            return;

                        }
                        else  //플레이어hp가 0 이하면 사망
                            {
                                Console.WriteLine("사망했습니다.");
                            Console.Clear();

                            return;

                        }





                    }
                    }


                }

                else if (50 < randomPlace && randomPlace <= 100)
                {
                    Console.WriteLine("탈라샤의 무덤으로 이동합니다.\n");
                    randomBoss = random.Next(1, 100);
                    if (0 <= randomBoss&& randomBoss <= 100)
                    {

                        Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                        Console.WriteLine("|  듀리엘을 만났습니다.  |\n");
                        Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                        Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                        while (true)
                        {
                            Thread.Sleep(500);
                            probability = random.Next(1, 100);


                            if (probability > 60 && Diablo > 0 && Player > 0)
                            {
                                Console.WriteLine("플레이어가 공격을 합니다. \n크리티컬입니다! 듀리엘이 정신못차립니다..\n{0}의 데미지를 입혔습니다.\n\n", Playercritical);
                                Console.WriteLine("듀리엘이 공격을 합니다.\n{0}의 데미지를 받았습니다. \n\n", DiabloDamage);

                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                Console.WriteLine("|  듀리엘 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");


                                Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                continue;
                            }
                            else if (probability <= 60 && Diablo > 0 && Player > 0)
                            {
                                Console.WriteLine("플레이어가 공격을 합니다.\n{0}의 데미지를 입혔습니다. \n\n", PlayerDamage);
                                Console.WriteLine("듀리엘이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);
                                Console.WriteLine("물약을 먹었습니다. hp를 {0} 회복했습니다. \n\n", heal, Player += heal);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                Console.WriteLine("|  듀리엘 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                continue;
                            }
                            else if (Player > 0 && Diablo <= 0)
                            {
                                Console.WriteLine("듀리엘을 처치했습니다.");
                            Console.Clear();

                            return;
                            }
                            else if (Player <= 0 && Diablo <= 0)
                            {
                                Console.WriteLine("사망했습니다.");
                            Console.Clear();

                            return;


                        }
                        else
                        {
                            Console.WriteLine("사망했습니다.");
                            Console.Clear();

                            return;

                        }

                    }

                    return;

                }
            }

            

        }
    }
}