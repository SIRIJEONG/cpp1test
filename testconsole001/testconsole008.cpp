#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Description001();

int main() {
	Description001();
}

void Description001() {

	int userInput = -1;
	printf("���ϴ� ũ�⸸ŭ �迭�� ������� ũ�⸦ �Է��ϼ��� : ");
	scanf_s("%d", &userInput);

	//new �����Ҵ� 
	//const int INT_TEN = 10;
	int numbers[10] = { 0 , };
	int* numbers2 = new int[userInput];  //�����ٰ� �迭�� �Ҵ� �ߴ�.

	for (int i = 0; i < userInput; i++) {
		numbers2[i] = i + 1;
	}

	for (int i = 0; i < userInput; i++) {
		printf("i�� : %d \n", numbers2[i]);
	}
	printf("\n\n");

	//���α׷� ����ÿ� 
	delete numbers2;

}

