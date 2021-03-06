// 搜索等式.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"

int box[10], book[10];

void put(int i_step)
{
	if (i_step == 9)
	{
		if (box[0] * 100 + box[1] * 10 + box[2] + box[3] * 100 + box[4] * 10 + box[5] == box[6] * 100 + box[7] * 10 + box[8])
		{
			printf_s("%d%d%d + %d%d%d = %d%d%d", box[0], box[1], box[2], box[3], box[4], box[5], box[6], box[7], box[8]);
			printf_s("\r\n");
		}
		
		return;
	}

	for (int i = 0; i <= 9;i++) 
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
	put(0);
	getchar();
    return 0;
}

