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
//float oneban(int ban);  //���漱�� 

/*char Al(char alpha);  *///���漱�� 


//void result(int r); // void ������ 
int star(int a , int b);


int main() {

	//{ ���� �����
	//int result;
	//int result1;
	//int x, y, z;
	//} ���� ����� 

	// { ����� �Է� �޴� ����
	//printf("���� one : ");
	//scanf_s("%d", &num1);
	//printf("���� two : ");
	//scanf_s("%d", &num2);
	//printf("���� 2���� �Է��� �ּ��� :");
	//scanf_s("%d , %d", &num1 , &num2);  //�ٿ��� ������ �ִ�. 
	// } ����� �Է� �޴� ����
	/*int x, y, z;*/
	//printf("���� 3���� �Է��� �ּ��� :");
	//scanf_s("%d , %d , %d", &x , &y , &z);
	// { ���� �����ϴ� ���� / �÷��� ���� 
	//result = num1 + num2;  
	//printf("%d + %d = %d \n", num1, num2, result);
	// } ���� �����ϴ� ���� / �÷��� ���� 

	//result = x + (y * z);  //�Լ�x
	//printf("%d + (%d * %d) = %d\n", x, y , z, result(x,y,z));  //�Լ�x
	//printf("���� ���� %d �Դϴ�. \n", result(x, y, z));
	//result1 = (x - y) * (y + z) * (y % x);  //�Լ�x
	//printf("(%d - %d) + (%d + %d) * (%d %% %d) = %d\n", x,y,y,z,y,x, result(x,y,z));  //�Լ�x
	//printf("���� ���� %d �Դϴ�. \n", result1(x, y, z));


	//char charValue = 'A'; // ���� �ϳ��� �����ϱ� ���� ������ Ÿ�� 
	//short shortValue = 10; //int���� ���� ���� �����ϱ� ���� ������ Ÿ��
	//int intValue = 100; // ���� ������ ���� �����ϱ� ���� ������ Ÿ��
	//long longValue = 200; // int�� Ŀ���� ���� �� �Ⱦ��� ������ Ÿ��
	//long long longlongValue = 1000; //int���� ū ���� �������� ���� ������ Ÿ��

	//float floatValue = 10.1; //���� ������ �Ǽ��� �����ϱ� ���� ������ Ÿ��
	//double doubleValue = 100.1; // float ���� ū �Ǽ��� �����ϱ� ���� ������ Ÿ��
	//long double longDoubleValue = 200.1; // double ���� ū �Ǽ��� �����ϱ� ���� ������ Ÿ��

	//printf(" char �� ũ��� %d byte \n" , sizeof(charValue));
	//printf(" short �� ũ��� %d byte \n" , sizeof(shortValue));
	//printf(" int �� ũ��� %d byte \n", sizeof(intValue));
	//printf(" long �� ũ��� %d byte \n", sizeof(longValue));
	//printf(" long long �� ũ��� %d byte \n", sizeof(longlongValue));


	//printf(" float �� ũ��� %d byte \n", sizeof(floatValue));
	//printf(" double �� ũ��� %d byte \n", sizeof(doubleValue));
	//printf(" long double �� ũ��� %d byte \n", sizeof(longDoubleValue));



	//int ban;
	//printf("���� �������� �Է����ּ��� \n");
	//scanf_s("%d", &ban);
 //   printf("���� ���̴� %f \n", oneban(ban));
 
	//return 0; //�Լ��� ���⼭ �����ڴٴ� �ǹ� 


	//int r;
	//
	//printf("������ �Է� : ");
	//scanf_s("%d \n", &r);
	//result(r);  //void ��� ������ 


	//char charValue = 'A';
	//printf("char ����� �� �� c�� �غ��� -> %d \n", charValue);

	//char someAlphabet = 'D';
	//bool isSame = ('A' == 65);
	//bool isBigAlphabet = ('A' <= someAlphabet && someAlphabet <= 'Z');
	//printf("\n Some alphabet�� �빮�� �ΰ�?? %d \n", isBigAlphabet);

	//char alpha;
	//printf("���ڸ� �Է��ϼ��� -> " );
	//scanf_s("%c", &alpha);

	//bool a = ('A' <= alpha && alpha <= 'Z');
	//bool b = ('a' <= alpha && alpha <= 'z');
	//(a == b) ?  printf("Ư�������Դϴ�.") :printf( "���ĺ� �Դϴ�."); // �빮�ڵ� �ƴϰ� �ҹ��ڵ� �ƴϸ� Ư�����ڷ� ���� ���� ��� 1 



	//char alpha;
	//printf("���ڸ� �Է��ϼ��� -> ");
	//scanf_s("%c", &alpha);

	//bool a = ('A' <= alpha && alpha <= 'Z');
	//bool b = ('a' <= alpha && alpha <= 'z');
	//bool c = ('0' <= alpha && alpha <= '9');
	////(a == b == c) ? printf("�������� �ʴ´�.") : printf("�����մϴ�.");

	//if (a) {
	//	printf("���� �빮�� �Դϴ�. \n");
	//} // if���� ���ǽ��� ���̸� ������ ���� ������ �����ϰ� �����̸� �ǳʶڴ�.
	//else if(b) {
	//	printf("���� �ҹ��� �Դϴ�. \n");
	//}
	//else if (c){
	//	printf("���� �Դϴ�. \n");
	//}
	//else {
	//	printf("�߸𸣰ڽ��ϴ�. \n");
	//} // ���� ���ǽĿ��� ���� �ƴ� �ٸ� ��� ��� ������ ���� ������ �����Ѵ�.


/*	char alpha;
	printf("���ڸ� �Է��ϼ��� -> ");
	scanf_s("%c", &alpha);

	bool a = ('A' <= alpha && alpha <= 'Z');
	bool b = ('a' <= alpha && alpha <= 'z');
	(a != b) ? printf("���ĺ�.") : printf("Ư������");*/   //���� ��� 2





	//printf("��¥�� ������? %d \n", isSame);
//int loopcount = 388;
//while (1 <= loopcount) {
//	printf("Hello world! ��� ° ���� �ִ��� ? %d \n" , loopcount);
//	loopcount -= 1;
//	} // loop����

int star;

printf("����� �Է��� �ּ��� ->");
scanf_s("%d", &star);

apple(star);
	//while (0 <= num&&num  <= 10) {
	//	printf("%d \n", num);
	//	num += 1;
	//}



	return 0;
} //main() �Լ��� ���� �˷��ִ� ���� ����. 

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
//	printf("���̴� %f \n", result);  //void ��� ������ 
//	
//}


//float oneban(int ban) {
//	const float PI = 3.141592f;
//
//
//	return (ban * ban) * PI;  //���漱��
//}