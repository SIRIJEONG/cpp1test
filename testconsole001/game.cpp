#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>
void BossBattle();
void walk();

int main() {

	walk();
}


void walk() 
{
	int playerWalk = 0;
	int randomPlace = 0;
	int choice;
	int randomBoss = 0;
	srand(time(NULL));

	printf("디아블로 미니게임에 오신걸 환영합니다!\n");
	printf("게임의 룰을 설명해드리겠습니다.\n");
	printf("1.플레이어가 6번 이동하면 게임은 클리어됩니다.\n2.중간에 40%확률로 몬스터를 만나서 대결하여 사망한다면 이동횟수는 초기화 됩니다..\n");
	printf("3.몬스터와의 대결은 자동으로 진행되기 때문에 운빨겜입니다.\n5.60%확률로 자동으로 물약을 먹습니다.");
	printf("길을 개척하여 세상을 구해보세요!\n\n");
	printf("플레이어 \n공격력 : 105(크리티컬시 157) \n체력 : 50\n\n");
	printf("보스 \n공격력 : 7 \n체력 : 1200\n\n\n");



	
	while(playerWalk < 7)
	{

	//이동질문 그리고 번호 입력
	printf("이동하시겠습니까?");
	printf("\n1.yes   2.no\n");
	scanf_s("%d", &choice );


	//배틀 코드
	const int PlayerDamage = 105;
	const int DiabloDamage = 7;
	int probability = 0;
	srand(time(NULL));
	int Diablo = 1200;
	int Player = 50;
	float Playercritical = PlayerDamage * 1.5;
	int heal = 4;




	if (choice == 1 && playerWalk < 6)										 // 1번을 입력하고 playerWalk가 6 이하일 때 실행 된다.
	{
		randomPlace = rand() % 100 + 1;										 // 1~100까지 랜덤 숫자를 나오게 하여 randomPlace 확률 결정

		if (100 >= randomPlace&& randomPlace >= 50)							 // randomPlace 50%확률 조건식
		{
			printf("아케인 생츄어리로 이동합니다.\n", playerWalk += 1);
			printf("%d번 이동했습니다.\n\n", playerWalk);

			randomBoss = rand() % 100 + 1;									//1~100까지 랜덤숫자를 나오게 하여 randomBoss 확률 결정

			if (randomBoss > 60)											//40% 확률로 몬스터 출현
			{
				printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
				printf("| 디아블로를 만났습니다  |\n");
				printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
				printf("------------------------------------------------------------------------------------------\n\n");

				while (1)  //무한루프
				{
					Sleep(1500);  //출력시간 조정
					probability = (rand() % 100) + 1;  //크리티컬 확률 결정


					if (probability > 60 && Diablo > 0 && Player > 0)  //40% 확률로 크리티컬 그리고 플레이어와 몬스터가 살아있을 경우 실행
					{
						printf("플레이어가 공격을 합니다. \n크리티컬입니다! 디아블로가 정신못차립니다..\n%f의 데미지를 입혔습니다.\n\n", Playercritical);
						printf("디아블로가 공격을 합니다.\n%d의 데미지를 받았습니다. \n\n", DiabloDamage);



						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("| 디아블로 남은체력 %d  |\n" , Diablo -= Playercritical);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("| 플레이어 남은체력 %d   |\n", Player -= DiabloDamage);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (probability <= 60 && Diablo > 0 && Player > 0)  // 60% 확률로 기본공격 그리고 플레이어와 몬스터가 살아있을 경우
					{
						printf("플레이어가 공격을 합니다.\n%d의 데미지를 입혔습니다.\n\n", PlayerDamage);
						printf("디아블로가 공격을 합니다.\n%d의 데미지를 받았습니다.\n\n", DiabloDamage);
						printf("물약을 먹었습니다. hp를 %d 회복했습니다.\n\n", heal, Player += heal);  //힐

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("| 디아블로 남은체력 %d  |\n", Diablo -= Playercritical);  
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("| 플레이어 남은체력 %d   |\n", Player -= DiabloDamage);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (Player > 0 && Diablo <= 0)  //플레이어 hp 0이상이고 몬스터 hp가 0이거나 0보다 작을 때 몬스터 처치 
					{
						/*system("cls");*/
						printf("디아블로를 처치했습니다.");
						break;
					}
					else if (Player <= 0 && Diablo <= 0)  //플레이어와 몬스터 둘다 hp가 0이거나 0보다 작을때 플레이어 사망 
					{
						printf("사망했습니다.", playerWalk = 0);
						system("cls");

						break;
					}
					else  //플레이어hp가 0 이하면 사망
					{
						printf("사망했습니다.", playerWalk = 0);
						system("cls");

						break;
					}

				}
			}
			else //몬스터를 만나지 않았을 때 
			{
				continue;
			}

			continue;

		}
		else if (50 > randomPlace && randomPlace >= 30)
		{
			printf("탈라샤의 무덤으로 이동합니다.\n" , playerWalk += 1);
			printf("%d번 이동했습니다.\n", playerWalk);
			randomBoss = rand() % 100 + 1;
			if (randomBoss > 60)
			{

				printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
				printf("|  듀리엘을 만났습니다.  |\n");
				printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
				printf("------------------------------------------------------------------------------------------\n\n");

				while (1)
				{
					Sleep(1500);
					probability = (rand() % 100) + 1;


					if (probability > 60 && Diablo > 0 && Player > 0)
					{
						printf("플레이어가 공격을 합니다. \n크리티컬입니다! 듀리엘이 정신못차립니다..\n%f의 데미지를 입혔습니다.\n\n", Playercritical);
						printf("듀리엘이 공격을 합니다.\n%d의 데미지를 받았습니다. \n\n", DiabloDamage);

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("|  듀리엘 남은체력 %d   |\n", Diablo -= Playercritical);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("| 플레이어 남은체력 %d   |\n", Player -= DiabloDamage);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");


						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (probability <= 60 && Diablo > 0 && Player > 0)
					{
						printf("플레이어가 공격을 합니다.\n%d의 데미지를 입혔습니다. \n\n", PlayerDamage);
						printf("듀리엘이 공격을 합니다.\n%d의 데미지를 받았습니다.\n\n", DiabloDamage);
						printf("물약을 먹었습니다. hp를 %d 회복했습니다. \n\n", heal, Player += heal);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("|  듀리엘 남은체력 %d   |\n", Diablo -= Playercritical);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("| 플레이어 남은체력 %d   |\n", Player -= DiabloDamage);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (Player > 0 && Diablo <= 0)
					{
						printf("듀리엘을 처치했습니다.");
						break;
					}
					else if (Player <= 0 && Diablo <= 0)
					{
						printf("사망했습니다.", playerWalk = 0);
						system("cls");

						break;
					}
					else
					{
						printf("사망했습니다.", playerWalk = 0);
						system("cls");

						break;
					}

				}
				continue;
			}
		}
		else if (30 > randomPlace && randomPlace > 0)
		{
			printf("수도원의 묘지로 이동합니다.\n", playerWalk += 1);
			printf("%d번 이동했습니다.\n", playerWalk);
			randomBoss = rand() % 100 + 1;
			if (randomBoss > 60)
			{

				printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
				printf("|   바알을 만났습니다    |\n");
				printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
				printf("------------------------------------------------------------------------------------------\n\n");


				while (1)
				{
					Sleep(1500);
					probability = (rand() % 100) + 1;


					if (probability > 60 && Diablo > 0 && Player > 0)
					{
						printf("플레이어가 공격을 합니다. \n크리티컬입니다! 바알이 정신못차립니다..\n%f의 데미지를 입혔습니다.\n\n", Playercritical);
						printf("바알이 공격을 합니다.\n%d의 데미지를 받았습니다.\n\n", DiabloDamage);

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("|  바알의 남은체력 %d   |\n", Diablo -= Playercritical);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("| 플레이어 남은체력 %d   |\n", Player -= DiabloDamage);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");
						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (probability <= 60 && Diablo > 0 && Player > 0)
					{
						printf("플레이어가 공격을 합니다.\n%d의 데미지를 입혔습니다.\n\n", PlayerDamage);
						printf("바알이 공격을 합니다.\n%d의 데미지를 받았습니다.\n\n", DiabloDamage);
						printf("물약을 먹었습니다. hp를 %d 회복했습니다.\n\n", heal, Player += heal);

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("|  바알의 남은체력 %d   |\n", Diablo -= Playercritical);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n");
						printf("| 플레이어 남은체력 %d   |\n", Player -= DiabloDamage);
						printf("|ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ|\n\n");

						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (Player > 0 && Diablo <= 0)
					{
						/*system("cls");*/
						printf("바알을 처치했습니다.");
						break;
					}
					else if (Player <= 0 && Diablo <= 0)
					{
						printf("사망했습니다.", playerWalk = 0);
						system("cls");
						break;
					}
					else
					{
						printf("사망했습니다.", playerWalk = 0);
						system("cls");

						break;
					}

				}
				continue;

			}
		}
		else 
		{
			continue;
		}
	}
	else if (playerWalk == 6) //플레이어 이동횟수가 6번이 되면  클리어 합니다.
	{
		printf("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
		printf("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
		printf("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");
		printf("\n\n클리어 하였습니다!!!!!!!!!!!!\n\n");

		break;

	}
	else
	{
		printf("이거 누를 거면 게임왜켰냐 ㅋㅋ\n"); //이동안한다고 하면 출력 
		continue;
	}
	}
}


