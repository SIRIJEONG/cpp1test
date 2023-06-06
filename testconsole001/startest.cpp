#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Description005();
void Description006();

int main() {
	//Description005();
	Description006();
}

////과제 배열 사용해서 아래처럼 별 5 개 찍어보기 (노말)
//// *****
//
//// 배열 사용해서 아래처럼 0을 오른쪽으로 이동하며 찍어보기  (어렵다 )
////0**** -> *0** enter(_아무키) 마지막은 프로그램 종료 
// 
// 
//아래의 프로그램을 수정해서 a 로 0이 왼쪽 d로 0이 오른쪽으로 이동 가능하도록 만들기 (매우 어려움 )





 
//void Description005()
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



void Description006()
{
	// 별 이동하기 

	int enterpress = 0;

	char board[5] = { 0, };

	while (1)
	{


		for (int i = 0; i < 5; i++)
		{

			board[i] = '*';
			if (i == enterpress) {
				board[enterpress] = '0';

			}
			

		}
			
		//borad를 출력 하는 로직
		for (int i = 0; i < 5; i++)
		{
			printf("%c ", board[i]);
			
		}

		if (enterpress == 4) {
			break;
		}
		_getch();
		enterpress++;
		printf("\n");
		
	}
}






