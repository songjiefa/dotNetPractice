// 解救小哈广度搜索.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"

struct Node
{
	int x;
	int y;
	int steps;
};

Node queue[21];
int head, tail;
int next[4][2] = { { 0,1 },{ 1,0 },{ 0,-1 },{ -1,0 } };
int map[4][5] = { { 0,0,0,0,0 },{ 0,0,0,1,0 },{ 1,0,1,0,0 },{ 0,0,0,0,1 } };
int book[4][5];

int main()
{
    return 0;
}

