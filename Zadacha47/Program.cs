//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
{
     Random random = new Random();
     int rows = random.Next(3,4);
     int columns = random.Next(3,4);
     int [,] array = new int[rows, columns];
     FillArray(array);
     PrintArray(array);
}
void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
         for (int j = 0; j < columns; j++)
         {
            array[i,j] = random.Next(startNumber, finishNumber);
         }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine(array[i, j]+ ",");
        }
        Console.WriteLine();
    }
}

