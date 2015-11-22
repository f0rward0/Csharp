#include <iostream>
#include <stdlib.h>

using namespace std;

int areEquals(int a, int b)
{
	if (a == b)
		return 0;
	else
		return 1;
}

int main()
{
	int a = 5;
	int b;
	cin >> b;

	int arr[] = { 1, 2, 3, 4, 5 };
	int *p = &a;

	cout << arr[3] << endl;
	
	
	return 0;
}