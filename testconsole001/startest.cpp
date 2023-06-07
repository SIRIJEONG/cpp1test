#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void star();
void moveStar();
void moveStar2();

int main() {
	//star();
	//moveStar();
	moveStar2();
}

////과제 배열 사용해서 아래처럼 별 5 개 찍어보기 (노말)
//// *****
//
//// 배열 사용해서 아래처럼 0을 오른쪽으로 이동하며 찍어보기  (어렵다 )
////0**** -> *0** enter(_아무키) 마지막은 프로그램 종료 
// 
// 
//아래의 프로그램을 수정해서 a 로 0이 왼쪽 d로 0이 오른쪽으로 이동 가능하도록 만들기 (매우 어려움 )





 
//void star()
//{
//	// 별 5개 찍기 
//	char board[5] = { 0, };
//
//	for (int i = 0; i < 5; i++)
//	{
//		board[i] = '*';
//	}
//	//borad를 출력 하는 로직
//	for (int i = 0; i < 5; i++)
//	{
//		printf("%c", board[i]);
//
//
//	}
//}



//void moveStar()
//{
//	// 별 이동하기 
//
//	int enterpress = 0;  //엔터 횟수 선언과 초기화
//
//	char board[5] = { 0, };  // 모든 배열을 0 으로 초기화 
//
//	while (1)  //계속 반복
//	{
//
//		//borad를 초기화 하는 로직
//		for (int i = 0; i < 5; i++)
//		{
//
//			board[i] = '*'; //각 인덱스마다 *을 출력한다.
//			if (i == enterpress) //요소의 인덱스와 엔터횟수가 같으면 0을 출력한다.
//			{
//				board[enterpress] = '0';
//
//			}
//			
//
//		}
//			
//		//borad를 출력 하는 로직
//		for (int i = 0; i < 5; i++)
//		{
//			printf("%c ", board[i]);
//			
//		}
//
//		if (enterpress == 4) // 엔터 4번 누르고 종료한다.
//		{
//			break;
//		}
//		_getch(); //엔터를 누를때 화면에 보여지지 않고 바로 실행된는 함수 
//		enterpress++;  // 엔터 누른 횟수를 계속 더해준다.
//		printf("\n");  //엔터를 누르고 한줄에 출력되지 않게 줄바꿈 해준다.
//		
//	}
//}






void moveStar2()
{
	// 키 눌러서 별 이동하기 
	char anyKey = '0';
	int enterpress = 0;  //엔터 횟수 선언과 초기화

	char board[5] = { 0, };  // 모든 배열을 0 으로 초기화 
	printf("a를 누르면 왼쪽으로 d 를 누르면 오른쪽으로 이동");

	while (1)  //계속 반복
	{
		system("cls");
		//borad를 초기화 하는 로직d
		for (int i = 0; i < 5; i++)
		{

			board[i] = '*'; //각 인덱스마다 *을 출력한다.
			if (i == enterpress  && -1 < enterpress&& enterpress < 6) //요소의 인덱스와 엔터횟수가 같으면 0을 출력한다.
			{
				board[enterpress] = '0';

			}
			else if (enterpress < 0) {
				board[0] = '0';
			}
			else  if (enterpress > 4) {
				board[4] = '0';
			}


		}

		//borad를 출력 하는 로직
		for (int i = 0; i < 5; i++)
		{
			printf("%c ", board[i]);

		}


		anyKey =_getch(); //엔터를 누를때 화면에 보여지지 않고 바로 실행된는 함수 

		switch (anyKey)
		{
		case 'a' :
			enterpress--;
			if (enterpress < 0) {
				enterpress = 0;
			}
			break;
		case 'd' :
			enterpress++;
			if (enterpress > 4) {
				enterpress = 4;
			}

		default:
			break;
		}
		
		printf("\n");  //엔터를 누르고 한줄에 출력되지 않게 줄바꿈 해준다.

	}
}



