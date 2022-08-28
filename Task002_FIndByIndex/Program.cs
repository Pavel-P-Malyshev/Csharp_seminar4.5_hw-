/*
Задача 2. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 ->  элемента с такой позицией в массиве нет
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}



int[,] FillMatrix(int rows, int columns, int range)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j]=new Random().Next(1,range+1);

        }

    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
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

int FindByIndex(int[,] matrix, int rPos, int cPos)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(rPos==i&&cPos==j)
            {
                return matrix[i,j];
            }

        }

    }

    return 0;
}


int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int range=Prompt("enter matrix value generator range: ");
int[,] matr=FillMatrix(r,c,range);
System.Console.WriteLine("Generated matrix is: ");
PrintMatrix(matr);
(int i, int j)=(Prompt("enter row position of element: "),Prompt("enter column position of element: "));
int foundValue=FindByIndex(matr,i,j);
if(foundValue!=0)
{
    System.Console.WriteLine($"Matrix element value on position[{i},{j}] is {foundValue} ");
    
}
else
{
    System.Console.WriteLine($"Matrix element on position[{i},{j}] does not exist ");

}

