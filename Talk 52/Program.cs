int GetNumber(string message)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out number)&& number>0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или некоректное число. Повторите ввод");
        }
    }
    return number;
}

int[,]IniMatrix(int rows, int colums)
{
    int[,]matrix = new int[rows,colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }        
    }
    return matrix;
}

void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void AverageOfColumns(int[,]matrix)
{   
    int lenght=matrix.GetLength(1);
    double[] average= new double[lenght];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j];
            average[j] = (double)(sum/matrix.GetLength(0));
            
        }
    Console.Write($"[{average[j]}] ");
    }
}

int countOfRows = GetNumber("Введите количество строк");
int countOfColums = GetNumber("Введите количество столбцов");
int[,]matrix = IniMatrix(countOfRows,countOfColums);
PrintMatrix(matrix);
AverageOfColumns(matrix);
