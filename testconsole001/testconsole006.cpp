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
//	printf("���ڿ��� �Է��ϼ��� (200�� �̳���) : ");
//	std::cin >> str;
//
//	printf("����� �Է��� �޾Ҵµ� %s", str);
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
//	printf("������ �迭�� ũ�� %d \n", sizeof(string_));  //�迭�� ���̸� ������ �� �ִ�.
//	printf("������ �迭�� 2��° ũ�� %d \n", sizeof(string2));  //�迭�� ���̸� ������ �� �ִ�.
//	printf("������ �迭�� ũ�� %d \n", sizeof(numbers));  //�迭�� ���̸� ������ �� �ִ�.
//	printf("������ �迭�� ũ�� %d \n", sizeof(numbers) / sizeof(int));  //�迭�� ���̸� ������ �� �ִ�.
//
//	string_[0] = 'G';
//	string_[1] = 'g';
//	string_[2] = 'g';
//
//	printf("���ڿ� �迭�� ������ �����Ǵ���? %s \n", string_);
//
//
//
//	bool isNullSamezero = false;
//	if (0 == '\0') //Null�� 0�̴�.
//	{
//		isNullSamezero = true;
//	}
//	else
//	{
//		isNullSamezero = false;
//	}
//	printf("Null�� 0�� ���� ���ΰ�? [%d] \n", isNullSamezero);
//
//	char string3[4];
//	string3[0] = 'H';
//	string3[1] = 'i';
//	string3[2] = '!';
//	string3[3] = '\0';
//
//
//	char string4[4] = "Hi!";
//	printf("string4�� ������ %s \n", string4);
//	printf("string3�� ������ %s \n", string3);
//}


//void Description003() {
//
//	//���ڿ��� �Է¹޾Ƽ�  - > ����ϴ°� 
//	// ���ڿ��� �Է¹޾Ƽ� �빮�� - �ҹ��� - �빮�� - �ҹ��� ... ������ �����ؼ� ����ϴ� ���α׷� �ۼ��ϱ� 
//	// ���� ���α׷��� �����ؼ� �Ųٷ� ����� ����ϴ� ���α׷� �ۼ��ϱ� 
//
//	char str[300] = { 0 , };
//	printf("���ڿ��� �Է��ϼ��� (200�� �̳���) : ");
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
//	// ���� ���α׷��� �����ؼ� �Ųٷ� ����� ����ϴ� ���α׷� �ۼ��ϱ� 
//
//	char str[200] = { 0 , };
//	printf("���ڿ��� �Է��ϼ��� (200�� �̳���) : ");
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
//			printf("%s", reverseString ); //�̿ϼ�
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
//	//�迭�� ����� �ʱ�ȭ
//	int numbers[10] = { 0, };
//	for (int i = 0; i < 10; i++) 
//	{
//		numbers[i] = i + 1;
//	}
//
//	//�迭�� ���
//	printf("shuffle�ϱ��� \n\n");
//	for (int i = 0; i < 10; i++) 
//	{
//		printf("%d ", numbers[i]);
//	}
//	printf("\n\n");
//
//	//���÷���
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
//	//�迭�� ���
//	printf("shuffle �� ��  \n\n");
//	for (int i = 0; i < 10; i++)
//	{
//		printf("%d ", numbers[i]);
//	}
//	printf("\n\n");
//
//}






void DescriptionShuffle2()
{
	//�迭�� ����� �ʱ�ȭ
	int numbers[45] = { 0, };
	for (int i = 0; i < 45; i++)
	{
		numbers[i] = i + 1;
	}

	//�迭�� ���
	printf("shuffle�ϱ��� \n\n");
	for (int i = 0; i < 10; i++)
	{
		printf("%d ", numbers[i]);
	}
	printf("\n\n");

	//���÷���
	const int shuffleCount = 1000000;
	int randomIndex1, randomIndex2 = 0;
	srand(time(NULL));
	for (int i = 0; i < shuffleCount; i++) {
		randomIndex1 = rand() % 45 ;
		randomIndex2 = rand() % 45 ;
		ShuffleOnce(&numbers[randomIndex1], &numbers[randomIndex2]);
	}

	printf("\n");

	//�迭�� ���
	printf("shuffle �� ��  \n\n");
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


//Ʈ���� ī�� 1�� �̾Ѱ� ����ϴ� ���α׷� ����� 
//��Ʈ . int cards[52] = { 0, };
//      char cardPatterns[4] = {'��','��','��','��'}
// ��¿��� 
// ������ ���� 




void Description006() {
	//������ ���� �ĺ��� 
	int number = 100;
	int* ptrNumber = &number;

	printf("number ������ �ּҴ� : %p , �Ҵ�� ���� %d \n", &number, number);
	printf("ptrNumber ������ �ּҴ� : %p , �Ҵ�� ���� %p  ,�� ������ �� : %d \n", &ptrNumber, ptrNumber , *ptrNumber);
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
	printf("[�����ϱ� �� ]firstChar �� : %c , secondChar ��  %c \n", firstChar, secondChar);

	char temp = '\0';
	temp = firstChar;
	firstChar = secondChar;
	secondChar = temp;
	printf("[���� ���� ]firstChar �� : %c , secondChar ��  %c \n" , firstChar, secondChar);
}




void swap2(char* firstChar, char* secondChar) {
	printf("[�����ϱ� �� ]firstChar �� : %c , secondChar ��  %c \n", *firstChar, *secondChar);

	char temp = '\0';
	temp = (*firstChar);
	(*firstChar) = (*secondChar);
	(*secondChar) = temp;
	printf("[���� ���� ]firstChar �� : %c , secondChar ��  %c \n", *firstChar, *secondChar);
}
