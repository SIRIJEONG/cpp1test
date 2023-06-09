#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>


void puzzle();
void swap2(int* firstChar, int* secondChar);
int main() {
	puzzle();
}

//과제 슬라이딩 퍼즐 게임 구현해서 제출할 것 
// 노멀 - 3~6 사이에 값을 입력받아서 해당 사이즈에 맞는 슬라이딩 퍼즐 구현하기 (3을 입력하면 3*3 퍼즐)
// 베리하드 - 클리어가 불가능한 퍼즐은 존재하지 않도록 구현할 것


void puzzle() {
	//다차원 배열
	char anykey = '0';
	int userx = 0;
	int usery = 0;
	int puzzleLine = 0;
	printf("퍼즐 라인 수를 입력해 주세요 : ");
	scanf_s("%d", &puzzleLine);
	int char_[36] = { 0 , };
	int char2_[6][6] = { 0 , };

	//for (int i = 0; i < 36; i++) {
	//	char_[i] = '*';
	//}
	for (int y = 0; y < puzzleLine; y++) {
		for (int x = 0; x < puzzleLine; x++) {
			if (x == 0 && y == 0 ) {
				char2_[0][0] = 0;
				continue;
			}

			char2_[y][x];
		}
	}




	//int array[3][3] = { 0 };       //2차원 배열 초기화
	//srand((unsigned)time(NULL)); //매번 새로운 난수 출력

	//2차원 배열에 난수 집어넣기(이중 for문 활용)
	//for (int i = 0; i < 3; i++)
	//	for (int j = 0; j < 3; j++)
	//		array[i][j] = (rand() % 10);
	//cout << endl;

	//cout << "========" << endl;

	//2차원 배열 출력하기(이중 for문 활용)
	//for (int i = 0; i < 3; i++) {
	//	for (int j = 0; j < 3; j++)
	//		cout << array[i][j] << "\t";
	//	cout << endl;
	//}
	//cout << "========" << endl;


	while (1)
	{
		for (int y = 0; y < puzzleLine; y++) {
			for (int x = 0; x < puzzleLine; x++) {
				printf("%d ", char2_[y][x]);
			}
			printf("\n");
		}

		anykey = _getch();
		system("cls");

		if (anykey == 'a' || anykey == 'A') 
		{
			swap2(&char2_[usery][userx], &char2_[usery][userx - 1]);
			userx--;
			if (0 <= userx&&userx <= puzzleLine)
			{

			}
			else 
			{
				userx = 0;
				continue;
			}
		}
		else if (anykey == 'd' || anykey == 'D') 
		{
			swap2(&char2_[usery][userx], &char2_[usery][userx + 1]);
			userx++;
			if (0 <= userx && userx <= puzzleLine)
			{

			}
			else 
			{
				userx = puzzleLine;
				continue;
			}
		}
		else if (anykey == 's' || anykey == 'S') 
		{
			swap2(&char2_[usery][userx], &char2_[usery + 1][userx]);
			usery++;
			if (0 <= usery && usery <= puzzleLine)
			{

			}
			else 
			{
				usery = puzzleLine;
				continue;
			}
		}
		else if (anykey == 'w' || anykey == 'W') 
		{
			swap2(&char2_[usery][userx], &char2_[usery - 1][userx]);
			usery--;
			if (0 <= usery && usery <= puzzleLine)
			{

			}
			else {
				usery = 0;
				continue;
			}
		}

	}


	printf("\n");
}
void swap2(int* firstChar, int* secondChar) {

	int temp = 0;
	temp = (*firstChar);
	(*firstChar) = (*secondChar);
	(*secondChar) = temp;
}