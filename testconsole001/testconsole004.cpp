#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Descrtiption004();
void Descrtiption003();
int Descrtiption002();
void Descrtiption001();
void Descrtiption005();
void Descrtiption006();
void Descrtiption007();
void Descrtiption008();
void Descrtiption009();

int main() {
	//int loopCount = 1;
	//while (loopCount <= 10) {
	//	if (loopCount == 7) { 
	//		loopCount += 1;
	//		/*continue;  */  //loop�� ��� ����
	//		break; // break�� ������ ����  loop�� ����������.
	//	}

	//	printf("�̰��� ������ ��µǴ� �����̴�. loopCount: %d \n" , loopCount);
	//	loopCount += 1;
	//}  //loop : ���� Ƚ�� �ݺ� 




	//char userInput = '0';
	//int loopCount = 1;
	//while (1) {  // 1�� �Է��ϸ� ������ �ݺ��Ѵ�. 
	//	if (loopCount == 1) {
	//		printf("[Ʃ�丮��] ���� ������ ������� �Ѵٸ� �̷������� \n\n");
	//	}
	//	printf("\n[system] ����� �÷��̾� �Դϴ�. \n");
	//	printf("������ �׼��� �Է��� �ּ��� : ");
	//	scanf_s("%c", &userInput);
	//	if (userInput == 'q' || userInput == 'Q') {
	//		printf("\n[System]���α׷��� �����մϴ�. \n");
	//		break;
	//	}
	//	else {
	//		printf("[System]\n�ش� �Է��� ���ǵǾ� ���� �ʽ��ϴ�. \n");
	//		loopCount += 1;
	//		continue;
	//	}

	//	loopCount += 1;
	//}  //loop : ���� Ƚ�� �ݺ� 


	//int userInput = 0;
	//int loopCount = 1;

	////Ȧ�� ¦�� ���� 
	//while (1) {
	//	printf("���ڸ� �Է��� �ּ��� : ");
	//	scanf_s("%d", &userInput);

	//	//Ż������
	//	if (userInput == 0) {
	//		printf("\n[System]���α׷��� �����մϴ�. \n");
	//		break;
	//	}
	//	else if (userInput % 2 == 1){
	//		printf("Ȧ�� �Դϴ�. \n");
	//		loopCount += 1;
	//	}		
	//	else {
	//		printf("¦���Դϴ�..\n");
	//		loopCount += 1;
	//		continue;
	//	}

	//}


	
	//Descrtiption003();
	//Descrtiption004();
	//Descrtiption005();
	//Descrtiption006();
	//Descrtiption007();
	//Descrtiption008();
	Descrtiption009();
}  // main()

//void Descrtiption008() {
//
//	int randomNumber = 0;
//	const int MAX_DICE_VALUE = 6;
//	srand(time(NULL));
//
//
//	printf("�ֻ��� ���α׷� \n\n");
//	_getch();
//	printf("��ǻ�Ͱ� ���� 3���� �ֻ��� �� -> ");
//	
//	for (int i = 0; i < 3; i++) {
//		Sleep(1000);
//		randomNumber = (rand() % MAX_DICE_VALUE) + 1;
//		printf("%d ", randomNumber);
//	}
//	
//	Sleep(1000);
//	printf("\n\n");
//	printf("���α׷� ���� \n\n "); 
//	//�Ľ�Į ��Ÿ�� 
//
//}

//60 �� ũ��Ƽ�� 
// loop����ؼ� ���� 
// �������� �����ѹ� �÷��̾ � �������� ����ؼ� ������ �� (ũ��Ƽ������ �ƴ��� �� �� �־�� ��)

void Descrtiption009() {
	const int Damage = 100;
	int probability = 0;
	srand(time(NULL));
	int boss = 1000;


while (1) {
			Sleep(1000);
			probability = (rand() % 100) + 1;

			if (probability >= 60 && boss > 0) {
				printf("%f ũ��Ƽ���Դϴ�! ������ ���Ÿ������ϴ�..(100�� %d�� ���� ũ��Ƽ���� �������ϴ�.)\n������ ü���� %d ���ҽ��ϴ�.\n", Damage * 1.5 , probability, boss -= 150);
				continue;
			}
			else if (probability <= 60 && boss > 0) {
				printf("100 ��� ����!(100�� %d�� ���ͼ� ��Ÿ�� Ĩ�ϴ�.)\n ������ ü���� %d ���ҽ��ϴ�.\n", probability, boss -= 100);
				continue;
			}
			else {
				system("cls");
				printf("������ óġ�߽��ϴ�.");
				break;
			}
			//system("cls");
		}
	
}


