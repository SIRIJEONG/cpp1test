using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market
{
    public class Market
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

        public void Initem(string name, int price)
        {



            itemName = name;
            itemPrice = price;
        }
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

        public void ShowItem()
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
        }

    }
}
