#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Description001();
void Description002();
void Description003();
void Description004();
void Description005();
void swap(char firstChar, char secondChar);
void swap2(char* firstChar, char* secondChar);
void Description006();
void DescriptionShuffle();
void ShuffleOnce(int* firstNumber, int* secondNumber);
void DescriptionShuffle2();
int main() {


	//Description001();

	//Description002();
	//Description003();
	//Description004();
	//Description005();
	//Description006();
	//DescriptionShuffle();
	DescriptionShuffle2();
	//swap();
	//swap2();

}


//void Description001() {
//	char str[300] = { 0, };
//	printf("문자열을 입력하세요 (200자 이내로) : ");
//	std::cin >> str;
//
//	printf("제대로 입력을 받았는디 %s", str);
//}



//void Description002() {
//	char string_[15] = "Good morning \n";
//	char stringCopy[16] = { 0 , };
//
//	char string2[] = "Good morning! \n";
//	int numbers[10] = { 0 , };
//
//
//	printf("%s", string_);
//	printf("문지열 배열의 크기 %d \n", sizeof(string_));  //배열의 길이를 예측할 수 있다.
//	printf("문지열 배열의 2번째 크기 %d \n", sizeof(string2));  //배열의 길이를 예측할 수 있다.
//	printf("정수형 배열의 크기 %d \n", sizeof(numbers));  //배열의 길이를 예측할 수 있다.
//	printf("정수형 배열의 크기 %d \n", sizeof(numbers) / sizeof(int));  //배열의 길이를 예측할 수 있다.
//
//	string_[0] = 'G';
//	string_[1] = 'g';
//	string_[2] = 'g';
//
//	printf("문자열 배열이 정말로 수정되는지? %s \n", string_);
//
//
//
//	bool isNullSamezero = false;
//	if (0 == '\0') //Null은 0이다.
//	{
//		isNullSamezero = true;
//	}
//	else
//	{
//		isNullSamezero = false;
//	}
//	printf("Null은 0과 같은 값인가? [%d] \n", isNullSamezero);
//
//	char string3[4];
//	string3[0] = 'H';
//	string3[1] = 'i';
//	string3[2] = '!';
//	string3[3] = '\0';
//
//
//	char string4[4] = "Hi!";
//	printf("string4번 찍어보겠음 %s \n", string4);
//	printf("string3번 찍어보겠음 %s \n", string3);
//}


//void Description003() {
//
//	//문자열을 입력받아서  - > 출력하는것 
//	// 문자열을 입력받아서 대문자 - 소문자 - 대문자 - 소문자 ... 순으로 수정해서 출력하는 프로그램 작성하기 
//	// 위의 프로그램을 수정해서 거꾸로 뒤집어서 출력하는 프로그램 작성하기 
//
//	char str[300] = { 0 , };
//	printf("문자열을 입력하세요 (200자 이내로) : ");
//	std::cin >> str;
//
//
//	while (1) 
//	{		
//		for (int i = 1; i < 300; i+=2)
//		{
//			if ( 65 <= str[i] && str[i] <= 90) 
//			{
//				str[i] += 32;
//			}
//			for (int i = 0; i < 300; i+=2) 
//			{
//				if ( 97 <= str[i] && str[i] <= 122) 
//				{
//					str[i] -= 32;
//				}
//			}
//		}
//		
//		printf("%s \n", str);
//		break;
//	}
//
//}


//void Description004() {
//	// 위의 프로그램을 수정해서 거꾸로 뒤집어서 출력하는 프로그램 작성하기 
//
//	char str[200] = { 0 , };
//	printf("문자열을 입력하세요 (200자 이내로) : ");
//	std::cin >> str;
//	int count = 0;
//	char reverseString[200] = { 0, };
//
//	while (1)
//	{
//		for (int i = 200; i >= 0; i -= 2)
//		{
//			if (1 <= str[i] && str[i] <= 127)
//			{
//
//				count += 1;
//
//				if (65 <= str[i] && str[i] <= 90)
//				{
//					str[i] += 32;
//				}
//				for (int i = 199; i > 0; i -= 2)
//				{
//					if (97 <= str[i] && str[i] <= 122)
//					{
//
//						str[i] -= 32;
//
//					}
//				}
//			}
//		}
//
//		for (int j = 0; j < count; j++) {
//			reverseString[j] = str[count - j];
//
//		}
//			printf("%s", reverseString ); //미완성
//
//
//		//for (int i = 200; i >= 0; i--) {
//		//printf("%c", str[i]);
//		//}
//		break;
//	}
//
//}


