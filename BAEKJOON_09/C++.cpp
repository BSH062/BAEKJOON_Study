#include<stdio.h>
#pragma warning(disable:4996)



int main()
{
	////내가 현재 가진 체스 말의 수
	//int a, b, c, d, e, f;

	////체스 말의 원래 수 
	//int king = 1;
	//int Queen = 1;
	//int Rppks = 2;
	//int Bishops = 2;
	//int Knigths = 2;
	//int Pawns = 8;

	//scanf("%d %d %d %d %d %d", &a, &b, &c, &d, &e, &f);

	//printf("%d %d %d %d %d %d \n", (king -a), ( Queen-b), ( Rppks-c), ( Bishops-d), ( Knigths-e), ( Pawns-f));

	int chess[] = { 1,1,2,2,2,8 }, i, me;
	for ( i = 0; i < 6; i++)
	{
		scanf("%d", &me);
		printf("%d ", chess[i] - me);
	}

}