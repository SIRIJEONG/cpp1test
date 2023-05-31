#include<iostream> 
#include<stdio.h> //전처리기 지시문 
                  // #include 안에 < ,> 안에 적어주는 것이 헤더파일 

int MultiplicationThreeNumbers(int number1, int number2, int number3) {
	printf("입력값은 %d , %d ,%d입니다. ", number1, number2, number3);
	return number1 * number2 * number3;
}

void MyNewPrint(int number) {
	printf("입력값은 %d 입니다. \n", number);
}

int plusTwoNumbers(int number1, int number2) {
	printf("입력 값은 %d ,%d입니다.", number1, number2);
	return number1 + number2;
}



int main(){

	int number = 10;
	std::cout << "Hello! world! \n";
	printf("hello world!! \n");

	printf("hello world!! \n");
	printf("hello world!! \n");
	printf("hello world!! %d\n" , number - 2 );

	MyNewPrint(100);// 실제로 함수를 사용하는 줄에서 함수를 부른다.

	printf("두 수의 합은? %d 입니다.  \n\n", plusTwoNumbers(5, 7));

	printf("세 숫자의 곱은 ? %d 입니다. ", MultiplicationThreeNumbers(5, 5, 5));

	//  Comment 주석 이 라인은 프로그램에 영향을 주지 않는다 
	// 내가 필요한 글자를 마음대로 적으면 된다.

	//한줄주석이라고 한다

	/*
	이걸 여러줄 주석이라고 한다
	여러줄 주석 
	이 라인들은 프로그램에 영향을 주지 않는다. */

	return 0; //리턴을 만나는 순간 함수는 종료가 된다.
}