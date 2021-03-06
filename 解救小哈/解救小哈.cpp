// 解救小哈.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"

int next[4][2] = { {0,1},{1,0},{0,-1},{-1,0} };
int map[4][5] = { {0,0,0,0,0},{0,0,0,1,0},{1,0,1,0,0},{0,0,0,0,1} };
int steps[4][5];

int hax = 3;
int hay = 2;
int min = 99999;

void find(int x, int y, int i_step) \
{
	int tx = 0; int ty = 0;
	if (x == hax && y == hay)
	{
		printf_s("----------%d------------\r\n", i_step);
		if (i_step < min)
		{
			min = i_step;
		}
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				printf_s("%d ", steps[i][j]);

			}
			printf_s("\r\n");
		}

		return;
	}

	for (int i = 0; i < 4; i++)
	{
		tx = x + next[i][0];
		ty = y + next[i][1];

		if (map[tx][ty] == 0 
			&& tx>= 0 && tx < 4 
			&& ty>= 0 && ty < 5 
			&& steps[tx][ty] == 0) 
		{
			steps[tx][ty] = 1;
			find(tx, ty, i_step + 1);
			steps[tx][ty] = 0;
		}
	}
}

int main()
{
	steps[0][0] = 1;
	find(0, 0, 1);
	getchar();
    return 0;
}

