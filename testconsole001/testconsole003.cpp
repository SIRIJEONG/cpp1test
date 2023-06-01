#include<iostream> 
#include<stdio.h>

//int result(int x, int y, int z) {
//
//	return x + (y * z);
//}
//
//int result1(int x, int y, int z) {
//
//	return (x - y) * (y + z) * (y % x);
//}

//
//float oneban(int ban);  //전방선언 

/*char Al(char alpha);  *///전방선언 


//void result(int r); // void 반지름 
int star(int a , int b);


int main() {

	//{ 변수 선언부
	//int result;
	//int result1;
	//int x, y, z;
	//} 변수 선언부 

	// { 사용자 입력 받는 로직
	//printf("정수 one : ");
	//scanf_s("%d", &num1);
	//printf("정수 two : ");
	//scanf_s("%d", &num2);
	//printf("정수 2개를 입력해 주세요 :");
	//scanf_s("%d , %d", &num1 , &num2);  //줄여서 쓸수도 있다. 
	// } 사용자 입력 받는 로직
	/*int x, y, z;*/
	//printf("정수 3개를 입력해 주세요 :");
	//scanf_s("%d , %d , %d", &x , &y , &z);
	// { 실제 연산하는 로직 / 플러스 연산 
	//result = num1 + num2;  
	//printf("%d + %d = %d \n", num1, num2, result);
	// } 실제 연산하는 로직 / 플러스 연산 

	//result = x + (y * z);  //함수x
	//printf("%d + (%d * %d) = %d\n", x, y , z, result(x,y,z));  //함수x
	//printf("연산 값은 %d 입니다. \n", result(x, y, z));
	//result1 = (x - y) * (y + z) * (y % x);  //함수x
	//printf("(%d - %d) + (%d + %d) * (%d %% %d) = %d\n", x,y,y,z,y,x, result(x,y,z));  //함수x
	//printf("연산 값은 %d 입니다. \n", result1(x, y, z));


	//char charValue = 'A'; // 문자 하나를 저장하기 위한 데이터 타입 
	//short shortValue = 10; //int보다 작은 수를 저장하기 위한 데이터 타입
	//int intValue = 100; // 가장 만만한 수를 저장하기 위한 데이터 타입
	//long longValue = 200; // int가 커져서 이제 잘 안쓰는 데이터 타입
	//long long longlongValue = 1000; //int보다 큰 수를 저장히기 위한 데이터 타입

	//float floatValue = 10.1; //가장 만만한 실수를 저장하기 위한 데이터 타입
	//double doubleValue = 100.1; // float 보다 큰 실수를 저장하기 위한 데이터 타입
	//long double longDoubleValue = 200.1; // double 보다 큰 실수를 저장하기 위한 데이터 타입

	//printf(" char 의 크기는 %d byte \n" , sizeof(charValue));
	//printf(" short 의 크기는 %d byte \n" , sizeof(shortValue));
	//printf(" int 의 크기는 %d byte \n", sizeof(intValue));
	//printf(" long 의 크기는 %d byte \n", sizeof(longValue));
	//printf(" long long 의 크기는 %d byte \n", sizeof(longlongValue));


	//printf(" float 의 크기는 %d byte \n", sizeof(floatValue));
	//printf(" double 의 크기는 %d byte \n", sizeof(doubleValue));
	//printf(" long double 의 크기는 %d byte \n", sizeof(longDoubleValue));



	//int ban;
	//printf("원의 반지름을 입력해주세요 \n");
	//scanf_s("%d", &ban);
 //   printf("원의 넓이는 %f \n", oneban(ban));
 
	//return 0; //함수를 여기서 끝내겠다는 의미 


	//int r;
	//
	//printf("반지름 입력 : ");
	//scanf_s("%d \n", &r);
	//result(r);  //void 사용 반지름 


	//char charValue = 'A';
	//printf("char 출력할 때 는 c로 해보자 -> %d \n", charValue);

	//char someAlphabet = 'D';
	//bool isSame = ('A' == 65);
	//bool isBigAlphabet = ('A' <= someAlphabet && someAlphabet <= 'Z');
	//printf("\n Some alphabet은 대문자 인가?? %d \n", isBigAlphabet);

	//char alpha;
	//printf("문자를 입력하세여 -> " );
	//scanf_s("%c", &alpha);

	//bool a = ('A' <= alpha && alpha <= 'Z');
	//bool b = ('a' <= alpha && alpha <= 'z');
	//(a == b) ?  printf("특수문자입니다.") :printf( "알파벳 입니다."); // 대문자도 아니고 소문자도 아니면 특수문자로 인정 이지 방법 1 



	//char alpha;
	//printf("문자를 입력하세여 -> ");
	//scanf_s("%c", &alpha);

	//bool a = ('A' <= alpha && alpha <= 'Z');
	//bool b = ('a' <= alpha && alpha <= 'z');
	//bool c = ('0' <= alpha && alpha <= '9');
	////(a == b == c) ? printf("인정하지 않는다.") : printf("인정합니다.");

	//if (a) {
	//	printf("영문 대문자 입니다. \n");
	//} // if문은 조건식이 참이면 스코프 안의 내용을 진행하고 거짓이면 건너뛴다.
	//else if(b) {
	//	printf("영문 소문자 입니다. \n");
	//}
	//else if (c){
	//	printf("숫자 입니다. \n");
	//}
	//else {
	//	printf("잘모르겠습니다. \n");
	//} // 위의 조건식에서 참이 아닌 다른 모든 경우 스코프 안의 내용을 진행한다.


/*	char alpha;
	printf("문자를 입력하세여 -> ");
	scanf_s("%c", &alpha);

	bool a = ('A' <= alpha && alpha <= 'Z');
	bool b = ('a' <= alpha && alpha <= 'z');
	(a != b) ? printf("알파벳.") : printf("특수문자");*/   //이지 방법 2





	//printf("진짜로 같을까? %d \n", isSame);
//int loopcount = 388;
//while (1 <= loopcount) {
//	printf("Hello world! 몇번 째 돌고 있는지 ? %d \n" , loopcount);
//	loopcount -= 1;
//	} // loop종료

int star;

printf("사이즈를 입력해 주세여 ->");
scanf_s("%d", &star);

apple(star);
	//while (0 <= num&&num  <= 10) {
	//	printf("%d \n", num);
	//	num += 1;
	//}



	return 0;
} //main() 함수의 끝을 알려주는 것이 좋다. 

int apple(int star) {
	int width = 0;
	int heigh = 0;
	if (3 <= star && star <= 10) {
		while (star > heigh) {
			while (star > width) {
				printf("* %d");
				width += 1;

			}
			width = 0;

			heigh += 1;

		}
	}
	else {

	}
	return 0 ;
}

//char al(char alpha) {
//	return alpha;
//}

//void result(int r)
//{
//
//	const float PI = 3.141592;
//	float result = (r * r) * PI;
//	printf("넓이는 %f \n", result);  //void 사용 반지름 
//	
//}


//float oneban(int ban) {
//	const float PI = 3.141592f;
//
//
//	return (ban * ban) * PI;  //전방선언
//}