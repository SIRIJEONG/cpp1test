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

//���� �����̵� ���� ���� �����ؼ� ������ �� 
// ��� - 3~6 ���̿� ���� �Է¹޾Ƽ� �ش� ����� �´� �����̵� ���� �����ϱ� (3�� �Է��ϸ� 3*3 ����)
// �����ϵ� - Ŭ��� �Ұ����� ������ �������� �ʵ��� ������ ��


void puzzle() {
	//������ �迭
	char anykey = '0';
	int userx = 0;
	int usery = 0;
	int puzzleLine = 0;
	printf("���� ���� ���� �Է��� �ּ��� : ");
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




	//int array[3][3] = { 0 };       //2���� �迭 �ʱ�ȭ
	//srand((unsigned)time(NULL)); //�Ź� ���ο� ���� ���

	//2���� �迭�� ���� ����ֱ�(���� for�� Ȱ��)
	//for (int i = 0; i < 3; i++)
	//	for (int j = 0; j < 3; j++)
	//		array[i][j] = (rand() % 10);
	//cout << endl;

	//cout << "========" << endl;

	//2���� �迭 ����ϱ�(���� for�� Ȱ��)
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