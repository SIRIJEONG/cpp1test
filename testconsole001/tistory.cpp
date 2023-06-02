#include<iostream> 
#include<stdio.h>


int main() {
	int loopcount = 388; //변수 설정
	while (1 <= loopcount) {       //while (조건식)
		printf("Hello world! 몇번 째 돌고 있는지 ? %d \n", loopcount);
		loopcount -= 1; //조건식을 만족할 때 까지 반복 
	} // loop종료
}
