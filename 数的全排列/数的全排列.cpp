// 数的全排列.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"

int book[10], box[10];
int n,sum;

void put(int i_step) 
{
	if (i_step == n + 1) 
	{
		for (int i = 1; i <= n; i++)
		{
			printf_s("%d", box[i]);
		}
		printf_s("\r\n");
		sum++;
		return;
	}

	for (int i = 1; i <= n; i++)
	{
		if (book[i] == 0)
		{
			box[i_step] = i;
			book[i] = 1;
			put(i_step + 1);
			book[i] = 0;
		}
	}
}

int main()
{
	n = 5;
	put(1);
	printf_s("%d", sum);
	getchar();
    return 0;
}

