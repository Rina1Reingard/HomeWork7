int GetNumber(string message)
{
    int number = 0;
    while (true)
    {   Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out number)&& number>=0)
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

void CheckMatrix(int[,]matri, int a, int b)
{    
    if(a>=matri.GetLength(0) && b>=matri.GetLength(1))
    Console.WriteLine("Такого элемента нет");
    else
    Console.WriteLine($"Элемент массива равен {matri[a,b]}");
        
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

int m=GetNumber("Введите число");
int n=GetNumber("Введите число");
int[,]matrix=InitMatrix(5,5);
PrintMatrix(matrix);
CheckMatrix(matrix,m,n);
