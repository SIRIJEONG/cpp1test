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
	////�� ��ġ���� ���α׷��� ���۵ȴ�.
	//Description001(10);
	//printf("Description001�Լ��� ���Ƹ� �ǵ��ƿͼ� �̰� ����ؾ��� \n");

	//int mainNumber1 = 0;
	//int	mainNumber2 = 0;
	//addOne(&mainNumber1, &mainNumber2);
	//printf("number�� ���� 1:%d , 2:%d \n\n", mainNumber1, mainNumber2);
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


////���� �迭 ����ؼ� �Ʒ�ó�� �� 5 �� ���� (�븻)
//// *****
//
//// �迭 ����ؼ� �Ʒ�ó�� 0�� ���������� �̵��ϸ� ����  (��ƴ� )
////0**** -> *0** enter(_�ƹ�Ű) �������� ���α׷� ���� 
// 
// 
// �Ʒ��� ���α׷��� �����ؼ� a �� 0�� ���� d�� 0�� ���������� �̵� �����ϵ��� ����� (�ſ� ����� )
// 
//void Description005() {
//	//���� �ȴ� ��� 1 
//	char board[5] = { 0, };
//	//borad�� �ʱ�ȭ �ϴ� ����
//	for (int i = 0; i < 5; i++)
//	{
//		board[i] = '*';
//		if (i = 0) {
//			board[i] = '0';
//		}
//
//	}
//	//board�� ����ϴ� ���� 
//	for (int i = 0; i < 5; i++)
//	{
//		printf("%c" , board[i]);
//
//	}
//
//	printf("\n\n");




//void Description003() {
	//�迭�̶� �������� �ǽ�
	//const int MAX_ARRAY = 5;
	//int numbers[MAX_ARRAY];      //5���� ������ �����Ѱ��̴�.
	////numbers[0] = 100;
	////numbers[1] = 200;
	////numbers[2] = 300;
	////numbers[3] = 400;
	////numbers[4] = 500;

	//for (int i = 0; i < MAX_ARRAY; i++) {
	//	numbers[i] = (i + 1) ;
	//	printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", i, numbers[i]);

	//}

	//int numbers2[5] = { 10,20,30,40,50 };
	//int numbers3[5] = { 0, };  //��� �迭�� ���� 0���� �ʱ�ȭ �ϰڴٴ� �ǹ� 

	//int number1 = 1;
	//int number2 = 2;
	//int number3 = 3;
	//int number4 = 4;
	//int number5 = 5;


	//printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", 0, number1);
	//printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", 1, number2);
	//printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", 2, number3);
	//printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", 3, number4);
	//printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d ,%d)\n", 4, number5);



//}




//void Description002() {
//	//ĳ���� �׽�Ʈ
//	char char_ = 'A';
//	int int_ = char_;
//	float floatvalue = 100.123;
//	int_ = floatvalue;
//
//	printf("int_ �����ȿ� ���� ���� ����ֳ�? %f \n", (float)int_);
//}

//void addOne(int* localNumber1, int* localNumber2) {
//	*localNumber1 += 1;
//	*localNumber2 += 1;
//}
//	
//
//void Description001(int number) {
//	printf("Number�� %d \n", number);
//}
