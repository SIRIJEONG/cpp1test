#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Description001();
void ArrayFunc(int* ptrArray , int arraySize);
void ArrayFunc2(int array_[] , int arraySize);
void Description002();
void swap2(char* firstChar, char* secondChar);
void Description003();
void Description004();
void Description005();
void Description006();

int main() {
	//Description001();
	//Description002();
	//Description003();
	//Description005();
	Description006();
	//Description004();
	//ArrayFunc();
	//array_[]();
}

//void Description001() {
//	int numbers[10] = { 0 , };
//	for (int i = 0; i < 10; i++) {
//		numbers[i] = (i + 1) * 10 ;
//	}
//	for (int i = 0; i < 10; i++) {
//		printf("%d ", numbers[i]);
//	}
//	printf("\n");
//
//	int* ptrnumber = &numbers[2];
//
//	//������ (�迭�� 5�� ° ���� ���� �Ϸ��� �� ��)
//	numbers[4];           //�� ���°� �迭�� ����� ������ 
//	*(ptrnumber + 4);	  //�� ���°� �����͸� ����� ������ 	
//
//
//	printf("3���� �ڸ��� �ִ� �� + 1 -> %d \n", *(ptrnumber + 1));
//
//	printf("numbers�� ����ִ� ��  -> %p \n", numbers);
//	printf("numbers[0]�� �ּ� ��  -> %p \n", &numbers[0]);
//	printf("\n\n");
//
//	printf("numbers�� size : %d \n", sizeof(numbers));
//	//ArrayFunc(numbers, 10);
//
//	ArrayFunc2(numbers , 10);
//}

//void ArrayFunc(int* ptrArray ,int arraySize) {
//	for(int i = 0; i < arraySize; i ++)
//	//printf("ptrArray ������ �� : %d \n", *(ptrArray));
//	//printf("ptrArray + 1 ������ �� : %d \n", *(ptrArray + 1));
//	printf("ptrArray[%d] ������ �� : %d \n", i ,  *(ptrArray + i));
//
//
//}
//
//
//void ArrayFunc2(int array_[] , int arraySize) {
//
//	printf("�Լ����� �� numbers�� size : %d \n", sizeof(array_));
//
//	for (int i = 0; i < sizeof(array_) / sizeof(int); i++) 
//	{
//
//		printf("array[%d]�� �� : %d \n", i, array_[i]);
//
//	}
//
//
//}

// ����
//void Description004() {
//
//	int number[5] = {21,59,36,99,17};
//	int temp = 0;
//	
//
//for (int i = 0; i < 4; i++)
//{
//	if (number[i] > number[i + 1]) {
//		swap2(&number[i], &number[i + 1]);
//		continue;
//	}
//	else if (number[i] < number[i + 1]) {
//		continue;
//
//	}
//
//
//}
//for (int i = 0; i < 3; i++)
//{
//	if (number[i] > number[i + 1]) {
//		swap2(&number[i], &number[i + 1]);
//		continue;
//	}
//	else if (number[i] < number[i + 1]) {
//		continue;
//
//	}
//
//
//}
//for (int i = 0; i < 2; i++)
//{
//	if (number[i] > number[i + 1]) {
//		swap2(&number[i], &number[i + 1]);
//		continue;
//	}
//	else if (number[i] < number[i + 1]) {
//		continue;
//
//	}
//
//
//}
//for (int i = 0; i < 1; i++)
//{
//	if (number[i] > number[i + 1]) {
//		swap2(&number[i], &number[i + 1]);
//		continue;
//	}
//	else if (number[i] < number[i + 1]) {
//		continue;
//
//	}
//
//
//}
//
//for (int i = 0; i < 5; i++) {
//
//	printf("%d ", number[i]);
//}
//
//	}


