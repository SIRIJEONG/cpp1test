#include<iostream> 
#include<stdio.h>


int main() {
	int star =0;

	printf("사이즈를 입력해 주세여 ->");
	scanf_s("%d", &star);

	int width = 0;
	int heigh = 0;
	if (3 <= star && star <= 10) {
		while (star > heigh) {
			while (star > width) {
				printf("* ");
				width += 1;

			}
			width = 0;
			printf("\n");
			heigh += 1;

		}
	}
	else {

	}
	return 0;
}

