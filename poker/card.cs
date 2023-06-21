using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    public class card
    {

        Random random = new Random();
        public string cardpattern;
        public string cardnumber;
        int[] randomcard = new int[7];


        List<card> card_list = default;
        List<string> Computer_list = default;
        List<string> User_list = default;


        public void Incard(string pattern, string number)
        {


            cardpattern = pattern;
            cardnumber = number;
        }







        public void cardGame()
        {

            #region 열지마 변수선언
            card card1 = new card();
            card1.Incard("♠", "A");
            card card2 = new card();
            card2.Incard("♠", "2");
            card card3 = new card();
            card3.Incard("♠", "3");
            card card4 = new card();
            card4.Incard("♠", "4");
            card card5 = new card();
            card5.Incard("♠", "5");
            card card6 = new card();
            card6.Incard("♠", "6");
            card card7 = new card();
            card7.Incard("♠", "7");
            card card8 = new card();
            card8.Incard("♠", "8");
            card card9 = new card();
            card9.Incard("♠", "9");
            card card10 = new card();
            card10.Incard("♠", "10");
            card card11 = new card();
            card11.Incard("♠", "J");
            card card12 = new card();
            card12.Incard("♠", "Q");
            card card13 = new card();
            card13.Incard("♠", "K");

            card card14 = new card();
            card14.Incard("◆", "A");
            card card15 = new card();
            card15.Incard("◆", "2");
            card card16 = new card();
            card16.Incard("◆", "3");
            card card17 = new card();
            card17.Incard("◆", "4");
            card card18 = new card();
            card18.Incard("◆", "5");
            card card19 = new card();
            card19.Incard("◆", "6");
            card card20 = new card();
            card20.Incard("◆", "7");
            card card21 = new card();
            card21.Incard("◆", "8");
            card card22 = new card();
            card22.Incard("◆", "9");
            card card23 = new card();
            card23.Incard("◆", "10");
            card card24 = new card();
            card24.Incard("◆", "J");
            card card25 = new card();
            card25.Incard("◆", "Q");
            card card26 = new card();
            card26.Incard("◆", "K");

            card card27 = new card();
            card27.Incard("♥", "A");
            card card28 = new card();
            card28.Incard("♥", "2");
            card card29 = new card();
            card29.Incard("♥", "3");
            card card30 = new card();
            card30.Incard("♥", "4");
            card card31 = new card();
            card31.Incard("♥", "5");
            card card32 = new card();
            card32.Incard("♥", "6");
            card card33 = new card();
            card33.Incard("♥", "7");
            card card34 = new card();
            card34.Incard("♥", "8");
            card card35 = new card();
            card35.Incard("♥", "9");
            card card36 = new card();
            card36.Incard("♥", "10");
            card card37 = new card();
            card37.Incard("♥", "J");
            card card38 = new card();
            card38.Incard("♥", "Q");
            card card39 = new card();
            card39.Incard("♥", "K");


            card card40 = new card();
            card40.Incard("♣", "A");
            card card41 = new card();
            card41.Incard("♣", "2");
            card card42 = new card();
            card42.Incard("♣", "3");
            card card43 = new card();
            card43.Incard("♣", "4");
            card card44 = new card();
            card44.Incard("♣", "5");
            card card45 = new card();
            card45.Incard("♣", "6");
            card card46 = new card();
            card46.Incard("♣", "7");
            card card47 = new card();
            card47.Incard("♣", "8");
            card card48 = new card();
            card48.Incard("♣", "9");
            card card49 = new card();
            card49.Incard("♣", "10");
            card card50 = new card();
            card50.Incard("♣", "J");
            card card51 = new card();
            card51.Incard("♣", "Q");
            card card52 = new card();
            card52.Incard("♣", "K");
            #endregion 



            card_list = new List<card>();

            #region 열지마리스트
            
            card_list.Add(card1);
            card_list.Add(card2);
            card_list.Add(card3);
            card_list.Add(card4);
            card_list.Add(card5);
            card_list.Add(card6);
            card_list.Add(card7);
            card_list.Add(card8);
            card_list.Add(card9);
            card_list.Add(card10);
            card_list.Add(card11);
            card_list.Add(card12);
            card_list.Add(card13);
            card_list.Add(card14);
            card_list.Add(card15);
            card_list.Add(card16);
            card_list.Add(card17);
            card_list.Add(card18);
            card_list.Add(card19);
            card_list.Add(card20);
            card_list.Add(card21);
            card_list.Add(card22);
            card_list.Add(card23);
            card_list.Add(card24);
            card_list.Add(card25);
            card_list.Add(card26);
            card_list.Add(card27);
            card_list.Add(card28);
            card_list.Add(card29);
            card_list.Add(card30);
            card_list.Add(card31);
            card_list.Add(card32);
            card_list.Add(card33);
            card_list.Add(card34);
            card_list.Add(card35);
            card_list.Add(card36);
            card_list.Add(card37);
            card_list.Add(card38);
            card_list.Add(card39);
            card_list.Add(card40);
            card_list.Add(card41);
            card_list.Add(card42);
            card_list.Add(card43);
            card_list.Add(card44);
            card_list.Add(card45);
            card_list.Add(card46);
            card_list.Add(card47);
            card_list.Add(card48);
            card_list.Add(card49);
            card_list.Add(card50);
            card_list.Add(card51);
            card_list.Add(card52);
            #endregion

            Computer_list = new List<string>();
            User_list = new List<string>();


            
        }







        public void showGame()
        {



            while (Computer_list.Count < 7)
            {

               int  randomcard =  random.Next(0, 52);
                    int nonSame = 0;


                string computer_list3 = card_list[randomcard].cardpattern + card_list[randomcard].cardnumber;


                    if(Computer_list.Count == 0)
                    {
                        Computer_list.Add(computer_list3);

                    }
                for (int i = 0; i < Computer_list.Count; i++)
                {

                    if (!Computer_list[i].Contains(computer_list3))
                    {
                        nonSame += 1; 
                    }

                    if (nonSame == Computer_list.Count)
                    {
                        Computer_list.Add(computer_list3);
                    }
                }

            }


            while (User_list.Count < 5)
            {
                
                int randomcard = random.Next(0, 52);
                    int nonSame = 0;

                string User_list3 = card_list[randomcard].cardpattern + card_list[randomcard].cardnumber;

                    if(User_list.Count == 0)
                    {
                        User_list.Add(User_list3);

                    }
                for (int i = 0; i < User_list.Count; i++)
                {


                    if (!User_list[i].Contains(User_list3))
                    {
                        nonSame += 1;
                    }
                    if (nonSame == User_list.Count)
                    {
                        User_list.Add(User_list3);
                    }
                }

                if(Computer_list.Contains(User_list3))
                {
                    User_list.Remove(User_list3);
                }

            }


            
                int turn = 0;

            Console.WriteLine("Computer");
            while (true)
            {
                Console.SetCursorPosition(0, 0);


                Console.WriteLine("Computer");

                for (int i = 0; i < Computer_list.Count; i++)
                {
                    
                    Computer_list.Sort();

                    Console.Write("{0} ", Computer_list[i]);

                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("User");

                for (int i = 0; i < User_list.Count; i++)
                {
                    User_list.Sort();
                    Console.Write("{0} ",User_list[i]);

                }

                Console.WriteLine();
                Console.WriteLine();


                Console.Write("바꿀 카드 순서를 입력해주세요 / ");
                Console.Write("바꿀 카드가 없다면 0을 눌러주세요 ");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                int swapcard = random.Next(0,52);

                string swapcard_list = card_list[swapcard].cardpattern + card_list[swapcard].cardnumber;

                if (userChoice == 1)
                {
                    if (User_list != null)
                    {

                    swap(ref User_list,0, ref swapcard_list);
                        turn ++;
                    }
                }
                if (userChoice == 2)
                {
                    if (User_list != null)
                    {

                        swap(ref User_list, 1, ref swapcard_list);
                        turn++;

                    }
                }
                if (userChoice == 3)
                {
                    if (User_list != null)
                    {

                        swap(ref User_list, 2, ref swapcard_list);
                        turn++;

                    }
                }
                if (userChoice == 4)
                {
                    if (User_list != null)
                    {

                        swap(ref User_list, 3, ref swapcard_list);
                        turn++;

                    }
                }
                if (userChoice == 5)
                {
                    if (User_list != null)
                    {

                        swap(ref User_list, 4, ref swapcard_list);
                        turn++;

                    }
                }



                if(userChoice == 0)
                {
                    break;

                }

                if (turn == 3)
                {
                    break;
                }

                

            }

        }

        public void swap(ref List<string> userList, int index_, ref string secondChar)
        {
            string temp = "0";
            temp = (userList[index_]);
            (userList[index_]) = (secondChar);
            (secondChar) = temp;
        }

            public void swap(ref string firstChar, ref string secondChar)
            {
                string temp = "0";
                temp = (firstChar);
                (firstChar) = (secondChar);
                (secondChar) = temp;
            }


        public void onepair()
        {
            //List<int>

                Console.WriteLine("onepair");
            
        }


        public void twopair()
        {

                Console.WriteLine("onepair");
            
        }
        

    }
}
