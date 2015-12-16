#include <iostream>


using namespace std;



int main()
{
	int M, N;

	cout << "M=" << endl;
	cin >> M;
	cout << "N=" << endl;
	cin >> N;



	double** X = new double*[M];

	for (int i = 0; i < M; i++)
		X[i] = new double[N];




	int counter = 1;

	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < N; j++)
		{
			cout << "Wuwedi element " << counter<<"  ";
			cin >> X[i][j];
			counter++;
		}

	}


	cout << "Matrix" << endl;

	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < N; j++)
		{
			cout << X[i][j]<<" ";
		}
		cout << endl;
	}



	for (int i = 0; i < M; i++)
	{

		double temp;
		if (i % 2 == 0)
		{
			double swap;
			int c, d;
			for (c = 0; c < (M - 1); c++)
			{
				for (d = 0; d < N - c - 1; d++)
				{
					if (X[i][d] > X[i][d + 1])
					{
						swap = X[i][d];
						X[i][d] = X[i][d + 1];
						X[i][d + 1] = swap;
					}
				}
			}
		}
		else
		{
			double swap;
			int c, d;
			for (c = 0; c < (M - 1); c++)
			{
				for (d = 0; d < N - c - 1; d++)
				{
					if (X[i][d] < X[i][d + 1])
					{
						swap = X[i][d];
						X[i][d] = X[i][d + 1];
						X[i][d + 1] = swap;
					}
				}
			}
		}
	}

	cout << "Sorted Matrix" << endl;

	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < N; j++)
		{
			cout << X[i][j] << " ";
		}
		cout << endl;
	}


    return 0;

}

