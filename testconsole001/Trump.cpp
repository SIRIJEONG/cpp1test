#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Trump();
void ShuffleOnce(int* firstNumber, int* secondNumber);


int main() {
	Trump();
}

//트럼프 카드 1장 뽑앗거 출력하는 프로그램 만들기 
//힌트 . int cards[52] = { 0, };
//      char cardPatterns[4] = {'♠','♥','♣','◆'} spade clover heart diamond
// 출력예시 
// 갤러리 참조 

//A 2 3 4 5 6 7 8 9 10 J Q K 한 무늬당 13장 씩 존재한다. 


//void Trump() 
//{
//	
//		//배열의 선언과 초기화
//		int cards[52] = { 0, }; //나머지
//		char cardPatterns[4][8] = {"spade","diamond","heart","clover"}; //몫 
//		
//		//쓸 수있는 인원 사용하기 
//		//char cardPatterns2[4][3] = { '♠','♥','♣','◆' };
//		//이거 쓸수 있나?
//		//char cardPatterns[8] = "Spade";
//		//char cardPatterns[8] = "diamond";
//		//char cardPatterns[8] = "heart";
//		//char cardPatterns[8] = "clover";
//
//		//printf("%s \n", cardPatterns1[0]);
//		//std::cout << cardPatterns[0] << std::endl;
//
//		
//
//		//셔플로직
//		const int shuffleCount = 1000000;
//		int randomIndex1, randomIndex2 = 0;
//		srand(time(NULL));
//		for (int i = 0; i < shuffleCount; i++) {
//			randomIndex1 = rand() % 13;
//			randomIndex2 = rand() % 13;
//			ShuffleOnce(&cards[randomIndex1], &cards[randomIndex2]);
//		}
//		
//		int a = 0;
//		a = (rand() % 52) + 1;
//		if (1 <= a && a <= 13) {
//			printf("Spade");
//		}
//		else if (14 <= a&&a <= 26) {
//			printf("heart");
//		}
//		else if (27 <= a&&a <= 39) {
//			printf("diamond");
//		}
//		else {
//			printf("clover");
//		}
//
//		//if (cards[a] < 15)
//		//{
//
//		//}
//
//
//
//		printf("\n");
//
//	
//		//배열의 출력
//		
//		int i = 0;
//		i = rand() % 13 +1 ;
//
//
//			//cards[i] = i + 1;
//		if (i == 1) {
//
//			i = 'A';
//			printf("%c", i);
//
//
//		}
//		else if (i == 11) {
//			i = 'J';
//			printf("%c", i);
//
//
//
//		}
//		else if (i == 12) {
//			i = 'J';
//			printf("%c", i);
//
//
//
//		}
//		else if (i == 13) {
//			i = 'J';
//			printf("%c", i);
//
//
//
//		}
//		else
//		{
//
//			printf("%d", i);
//			
//		}
//		printf("\n\n");
//		}
//
//
//
//void ShuffleOnce(int* firstNumber, int* secondNumber)
//{
//	int temp = 0;
//	temp = *firstNumber;
//	*firstNumber = *secondNumber;
//	*secondNumber = temp;
//	
//}





void Trump()
{


	char cardPattern2[4][4] = { "♠", "◇", "♡", "♣" };   //한칸당 4바이트 4글자


	int cards[52] = { 0, };

	for (int i = 0; i < 52; i++)   // 숫자 문자 나눠서
	{

		if (i % 13 == 0)
		{
			cards[i] = 'A';
		}
		else if (i % 13 == 10)
		{
			cards[i] = 'J';
		}
		else if (i % 13 == 11)
		{
			cards[i] = 'Q';

		}
		else if (i % 13 == 12)
		{
			cards[i] = 'K';
		}
		else
		{
			cards[i] = i % 13 + 1;
		}

	}


	srand(time(NULL));

	int randomCard = rand() % 52;

	if (cards[randomCard] <= 15)
	{
		printf("%d /", cards[randomCard]);
	}

	else
	{
		printf("%c /", cards[randomCard]);

	}

	// 문자 출력
	if (randomCard % 4 == 0)
	{
		printf("%s", cardPattern2[0]);
	}
	else if (randomCard % 4 == 1)
	{
		printf("%s", cardPattern2[1]);
	}
	else if (randomCard % 4 == 2)
	{
		printf("%s", cardPattern2[2]);
	}
	else
	{
		printf("%s", cardPattern2[3]);
	}
}