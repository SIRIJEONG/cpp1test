using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole004
{
    public class itemInfo
    {
        public string itemName;
        public int itemCount;
        public int itemPrice;

        public void Initem(string name , int count , int price)
        {
            itemName = name;
            itemCount = count;
            itemPrice = price;
        }
    }
}
