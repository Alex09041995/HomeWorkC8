Console.WriteLine("Данная программа создаёт двумерный массив, размер которого зависит от введёных пользователем - количества строк и столбцов, и упорядочивает по убыванию элементы каждой строки двумерного массива.");
Console.Write("Введите необходимое количество строк для создания двумерного массива: ");

int linesVol = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов для создания двумерного массива: ");

int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int [linesVol, columnsVol];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
PrintArray2(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Создан следующий двумерный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void PrintArray2(int [,] array)
{
    Console.WriteLine("Двумерный массив был упорядочен по убыванию: ");
    OrderArrayLines(array);
    WriteArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
    Console.Write(array[i, j] + " ");
    }
    Console.Write("]");
    Console.WriteLine("");
  }
}
}