using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0619tsetconsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parent myParent = new Parent();
            Child myChild = new Child();

            //myParent.PrintFos();
            //myChild.PrintFos();

            Parent tempParent = myChild;  // 업캐스팅 
            Child tempChild = (Child)tempParent; // 다운캐스팅 
            //Child tempChild = (Child)myParent; // 오류뜸 



            tempParent.PrintFos();
            tempChild.PrintFos();


            int number = 10;
            number.PlusAndPrint(5);
            
        }
        static void Desc001()
        {
            int number = 10;
            char charValue = 'A';
            string textStr = "Hello World!";

            object canSaveAll = number;  // object상위변수  = 하위변수 
            object canSaveAll1 = charValue;
            object canSaveAll2 = textStr;

            var canSaveAnything1 = canSaveAll;
            var canSaveAnything2 = charValue;
            var canSaveAnything3 = textStr;    //리플렉션이 일어나고 있다. //추론하는 기능 


            int number2 = (int)canSaveAll; // 언박싱   // 박싱과 언박싱은 변수에서만 사용한다. 

            Console.WriteLine(number2);
            Console.WriteLine(canSaveAll1);
            Console.WriteLine(canSaveAll2);

        }
    }
}
