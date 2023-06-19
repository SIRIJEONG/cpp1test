using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    public class Program
    {


        // 컴퓨터는  7장을 받고 플레이어는 5장을 받는다 플레이어는 카드를 보고 베팅한다 
        // 플레이어는 5장중 2장을 다른 카드로 교체한다
        // 결과는 포커의 족보로 비교한다.
        // 플레이어가 승리한경우 플레이어는 1번의 게임을 승리하여 베팅점수의 두배를 얻는다
        // 컴퓨터가 승리한 경우 플레이어는 1번의 게임을 패배하여 베팅점수를 잃는다 
        // 플레이어는 일정 점수를 얻게 된다면 승리한다. 0점 이하인 경우 게임을 최종 패배한다, 이경우 게임을 종료한다,.  
        static void Main(string[] args)
        {

            card mycard = new card();
            mycard.cardGame();
            mycard.showGame();


        }
    }
}
