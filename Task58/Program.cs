Console.WriteLine("Данная программа создаёт две матрицы, размер которых зависит от введёных пользователем - количества строк, столбцов, и заданного диапозона случайных числовых значений. И находит произведение созданных двух матриц.");

int m = InputNumbers("Введите количество строк для первой матрицы: ");
int n = InputNumbers("Введите количество столбцов для первой матрицы: ");
int l = InputNumbers("Введите количество строк для второй матрицы: ");
int p = InputNumbers("Введите количество столбцов для второй матрицы: ");
int range = InputNumbers("Введите любое число для определния максимального диапазона случайных числовых значений от 1 и до максимального числового значения: ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nСоздана первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[l, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nСоздана вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение созданных программой - первой и второй матрицы составляет: ");
WriteArray(resultMatrix);
Console.WriteLine($"\nСогласно правилу высшей математики и условиям задачи: Произведение двух матриц - первой и второй, имеет смысл только в том случае, когда число столбцов первой матрицы совпадает с числом строк второй матрицы, поэтому количество введёных столбцов первой матрицы - должно быть равно введёному количеству строк второй матрицы!");

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i, k] * secomdMartrix[k, j];
      }
      resultMatrix[i, j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}