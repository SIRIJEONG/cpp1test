using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWall
{
    public class Program
    {

        //1. 맵 내부에 벽이 랜ㄷㅁ한 위치에 생선된다.
        //2. 벽은 장애물이 되어서 플레이어의 이동을 방해하는 수단으로 사용이 된다. 
        //3. 플레이어는 특정한 위치에 초기화된다. 
        //4. 적은 일정 시간 혹은 턴마다 1명씩 추가 된다.
        //5.적은 플레이어가 입력을 받을 때 마다 플에이어 방향으로 한칸 이동한다.
        //6. 플레이어가 이동한 횟수를 점수로 처리한다. 
        //(hard)  콘솔이 켜져있는 동안 플레이어의 best score를 출력한다.
        static void Main(string[] args)
        {
            WallRun wallRun = new WallRun();
            wallRun.Wall();
        }
    }
}
