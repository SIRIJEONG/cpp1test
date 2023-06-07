#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void moveStar();

int main() {

	moveStar();
}

void moveStar()
{
	// 별 이동하기 

	int enterpress = 0;  //엔터 횟수 선언과 초기화

	char board[5] = { 0, };  // 모든 배열을 0 으로 초기화 

	while (1)  //계속 반복
	{

		//borad를 초기화 하는 로직
		for (int i = 0; i < 5; i++)
		{

			board[i] = '*'; //각 인덱스마다 *을 출력한다.
			if (i == enterpress) //요소의 인덱스와 엔터횟수가 같으면 0을 출력한다.
			{
				board[enterpress] = '0';

			}


		}

		//borad를 출력 하는 로직
		for (int i = 0; i < 5; i++)
		{
			printf("%c ", board[i]);

		}

		if (enterpress == 4) // 엔터 4번 누르고 종료한다.
		{
			break;
		}
		_getch(); //엔터를 누를때 화면에 보여지지 않고 바로 실행된는 함수 
		enterpress++;  // 엔터 누른 횟수를 계속 더해준다.
		printf("\n");  //엔터를 누르고 한줄에 출력되지 않게 줄바꿈 해준다.

	}
}
