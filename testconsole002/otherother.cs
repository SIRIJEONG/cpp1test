using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole002
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int userChoice;
            int computerChoice = default;
            char[] number = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            computerChoice = (char)random.Next(0, 9);


            while (true)
            {
                Console.Clear();
                Console.WriteLine("user : O computer : X 로 진행됩니다.");
                Console.Write("원하는 칸의 번호를 입력해 주세요 : ");
                userChoice = Console.ReadLine()[0];

                userChoice = Convert.ToChar(userChoice);


                if (number[userChoice] == number[computerChoice])
                {
                    continue;
                }
                else if (number[userChoice] != number[computerChoice])
                {
                    number[userChoice] = 'O';
                    number[computerChoice] = 'X';
                    continue;

                }





                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();





                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("     {0}      |      {1}        |       {2}   ", number[0], number[1], number[2]);
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("     {0}      |      {1}        |       {2}   ", number[3], number[4], number[5]);
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");
                Console.WriteLine("     {0}      |      {1}        |       {2}   ", number[6], number[7], number[8]);
                Console.WriteLine("            |               |            ");
                Console.WriteLine("            |               |            ");


                if (number[0] == number[1] && number[1] == number[2])
                {
                    Console.WriteLine("승리하였습니다.");
                }
                else if (number[3] == number[4] && number[4] == number[5])
                {
                    Console.WriteLine("승리하였습니다.");
                }
                else if (number[6] == number[7] && number[7] == number[8])
                {
                    Console.WriteLine("승리하였습니다.");
                }
                else if (number[0] == number[3] && number[3] == number[6])
                {
                    Console.WriteLine("승리하였습니다.");
                }
                else if (number[1] == number[4] && number[4] == number[7])
                {
                    Console.WriteLine("승리하였습니다.");
                }
                else if (number[2] == number[5] && number[5] == number[8])
                {
                    Console.WriteLine("승리하였습니다.");
                }
                else if (number[0] == number[4] && number[4] == number[8])
                {
                    Console.WriteLine("승리하였습니다.");
                }
                else if (number[2] == number[4] && number[4] == number[6])
                {
                    Console.WriteLine("승리하였습니다.");
                }
                else
                {
                    continue;
                }


            }


            //SecretCodeGame MyComputerCode = new SecretCodeGame();
            //MyComputerCode.ComputerCode();

            //Dog myDog = new Dog();
            //Console.WriteLine("우리집 강아지 이름은 : {0} 이고 , 다리 갯수는 {1}개 이다." , myDog.dogName , myDog.legCount);

            //myDog.Print_DogDescription();

            //Dog.Print_DogDescription002();

            //Cat myCat = new Cat(4, "야옹이" , "검정색");
            //myCat.print_MyCat();
            //myCat.catName = "새로운 야옹이";
            //myCat.print_MyCat();


            //Monster theMonster = new Monster();
            //theMonster.Initilize("Diablo", 50000, 50000, 1000, 1000, "데몬");
            //theMonster.Print_MonsterDescription();
            //Console.WriteLine();

            //Monster2 theMonster1 = new Monster2();
            //theMonster1.Initilize("Lilith", 80000, 80000, 2000, 2000, "언데드");
            //theMonster1.Print_MonsterDescription();

            //Console.WriteLine();


            //Monster3 theMonster2 = new Monster3();
            //theMonster2.Initilize("Andariel", 30000, 30000, 1000, 600, "부활자");
            //theMonster2.Print_MonsterDescription();











            //Console.WriteLine();

            //string[] str = new string[2] { "Hello", "world" };
            ////CallFunc001(str);
            ////CallFunc002("Hello ", "world", " + ", "hello ", "world");
            ////CallFunc003(ref str);

            //string[] resultStr;  //string 배열을 선언함 
            //CallFunc004(str, out resultStr);  //out을 활용해서 값을 넘겨 받음
            //foreach (string result_ in resultStr)
            //{
            //    Console.Write("{0}", result_);
            //}
            //Console.WriteLine();


            //int number = 0;
            //number = number++;
            //Console.WriteLine("number는 무슨 값이 들어 있나? {0}" , number);

        } // main

        // ! 네 번째 방법도 매개변수를 call by reference 방식으로 넘기는 방법
        // ! 매개변수를 통해서 값은 return한다.
        static void CallFunc004(string[] str, out string[] outstr)
        {
            string[] resultString = new string[str.Length + 1];

            for (int i = 0; i < str.Length; i++)
            {
                resultString[i] = str[i];
            }
            resultString[str.Length] = "!";
            outstr = resultString;
        } //CallFunc004



        // ! 세 번째 방법은 매개변수를 call by reference 방식으로 넘기는 방법 
        static void CallFunc003(ref string[] str)
        {
            foreach (string strElement in str)
            {
                Console.WriteLine("{0}", strElement);
            }
            Console.WriteLine();

        } //CallFunc003




        // ! 두 번째 방법은 매개변수를 call by value 방식으로 넘기는 건 똑같음 그런데 넘겨줄
        // ! 매개변수를 배열의 요소 형태로 여러개 넘길 수 있다. 
        static void CallFunc002(params string[] str)
        {
            foreach (string strElement in str)  //str이 몇 번 반복하는지 정해준다. 컬렉션이 비어있을 때 까지 루프를 돈다. 
            {
                Console.Write("{0}", strElement);
            }
            Console.WriteLine();
        }//CallFunc002





        // ! 첫 번째 방법법은 매개변수를 call by value 방식으로 넘기는 방법 
        static void CallFunc001(string[] str)
        {
            foreach (string strElement in str)  //str이 몇 번 반복하는지 정해준다. 컬렉션이 비어있을 때 까지 루프를 돈다. 
            {
                foreach (char char_ in strElement)
                {
                    Console.Write("{0}", strElement);
                }
            }
            Console.WriteLine();
        } //CallFunc001



    } // class 
}
