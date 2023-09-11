#include<stdio.h>
void sayhello()
{
	printf("hello\n");
}
int main()
{
	printf("calling function\n");
	sayhello();
	printf("back in main function \n");
	sayhello();
	printf("bye");
}
