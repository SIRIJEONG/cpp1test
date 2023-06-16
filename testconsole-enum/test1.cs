using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole_enum
{
    internal class test1
    {

        public string itemName;
        public int itemCount { get; set; }
        private int _itemPrice;


        public int Itemprice
        {

            get
            {
                return _itemPrice;
            }

            private set
            {
                _itemPrice = value;
            }
        }

        public void Initem(string name, int price , int count)
        {
            itemName = name;
            itemCount = count;
            Itemprice = price;
        }

        //! 아이템 name 을 return해보겠음
        public string Get_ItemName()
        {
            return itemName;

        }//Get_ItemName()


        //아이템 name을 외부에서 변경할 수있게  해주겠음 
        public void Set_ItemName(string changedNAme)
        {
            itemName= changedNAme;
        } //Set_ItemName()
    }
}
