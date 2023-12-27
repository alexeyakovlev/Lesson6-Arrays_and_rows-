//Задайте двумерный массив символов (тип char [,]).
//Создать строку из символов этого массива.
Console.Clear();

string Array(char[,] array)
{
  string result = "";
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += array[i, j];
    }
  }
  return result;
}

char[,] array = new char[,]
{
  {'a', 'b', 'c'},
  {'d', 'e', 'f'},
  {'g', 'h', 'i'}
};
Console.Write(Array(array));
