#include<iostream> 
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
#include<windows.h>



int main() {

}


void Move(int mapSize)
{
    srand(time(NULL));
    int map_[15][15] = { 0, };
    map_[mapSize][mapSize];
    int clearMap_[15][15] = { 0, };
    clearMap_[mapSize][mapSize];
    char userInput = '0';
    int userX = 0;
    int userY = 0;
    int mapx[225] = { 0, };
    mapx[mapSize];
    int* ptrmapx = mapx;

    for (int i = 0; i < (mapSize * mapSize); i++)
    {
        mapx[i] = i;
    }

    for (int i = 0; i < ((mapSize * mapSize) - 1); i++)
    {
        clearMap_[i / mapSize][i % mapSize] = i + 1;
    }

    int randomIdx1 = 0;
    int randomIdx2 = 0;

    srand(time(NULL));
    for (int i = 0; i < 100000; i++)
    {
        randomIdx1 = rand() % (mapSize * mapSize);
        randomIdx2 = rand() % (mapSize * mapSize);
        Swap(&mapx[randomIdx1], &mapx[randomIdx2]);
    }


    for (int i = 0; i < (mapSize * mapSize); i++)
    {
        map_[i / mapSize][i % mapSize] = *(ptrmapx + i);
    }

    for (int y = 0; y < mapSize; y++)
    {
        for (int x = 0; x < mapSize; x++)
        {
            if (map_[y][x] == 0)
            {
                userY = y;
                userX = x;
            }
        }
    }

    while (1)
    {
        int sameNumber = 0;
        system("cls");
        for (int y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                printf("%3d ", map_[y][x]);
            }
            printf("\n");
        }
        printf("\n");
        printf("w 위로이동, s 아래로이동, a 왼쪽으로이동, d 오른쪽으로이동\n");
        printf("종료 q\n");
        userInput = _getch();

        for (int y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                if (map_[y][x] == clearMap_[y][x])
                {
                    sameNumber += 1;
                }
            }
        }

        if (sameNumber == (mapSize * mapSize))
        {
            system("cls");
            printf("\n\n클리어!\n\n");
            Sleep(1000);
            break;
        }


        if (userInput == 'q' || userInput == 'Q')
        {
            break;
        }

        if (userInput == 'w' || userInput == 'W')
        {
            if (userY - 1 < 0)
            {
                printf("벽으로 막혀 지나갈 수 없습니다.\n");
                Sleep(700);
                userY = 0;
                continue;
            }
            char temp = '0';
            temp = map_[userY][userX];
            map_[userY][userX] = map_[userY - 1][userX];
            map_[userY - 1][userX] = temp;
            userY -= 1;
            continue;
        }

        if (userInput == 's' || userInput == 'S')
        {
            if (userY + 1 > (mapSize - 1))
            {
                printf("벽으로 막혀 지나갈 수 없습니다.\n");
                Sleep(700);
                userY = (mapSize - 1);
                continue;
            }
            char temp = '0';
            temp = map_[userY][userX];
            map_[userY][userX] = map_[userY + 1][userX];
            map_[userY + 1][userX] = temp;
            userY += 1;
            continue;
        }

        if (userInput == 'a' || userInput == 'A')
        {
            if (userX - 1 < 0)
            {
                printf("벽으로 막혀 지나갈 수 없습니다.\n");
                Sleep(700);
                userX = 0;
                continue;
            }
            char temp = '0';
            temp = map_[userY][userX];
            map_[userY][userX] = map_[userY][userX - 1];
            map_[userY][userX - 1] = temp;
            userX -= 1;
            continue;
        }

        if (userInput == 'd' || userInput == 'D')
        {
            if (userX + 1 > (mapSize - 1))
            {
                printf("벽으로 막혀 지나갈 수 없습니다.\n");
                Sleep(700);
                userX = (mapSize - 1);
                continue;
            }
            char temp = '0';
            temp = map_[userY][userX];
            map_[userY][userX] = map_[userY][userX + 1];
            map_[userY][userX + 1] = temp;
            userX += 1;
            continue;
        }

        printf("올바른 값을 입력하세요\n");
        Sleep(1000);
        continue;
    }
}


void Swap(int* firstNumber, int* secondNumber)
{
    int temp = 0;
    temp = *firstNumber;
    *firstNumber = *secondNumber;
    *secondNumber = temp;
}