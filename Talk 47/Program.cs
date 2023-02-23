int GetNumber(string message)
{
    int number = 0;
    while (true)
    {   Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out number)&& number>0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод.");
        }
    }
    return number;
} 

int[,] InitMatrix(int rows, int columns)
{
    int[,]matrix=new int[rows,columns];
    Random rnd=new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=rnd.Next(1,10);
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

int rows=GetNumber("Введите количество строк");
int columns=GetNumber("Введите количество столбцов");
int[,] matrix=InitMatrix(rows,columns);
PrintMatrix(matrix);
