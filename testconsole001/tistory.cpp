#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>

void Description005();
void swap(char firstChar, char secondChar);
void swap2(char* firstChar, char* secondChar);

int main() {

	Description005();
}


void Description005() {
	char str[10] = "hello";
	char temp = '\0';

	swap2(&str[0], &str[4]);
	printf("%s \n", str);
}

void swap(char firstChar, char secondChar) {
	printf("[스왑하기 전 ]firstChar 값 : %c , secondChar 값  %c \n", firstChar, secondChar);

	char temp = '\0';
	temp = firstChar;
	firstChar = secondChar;
	secondChar = temp;
	printf("[스왑 이후 ]firstChar 값 : %c , secondChar 값  %c \n", firstChar, secondChar);
}




void swap2(char* firstChar, char* secondChar) {
	printf("[스왑하기 전 ]firstChar 값 : %c , secondChar 값  %c \n", *firstChar, *secondChar);

	char temp = '\0';
	temp = (*firstChar);
	(*firstChar) = (*secondChar);
	(*secondChar) = temp;
	printf("[스왑 이후 ]firstChar 값 : %c , secondChar 값  %c \n", *firstChar, *secondChar);
}

