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

	printf("��ƺ�� �̴ϰ��ӿ� ���Ű� ȯ���մϴ�!\n");
	printf("������ ���� �����ص帮�ڽ��ϴ�.\n");
	printf("1.�÷��̾ 6�� �̵��ϸ� ������ Ŭ����˴ϴ�.\n2.�߰��� 40%Ȯ���� ���͸� ������ ����Ͽ� ����Ѵٸ� �̵�Ƚ���� �ʱ�ȭ �˴ϴ�..\n");
	printf("3.���Ϳ��� ����� �ڵ����� ����Ǳ� ������ ����Դϴ�.\n5.60%Ȯ���� �ڵ����� ������ �Խ��ϴ�.");
	printf("���� ��ô�Ͽ� ������ ���غ�����!\n\n");
	printf("�÷��̾� \n���ݷ� : 105(ũ��Ƽ�ý� 157) \nü�� : 50\n\n");
	printf("���� \n���ݷ� : 7 \nü�� : 1200\n\n\n");



	
	while(playerWalk < 7)
	{

	printf("�̵��Ͻðڽ��ϱ�?");
	printf("\n1.yes   2.no\n");
	scanf_s("%d", &choice );


	//��Ʋ �ڵ�
	const int PlayerDamage = 105;
	const int DiabloDamage = 7;
	int probability = 0;
	srand(time(NULL));
	int Diablo = 1200;
	int Player = 50;
	float Playercritical = PlayerDamage * 1.5;
	int heal = 4;

	if (choice == 1 && playerWalk < 6)
	{
		randomPlace = rand() % 100 + 1;

		if (100 >= randomPlace&& randomPlace >= 50)
		{
			printf("������ ������ �̵��մϴ�.\n", playerWalk += 1);
			printf("%d�� �̵��߽��ϴ�.\n\n", playerWalk);

			randomBoss = rand() % 100 + 1;

			if (randomBoss > 60) 
			{
				printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
				printf("| ��ƺ�θ� �������ϴ�  |\n");
				printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");
				printf("------------------------------------------------------------------------------------------\n\n");

				while (1)
				{
					Sleep(1500);
					probability = (rand() % 100) + 1;


					if (probability > 60 && Diablo > 0 && Player > 0)
					{
						printf("�÷��̾ ������ �մϴ�. \nũ��Ƽ���Դϴ�! ��ƺ�ΰ� ���Ÿ������ϴ�..\n%f�� �������� �������ϴ�.\n\n", Playercritical);
						printf("��ƺ�ΰ� ������ �մϴ�.\n%d�� �������� �޾ҽ��ϴ�. \n\n", DiabloDamage);



						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("| ��ƺ�� ����ü�� %d  |\n" , Diablo -= Playercritical);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("| �÷��̾� ����ü�� %d   |\n", Player -= DiabloDamage);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");
						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (probability <= 60 && Diablo > 0 && Player > 0)
					{
						printf("�÷��̾ ������ �մϴ�.\n%d�� �������� �������ϴ�.\n\n", PlayerDamage);
						printf("��ƺ�ΰ� ������ �մϴ�.\n%d�� �������� �޾ҽ��ϴ�.\n\n", DiabloDamage);
						printf("������ �Ծ����ϴ�. hp�� %d ȸ���߽��ϴ�.\n\n", heal, Player += heal);

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("| ��ƺ�� ����ü�� %d  |\n", Diablo -= Playercritical);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("| �÷��̾� ����ü�� %d   |\n", Player -= DiabloDamage);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (Player > 0 && Diablo <= 0)
					{
						/*system("cls");*/
						printf("��ƺ�θ� óġ�߽��ϴ�.");
						break;
					}
					else if (Player <= 0 && Diablo <= 0)
					{
						printf("����߽��ϴ�.", playerWalk = 0);
						system("cls");

						break;
					}
					else
					{
						printf("����߽��ϴ�.", playerWalk = 0);
						system("cls");

						break;
					}

				}
			}
			else 
			{
				continue;
			}

			continue;

		}
		else if (50 > randomPlace && randomPlace >= 30)
		{
			printf("Ż����� �������� �̵��մϴ�.\n" , playerWalk += 1);
			printf("%d�� �̵��߽��ϴ�.\n", playerWalk);
			randomBoss = rand() % 100 + 1;
			if (randomBoss > 60)
			{

				printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
				printf("|  �ฮ���� �������ϴ�.  |\n");
				printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");
				printf("------------------------------------------------------------------------------------------\n\n");

				while (1)
				{
					Sleep(1500);
					probability = (rand() % 100) + 1;


					if (probability > 60 && Diablo > 0 && Player > 0)
					{
						printf("�÷��̾ ������ �մϴ�. \nũ��Ƽ���Դϴ�! �ฮ���� ���Ÿ������ϴ�..\n%f�� �������� �������ϴ�.\n\n", Playercritical);
						printf("�ฮ���� ������ �մϴ�.\n%d�� �������� �޾ҽ��ϴ�. \n\n", DiabloDamage);

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("|  �ฮ�� ����ü�� %d   |\n", Diablo -= Playercritical);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("| �÷��̾� ����ü�� %d   |\n", Player -= DiabloDamage);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");


						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (probability <= 60 && Diablo > 0 && Player > 0)
					{
						printf("�÷��̾ ������ �մϴ�.\n%d�� �������� �������ϴ�. \n\n", PlayerDamage);
						printf("�ฮ���� ������ �մϴ�.\n%d�� �������� �޾ҽ��ϴ�.\n\n", DiabloDamage);
						printf("������ �Ծ����ϴ�. hp�� %d ȸ���߽��ϴ�. \n\n", heal, Player += heal);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("|  �ฮ�� ����ü�� %d   |\n", Diablo -= Playercritical);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("| �÷��̾� ����ü�� %d   |\n", Player -= DiabloDamage);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (Player > 0 && Diablo <= 0)
					{
						printf("�ฮ���� óġ�߽��ϴ�.");
						break;
					}
					else if (Player <= 0 && Diablo <= 0)
					{
						printf("����߽��ϴ�.", playerWalk = 0);
						system("cls");

						break;
					}
					else
					{
						printf("����߽��ϴ�.", playerWalk = 0);
						system("cls");

						break;
					}

				}
				continue;
			}
		}
		else if (30 > randomPlace && randomPlace > 0)
		{
			printf("�������� ������ �̵��մϴ�.\n", playerWalk += 1);
			printf("%d�� �̵��߽��ϴ�.\n", playerWalk);
			randomBoss = rand() % 100 + 1;
			if (randomBoss > 60)
			{

				printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
				printf("|   �پ��� �������ϴ�    |\n");
				printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");
				printf("------------------------------------------------------------------------------------------\n\n");


				while (1)
				{
					Sleep(1500);
					probability = (rand() % 100) + 1;


					if (probability > 60 && Diablo > 0 && Player > 0)
					{
						printf("�÷��̾ ������ �մϴ�. \nũ��Ƽ���Դϴ�! �پ��� ���Ÿ������ϴ�..\n%f�� �������� �������ϴ�.\n\n", Playercritical);
						printf("�پ��� ������ �մϴ�.\n%d�� �������� �޾ҽ��ϴ�.\n\n", DiabloDamage);

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("|  �پ��� ����ü�� %d   |\n", Diablo -= Playercritical);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("| �÷��̾� ����ü�� %d   |\n", Player -= DiabloDamage);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");
						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (probability <= 60 && Diablo > 0 && Player > 0)
					{
						printf("�÷��̾ ������ �մϴ�.\n%d�� �������� �������ϴ�.\n\n", PlayerDamage);
						printf("�پ��� ������ �մϴ�.\n%d�� �������� �޾ҽ��ϴ�.\n\n", DiabloDamage);
						printf("������ �Ծ����ϴ�. hp�� %d ȸ���߽��ϴ�.\n\n", heal, Player += heal);

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("|  �پ��� ����ü�� %d   |\n", Diablo -= Playercritical);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n");
						printf("| �÷��̾� ����ü�� %d   |\n", Player -= DiabloDamage);
						printf("|�ѤѤѤѤѤѤѤѤѤѤѤ�|\n\n");

						printf("------------------------------------------------------------------------------------------\n");

						continue;
					}
					else if (Player > 0 && Diablo <= 0)
					{
						/*system("cls");*/
						printf("�پ��� óġ�߽��ϴ�.");
						break;
					}
					else if (Player <= 0 && Diablo <= 0)
					{
						printf("����߽��ϴ�.", playerWalk = 0);
						system("cls");
						break;
					}
					else
					{
						printf("����߽��ϴ�.", playerWalk = 0);
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
	else if (playerWalk == 6) 
	{
		printf("\n\nŬ���� �Ͽ����ϴ�!!!!!!!!!!!!\n\n");
		printf("\n\nŬ���� �Ͽ����ϴ�!!!!!!!!!!!!\n\n");
		printf("\n\nŬ���� �Ͽ����ϴ�!!!!!!!!!!!!\n\n");
		printf("\n\nŬ���� �Ͽ����ϴ�!!!!!!!!!!!!\n\n");

		break;

	}
	else
	{
		printf("�̰� ���� �Ÿ� ���ӿ��׳� ����\n");
		continue;
	}
	}
}