//�Է¹���
//void Description003() {
//
//	int number[5] = {0 , };
//	int temp = 0;
//	printf("���� 5���� �Է��Ͻÿ� -> ");
//	scanf_s("%d %d %d %d %d", &number[0], &number[1], &number[2], &number[3], &number[4]);
//	
//		
//	
//			for (int i = 0; i < 4; i++) 
//			{
//				if (number[i] > number[i+1]) {
//					swap2(&number[i], &number[i+1]);
//					continue;
//				}
//				else if (number[i] < number[i+1]) {
//					continue;
//
//				}
//
//				
//			}
//			for (int i = 0; i < 3; i++)
//			{
//				if (number[i] > number[i + 1]) {
//					swap2(&number[i], &number[i + 1]);
//					continue;
//				}
//				else if (number[i] < number[i + 1]) {
//					continue;
//
//				}
//
//
//			}
//			for (int i = 0; i < 2; i++)
//			{
//				if (number[i] > number[i + 1]) {
//					swap2(&number[i], &number[i + 1]);
//					continue;
//				}
//				else if (number[i] < number[i + 1]) {
//					continue;
//
//				}
//
//
//			}
//			for (int i = 0; i < 1; i++)
//			{
//				if (number[i] > number[i + 1]) {
//					swap2(&number[i], &number[i + 1]);
//					continue;
//				}
//				else if (number[i] < number[i + 1]) {
//					continue;
//
//				}
//
//
//			}
//	
//			for (int i = 0; i < 5; i++) {
//	
//				printf("%d ",  number[i]);
//			}
//}


//void Description002() {
//
//
//	int number[5] = { 21,59,36,99,17 };
//	int temp = 0;
//
//	for (int i = 0; i < 5; i++)
//	{
//
//		if (i == 1)
//		{
//			swap2(&number[0], &number[4]);
//			swap2(&number[1], &number[4]);
//			swap2(&number[3], &number[4]);
//
//		}
//	}
//
//	for (int i = 0; i < 5; i++) {
//
//		printf("%d ", number[i]);
//	}
//
//}



//void Description005() {
//
//	int number[5] = { 0 , };
//	int temp = 0;
//	printf("���� 5���� �Է��Ͻÿ� -> ");
//	scanf_s("%d %d %d %d %d", &number[0], &number[1], &number[2], &number[3], &number[4]);
//
//
//
//	for (int i = 1; i < 5; i++)
//	{		
//			for (int j = 0; j < i ; j++) {
//				if (number[i - j-1] > number[i - j ] ) {
//					swap2(&number[i - j-1], &number[i - j]);
//					continue;
//				}
//			}
//		
//
//	}
//
//		for (int i = 0; i < 5; i++) {
//
//			printf("%d ", number[i]);
//		}
//	/*for (int i = 0; i < 5; i++) {
//
//		printf("%d ", number[i]);
//	}*/
//}





void Description006() {
	//������ �迭
	char anykey = '0';
	int userx = 2;
	int usery = 2;
	char char_[25] = { 0 , };
	char char2_[5][5] = { 0 , };
	//{
	//	{1,2,3,4,5},
	//	{6,7,8,9,10},
	//	{11,12,13,14,15},
	//	{16,17,18,19,20},
	//	{21,22,23,24,25}
	//};
	for (int i = 0; i < 25; i++) {
		char_[i] = '*';
	}
	for (int y = 0; y < 5; y++) {
		for (int x = 0; x < 5; x++) {
			if (x == 2 && y == 2) {
				char2_[2][2] = '0';
				continue;
			}

			char2_[y][x] = '*';
		}
	}


	//��ºκ�
	//for (int i = 0; i < 25; i++) {
	//	printf("%c ", char_[i]);
	//	if (i % 5 == 4) {
	//		printf("\n");
	//	}
	/*}*/

	while (1) 
	{
		for (int y = 0; y < 5; y++) {
			for (int x = 0; x < 5; x++) {
				printf("%c ", char2_[y][x]);
			}
			printf("\n");
		}
		
		anykey = _getch();
		system("cls");

		if (anykey == 'a' || anykey == 'A') {
			swap2(&char2_[usery][userx], &char2_[usery][userx - 1]);
			userx -= 1;
		}
		else if (anykey == 'd' || anykey == 'D') {
			swap2(&char2_[usery][userx], &char2_[usery][userx + 1]);
			userx += 1;
		}
		else if (anykey == 's' || anykey == 'S') {
			swap2(&char2_[usery][userx], &char2_[usery+1][userx]);

			usery += 1;
		}
		else if (anykey == 'w' || anykey == 'W') {
			swap2(&char2_[usery][userx], &char2_[usery-1][userx]);

			usery -= 1;
		}
		
	}


	printf("\n");
}
void swap2(char* firstChar, char* secondChar) {
	//printf("[�����ϱ� �� ]firstChar �� : %c , secondChar ��  %c \n", *firstChar, *secondChar);

	int temp = 0;
	temp = (*firstChar);
	(*firstChar) = (*secondChar);
	(*secondChar) = temp;
	//printf("[���� ���� ]firstChar �� : %c , secondChar ��  %c \n", *firstChar, *secondChar);
}