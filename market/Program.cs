using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



//상점과 인벤토리 시스템 만들기 
//아이템을 저장하고있는 컬렉션을 만들고 
// 상점을 열면 -> 위의 컬렉션에서 랜덤으로 3가지 종류의 아이템을 출력한다 
// 상점을 일정시간 (or열때 마다 ) 아이템의 종류가 바뀐다. 
// 플레이어는 가지고 있는 골드의 범위안에서 아이템을 구매할 수있다. 
// 구매한 아이템은 플레이어의 인벤토리로 들어가고 , 출력해서 볼 수 있다. 
// 아이템 갯수 제한은 따로 없음 


namespace market
{
    internal class Program
    {
        static void Main(string[] args)
        {


            itemInfo item1 = new itemInfo();
            //item1.Initem();
            item1.itemMarket();
            item1.ShowItem();



        }
    }
}
