using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stone2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stone22 stone = new Stone22();
            stone.numberPush();
        }
    }
}
//if ('s' == key.KeyChar || 'S' == key.KeyChar)
//{
//    if (userx < userInput - 1)
//    {
//        for (int y = 0; y < userInput-1; y++)
//        {
//            for (int x = 0; x < userInput; x++)
//            {

//                if (char2_[y, x] == 1 && char2_[userInput-1, x] == 0)
//                {

//                    char2_[y, x] = 0;


//                    char2_[userInput - 1, x] = 1;
//                }
//                else if (char2_[y, x] == 1 && char2_[userInput - 1, x] > 0)
//                {
//                    char2_[y, x] = 0;

//                    char2_[userInput - 1, x] += 1;
//                }

//            }
//        }
//    }


//}
