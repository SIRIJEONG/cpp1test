using market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace map
{
    public class MoveMap
    {


        Random random = new Random();
        int randomMarket;
        int randomMarket1;
        int randomMarket2;
        int itemNumber1 = 1;
        int itemNumber2 = 2;
        int itemNumber3 = 3;
        int userchoice1;

        string userchoice;
        int gold = 200000;


        List<Market> item_list = default;
        List<string> Invrntory_list = default;

        public string itemName;
        public int itemPrice;


        public void itemMarket()
        {

            Market waterbottle = new Market();
            waterbottle.Initem("김재현의 물병", 100);
            Market glasses = new Market();
            glasses.Initem("박시연의 알없는 안경", 15000);
            Market macbook = new Market();
            macbook.Initem("배경택의 맥북", 39800);
            Market pouch = new Market();
            pouch.Initem("이미정의 곰돌이 파우치", 100000);
            Market pin = new Market();
            pin.Initem("박준오의 머리핀", 8000);
            Market pants = new Market();
            pants.Initem("유준호의 찢어진바지", 80000);
            Market coffee = new Market();
            coffee.Initem("교수님의 아이스아메리카노", 3000);
            Market mandarin = new Market();
            mandarin.Initem("신성창의 제주감귤", 200);
            Market IQOS = new Market();
            IQOS.Initem("이경민의 부숴진 아이코스", 5000);
            Market lighter = new Market();
            lighter.Initem("박정근의 세상을 멸망시킬 라이터", 200);


            item_list = new List<Market>();

            item_list.Add(waterbottle);
            item_list.Add(glasses);
            item_list.Add(macbook);
            item_list.Add(pouch);
            item_list.Add(pin);
            item_list.Add(pants);
            item_list.Add(coffee);
            item_list.Add(mandarin);
            item_list.Add(IQOS);
            item_list.Add(lighter);

            Invrntory_list = new List<string>();

        }

        public void Initem(string name, int price)
        {

            itemName = name;
            itemPrice = price;
        }



        char userInput;
        int userx = 0;
        int usery = 0;
        System.ConsoleKeyInfo key = default;






        public void userMap()
        {

            char[,] char2_ = new char[15, 15];



            for (int y = 0; y < 15; y++)
            {
                for (int x = 0; x < 15; x++)
                {
                    if (x == 0 && y == 0)
                    {
                        char2_[x, y] = '♣';
                        continue;
                    }

                    char2_[y, x] = '□';
                }
            }

            char2_[10, 5] = '★';
            char2_[5, 9] = '▲';
            char2_[13, 7] = '♥';

            while (true)
            {
                end1:

                Console.SetCursorPosition(0, 0);

                Console.WriteLine("태초마을에 오신걸 환영합니다.");
                Console.WriteLine("세모는 던전     별은 상점     하트는 카드게임입니다.");

                for (int y = 0; y < 15; y++)
                {
                    for (int x = 0; x < 15; x++)
                    {
                        if (char2_[y, x] == '♣')
                        {

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();

                        }
                        else if (char2_[y, x] == '▲')
                        {

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();

                        }
                        else if (char2_[y, x] == '★')
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0} ", char2_[y, x]);
                            Console.ResetColor();

                        }
                        else if (char2_[y, x] == '♥')
                        {

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
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


                        swap(ref char2_[usery, userx], ref char2_[usery, userx - 1]);
                        userx -= 1;

                        if (char2_[usery, userx] == char2_[10, 5])
                        {

                            while (true)
                            {
                                randomMarket = random.Next(0, 10);
                                randomMarket1 = random.Next(0, 10);
                                randomMarket2 = random.Next(0, 10);

                                Console.WriteLine("상점에 들어가려면 Y 인벤토리에 들어가려면 N 을눌러주세요");
                                userchoice = Console.ReadLine();

                                if (userchoice == "Y")
                                {

                                    if (randomMarket != randomMarket1 && randomMarket1 != randomMarket2 && randomMarket != randomMarket2)
                                    {
                                        Console.WriteLine("[상점]");
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber1, item_list[randomMarket].itemName, item_list[randomMarket].itemPrice);
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber2, item_list[randomMarket1].itemName, item_list[randomMarket1].itemPrice);
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber3, item_list[randomMarket2].itemName, item_list[randomMarket2].itemPrice);
                                        Console.WriteLine();
                                        Console.WriteLine();

                                        Console.WriteLine("원하시는 상품을 구입하시려면 해당 상품의 번호를 입력해 주세요");
                                        Console.WriteLine("상점 이용을 그만하시려면 4번을 눌러주세요");
                                        Console.WriteLine();

                                        userchoice1 = Convert.ToInt32(Console.ReadLine());



                                        if (userchoice1 == 1)
                                        {
                                            gold -= item_list[randomMarket].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket].itemName);
                                            continue;

                                        }



                                        else if (userchoice1 == 2)
                                        {
                                            gold -= item_list[randomMarket1].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket1].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket1].itemName);

                                            continue;


                                        }





                                        else if (userchoice1 == 3)
                                        {
                                            gold -= item_list[randomMarket2].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket2].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket2].itemName);

                                            continue;


                                        }





                                        else if (userchoice1 == 4)
                                        {
                                            Console.WriteLine("상점을 나갑니다.");

                                            continue;


                                        }



                                    }

                                }
                                else if (userchoice == "N")
                                {
                                    Console.WriteLine("[인벤토리]");
                                    //Invrntory_list = new List<string>();
                                    for (int i = 0; i < Invrntory_list.Count; i++)
                                    {
                                        Console.WriteLine("{0}", Invrntory_list[i]);

                                    }
                                    Console.WriteLine();


                                }



                            }

                            char2_[usery, userx - 1] = '□';


                        }

                        if (char2_[usery, userx] == char2_[5, 9])
                        {

                            int playerWalk = 0;
                            int randomPlace = 0;
                            int choice;
                            int randomBoss = 0;

                            Console.WriteLine("디아블로 미니게임에 오신걸 환영합니다!\n");
                            Console.WriteLine("게임의 룰을 설명해드리겠습니다.\n");
                            Console.WriteLine("1.플레이어가 6번 이동하면 게임은 클리어됩니다.\n2.중간에 40%확률로 몬스터를 만나서 대결하여 사망한다면 이동횟수는 초기화 됩니다..\n");
                            Console.WriteLine("3.몬스터와의 대결은 자동으로 진행되기 때문에 운빨겜입니다.\n5.60%확률로 자동으로 물약을 먹습니다.");
                            Console.WriteLine("길을 개척하여 세상을 구해보세요!\n\n");
                            Console.WriteLine("플레이어 \n공격력 : 105(크리티컬시 157) \n체력 : 50\n\n");
                            Console.WriteLine("보스 \n공격력 : 7 \n체력 : 1200\n\n\n");




                            while (playerWalk < 7)
                            {

                                //이동질문 그리고 번호 입력
                                Console.WriteLine("이동하시겠습니까?");
                                Console.WriteLine("\n1.yes   2.no\n");
                                choice = Convert.ToInt32(Console.ReadLine());


                                //배틀 코드
                                int PlayerDamage = 105;
                                const int DiabloDamage = 7;
                                int probability = 0;
                                int Diablo = 1200;
                                int Player = 50;
                                float Playercritical = (PlayerDamage * 1.5f);
                                int heal = 4;




                                if (choice == 1 && playerWalk < 6)                                       // 1번을 입력하고 playerWalk가 6 이하일 때 실행 된다.
                                {
                                    randomPlace = random.Next(1, 100);
                                    // 1~100까지 랜덤 숫자를 나오게 하여 randomPlace 확률 결정

                                    if (100 >= randomPlace && randomPlace >= 50)                             // randomPlace 50%확률 조건식
                                    {
                                        Console.WriteLine("아케인 생츄어리로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n\n", playerWalk);

                                        randomBoss = random.Next(1, 100);                              //1~100까지 랜덤숫자를 나오게 하여 randomBoss 확률 결정

                                        if (randomBoss > 60)                                            //40% 확률로 몬스터 출현
                                        {
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("| 디아블로를 만났습니다  |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                                            while (true)  //무한루프
                                            {
                                                Thread.Sleep(1500);  //출력시간 조정
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
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)  //플레이어와 몬스터 둘다 hp가 0이거나 0보다 작을때 플레이어 사망 
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }
                                                else  //플레이어hp가 0 이하면 사망
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                        }
                                        else //몬스터를 만나지 않았을 때 
                                        {
                                            continue;
                                        }

                                        continue;

                                    }
                                    else if (50 > randomPlace && randomPlace >= 30)
                                    {
                                        Console.WriteLine("탈라샤의 무덤으로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n", playerWalk);
                                        randomBoss = random.Next(1, 100);
                                        if (randomBoss > 60)
                                        {

                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("|  듀리엘을 만났습니다.  |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                                            while (true)
                                            {
                                                Thread.Sleep(1500);
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
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);
                                                    goto end1;

                                                    
                                                }
                                                else
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                            continue;
                                        }
                                    }
                                    else if (30 > randomPlace && randomPlace > 0)
                                    {
                                        Console.WriteLine("수도원의 묘지로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n", playerWalk);
                                        randomBoss = random.Next(1, 100);
                                        if (randomBoss > 60)
                                        {

                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("|   바알을 만났습니다    |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");


                                            while (true)
                                            {
                                                Thread.Sleep(1500);
                                                probability = random.Next(1, 100);


                                                if (probability > 60 && Diablo > 0 && Player > 0)
                                                {
                                                    Console.WriteLine("플레이어가 공격을 합니다. \n크리티컬입니다! 바알이 정신못차립니다..\n{0}의 데미지를 입혔습니다.\n\n", Playercritical);
                                                    Console.WriteLine("바알이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("|  바알의 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                                    Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                                    continue;
                                                }
                                                else if (probability <= 60 && Diablo > 0 && Player > 0)
                                                {
                                                    Console.WriteLine("플레이어가 공격을 합니다.\n{0}의 데미지를 입혔습니다.\n\n", PlayerDamage);
                                                    Console.WriteLine("바알이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);
                                                    Console.WriteLine("물약을 먹었습니다. hp를 {0} 회복했습니다.\n\n", heal, Player += heal);

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("|  바알의 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                                    continue;
                                                }
                                                else if (Player > 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("바알을 처치했습니다.");
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);
                                                    goto end1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else if (playerWalk == 6) //플레이어 이동횟수가 6번이 되면  클리어 합니다.
                                {
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");

                                    goto end1;

                                }
                                else
                                {
                                    Console.WriteLine("이거 누를 거면 게임왜켰냐 ㅋㅋ\n"); //이동안한다고 하면 출력 
                                    continue;
                                }
                            }
                            char2_[usery, userx + 1] = '□';


                        }

                        if (char2_[usery , userx] == char2_[13, 7])
                        {
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

                                    if (userChoice == "1")
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
                                            Console.WriteLine("배팅에 실패 했습니다. 배팅금을 잃습니다. 남은 베팅금은 {0}원 입니다.", userMoney);
                                        }


                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();



                                        if (0 < userMoney && userMoney < 1000)
                                        {
                                            Console.WriteLine("다음 턴을 시작합니다.");
                                            continue;
                                        }
                                        else if (userMoney >= 1000)
                                        {
                                            Console.WriteLine("플레이어 승리!");
                                            goto end1;

                                        }
                                        else if (0 >= userMoney)
                                        {
                                            Console.WriteLine("플레이어 파산....");
                                            goto end1;


                                        }
                                        else
                                        {
                                            break;

                                        }

                                    }
                                }
                                char2_[usery, userx + 1] = '□';

                            }
                        }


                    }
                }





                else if ('d' == key.KeyChar || 'D' == key.KeyChar)
                {
                    if (userx < 15)
                    {


                        swap(ref char2_[usery, userx], ref char2_[usery, userx + 1]);
                        userx += 1;

                        if (char2_[usery, userx] == char2_[10, 5])
                        {
                            while (true)
                            {
                                randomMarket = random.Next(0, 10);
                                randomMarket1 = random.Next(0, 10);
                                randomMarket2 = random.Next(0, 10);

                                Console.WriteLine("상점에 들어가려면 Y 인벤토리에 들어가려면 N 을눌러주세요");
                                userchoice = Console.ReadLine();

                                if (userchoice == "Y")
                                {

                                    if (randomMarket != randomMarket1 && randomMarket1 != randomMarket2 && randomMarket != randomMarket2)
                                    {
                                        Console.WriteLine("[상점]");
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber1, item_list[randomMarket].itemName, item_list[randomMarket].itemPrice);
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber2, item_list[randomMarket1].itemName, item_list[randomMarket1].itemPrice);
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber3, item_list[randomMarket2].itemName, item_list[randomMarket2].itemPrice);
                                        Console.WriteLine();
                                        Console.WriteLine();

                                        Console.WriteLine("원하시는 상품을 구입하시려면 해당 상품의 번호를 입력해 주세요");
                                        Console.WriteLine("상점 이용을 그만하시려면 4번을 눌러주세요");
                                        Console.WriteLine();

                                        userchoice1 = Convert.ToInt32(Console.ReadLine());



                                        if (userchoice1 == 1)
                                        {
                                            gold -= item_list[randomMarket].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket].itemName);
                                            continue;

                                        }



                                        else if (userchoice1 == 2)
                                        {
                                            gold -= item_list[randomMarket1].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket1].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket1].itemName);

                                            continue;


                                        }





                                        else if (userchoice1 == 3)
                                        {
                                            gold -= item_list[randomMarket2].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket2].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket2].itemName);

                                            continue;


                                        }





                                        else if (userchoice1 == 4)
                                        {
                                            Console.WriteLine("상점을 나갑니다.");

                                            continue;


                                        }



                                    }

                                }
                                else if (userchoice == "N")
                                {
                                    Console.WriteLine("[인벤토리]");
                                    //Invrntory_list = new List<string>();
                                    for (int i = 0; i < Invrntory_list.Count; i++)
                                    {
                                        Console.WriteLine("{0}", Invrntory_list[i]);

                                    }
                                    Console.WriteLine();


                                }



                            }
                            char2_[usery, userx + 1] = '□';

                        }




                        if (char2_[usery, userx] == char2_[5, 9])
                        {
                            int playerWalk = 0;
                            int randomPlace = 0;
                            int choice;
                            int randomBoss = 0;

                            Console.WriteLine("디아블로 미니게임에 오신걸 환영합니다!\n");
                            Console.WriteLine("게임의 룰을 설명해드리겠습니다.\n");
                            Console.WriteLine("1.플레이어가 6번 이동하면 게임은 클리어됩니다.\n2.중간에 40%확률로 몬스터를 만나서 대결하여 사망한다면 이동횟수는 초기화 됩니다..\n");
                            Console.WriteLine("3.몬스터와의 대결은 자동으로 진행되기 때문에 운빨겜입니다.\n5.60%확률로 자동으로 물약을 먹습니다.");
                            Console.WriteLine("길을 개척하여 세상을 구해보세요!\n\n");
                            Console.WriteLine("플레이어 \n공격력 : 105(크리티컬시 157) \n체력 : 50\n\n");
                            Console.WriteLine("보스 \n공격력 : 7 \n체력 : 1200\n\n\n");




                            while (playerWalk < 7)
                            {

                                //이동질문 그리고 번호 입력
                                Console.WriteLine("이동하시겠습니까?");
                                Console.WriteLine("\n1.yes   2.no\n");
                                choice = Convert.ToInt32(Console.ReadLine());


                                //배틀 코드
                                int PlayerDamage = 105;
                                const int DiabloDamage = 7;
                                int probability = 0;
                                int Diablo = 1200;
                                int Player = 50;
                                float Playercritical = (PlayerDamage * 1.5f);
                                int heal = 4;




                                if (choice == 1 && playerWalk < 6)                                       // 1번을 입력하고 playerWalk가 6 이하일 때 실행 된다.
                                {
                                    randomPlace = random.Next(1, 100);
                                    // 1~100까지 랜덤 숫자를 나오게 하여 randomPlace 확률 결정

                                    if (100 >= randomPlace && randomPlace >= 50)                             // randomPlace 50%확률 조건식
                                    {
                                        Console.WriteLine("아케인 생츄어리로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n\n", playerWalk);

                                        randomBoss = random.Next(1, 100);                              //1~100까지 랜덤숫자를 나오게 하여 randomBoss 확률 결정

                                        if (randomBoss > 60)                                            //40% 확률로 몬스터 출현
                                        {
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("| 디아블로를 만났습니다  |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                                            while (true)  //무한루프
                                            {
                                                Thread.Sleep(1500);  //출력시간 조정
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
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)  //플레이어와 몬스터 둘다 hp가 0이거나 0보다 작을때 플레이어 사망 
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }
                                                else  //플레이어hp가 0 이하면 사망
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                        }
                                        else //몬스터를 만나지 않았을 때 
                                        {
                                            continue;
                                        }

                                        continue;

                                    }
                                    else if (50 > randomPlace && randomPlace >= 30)
                                    {
                                        Console.WriteLine("탈라샤의 무덤으로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n", playerWalk);
                                        randomBoss = random.Next(1, 100);
                                        if (randomBoss > 60)
                                        {

                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("|  듀리엘을 만났습니다.  |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                                            while (true)
                                            {
                                                Thread.Sleep(1500);
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
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                            continue;
                                        }
                                    }
                                    else if (30 > randomPlace && randomPlace > 0)
                                    {
                                        Console.WriteLine("수도원의 묘지로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n", playerWalk);
                                        randomBoss = random.Next(1, 100);
                                        if (randomBoss > 60)
                                        {

                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("|   바알을 만났습니다    |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");


                                            while (true)
                                            {
                                                Thread.Sleep(1500);
                                                probability = random.Next(1, 100);


                                                if (probability > 60 && Diablo > 0 && Player > 0)
                                                {
                                                    Console.WriteLine("플레이어가 공격을 합니다. \n크리티컬입니다! 바알이 정신못차립니다..\n{0}의 데미지를 입혔습니다.\n\n", Playercritical);
                                                    Console.WriteLine("바알이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("|  바알의 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                                    Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                                    continue;
                                                }
                                                else if (probability <= 60 && Diablo > 0 && Player > 0)
                                                {
                                                    Console.WriteLine("플레이어가 공격을 합니다.\n{0}의 데미지를 입혔습니다.\n\n", PlayerDamage);
                                                    Console.WriteLine("바알이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);
                                                    Console.WriteLine("물약을 먹었습니다. hp를 {0} 회복했습니다.\n\n", heal, Player += heal);

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("|  바알의 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                                    continue;
                                                }
                                                else if (Player > 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("바알을 처치했습니다.");
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);
                                                    goto end1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else if (playerWalk == 6) //플레이어 이동횟수가 6번이 되면  클리어 합니다.
                                {
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");

                                    goto end1;

                                }
                                else
                                {
                                    Console.WriteLine("이거 누를 거면 게임왜켰냐 ㅋㅋ\n"); //이동안한다고 하면 출력 
                                    continue;
                                }
                            }
                            char2_[usery, userx + 1] = '□';

                        }

                        if (char2_[usery, userx] == char2_[13, 7])
                        {
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

                                    if (userChoice == "1")
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
                                            Console.WriteLine("배팅에 실패 했습니다. 배팅금을 잃습니다. 남은 베팅금은 {0}원 입니다.", userMoney);
                                        }


                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();



                                        if (0 < userMoney && userMoney < 1000)
                                        {
                                            Console.WriteLine("다음 턴을 시작합니다.");
                                            continue;
                                        }
                                        else if (userMoney >= 1000)
                                        {
                                            Console.WriteLine("플레이어 승리!");
                                            Console.Clear();
                                            goto end1;


                                        }
                                        else if (0 >= userMoney)
                                        {
                                            Console.WriteLine("플레이어 파산....");
                                            Console.Clear();

                                            goto end1;

                                        }
                                        else
                                        {
                                            break;

                                        }

                                    }
                                }
                                char2_[usery, userx + 1] = '□';

                            }
                        }


                    }

                }



                else if ('s' == key.KeyChar || 'S' == key.KeyChar)
                {
                    if (15 > usery)
                    {
                        swap(ref char2_[usery, userx], ref char2_[usery + 1, userx]);
                        usery += 1;

                        if (char2_[usery, userx] == char2_[10, 5])
                        {
                            while (true)
                            {
                                randomMarket = random.Next(0, 10);
                                randomMarket1 = random.Next(0, 10);
                                randomMarket2 = random.Next(0, 10);

                                Console.WriteLine("상점에 들어가려면 Y 인벤토리에 들어가려면 N 을눌러주세요");
                                userchoice = Console.ReadLine();

                                if (userchoice == "Y")
                                {

                                    if (randomMarket != randomMarket1 && randomMarket1 != randomMarket2 && randomMarket != randomMarket2)
                                    {
                                        Console.WriteLine("[상점]");
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber1, item_list[randomMarket].itemName, item_list[randomMarket].itemPrice);
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber2, item_list[randomMarket1].itemName, item_list[randomMarket1].itemPrice);
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber3, item_list[randomMarket2].itemName, item_list[randomMarket2].itemPrice);
                                        Console.WriteLine();
                                        Console.WriteLine();

                                        Console.WriteLine("원하시는 상품을 구입하시려면 해당 상품의 번호를 입력해 주세요");
                                        Console.WriteLine("상점 이용을 그만하시려면 4번을 눌러주세요");
                                        Console.WriteLine();

                                        userchoice1 = Convert.ToInt32(Console.ReadLine());



                                        if (userchoice1 == 1)
                                        {
                                            gold -= item_list[randomMarket].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket].itemName);
                                            continue;

                                        }



                                        else if (userchoice1 == 2)
                                        {
                                            gold -= item_list[randomMarket1].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket1].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket1].itemName);

                                            continue;


                                        }





                                        else if (userchoice1 == 3)
                                        {
                                            gold -= item_list[randomMarket2].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket2].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket2].itemName);

                                            continue;


                                        }





                                        else if (userchoice1 == 4)
                                        {
                                            Console.WriteLine("상점을 나갑니다.");

                                            continue;


                                        }



                                    }

                                }
                                else if (userchoice == "N")
                                {
                                    Console.WriteLine("[인벤토리]");
                                    //Invrntory_list = new List<string>();
                                    for (int i = 0; i < Invrntory_list.Count; i++)
                                    {
                                        Console.WriteLine("{0}", Invrntory_list[i]);

                                    }
                                    Console.WriteLine();


                                }



                            }
                            char2_[usery + 1, userx] = '□';

                        }


                        if (char2_[usery, userx] == char2_[5, 9])
                        {

                            int playerWalk = 0;
                            int randomPlace = 0;
                            int choice;
                            int randomBoss = 0;

                            Console.WriteLine("디아블로 미니게임에 오신걸 환영합니다!\n");
                            Console.WriteLine("게임의 룰을 설명해드리겠습니다.\n");
                            Console.WriteLine("1.플레이어가 6번 이동하면 게임은 클리어됩니다.\n2.중간에 40%확률로 몬스터를 만나서 대결하여 사망한다면 이동횟수는 초기화 됩니다..\n");
                            Console.WriteLine("3.몬스터와의 대결은 자동으로 진행되기 때문에 운빨겜입니다.\n5.60%확률로 자동으로 물약을 먹습니다.");
                            Console.WriteLine("길을 개척하여 세상을 구해보세요!\n\n");
                            Console.WriteLine("플레이어 \n공격력 : 105(크리티컬시 157) \n체력 : 50\n\n");
                            Console.WriteLine("보스 \n공격력 : 7 \n체력 : 1200\n\n\n");




                            while (playerWalk < 7)
                            {

                                //이동질문 그리고 번호 입력
                                Console.WriteLine("이동하시겠습니까?");
                                Console.WriteLine("\n1.yes   2.no\n");
                                choice = Convert.ToInt32(Console.ReadLine());


                                //배틀 코드
                                int PlayerDamage = 105;
                                const int DiabloDamage = 7;
                                int probability = 0;
                                int Diablo = 1200;
                                int Player = 50;
                                float Playercritical = (PlayerDamage * 1.5f);
                                int heal = 4;




                                if (choice == 1 && playerWalk < 6)                                       // 1번을 입력하고 playerWalk가 6 이하일 때 실행 된다.
                                {
                                    randomPlace = random.Next(1, 100);
                                    // 1~100까지 랜덤 숫자를 나오게 하여 randomPlace 확률 결정

                                    if (100 >= randomPlace && randomPlace >= 50)                             // randomPlace 50%확률 조건식
                                    {
                                        Console.WriteLine("아케인 생츄어리로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n\n", playerWalk);

                                        randomBoss = random.Next(1, 100);                              //1~100까지 랜덤숫자를 나오게 하여 randomBoss 확률 결정

                                        if (randomBoss > 60)                                            //40% 확률로 몬스터 출현
                                        {
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("| 디아블로를 만났습니다  |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                                            while (true)  //무한루프
                                            {
                                                Thread.Sleep(1500);  //출력시간 조정
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
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)  //플레이어와 몬스터 둘다 hp가 0이거나 0보다 작을때 플레이어 사망 
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }
                                                else  //플레이어hp가 0 이하면 사망
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                        }
                                        else //몬스터를 만나지 않았을 때 
                                        {
                                            continue;
                                        }

                                        continue;

                                    }
                                    else if (50 > randomPlace && randomPlace >= 30)
                                    {
                                        Console.WriteLine("탈라샤의 무덤으로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n", playerWalk);
                                        randomBoss = random.Next(1, 100);
                                        if (randomBoss > 60)
                                        {

                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("|  듀리엘을 만났습니다.  |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                                            while (true)
                                            {
                                                Thread.Sleep(1500);
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
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                            continue;
                                        }
                                    }
                                    else if (30 > randomPlace && randomPlace > 0)
                                    {
                                        Console.WriteLine("수도원의 묘지로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n", playerWalk);
                                        randomBoss = random.Next(1, 100);
                                        if (randomBoss > 60)
                                        {

                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("|   바알을 만났습니다    |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");


                                            while (true)
                                            {
                                                Thread.Sleep(1500);
                                                probability = random.Next(1, 100);


                                                if (probability > 60 && Diablo > 0 && Player > 0)
                                                {
                                                    Console.WriteLine("플레이어가 공격을 합니다. \n크리티컬입니다! 바알이 정신못차립니다..\n{0}의 데미지를 입혔습니다.\n\n", Playercritical);
                                                    Console.WriteLine("바알이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("|  바알의 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                                    Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                                    continue;
                                                }
                                                else if (probability <= 60 && Diablo > 0 && Player > 0)
                                                {
                                                    Console.WriteLine("플레이어가 공격을 합니다.\n{0}의 데미지를 입혔습니다.\n\n", PlayerDamage);
                                                    Console.WriteLine("바알이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);
                                                    Console.WriteLine("물약을 먹었습니다. hp를 {0} 회복했습니다.\n\n", heal, Player += heal);

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("|  바알의 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                                    continue;
                                                }
                                                else if (Player > 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("바알을 처치했습니다.");
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);
                                                    goto end1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else if (playerWalk == 6) //플레이어 이동횟수가 6번이 되면  클리어 합니다.
                                {
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");

                                    goto end1;

                                }
                                else
                                {
                                    Console.WriteLine("이거 누를 거면 게임왜켰냐 ㅋㅋ\n"); //이동안한다고 하면 출력 
                                    continue;
                                }
                            }

                            char2_[usery, userx + 1] = '□';

                        }


                        if (char2_[usery, userx] == char2_[13, 7])
                        {
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

                                    if (userChoice == "1")
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
                                            Console.WriteLine("배팅에 실패 했습니다. 배팅금을 잃습니다. 남은 베팅금은 {0}원 입니다.", userMoney);
                                        }


                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();



                                        if (0 < userMoney && userMoney < 1000)
                                        {
                                            Console.WriteLine("다음 턴을 시작합니다.");
                                            continue;
                                        }
                                        else if (userMoney >= 1000)
                                        {
                                            Console.WriteLine("플레이어 승리!");
                                            Console.Clear();


                                            goto end1;

                                        }
                                        else if (0 >= userMoney)
                                        {
                                            Console.WriteLine("플레이어 파산....");
                                            Console.Clear();



                                            goto end1;
                                        }
                                        else
                                        {
                                            break;

                                        }

                                        break;
                                    }
                                }
                                char2_[usery, userx + 1] = '□';

                            }
                        }


                    }
                }






                else if ('w' == key.KeyChar || 'W' == key.KeyChar)
                {
                    if (usery > 0)
                    {

                        swap(ref char2_[usery, userx], ref char2_[usery - 1, userx]);
                        usery -= 1;

                        if (char2_[usery, userx] == char2_[10, 5])
                        {
                            while (true)
                            {
                                randomMarket = random.Next(0, 10);
                                randomMarket1 = random.Next(0, 10);
                                randomMarket2 = random.Next(0, 10);

                                Console.WriteLine("상점에 들어가려면 Y 인벤토리에 들어가려면 N 을눌러주세요");
                                userchoice = Console.ReadLine();

                                if (userchoice == "Y")
                                {

                                    if (randomMarket != randomMarket1 && randomMarket1 != randomMarket2 && randomMarket != randomMarket2)
                                    {
                                        Console.WriteLine("[상점]");
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber1, item_list[randomMarket].itemName, item_list[randomMarket].itemPrice);
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber2, item_list[randomMarket1].itemName, item_list[randomMarket1].itemPrice);
                                        Console.WriteLine("{0}.아이템 이름 : {1} ,  아이템 가격 {2}", itemNumber3, item_list[randomMarket2].itemName, item_list[randomMarket2].itemPrice);
                                        Console.WriteLine();
                                        Console.WriteLine();

                                        Console.WriteLine("원하시는 상품을 구입하시려면 해당 상품의 번호를 입력해 주세요");
                                        Console.WriteLine("상점 이용을 그만하시려면 4번을 눌러주세요");
                                        Console.WriteLine();

                                        userchoice1 = Convert.ToInt32(Console.ReadLine());



                                        if (userchoice1 == 1)
                                        {
                                            gold -= item_list[randomMarket].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket].itemName);
                                            continue;

                                        }



                                        else if (userchoice1 == 2)
                                        {
                                            gold -= item_list[randomMarket1].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket1].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket1].itemName);

                                            continue;


                                        }





                                        else if (userchoice1 == 3)
                                        {
                                            gold -= item_list[randomMarket2].itemPrice;
                                            if (gold <= 0)
                                            {
                                                Console.WriteLine("골드가 부족합니다.");
                                                break;
                                            }
                                            Console.WriteLine("{0}을 구매했습니다. 남은 금액은 {1}원입니다", item_list[randomMarket2].itemName, gold);
                                            Invrntory_list.Add(item_list[randomMarket2].itemName);

                                            continue;


                                        }





                                        else if (userchoice1 == 4)
                                        {
                                            Console.WriteLine("상점을 나갑니다.");

                                            continue;


                                        }



                                    }

                                }
                                else if (userchoice == "N")
                                {
                                    Console.WriteLine("[인벤토리]");
                                    //Invrntory_list = new List<string>();
                                    for (int i = 0; i < Invrntory_list.Count; i++)
                                    {
                                        Console.WriteLine("{0}", Invrntory_list[i]);

                                    }
                                    Console.WriteLine();


                                }



                            }
                            char2_[usery - 1, userx] = '□';

                        }

                        if (char2_[usery, userx] == char2_[5, 9])
                        {

                            int playerWalk = 0;
                            int randomPlace = 0;
                            int choice;
                            int randomBoss = 0;

                            Console.WriteLine("디아블로 미니게임에 오신걸 환영합니다!\n");
                            Console.WriteLine("게임의 룰을 설명해드리겠습니다.\n");
                            Console.WriteLine("1.플레이어가 6번 이동하면 게임은 클리어됩니다.\n2.중간에 40%확률로 몬스터를 만나서 대결하여 사망한다면 이동횟수는 초기화 됩니다..\n");
                            Console.WriteLine("3.몬스터와의 대결은 자동으로 진행되기 때문에 운빨겜입니다.\n5.60%확률로 자동으로 물약을 먹습니다.");
                            Console.WriteLine("길을 개척하여 세상을 구해보세요!\n\n");
                            Console.WriteLine("플레이어 \n공격력 : 105(크리티컬시 157) \n체력 : 50\n\n");
                            Console.WriteLine("보스 \n공격력 : 7 \n체력 : 1200\n\n\n");




                            while (playerWalk < 7)
                            {

                                //이동질문 그리고 번호 입력
                                Console.WriteLine("이동하시겠습니까?");
                                Console.WriteLine("\n1.yes   2.no\n");
                                choice = Convert.ToInt32(Console.ReadLine());


                                //배틀 코드
                                int PlayerDamage = 105;
                                const int DiabloDamage = 7;
                                int probability = 0;
                                int Diablo = 1200;
                                int Player = 50;
                                float Playercritical = (PlayerDamage * 1.5f);
                                int heal = 4;




                                if (choice == 1 && playerWalk < 6)                                       // 1번을 입력하고 playerWalk가 6 이하일 때 실행 된다.
                                {
                                    randomPlace = random.Next(1, 100);
                                    // 1~100까지 랜덤 숫자를 나오게 하여 randomPlace 확률 결정

                                    if (100 >= randomPlace && randomPlace >= 50)                             // randomPlace 50%확률 조건식
                                    {
                                        Console.WriteLine("아케인 생츄어리로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n\n", playerWalk);

                                        randomBoss = random.Next(1, 100);                              //1~100까지 랜덤숫자를 나오게 하여 randomBoss 확률 결정

                                        if (randomBoss > 60)                                            //40% 확률로 몬스터 출현
                                        {
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("| 디아블로를 만났습니다  |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                                            while (true)  //무한루프
                                            {
                                                Thread.Sleep(1500);  //출력시간 조정
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
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)  //플레이어와 몬스터 둘다 hp가 0이거나 0보다 작을때 플레이어 사망 
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }
                                                else  //플레이어hp가 0 이하면 사망
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                        }
                                        else //몬스터를 만나지 않았을 때 
                                        {
                                            continue;
                                        }

                                        continue;

                                    }
                                    else if (50 > randomPlace && randomPlace >= 30)
                                    {
                                        Console.WriteLine("탈라샤의 무덤으로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n", playerWalk);
                                        randomBoss = random.Next(1, 100);
                                        if (randomBoss > 60)
                                        {

                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("|  듀리엘을 만났습니다.  |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");

                                            while (true)
                                            {
                                                Thread.Sleep(1500);
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
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                            continue;
                                        }
                                    }
                                    else if (30 > randomPlace && randomPlace > 0)
                                    {
                                        Console.WriteLine("수도원의 묘지로 이동합니다.\n", playerWalk += 1);
                                        Console.WriteLine("{0}번 이동했습니다.\n", playerWalk);
                                        randomBoss = random.Next(1, 100);
                                        if (randomBoss > 60)
                                        {

                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                            Console.WriteLine("|   바알을 만났습니다    |\n");
                                            Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                            Console.WriteLine("------------------------------------------------------------------------------------------\n\n");


                                            while (true)
                                            {
                                                Thread.Sleep(1500);
                                                probability = random.Next(1, 100);


                                                if (probability > 60 && Diablo > 0 && Player > 0)
                                                {
                                                    Console.WriteLine("플레이어가 공격을 합니다. \n크리티컬입니다! 바알이 정신못차립니다..\n{0}의 데미지를 입혔습니다.\n\n", Playercritical);
                                                    Console.WriteLine("바알이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("|  바알의 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
                                                    Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                                    continue;
                                                }
                                                else if (probability <= 60 && Diablo > 0 && Player > 0)
                                                {
                                                    Console.WriteLine("플레이어가 공격을 합니다.\n{0}의 데미지를 입혔습니다.\n\n", PlayerDamage);
                                                    Console.WriteLine("바알이 공격을 합니다.\n{0}의 데미지를 받았습니다.\n\n", DiabloDamage);
                                                    Console.WriteLine("물약을 먹었습니다. hp를 {0} 회복했습니다.\n\n", heal, Player += heal);

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("|  바알의 남은체력 {0}   |\n", Diablo -= (int)Playercritical);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
                                                    Console.WriteLine("| 플레이어 남은체력 {0}   |\n", Player -= DiabloDamage);
                                                    Console.WriteLine("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

                                                    Console.WriteLine("------------------------------------------------------------------------------------------\n");

                                                    continue;
                                                }
                                                else if (Player > 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("바알을 처치했습니다.");
                                                    break;
                                                }
                                                else if (Player <= 0 && Diablo <= 0)
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);
                                                    goto end1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("사망했습니다.", playerWalk = 0);

                                                    goto end1;
                                                }

                                            }
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else if (playerWalk == 6) //플레이어 이동횟수가 6번이 되면  클리어 합니다.
                                {
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
                                    Console.WriteLine("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");

                                    goto end1;

                                }
                                else
                                {
                                    Console.WriteLine("이거 누를 거면 게임왜켰냐 ㅋㅋ\n"); //이동안한다고 하면 출력 
                                    continue;
                                }
                            }
                            char2_[usery, userx + 1] = '□';


                        }


                        if (char2_[usery, userx] == char2_[13, 7])
                        {
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

                                    if (userChoice == "1")
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
                                            Console.WriteLine("배팅에 실패 했습니다. 배팅금을 잃습니다. 남은 베팅금은 {0}원 입니다.", userMoney);
                                        }


                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();



                                        if (0 < userMoney && userMoney < 1000)
                                        {
                                            Console.WriteLine("다음 턴을 시작합니다.");
                                            continue;
                                        }
                                        else if (userMoney >= 1000)
                                        {
                                            Console.WriteLine("플레이어 승리!");
                                            Console.Clear();

                                            goto end1;

                                        }
                                        else if (0 >= userMoney)
                                        {
                                            Console.WriteLine("플레이어 파산....");
                                            Console.Clear();


                                            goto end1;
                                        }
                                        else
                                        {
                                            break;

                                        }

                                    }
                                }
                                char2_[usery, userx + 1] = '□';

                            }
                        }

                    }
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










