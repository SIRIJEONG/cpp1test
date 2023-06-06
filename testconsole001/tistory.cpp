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
	int numbers[MAX_ARRAY];      //5개의 변수를 선언한것이다.
	//numbers[0] = 100;
	//numbers[1] = 200;
	//numbers[2] = 300;
	//numbers[3] = 400;
	//numbers[4] = 500;

	for (int i = 0; i < MAX_ARRAY; i++) {
		numbers[i] = (i + 1) ;
		printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", i, numbers[i]);

	}

	int numbers2[5] = { 10,20,30,40,50 };
	int numbers3[5] = { 0, };  //모든 배열을 전부 0으로 초기화 하겠다는 의미 

	int number1 = 1;
	int number2 = 2;
	int number3 = 3;
	int number4 = 4;
	int number5 = 5;


	printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", 0, number1);
	printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", 1, number2);
	printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", 2, number3);
	printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d, %d)\n", 3, number4);
	printf("배열의 값 앞은(인덱스 , 뒤는 값) (%d ,%d)\n", 4, number5);

}
