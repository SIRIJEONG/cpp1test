#include<iostream> 
#include<stdio.h> 


//void YourAge(int age) {
//	printf("������ , ���̴� %d�� �Դϴ�. , 010-5041-1971  \n", age + 1); // (age < 40): 1 : 2 ���׿����� ���� 
//}


//int Damage(int Damage1) {
//	printf(" ũ��Ƽ���� �������ϴ�! %f ", Damage1 * 1.5);
//	return Damage1;

//}

//int YourAge(int age) {
//	printf("���� ���̴� %d�� �Դϴ�. \n", age);
//	return age;
//}

//int Plus(int num1 ,int num2) {
//	printf("�� ���� %d ,%d �Դϴ�.\n", num1, num2);
//	return num1 + num2;
//}
//
//int Minus(int num1, int num2) {
//	return num1 - num2;
//}
//
//int Division(int num1, int num2) {
//	return num1 / num2;
//}
//
//int Multiplication(int num1, int num2) {
//	return num1 * num2;
//}
//
//int Remainder(int num1, int num2) {
//	return num1 % num2;
//}
//
//int PlusHeal(int heal) {
//
//	int MaxHp = 50;
//	int Current = 20;
//	int Hp = ((Current + heal) < MaxHp) ? (Current + heal) : MaxHp;
//
//	printf("���� �ް� ���� ü�·� %d", Hp);
//	printf(" �� %d �� �޾ҽ��ϴ�.", heal);
//	return 0;
//}

/*void PrintFunc(int age);*/ // main �Լ����� ���� ���� ���� �Լ��� �̷� ����̴�. ��� �˷��ִ� ���� 


 	


int main() {
	
	int cp = 2;
	int inputNumber = 0;
	scanf_s("%d", &inputNumber);
	printf("���ڸ� �Է����ּ��� ->");

	int abc = (cp < inputNumber) ? printf("�¸�") : printf("�й�"); 
	


	//printf("���ڰ��� �Է��� �ּ��� ->");
	//int inputNumber = 0;
	//scanf_s("%d", &inputNumber);

	//printf("Input number �� ����? %d \n", inputNumber);


	/*PrintFunc(20);*/
	//printf("�� ���� ���ϱ�� %d �Դϴ�.  \n", Plus(9, 2));
	//printf("�� ���� ����´� %d �Դϴ�.  \n", Minus(9, 2));
	//printf("�� ���� ������� %d �Դϴ�.  \n", Division(9, 2));
	//printf("�� ���� ���ϱ�� %d �Դϴ�.  \n", Multiplication(9, 2));
	//printf("�� ���� �������� %d �Դϴ�.  \n", Remainder(9, 2));
	//c++ ���� main �Լ��� ������ �־�� �Ѵ�.
	//���α׷��� main�Լ����� ���� �����Ѵ�. 
	/*YourAge(25);*/ // �̷��� �Լ��� ȣ���̴�.
	
	/*Damage(100);*/

	//int number = 10; // integer�� ������ . �׷��� ������ �����ϱ� ���� ������ Ÿ������ ���Ӹ��� int�� ���.
  
	//int number2 = 1.6;
	//float number3 = 1.6;

	//printf("�Ǽ��� ����� ���ڽ��ϴ�. %d\n", number2);
	//printf("�Ǽ��� ����� ���ڽ��ϴ�. %d", number3);

	//int _int = 10; ���� �����̸��տ� ����ٰ� ������ �ǵ帮�� ����� ���̴�.



	//return 0;
	
	//int number = 0;
	//printf("number ������ ����? : %d\n\n", number);


	//int num1 = 9, num2 = 2;
	//int result1 = 0;
	//result1 += (num1 + num2);
	////result1 = result1 + (num1 + num2);

	////num1++;
	//printf("num1 : %d \n", num1++);

	////++num1;
	//printf("num1 : %d \n", ++num1);

	//int someNumber = 0;
	//someNumber = someNumber++;
	//printf(" someNumber �ȿ��� ���� ���� ��� ������ ? %d \n", someNumber);

	//printf("%d + %d = %d \n", num1, num2, num1 + num2);
	//printf("%d - %d = %d \n", num1, num2, num1 - num2);
	//printf("%d * %d = %d \n", num1, num2, num1 * num2);
	//printf("%d / %d = %d \n", num1, num2, num1 / num2);
	//printf("%d %% %d = %d \n", num1, num2, num1 % num2);



	//int num1 = 10;
	//int num2 = 12;
	//int result1, result2, result3;

	//result1 = num1 == num2;
	//result2 = num1 <= num2;
	//result3 = num1 > num2;

	//printf("Result1 ����� %d \n", result1);
	//printf("Result2 ����� %d \n", result2);
	//printf("Result3 ����� %d \n", result3);

	//int num1 = 10;
	//int num2 = 12;
	//int result1, result2, result3;

	//result1 = (num1 == 10 && num2 == 12);
	//result2 = (num1 < 12 || num2 > 12);
	//result3 = (!num1);

	//printf("result1: %d \n", result1);
	//printf("result2: %d \n", result2);
	//printf("result3: %d \n", result3);


	//int age = 25;
	//bool boolResult;

	//boolResult = (age < 20) ? true : false;
	//printf("Bool result�� � ��? %d", boolResult);
	//printf("�� ������ %d �Դϴ�.", PlusHeal(20));


	//PlusHeal(200);


	return 0;
 }

//void PrintFunc(int age) {
//	printf("������ , ���� : %d, 010-5041-1971 \n\n", age);
//}