using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole004
{
    public class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> myInventory = new Dictionary<string, int>();
            myInventory.Add("빨간포션", 5);
            myInventory.Add("골드", 500);
            myInventory.Add("몰락한 왕의 검", 1);
            //Print001 printClass = new Print001();
            //printClass.PrintMessage("Hello world!");

            //Print002.PrintMessage("Hello!");

            itemInfo redpotion = new itemInfo();
            redpotion.Initem("빨간포션", 5, 100);
            itemInfo gold = new itemInfo();
            gold.Initem("골드", 500, 1);
            itemInfo sword = new itemInfo();
            sword.Initem("몰락한 왕의 검", 1, 39800);

            Dictionary<string , itemInfo> myInvrntory2 = new Dictionary<string , itemInfo>();
            myInvrntory2.Add("빨간포션", redpotion);
            myInvrntory2.Add("골드", gold);
            myInvrntory2.Add("몰락한 왕의 검", sword);
            

            foreach(var item in myInvrntory2)
            {
                Console.WriteLine("아이템 이름 : {0} , 아이템 갯수 : {1} , 아이템 가격 {2}", item.Value.itemName , item.Value.itemCount , item.Value.itemPrice) ;
            }

            //foreach (KeyValuePair<string, int> item in myInventory)
            //{
            //    Console.WriteLine("아이템 이름 : {0} , 아이템 갯수 : {1}", item.Key, item.Value);
            //}
            //Console.WriteLine("아이템 갯수 : {0}", myInventory["빨간포션"]);

            Stack<int> stacknumbers = new Stack<int>();
            stacknumbers.Push(1);
            stacknumbers.Pop();
        }

        public static void Desc001()
        {

            Print001.staticMessage = "여기 값이 들어가나?";
            Console.WriteLine(Print001.staticMessage);

            List<int> numbers = new List<int>();
            Console.WriteLine("내 리스트의 크기는 몇일까? -> {0}", numbers.Count);

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i + 1);
            }
            foreach (int n in numbers)
            {
                Console.Write("{0}", n);
            }
            Console.WriteLine();

            Console.WriteLine("내 리스트의 크기는 몇일까? -> {0}", numbers.Count);

            Console.WriteLine();


            for (int i = numbers.Count - 1; 0 <= i; i--)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("[데이터 지우는 중] 내가 지우려는 데이터 -> {0}", numbers[i]);
                    Console.WriteLine("[데이터 지우는 중] 내 리스트의 크기는 -> {0}", numbers.Count);
                    numbers.RemoveAt(i);
                }

            }

        }


        } //main
    }




//상점과 인벤토리 시스템 만들기 
//아이템을 저장하고있는 컬렉션을 만들고 
// 상점을 열면 -> 위의 컬렉션에서 랜덤으로 3가지 종류의 아이템을 출력한다 
// 상점을 일정시간 (or열때 마다 ) 아이템의 종류가 바뀐다. 
// 플레이어는 가지고 있는 골드의 범위안에서 아이템을 구매할 수있다. 
// 구매한 아이템은 플레이어의 인벤토리로 들어가고 , 출력해서 볼 수 있다. 
// 아이템 갯수 제한은 따로 없음 
