using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole002
{

    public class Monster : MonsterBase
    {
        //클래스 작성 실습해보기
        //본인이 만들고 싶은 몬스터 클래스 3개 만들 것 
        //몬스터 이름 ,hp , mp , damage , defence , 몬스터 타입
        //위에 저장된 값을 출력하는 함수를 클래스 내부에 구현할 것 
        //public string monsterName = "Diablo";
        //public int monsterHp = 50000;
        //public int monsterMp = 50000;
        //public int monsterDamage = 1000;
        //public int monsterDefence = 1000;
        //public string monsterType = "데몬";



        //캡슐화 -> 필드를  private로 처리해서 외부에서 접근 불가능 하도록 하겠다는 의미 
        // protected는 상속받은 자식 클래스에서는 쓸 수 있도록 하겠다는 의미
        //public string monsterName;
        //public int monsterHp;
        //public int monsterMp;
        //public int monsterDamage;
        //public int monsterDefence;
        //public string monsterType;

        public override void Initilize(string monsterName, int monsterHp, int monsterMp, int monsterDamage, int monsterDefence, string monsterType)
        {
            this.monsterName = monsterName;
            this.monsterHp = monsterHp;
            this.monsterMp = monsterMp;
            this.monsterDamage = monsterDamage;
            this.monsterDefence = monsterDefence;
            this.monsterType = monsterType;
        }
        public void Print_MonsterDescription()
        {
            Console.WriteLine("몬스터 이름은 {0} 이고 , hp는 {1}, mp는 {2} ,데미지는 {3} ,방어력은{4} , 몬스터 타입은 {5}.",
                monsterName, monsterHp, monsterMp, monsterDamage, monsterDefence, monsterType);
        }

        //public override void Print_MonsterDescription()
        //{
        //    base .Print_MonsterDescription();
        //    Console.WriteLine("Monster 클래스에서 뭔가 작업을 추가했다.");
        //    Console.WriteLine();
        //}
        //public void Print_OverloadingTest() 
        //{ 
        //    Console.WriteLine("함수 찍힌다.");
        //}
        //public Print_OverloadingTest(out int number)
        //{

        //}

    }
}
