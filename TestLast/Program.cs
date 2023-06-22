using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLast
{
    public class Program
    {
        static void Main(string[] args)
        {

            Desc1();

            ////튜플 선언하는 법 
            //(int xpos , int ypos)playerPosition = (0,1);

            //playerPosition.xpos = 10;
            //playerPosition.ypos = 20;

            //Console.WriteLine("Player position ({0} , {1})" , playerPosition.xpos , playerPosition.ypos);
            //(playerPosition.xpos, playerPosition.ypos) = (playerPosition.ypos, playerPosition.xpos);
            //Console.WriteLine("Player position ({0} , {1})", playerPosition.xpos, playerPosition.ypos);


        }




        static void Desc2()
        {
            string strValue = "I am a boy";
            string[] strArray = strValue.Split(' ');

            Console.WriteLine("몇 개로 split 되었는가 -> {0}", strArray.Count());
            Console.WriteLine();

            foreach (string str_ in strArray)
            {
                Console.WriteLine("{0}", str_);
            }

            int? number = null;

        }




        static void Desc1()
        {
            List<int> intList = new List<int>();
            CustomClass customClass = new CustomClass();
            CustomClass customClass2 = null;
            
            
            CustomChild customChild = new CustomChild();
            CustomChild customChild2 = default;
            CustomChild customChild3 = new CustomChild();






            customClass2 = customChild;

            customChild.Initialize(0, 1);

            //customChild3.Initialize(customChild.xPos, customChild.yPos);

            customChild2.PrintPosition();

            //PrintValue(customChild);


            //customChild = null;
            //if(customChild ==  null)
            //{
            //    Console.WriteLine("customChild는 null 입니다");
            //}
            //else
            //{
            //    customChild.PrintPosition();
            //}

            //customChild?.PrintPosition();
        }

        static void PrintValue<T>(T anyValue) where T : CustomClass  //이름은 내마음 대로 
        {

            anyValue.PrintPosition();
        }

        //static void PrintValue(int intValue)
        //{
        //    Console.WriteLine("int 매개변수로 넘겨 받은 값을 출력했다. -> {0}" , intValue);
        //}
        //static void PrintValue(float floatValue)
        //{
        //    Console.WriteLine("float 매개변수로 넘겨 받은 값을 출력했다. -> {0}", floatValue);
        //}
        //static void PrintValue(string strValue)
        //{
        //    Console.WriteLine("str 매개변수로 넘겨 받은 값을 출력했다. -> {0}", strValue);
        //}
    }
}
