#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Descrtiption003();


int main() {
	Descrtiption003();
}

void Description003() {
	const int MAX_ARRAY = 5;
	int numbers[MAX_ARRAY];      //5���� ������ �����Ѱ��̴�.
	//numbers[0] = 100;
	//numbers[1] = 200;
	//numbers[2] = 300;
	//numbers[3] = 400;
	//numbers[4] = 500;

	for (int i = 0; i < MAX_ARRAY; i++) {
		numbers[i] = (i + 1) ;
		printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", i, numbers[i]);

	}

	int numbers2[5] = { 10,20,30,40,50 };
	int numbers3[5] = { 0, };  //��� �迭�� ���� 0���� �ʱ�ȭ �ϰڴٴ� �ǹ� 

	int number1 = 1;
	int number2 = 2;
	int number3 = 3;
	int number4 = 4;
	int number5 = 5;


	printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", 0, number1);
	printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", 1, number2);
	printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", 2, number3);
	printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d, %d)\n", 3, number4);
	printf("�迭�� �� ����(�ε��� , �ڴ� ��) (%d ,%d)\n", 4, number5);

}
