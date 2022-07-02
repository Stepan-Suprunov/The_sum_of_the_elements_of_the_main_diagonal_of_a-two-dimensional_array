// Сумма элементов главной диагонали двумерного массива


void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void DiagonalSum(int[,] collection)
{
    int sum = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < 1 ; j++)
        {
            sum += collection[i,i]; 
        }
    }
    Console.WriteLine(sum);
}

int m = 3, n = 4;
int[,] array = new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
    }   
}

PrintArray(array);
Console.WriteLine("___________________");
DiagonalSum(array);