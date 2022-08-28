/*
Задача 3. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] ColumnAverage(int[,] matrix)
{
    double[] answer=new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            answer[j]+=(double)matrix[i,j]/matrix.GetLength(1);
            

        }

    }

    return answer;
}

//распечатка массива
void PrintArray (double[] col)
{

    int count=col.Length;
    int position=0;

    Console.Write("[ ");
    while(position<count) 
    {
        if(position==count-1)  {Console.Write($"{col[position]:f2}");}
        else {Console.Write($"{col[position]:f2}; ");}
        
        position++;
    }
    Console.WriteLine("] ");

}



int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int range=Prompt("enter matrix value generator range: ");
int[,] matr=FillMatrix(r,c,range);
System.Console.WriteLine("Generated matrix is: ");
PrintMatrix(matr);
System.Console.WriteLine("Every column average is:  ");
PrintArray(ColumnAverage(matr));    


