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

////���� �迭 ����ؼ� �Ʒ�ó�� �� 5 �� ���� (�븻)
//// *****
//
//// �迭 ����ؼ� �Ʒ�ó�� 0�� ���������� �̵��ϸ� ����  (��ƴ� )
////0**** -> *0** enter(_�ƹ�Ű) �������� ���α׷� ���� 
// 
// 
//�Ʒ��� ���α׷��� �����ؼ� a �� 0�� ���� d�� 0�� ���������� �̵� �����ϵ��� ����� (�ſ� ����� )





 
//void Description005()
//{
//	// �� 5�� ��� 
//	char board[5] = { 0, };
//
//	for (int i = 0; i < 5; i++)
//	{
//		board[i] = '*';
//	}
//	//borad�� ��� �ϴ� ����
//	for (int i = 0; i < 5; i++)
//	{
//		printf("%c", board[i]);
//
//
//	}
//}



void Description006()
{
	// �� �̵��ϱ� 

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
			
		//borad�� ��� �ϴ� ����
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






