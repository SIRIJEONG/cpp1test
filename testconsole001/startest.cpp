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

////���� �迭 ����ؼ� �Ʒ�ó�� �� 5 �� ���� (�븻)
//// *****
//
//// �迭 ����ؼ� �Ʒ�ó�� 0�� ���������� �̵��ϸ� ����  (��ƴ� )
////0**** -> *0** enter(_�ƹ�Ű) �������� ���α׷� ���� 
// 
// 
//�Ʒ��� ���α׷��� �����ؼ� a �� 0�� ���� d�� 0�� ���������� �̵� �����ϵ��� ����� (�ſ� ����� )





 
//void star()
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



//void moveStar()
//{
//	// �� �̵��ϱ� 
//
//	int enterpress = 0;  //���� Ƚ�� ����� �ʱ�ȭ
//
//	char board[5] = { 0, };  // ��� �迭�� 0 ���� �ʱ�ȭ 
//
//	while (1)  //��� �ݺ�
//	{
//
//		//borad�� �ʱ�ȭ �ϴ� ����
//		for (int i = 0; i < 5; i++)
//		{
//
//			board[i] = '*'; //�� �ε������� *�� ����Ѵ�.
//			if (i == enterpress) //����� �ε����� ����Ƚ���� ������ 0�� ����Ѵ�.
//			{
//				board[enterpress] = '0';
//
//			}
//			
//
//		}
//			
//		//borad�� ��� �ϴ� ����
//		for (int i = 0; i < 5; i++)
//		{
//			printf("%c ", board[i]);
//			
//		}
//
//		if (enterpress == 4) // ���� 4�� ������ �����Ѵ�.
//		{
//			break;
//		}
//		_getch(); //���͸� ������ ȭ�鿡 �������� �ʰ� �ٷ� ����ȴ� �Լ� 
//		enterpress++;  // ���� ���� Ƚ���� ��� �����ش�.
//		printf("\n");  //���͸� ������ ���ٿ� ��µ��� �ʰ� �ٹٲ� ���ش�.
//		
//	}
//}






void moveStar2()
{
	// Ű ������ �� �̵��ϱ� 
	char anyKey = '0';
	int enterpress = 0;  //���� Ƚ�� ����� �ʱ�ȭ

	char board[5] = { 0, };  // ��� �迭�� 0 ���� �ʱ�ȭ 
	printf("a�� ������ �������� d �� ������ ���������� �̵�");

	while (1)  //��� �ݺ�
	{
		system("cls");
		//borad�� �ʱ�ȭ �ϴ� ����d
		for (int i = 0; i < 5; i++)
		{

			board[i] = '*'; //�� �ε������� *�� ����Ѵ�.
			if (i == enterpress  && -1 < enterpress&& enterpress < 6) //����� �ε����� ����Ƚ���� ������ 0�� ����Ѵ�.
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

		//borad�� ��� �ϴ� ����
		for (int i = 0; i < 5; i++)
		{
			printf("%c ", board[i]);

		}


		anyKey =_getch(); //���͸� ������ ȭ�鿡 �������� �ʰ� �ٷ� ����ȴ� �Լ� 

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
		
		printf("\n");  //���͸� ������ ���ٿ� ��µ��� �ʰ� �ٹٲ� ���ش�.

	}
}



