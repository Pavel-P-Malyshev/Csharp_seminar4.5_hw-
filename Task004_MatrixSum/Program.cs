/*
Задача 4. Со звездочкой(*). 
Найдите максимальное значение в матрице по каждой строке, сумируйте их. 
Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их.
 Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
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

int MaxRowSum(int[,] matrix)//максимальное значение в матрице по каждой строке, сумируйте их
{
    int maxsum=0;
    int[] rowMax= new int[matrix.GetLength(0)];
    

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //переопределяем максимум для каждой новой строки как первый элемент строки
        rowMax[i]=matrix[i,0];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (rowMax[i] < matrix[i, j])
            {
                rowMax[i] = matrix[i, j];
                
                
            }
            if(j==matrix.GetLength(1)-1) 
            {
                maxsum+=rowMax[i];
            }
        }

    }
    return maxsum;
}

int MinColumnSum(int[,] matrix)//Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их.
{
    int minsum=0;
    int[] colMin= new int[matrix.GetLength(1)];
    
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
         //переопределяем минимум для каждого нового столбца как первый элемент столбца
        colMin[j]=matrix[0,j];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if(colMin[j]>matrix[i,j])
            {
                colMin[j]=matrix[i,j];
                
            } 
            if(i==matrix.GetLength(0)-1)
            {
                minsum+=colMin[j];
                
            }

        }

    }
    return minsum;
}






int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int range=Prompt("enter matrix value generator range: ");
int[,] matr=FillMatrix(r,c,range);
System.Console.WriteLine("Generated matrix is: ");
PrintMatrix(matr);

int max=MaxRowSum(matr);
int min=MinColumnSum(matr);
System.Console.WriteLine($"Sum of max elements found in every row: {max} ");
System.Console.WriteLine($"Sum of min elements found in every column: {min} ");
System.Console.WriteLine($"Difference between MAX sum and MIN sum is: {max-min} ");



