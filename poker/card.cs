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
        public int cardnumber;
        int[] randomcard = new int[7];


        List<card> card_list = default;
        List<string> Computer_list = default;
        List<int> Computer_list1 = default;


        public void Incard(string pattern, int number)
        {


            cardpattern = pattern;
            cardnumber = number;
        }







        public void cardGame()
        {

            #region 열지마 변수선언
            card card1 = new card();
            card1.Incard("♠", 1);
            card card2 = new card();
            card2.Incard("♠", 2);
            card card3 = new card();
            card3.Incard("♠", 3);
            card card4 = new card();
            card4.Incard("♠", 4);
            card card5 = new card();
            card5.Incard("♠", 5);
            card card6 = new card();
            card6.Incard("♠", 6);
            card card7 = new card();
            card7.Incard("♠", 7);
            card card8 = new card();
            card8.Incard("♠", 8);
            card card9 = new card();
            card9.Incard("♠", 9);
            card card10 = new card();
            card10.Incard("♠", 10);
            card card11 = new card();
            card11.Incard("♠", 11);
            card card12 = new card();
            card12.Incard("♠", 12);
            card card13 = new card();
            card13.Incard("♠", 13);

            card card14 = new card();
            card14.Incard("◆", 1);
            card card15 = new card();
            card15.Incard("◆", 2);
            card card16 = new card();
            card16.Incard("◆", 3);
            card card17 = new card();
            card17.Incard("♠", 4);
            card card18 = new card();
            card18.Incard("◆", 5);
            card card19 = new card();
            card19.Incard("◆", 6);
            card card20 = new card();
            card20.Incard("◆", 7);
            card card21 = new card();
            card21.Incard("◆", 8);
            card card22 = new card();
            card22.Incard("◆", 9);
            card card23 = new card();
            card23.Incard("◆", 10);
            card card24 = new card();
            card24.Incard("◆", 11);
            card card25 = new card();
            card25.Incard("◆", 12);
            card card26 = new card();
            card26.Incard("◆", 13);

            card card27 = new card();
            card27.Incard("♥", 1);
            card card28 = new card();
            card28.Incard("♥", 2);
            card card29 = new card();
            card29.Incard("♥", 3);
            card card30 = new card();
            card30.Incard("♠", 4);
            card card31 = new card();
            card31.Incard("♥", 5);
            card card32 = new card();
            card32.Incard("♥", 6);
            card card33 = new card();
            card33.Incard("♥", 7);
            card card34 = new card();
            card34.Incard("♥", 8);
            card card35 = new card();
            card35.Incard("♥", 9);
            card card36 = new card();
            card36.Incard("♥", 10);
            card card37 = new card();
            card37.Incard("♥", 11);
            card card38 = new card();
            card38.Incard("♥", 12);
            card card39 = new card();
            card39.Incard("♥", 13);


            card card40 = new card();
            card40.Incard("♣", 1);
            card card41 = new card();
            card41.Incard("♣", 2);
            card card42 = new card();
            card42.Incard("♣", 3);
            card card43 = new card();
            card43.Incard("♣", 4);
            card card44 = new card();
            card44.Incard("♣", 5);
            card card45 = new card();
            card45.Incard("♣", 6);
            card card46 = new card();
            card46.Incard("♣", 7);
            card card47 = new card();
            card47.Incard("♣", 8);
            card card48 = new card();
            card48.Incard("♣", 9);
            card card49 = new card();
            card49.Incard("♣", 10);
            card card50 = new card();
            card50.Incard("♣", 11);
            card card51 = new card();
            card51.Incard("♣", 12);
            card card52 = new card();
            card52.Incard("♣", 13);
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
            Computer_list1 = new List<int>();

        }







        public void showGame()
        {



            for (int i = 0; i < 7; i++)
            {
                randomcard[i] = random.Next(0, 52);

                Computer_list.Add(card_list[randomcard[i]].cardpattern);
                Computer_list1.Add(card_list[randomcard[i]].cardnumber);


            }

            for (int i = 0;i < Computer_list.Count; i++) 
            {
                Console.Write("{0}", Computer_list[i]);
                Console.Write("{0} ", Computer_list1[i]);

            }



        }
    }
}
