#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void addOne(int* localNumber1, int* localNumber2);
void Description001(int number);
void Description002();
void Description003();
void Description004();
void Description005();
int main()
{

	//Description002();

	//Description003();
	Description004();
	//Description005();
	////이 위치에서 프로그램은 시작된다.
	//Description001(10);
	//printf("Description001함수가 끝아면 되돌아와서 이걸 출력해야함 \n");

	//int mainNumber1 = 0;
	//int	mainNumber2 = 0;
	//addOne(&mainNumber1, &mainNumber2);
	//printf("number의 상태 1:%d , 2:%d \n\n", mainNumber1, mainNumber2);
}

void Description004()
{


	const int MAX_ARRAY = 9;

	int lineCount[MAX_ARRAY] = { 0 , };
	int nDAn[9] = { 0 , };


	for (int i = 0; i < MAX_ARRAY; i++) 
	{
	int lineCount[MAX_ARRAY] = { 1,2,3,4,5,6,7,8,9 };
		nDAn[i] = (i + 1);
		printf("%d * 1 = %d \n",  nDAn[i], 1 * nDAn[i]);
		printf("%d * 2 = %d \n",  nDAn[i], 2 * nDAn[i]);
		printf("%d * 3 = %d \n", nDAn[i], 3 * nDAn[i]);
		printf("%d * 4 = %d \n", nDAn[i], 4 * nDAn[i]);
		printf("%d * 5 = %d \n", nDAn[i], 5 * nDAn[i]);
		printf("%d * 6 = %d \n", nDAn[i], 6 * nDAn[i]);
		printf("%d * 7 = %d \n", nDAn[i], 7 * nDAn[i]);
		printf("%d * 8 = %d \n", nDAn[i], 8 * nDAn[i]);
		printf("%d * 9 = %d \n", nDAn[i], 9 * nDAn[i]);


	}
}


////과제 배열 사용해서 아래처럼 별 5 개 찍어보기 (노말)
//// *****
//
//// 배열 사용해서 아래처럼 0을 오른쪽으로 이동하며 찍어보기  (어렵다 )
////0**** -> *0** enter(_아무키) 마지막은 프로그램 종료 
// 
// 
// 아래의 프로그램을 수정해서 a 로 0이 왼쪽 d로 0이 오른쪽으로 이동 가능하도록 만들기 (매우 어려움 )
// 
//void Description005() {
//	//길을 걷는 사람 1 
//	char board[5] = { 0, };
//	//borad를 초기화 하는 로직
//	for (int i = 0; i < 5; i++)
//	{
//		board[i] = '*';
//		if (i = 0) {
//			board[i] = '0';
//		}
//
//	}
//	//board를 출력하는 로직 
//	for (int i = 0; i < 5; i++)
//	{
//		printf("%c" , board[i]);
//
//	}
//
//	printf("\n\n");




//void Description003() {
	//배열이란 무엇인지 실습
	//const int MAX_ARRAY = 5;
	//int numbers[MAX_ARRAY];      //5개의 변수를 선언한것이다.
	////numbers[0] = 100;
	////numbers[1] = 200;
	////numbers[2] = 300;
	////numbers[3] = 400;
	////numbers[4] = 500;

	//for (int i = 0; i < MAX_ARRAY; i++) {
	//	numbers[i] = (i + 1) ;
	//	printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", i, numbers[i]);

	//}

	//int numbers2[5] = { 10,20,30,40,50 };
	//int numbers3[5] = { 0, };  //모든 배열을 전부 0으로 초기화 하겠다는 의미 

	//int number1 = 1;
	//int number2 = 2;
	//int number3 = 3;
	//int number4 = 4;
	//int number5 = 5;


	//printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", 0, number1);
	//printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", 1, number2);
	//printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", 2, number3);
	//printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", 3, number4);
	//printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d ,%d)\n", 4, number5);



//}




//void Description002() {
//	//캐스팅 테스트
//	char char_ = 'A';
//	int int_ = char_;
//	float floatvalue = 100.123;
//	int_ = floatvalue;
//
//	printf("int_ 변수안에 무슨 값이 들어있나? %f \n", (float)int_);
//}

//void addOne(int* localNumber1, int* localNumber2) {
//	*localNumber1 += 1;
//	*localNumber2 += 1;
//}
//	
//
//void Description001(int number) {
//	printf("Number는 %d \n", number);
//}
