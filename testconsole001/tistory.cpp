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
	// �� �̵��ϱ� 

	int enterpress = 0;  //���� Ƚ�� ����� �ʱ�ȭ

	char board[5] = { 0, };  // ��� �迭�� 0 ���� �ʱ�ȭ 

	while (1)  //��� �ݺ�
	{

		//borad�� �ʱ�ȭ �ϴ� ����
		for (int i = 0; i < 5; i++)
		{

			board[i] = '*'; //�� �ε������� *�� ����Ѵ�.
			if (i == enterpress) //����� �ε����� ����Ƚ���� ������ 0�� ����Ѵ�.
			{
				board[enterpress] = '0';

			}


		}

		//borad�� ��� �ϴ� ����
		for (int i = 0; i < 5; i++)
		{
			printf("%c ", board[i]);

		}

		if (enterpress == 4) // ���� 4�� ������ �����Ѵ�.
		{
			break;
		}
		_getch(); //���͸� ������ ȭ�鿡 �������� �ʰ� �ٷ� ����ȴ� �Լ� 
		enterpress++;  // ���� ���� Ƚ���� ��� �����ش�.
		printf("\n");  //���͸� ������ ���ٿ� ��µ��� �ʰ� �ٹٲ� ���ش�.

	}
}
