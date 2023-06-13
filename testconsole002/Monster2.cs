using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole002
{
    public class Monster2 : MonsterBase
    {
        //public string monsterName = "Lilith";
        //public int monsterHp = 80000;
        //public int monsterMp = 80000;
        //public int monsterDamage = 2000;
        //public int monsterDefence = 2000;
        //public string monsterType = "언데드";
        //캡슐화 -> 필드를  private로 처리해서 외부에서 접근 불가능 하도록 하겠다는 의미 
        // protected는 상속받은 자식 클래스에서는 쓸 수 있도록 하겠다는 의미
        //public string monsterName;
        //public int monsterHp;
        //public int monsterMp;
        //public int monsterDamage;
        //public int monsterDefence;
        //public string monsterType;

        //public override void Initilize(string monsterName, int monsterHp, int monsterMp, int monsterDamage, int monsterDefence, string monsterType)
        //{
        //    this.monsterName = monsterName;
        //    this.monsterHp = monsterHp;
        //    this.monsterMp = monsterMp;
        //    this.monsterDamage = monsterDamage;
        //    this.monsterDefence = monsterDefence;
        //    this.monsterType = monsterType;
        //}
        //public void Print_MonsterDescription()
        //{
        //    Console.WriteLine("몬스터 이름은 {0} 이고 , hp는 {1}, mp는 {2} ,데미지는 {3} ,방어력은{4} , 몬스터 타입은 {5}.", monsterName, monsterHp, monsterMp, monsterDamage, monsterDefence, monsterType);
        //}
    }
}
