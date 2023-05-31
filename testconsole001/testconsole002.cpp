#include<iostream> 
#include<stdio.h> 


//void YourAge(int age) {
//	printf("정현우 , 나이는 %d살 입니다. , 010-5041-1971  \n", age + 1); // (age < 40): 1 : 2 삼항연산자 예시 
//}


//int Damage(int Damage1) {
//	printf(" 크리티컬이 터졌습니다! %f ", Damage1 * 1.5);
//	return Damage1;

//}

//int YourAge(int age) {
//	printf("나의 나이는 %d살 입니다. \n", age);
//	return age;
//}

//int Plus(int num1 ,int num2) {
//	printf("두 수는 %d ,%d 입니다.\n", num1, num2);
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
//	printf("힐을 받고 남은 체력량 %d", Hp);
//	printf(" 힐 %d 을 받았습니다.", heal);
//	return 0;
//}

/*void PrintFunc(int age);*/ // main 함수보다 먼저 내가 만든 함수가 이런 모양이다. 라고 알려주는 역할 


 	


int main() {
	
	int cp = 2;
	int inputNumber = 0;
	scanf_s("%d", &inputNumber);
	printf("숫자를 입력해주세여 ->");

	int abc = (cp < inputNumber) ? printf("승리") : printf("패배"); 
	


	//printf("숫자값을 입력해 주세요 ->");
	//int inputNumber = 0;
	//scanf_s("%d", &inputNumber);

	//printf("Input number 의 값은? %d \n", inputNumber);


	/*PrintFunc(20);*/
	//printf("두 수의 더하기는 %d 입니다.  \n", Plus(9, 2));
	//printf("두 수의 빼기는는 %d 입니다.  \n", Minus(9, 2));
	//printf("두 수의 나누기는 %d 입니다.  \n", Division(9, 2));
	//printf("두 수의 곱하기는 %d 입니다.  \n", Multiplication(9, 2));
	//printf("두 수의 나머지는 %d 입니다.  \n", Remainder(9, 2));
	//c++ 에서 main 함수는 무조건 있어야 한다.
	//프로그램은 main함수에서 부터 시작한다. 
	/*YourAge(25);*/ // 이런게 함수의 호출이다.
	
	/*Damage(100);*/

	//int number = 10; // integer가 정수다 . 그러니 정수를 저장하기 위한 데이터 타입으로 줄임말인 int를 썼다.
  
	//int number2 = 1.6;
	//float number3 = 1.6;

	//printf("실수를 출력해 보겠습니다. %d\n", number2);
	//printf("실수를 출력해 보겠습니다. %d", number3);

	//int _int = 10; 에서 변수이름앞에 언더바가 있으면 건드리지 말라는 뜻이다.



	//return 0;
	
	//int number = 0;
	//printf("number 변수를 찍어볼까? : %d\n\n", number);


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
	//printf(" someNumber 안에는 무슨 값이 들어 있을까 ? %d \n", someNumber);

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

	//printf("Result1 결과는 %d \n", result1);
	//printf("Result2 결과는 %d \n", result2);
	//printf("Result3 결과는 %d \n", result3);

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
	//printf("Bool result는 어떤 값? %d", boolResult);
	//printf("총 힐량은 %d 입니다.", PlusHeal(20));


	//PlusHeal(200);


	return 0;
 }

//void PrintFunc(int age) {
//	printf("정현우 , 나이 : %d, 010-5041-1971 \n\n", age);
//}