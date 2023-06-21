using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Potal
{
    public class Gate
    {
        int userx = 0;
        int usery = 0;

        int usera = 7;
        int userb = 13;

        System.ConsoleKeyInfo key = default;

        public void passPotal()
        {


            char[,] char2_ = new char[15, 15];


            first:

            for (int y = 0; y < 15; y++)
            {
                for (int x = 0; x < 15; x++)
                {
                    if (x == 0 && y == 0)
                    {
                        char2_[x, y] = '♣';
                        continue;
                    }

                    char2_[y, x] = 'ㅤ';
                }
            }

            char2_[7, 14] = '■';
            char2_[7, 0] = '■';
            char2_[0, 7] = '■';
            char2_[14, 7] = '■';



            while (true)
            {



                

                Console.SetCursorPosition(0, 0);

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
                        else if (char2_[y, x] == '■')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
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

                        if (char2_[usery, userx - 1] == '■')
                        {
                            char2_[usery, userx - 1] = 'ㅤ';

                        }


                        swap(ref char2_[usery, userx], ref char2_[usery, userx - 1]);
                        userx -= 1;

                        if(char2_[usery, userx] == char2_[7,0])
                        {
                            //char2_[7, 13] = '♣';

                            //while (true)
                            //{

                            //swap(ref char2_[usera, userb], ref char2_[usera, userb - 1]);
                            //userb -= 1;

                            //}

                            char2_[7, 14] = '■';
                            char2_[usery, userx+13] = '♣';
                            char2_[7, 0] = 'ㅤ';
                            char2_[0, 7] = 'ㅤ';
                            char2_[14, 7] = 'ㅤ';



                        }


                        


                    }
                }





                else if ('d' == key.KeyChar || 'D' == key.KeyChar)
                {
                    if (userx < 14)
                    {

                        if (char2_[usery, userx + 1] == '■')
                        {
                            char2_[usery, userx + 1] = 'ㅤ';

                        }


                        swap(ref char2_[usery, userx], ref char2_[usery, userx + 1]);
                        userx += 1;

                        if (char2_[usery, userx] == char2_[7, 14])
                        {

                            char2_[7, 0] = '■';
                            char2_[usery, userx-13] = '♣';
                            char2_[7, 14] = 'ㅤ';
                            char2_[0, 7] = 'ㅤ';
                            char2_[14, 7] = 'ㅤ';



                        }



                    }

                }



                else if ('s' == key.KeyChar || 'S' == key.KeyChar)
                {
                    if (14 > usery)
                    {


                        if (char2_[usery + 1, userx] == '■')
                        {
                            char2_[usery + 1, userx] = 'ㅤ';

                        }


                        swap(ref char2_[usery, userx], ref char2_[usery + 1, userx]);
                        usery += 1;


                        if (char2_[usery, userx] == char2_[14, 7])
                        {

                            char2_[0, 7] = '■';
                            char2_[usery - 13, userx] = '♣';
                            char2_[14, 7] = 'ㅤ';
                            char2_[7, 0] = 'ㅤ';
                            char2_[7, 14] = 'ㅤ';




                        }



                    }
                }






                else if ('w' == key.KeyChar || 'W' == key.KeyChar)
                {
                    if (usery > 0)
                    {


                        if (char2_[usery - 1, userx] == '■')
                        {
                            char2_[usery -1 , userx] = 'ㅤ';

                        }


                        swap(ref char2_[usery, userx], ref char2_[usery - 1, userx]);
                        usery -= 1;


                        if (char2_[usery, userx] == char2_[0, 7])
                        {

                            char2_[14, 7] = '■';
                            char2_[usery + 13, userx] = '♣';
                            char2_[0, 7] = 'ㅤ';
                            char2_[7, 0] = 'ㅤ';
                            char2_[7, 14] = 'ㅤ';



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
