/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}



double[,] FillMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 || j % 2 == 0)
            {
                matrix[i, j] = new Random().NextDouble() * (i + 1) / (j + 1);
            }
            else
            {
                matrix[i, j] = (new Random().NextDouble() * (i + 1) / (j + 1))*-1;

            }

        }

    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} [{i},{j}] ");

        }
        Console.WriteLine();
    }

}
int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
double[,] matr=FillMatrix(r,c);
System.Console.WriteLine("Generated matrix of real values is: ");
PrintMatrix(matr);