//�÷��̾�� ���ڸ� �̸� ���� ���� , �÷��̾ Ȧ¦�� ������Ѵ�. 

//void Descrtiption007() {
//	int randomDice1, randomDice2;
//	int userNumber = 0;
//	srand(time(NULL));
//	
//	randomDice1 = rand() % 6 + 1;
//	randomDice2 = rand() % 6 + 1;//rand() �Լ��� ����ؼ� �������� �޴´�.
//	int result = randomDice1 + randomDice2;
//	printf("Ȧ�̸� 1 �ƴϸ� ¦�̸� 0�� �Է��ϼ��� :");
//	scanf_s("%d", &userNumber);
//	if (result % 2 == 0 && userNumber == 0) {
//		printf(" �����Դϴ�.\n");
//	}
//	else if (result % 2 == 1 &&  userNumber == 1) {
//		printf("�����Դϴ�.\n");
//	}
//	else if (userNumber > 1) {
//		printf("Ȧ¦ ���� �߸��Է� �߽��ϴ�.\n");
//	}
//	else {
//		printf("�����Դϴ�.\n");
//	}
//	printf("�� ���� ���� %d \n", result);



	//else if (result % 2 == 1 && result % userNumber == 0) {
	//	printf("�����Դϴ�.");
	//}
	//else if (result % 2 == 0 && result % userNumber == 1) {
	//	printf("�����Դϴ�.");
	//}
	//else if (result % 2 == 1 && result % userNumber == 1) {
	//	printf("�����Դϴ�.");
	//}
	//else if (result % 2 == 0 && result % userNumber == 1) {
	//	printf("�����Դϴ�.");
	//}

	
//}


//Ȧ¦ ���� 
//��ǻ�Ͱ� �ֻ����� 2�� ������.
//�÷��̾�� ���ڸ� �̸� ���� �ִ�. ������ Ȧ�� ���� ¦������ ����Ѵ�.
//void Descrtiption006() {
//	int randomDice1, randomDice2;
//	srand(time(NULL));
//	
//	randomDice1 = rand() % 6 + 1;
//	randomDice2 = rand() % 6 + 1;//rand() �Լ��� ����ؼ� �������� �޴´�.
//	int result = randomDice1 + randomDice2;
//	printf("random dice�� �� ���� %d %d \n", randomDice1, randomDice2);
//	printf("�� ���ڸ� ���ϸ� %d \n", result);
// 
//	if (result % 2 == 0) {
//		printf("¦���Դϴ�.");
//	}
//	else {
//		printf("Ȧ���Դϴ�.");
//	}
//
//
//}



//void Descrtiption005() {
//	//���⼭ Ű���� �ٲ㺼 ����
//
//	int randomNumber1 ,  randomNumber2 ,  randomNumber3 = 0;
//	srand (time(NULL));  //�̰��� rand()�Լ��� Ű���� �ٲ��ִ� �Լ� 
//	//Random�����ϱ�
//	printf("���� ��ȣ ���� \n");
//
//	for (int i = 0; i < 10; i++) {
//		randomNumber2 = (rand()%45)+1;
//		printf("%d", randomNumber2);
//	}
//	printf("\n\n");
//
//	randomNumber1 = rand()% 11; //rand() �Լ��� ����ؼ� �������� �޴´�.
//	randomNumber2 = rand()% 11;
//	randomNumber3 = rand()% 11;
//
//	printf("Random number?? %d \n", randomNumber1);
//	printf("Random number?? %d \n", randomNumber2);
//	printf("Random number?? %d \n", randomNumber3);
//
//}







//
//void Descrtiption004() {
//	printf("for ���� �ݺ����̴�. �̷��� ���ư���. \n");
//	for (int loopCount = 1;/*<-�̰� �� ��(������ �����ٸ�)*/ loopCount <= 5; loopCount += 1) {
//		printf("��� ���ư��� �ִ� ������? \n");
//	}
//	printf("\n");
//}


//void Descrtiption003()
//{
//	//switch / case ��
//	char userInput = '0';
//	printf("user input : ");
//	//scanf_s("%d", &userInput);
//	userInput = _getch();
//
//	printf("\n\n");
//
//	switch (userInput)
//	{
//	case 'a':
//		printf("�̰��� ���� \n");
//		break;
//	case 'b':
//		printf("�̰��� ���� \n");
//		break;
//	case 'c':
//		printf("�̰��� �� \n");
//		break;
//	default:
//		printf("ó������ ���� ���� �Է��Դϴ�. \n");
//		break;
//	}
//	//printf("���α׷��� �����մϴ�. \n");
//	printf("press any key... \n");
//}