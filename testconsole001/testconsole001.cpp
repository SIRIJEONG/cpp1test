#include<iostream> 
#include<stdio.h> //��ó���� ���ù� 
                  // #include �ȿ� < ,> �ȿ� �����ִ� ���� ������� 

int MultiplicationThreeNumbers(int number1, int number2, int number3) {
	printf("�Է°��� %d , %d ,%d�Դϴ�. ", number1, number2, number3);
	return number1 * number2 * number3;
}

void MyNewPrint(int number) {
	printf("�Է°��� %d �Դϴ�. \n", number);
}

int plusTwoNumbers(int number1, int number2) {
	printf("�Է� ���� %d ,%d�Դϴ�.", number1, number2);
	return number1 + number2;
}



int main(){

	int number = 10;
	std::cout << "Hello! world! \n";
	printf("hello world!! \n");

	printf("hello world!! \n");
	printf("hello world!! \n");
	printf("hello world!! %d\n" , number - 2 );

	MyNewPrint(100);// ������ �Լ��� ����ϴ� �ٿ��� �Լ��� �θ���.

	printf("�� ���� ����? %d �Դϴ�.  \n\n", plusTwoNumbers(5, 7));

	printf("�� ������ ���� ? %d �Դϴ�. ", MultiplicationThreeNumbers(5, 5, 5));

	//  Comment �ּ� �� ������ ���α׷��� ������ ���� �ʴ´� 
	// ���� �ʿ��� ���ڸ� ������� ������ �ȴ�.

	//�����ּ��̶�� �Ѵ�

	/*
	�̰� ������ �ּ��̶�� �Ѵ�
	������ �ּ� 
	�� ���ε��� ���α׷��� ������ ���� �ʴ´�. */

	return 0; //������ ������ ���� �Լ��� ���ᰡ �ȴ�.
}