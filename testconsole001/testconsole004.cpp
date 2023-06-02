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
	//		/*continue;  */  //loop를 계속 돈다
	//		break; // break를 만나는 순간  loop를 빠져나간다.
	//	}

	//	printf("이것은 무조건 출력되는 문장이다. loopCount: %d \n" , loopCount);
	//	loopCount += 1;
	//}  //loop : 일정 횟수 반복 




	//char userInput = '0';
	//int loopCount = 1;
	//while (1) {  // 1을 입력하면 무한히 반복한다. 
	//	if (loopCount == 1) {
	//		printf("[튜토리얼] 만약 게임을 만들려고 한다면 이런식으로 \n\n");
	//	}
	//	printf("\n[system] 당신은 플레이어 입니다. \n");
	//	printf("수행할 액션을 입력해 주세요 : ");
	//	scanf_s("%c", &userInput);
	//	if (userInput == 'q' || userInput == 'Q') {
	//		printf("\n[System]프로그램을 종료합니다. \n");
	//		break;
	//	}
	//	else {
	//		printf("[System]\n해당 입력은 정의되어 있지 않습니다. \n");
	//		loopCount += 1;
	//		continue;
	//	}

	//	loopCount += 1;
	//}  //loop : 일정 횟수 반복 


	//int userInput = 0;
	//int loopCount = 1;

	////홀수 짝수 구분 
	//while (1) {
	//	printf("숫자를 입력해 주세요 : ");
	//	scanf_s("%d", &userInput);

	//	//탈출조건
	//	if (userInput == 0) {
	//		printf("\n[System]프로그램을 종료합니다. \n");
	//		break;
	//	}
	//	else if (userInput % 2 == 1){
	//		printf("홀수 입니다. \n");
	//		loopCount += 1;
	//	}		
	//	else {
	//		printf("짝수입니다..\n");
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
//	printf("주사위 프로그램 \n\n");
//	_getch();
//	printf("컴퓨터가 뽑은 3개의 주사위 값 -> ");
//	
//	for (int i = 0; i < 3; i++) {
//		Sleep(1000);
//		randomNumber = (rand() % MAX_DICE_VALUE) + 1;
//		printf("%d ", randomNumber);
//	}
//	
//	Sleep(1000);
//	printf("\n\n");
//	printf("프로그램 종료 \n\n "); 
//	//파스칼 스타일 
//
//}

//60 퍼 크리티컬 
// loop사용해서 종료 
// 데미지값 매직넘버 플레이어가 어떤 상태인지 출력해서 보여줄 것 (크리티컬인지 아닌지 알 수 있어야 함)

void Descrtiption009() {
	const int Damage = 100;
	int probability = 0;
	srand(time(NULL));
	int boss = 1000;


while (1) {
			Sleep(1000);
			probability = (rand() % 100) + 1;

			if (probability >= 60 && boss > 0) {
				printf("%f 크리티컬입니다! 보스가 정신못차립니다..(100중 %d이 나와 크리티컬이 터졌습니다.)\n보스의 체력이 %d 남았습니다.\n", Damage * 1.5 , probability, boss -= 150);
				continue;
			}
			else if (probability <= 60 && boss > 0) {
				printf("100 어림도 없지!(100중 %d이 나와서 평타를 칩니다.)\n 보스의 체력이 %d 남았습니다.\n", probability, boss -= 100);
				continue;
			}
			else {
				system("cls");
				printf("보스를 처치했습니다.");
				break;
			}
			//system("cls");
		}
	
}


//플레이어는 숫자를 미리 볼수 없다 , 플레이어가 홀짝을 맞춰야한다. 

//void Descrtiption007() {
//	int randomDice1, randomDice2;
//	int userNumber = 0;
//	srand(time(NULL));
//	
//	randomDice1 = rand() % 6 + 1;
//	randomDice2 = rand() % 6 + 1;//rand() 함수를 사용해서 랜덤값을 받는다.
//	int result = randomDice1 + randomDice2;
//	printf("홀이면 1 아니면 짝이면 0을 입력하세요 :");
//	scanf_s("%d", &userNumber);
//	if (result % 2 == 0 && userNumber == 0) {
//		printf(" 정답입니다.\n");
//	}
//	else if (result % 2 == 1 &&  userNumber == 1) {
//		printf("정답입니다.\n");
//	}
//	else if (userNumber > 1) {
//		printf("홀짝 값을 잘못입력 했습니다.\n");
//	}
//	else {
//		printf("오답입니다.\n");
//	}
//	printf("두 수의 합은 %d \n", result);



	//else if (result % 2 == 1 && result % userNumber == 0) {
	//	printf("오답입니다.");
	//}
	//else if (result % 2 == 0 && result % userNumber == 1) {
	//	printf("오답입니다.");
	//}
	//else if (result % 2 == 1 && result % userNumber == 1) {
	//	printf("정답입니다.");
	//}
	//else if (result % 2 == 0 && result % userNumber == 1) {
	//	printf("오답입니다.");
	//}

	
//}


//홀짝 게임 
//컴퓨터가 주사위를 2번 굴린다.
//플레이어는 숫자를 미리 볼수 있다. 총합이 홀수 인지 짝수인지 출력한다.
//void Descrtiption006() {
//	int randomDice1, randomDice2;
//	srand(time(NULL));
//	
//	randomDice1 = rand() % 6 + 1;
//	randomDice2 = rand() % 6 + 1;//rand() 함수를 사용해서 랜덤값을 받는다.
//	int result = randomDice1 + randomDice2;
//	printf("random dice의 두 수는 %d %d \n", randomDice1, randomDice2);
//	printf("두 숫자를 더하면 %d \n", result);
// 
//	if (result % 2 == 0) {
//		printf("짝수입니다.");
//	}
//	else {
//		printf("홀수입니다.");
//	}
//
//
//}



//void Descrtiption005() {
//	//여기서 키값을 바꿔볼 예정
//
//	int randomNumber1 ,  randomNumber2 ,  randomNumber3 = 0;
//	srand (time(NULL));  //이것이 rand()함수의 키값을 바꿔주는 함수 
//	//Random이해하기
//	printf("랜덤 번호 찍어보기 \n");
//
//	for (int i = 0; i < 10; i++) {
//		randomNumber2 = (rand()%45)+1;
//		printf("%d", randomNumber2);
//	}
//	printf("\n\n");
//
//	randomNumber1 = rand()% 11; //rand() 함수를 사용해서 랜덤값을 받는다.
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
//	printf("for 문은 반복문이다. 이렇게 돌아간다. \n");
//	for (int loopCount = 1;/*<-이건 비어도 됨(밖으로 빼낸다면)*/ loopCount <= 5; loopCount += 1) {
//		printf("어떻게 돌아가고 있는 것이지? \n");
//	}
//	printf("\n");
//}


//void Descrtiption003()
//{
//	//switch / case 문
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
//		printf("이것은 가위 \n");
//		break;
//	case 'b':
//		printf("이것은 바위 \n");
//		break;
//	case 'c':
//		printf("이것은 보 \n");
//		break;
//	default:
//		printf("처리되지 않은 예외 입력입니다. \n");
//		break;
//	}
//	//printf("프로그램을 종료합니다. \n");
//	printf("press any key... \n");
//}