//void DescriptionShuffle() 
//{
//	//배열의 선언과 초기화
//	int numbers[10] = { 0, };
//	for (int i = 0; i < 10; i++) 
//	{
//		numbers[i] = i + 1;
//	}
//
//	//배열의 출력
//	printf("shuffle하기전 \n\n");
//	for (int i = 0; i < 10; i++) 
//	{
//		printf("%d ", numbers[i]);
//	}
//	printf("\n\n");
//
//	//셔플로직
//	const int shuffleCount = 100;
//	int randomIndex1, randomIndex2 = 0;
//	srand(time(NULL));
//	for (int i = 0; i < shuffleCount; i ++){
//	randomIndex1 = rand() % 10;
//	randomIndex2 = rand() % 10;
//	ShuffleOnce(&numbers[randomIndex1], &numbers[randomIndex2]);
//	}
//
//	printf("\n");
//
//	//배열의 출력
//	printf("shuffle 한 후  \n\n");
//	for (int i = 0; i < 10; i++)
//	{
//		printf("%d ", numbers[i]);
//	}
//	printf("\n\n");
//
//}






void DescriptionShuffle2()
{
	//배열의 선언과 초기화
	int numbers[45] = { 0, };
	for (int i = 0; i < 45; i++)
	{
		numbers[i] = i + 1;
	}

	//배열의 출력
	printf("shuffle하기전 \n\n");
	for (int i = 0; i < 10; i++)
	{
		printf("%d ", numbers[i]);
	}
	printf("\n\n");

	//셔플로직
	const int shuffleCount = 1000000;
	int randomIndex1, randomIndex2 = 0;
	srand(time(NULL));
	for (int i = 0; i < shuffleCount; i++) {
		randomIndex1 = rand() % 45 ;
		randomIndex2 = rand() % 45 ;
		ShuffleOnce(&numbers[randomIndex1], &numbers[randomIndex2]);
	}

	printf("\n");

	//배열의 출력
	printf("shuffle 한 후  \n\n");
	for (int i = 0; i < 6; i++)
	{
		Sleep(1000);
		printf("%d ", numbers[i]);
	}
	printf("\n\n");

}

void ShuffleOnce(int* firstNumber, int* secondNumber) {
	int temp = 0;
	temp = *firstNumber;
	*firstNumber = *secondNumber;
	*secondNumber = temp;
}


//트럼프 카드 1장 뽑앗거 출력하는 프로그램 만들기 
//힌트 . int cards[52] = { 0, };
//      char cardPatterns[4] = {'♠','♥','♣','◆'}
// 출력예시 
// 갤러리 참조 




void Description006() {
	//포인터 직접 쳐보기 
	int number = 100;
	int* ptrNumber = &number;

	printf("number 변수의 주소는 : %p , 할당된 값은 %d \n", &number, number);
	printf("ptrNumber 변수의 주소는 : %p , 할당된 값은 %p  ,역 참조한 값 : %d \n", &ptrNumber, ptrNumber , *ptrNumber);
}


void Description005() {
	char str[10] = "hello";
	char temp = '\0';

	//temp = str[0];
	//str[4] = temp;
	//str[0] = str[4];
	//str[4] = str[0];
	swap2(&str[0], &str[4]);
	printf("%s \n", str);
}

void swap(char firstChar, char secondChar) {
	printf("[스왑하기 전 ]firstChar 값 : %c , secondChar 값  %c \n", firstChar, secondChar);

	char temp = '\0';
	temp = firstChar;
	firstChar = secondChar;
	secondChar = temp;
	printf("[스왑 이후 ]firstChar 값 : %c , secondChar 값  %c \n" , firstChar, secondChar);
}




void swap2(char* firstChar, char* secondChar) {
	printf("[스왑하기 전 ]firstChar 값 : %c , secondChar 값  %c \n", *firstChar, *secondChar);

	char temp = '\0';
	temp = (*firstChar);
	(*firstChar) = (*secondChar);
	(*secondChar) = temp;
	printf("[스왑 이후 ]firstChar 값 : %c , secondChar 값  %c \n", *firstChar, *secondChar);
}
