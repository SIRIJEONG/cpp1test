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
	printf("원하는 크기만큼 배열을 만들겠음 크기를 입력하세오 : ");
	scanf_s("%d", &userInput);

	//new 동적할당 
	//const int INT_TEN = 10;
	int numbers[10] = { 0 , };
	int* numbers2 = new int[userInput];  //힙에다가 배열을 할당 했다.

	for (int i = 0; i < userInput; i++) {
		numbers2[i] = i + 1;
	}

	for (int i = 0; i < userInput; i++) {
		printf("i값 : %d \n", numbers2[i]);
	}
	printf("\n\n");

	//프로그램 종료시에 
	delete numbers2;

}

