Console.WriteLine("Данная программа создаёт прямоугольный двумерный массив, размер которого зависит от введёных пользователем - количества строк и столбцов, и находит строку с наименьшей суммой элементов.");
Console.Write("Введите необходимое количество строк для создания прямоугольного двумерного массива: ");

int linesVol = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите необходимое количество столбцов для создания прямоугольного двумерного массива: ");

int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [linesVol, columnsVol];

FillArrayRandomNumbers(array);
PrintArray(array);

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
    Console.WriteLine("Создан следующий прямоугольный двумерный массив: ");
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

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"Строкой с наименьшей суммой элементов - является строка под номером: {minSumLine+1}. Сумма данной строки составляет: {sumLine}.");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}