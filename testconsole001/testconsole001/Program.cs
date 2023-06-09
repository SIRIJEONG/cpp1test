using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace testconsole001
{
    public class Program
    {
        static void Main(string[] args)
        {
            //실습 플레이어와 컴퓨터가 각각 카드를 2장씩 뽑는다. 두 카드의 합이 더 큰 쪽이 승리 , 작은 쪽은 패배한다.
            //동일한 숫자가 나올 경우 문양은 -> 스페이드 , 다이아몬드 , 하트 ,클로버 순서로 승리한다. 

            //Description001();


            Random random = new Random();
            int[] lottos = new int[2];
            char[] card = new char[4];
            char[] number = new char[4];
            int[] lottos2 = new int[2];
            int[] computer = new int[2];
            int[] computer2 = new int[2];






            for (int i = 0; i < 2; i++)
                {

                    number[0] = 'A';
                    number[1] = 'J';
                    number[2] = 'Q';
                    number[3] = 'K';
                    lottos[i] = random.Next(0, 13);
                    //lottos2[i] = random.Next(1, 13);

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

            Console.WriteLine();
            Console.WriteLine();





            for (int i = 0; i < 2; i++)
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
                else if (computer[i] % 13 == 10)
                {
                    Console.Write("{0} ", number[1]);
                    continue;

                }
                else if (computer[i] % 13 == 11)
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




            for (int i = 0; i < 52; i++)
            {

                card[0] = '♠';
                card[1] = '◇';
                card[2] = '♡';
                card[3] = '♣';

                computer2[i] = random.Next(1, 52);

                if (lottos2[i] % 4 == 0)
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


            }







            //foreach (int lottos_ in lottos)
            //{
            //    Console.Write("{0} ", lottos_);
            //    //Task.Delay(1000).Wait();
            //}
            //Console.WriteLine();



        }
             

            //int[] numbers = new int[5];
            //int[,] numbers2 = new int[5, 5];

            //int valueCount = 0;


            //for(int y = 0; y < 5; y ++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        valueCount++;
            //        numbers2[y, x] = valueCount;
            //        //Console.WriteLine("numbers[{0}][{0}] 의값 : {1} \n", y,x, numbers2[y,x]);
            //    }
            //}

            ////for (int y = 0; y < 5; y++)
            ////{
            ////    for (int x = 0; x < 5; x++)
            ////    {
            ////        Console.Write("{0} " , numbers2[y, x]);
            ////    }
            ////    Console.WriteLine();
            ////}
            ////Console.WriteLine();    
            //PrintMyArray(numbers2);


    }


       //static void PrintMyArray(int[,] array_)
       // {

       //     for (int y = 0; y < 5; y++)
       //     {
       //         for (int x = 0; x < 5; x++)
       //         {
       //             Console.Write("{0} ", array_[y, x]);
       //         }
       //         Console.WriteLine();
       //     }
       //     Console.WriteLine();

       // }





        //static void Description001()
        //{
        //    Console.WriteLine("Hello Woeld! \n");

        //    string userInput1 = default;
        //    string userInput2 = default;

        //    int number = default;
        //    float floatNumber = default;

        //    int userNumber1 = default;
        //    int userNumber2 = default;

        //    //여기서 입력을 받는다. 
        //    userInput1 = Console.ReadLine();
        //    userInput2 = Console.ReadLine();

        //    //입력받은 것을 숫자로 변환한다.
        //    //userNumber1 = int.Parse(userInput1);
        //    //userNumber2 = int.Parse(userInput2);

        //    //userNumber1 = System.Convert.ToInt32(userInput1);
        //    //userNumber2 = System.Convert.ToInt32(userInput2);

        //    int.TryParse(userInput1, out userNumber1);
        //    int.TryParse(userInput2, out userNumber2);


        //    Console.WriteLine("{0} + {1} = {2} \n", userNumber1, userNumber2, userNumber1 + userNumber2);
        //    //Console.WriteLine("입력받은 내용을 출력하고 싶어 -> {1} , {0} \n\n", userInput1, userInput2);
        //}





}

