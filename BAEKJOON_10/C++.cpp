#include<stdio.h>
#pragma warning(disable:4996)
int main()
{
	int a, b, c ;
	
	scanf("%d %d %d", &a, &b, &c);

	int result_a = (a + b) % c;
	int result_b = ((a % c) + (b % c)) % c;
	int result_c = (a * b) % c;
	int result_d = ((a % c) * (b % c)) % c;

	printf("%d\n%d\n%d\n%d\n", result_a, result_b, result_c, result_d);

}