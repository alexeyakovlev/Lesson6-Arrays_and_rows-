//Задайте произвольную строку. 
//Выясните, является ли она палиндромом.

Console.Clear();

string ReadString(string msg)
{
  Console.Write(msg);
  return Console.ReadLine();
}

bool Check(string input)
{
  int min = 0;
  int max = input.Length - 1;
  while (true)
  {
    if (min > max)
    {
      return true;
    }
    char a = input[min];
    char b = input[max];
    if (char.ToLower(a) != char.ToLower(b))
    {
      return false;
    }
    min++;
    max--;
  }
}

//-----------------------------------

string input = ReadString("Введите строку: ");
if (Check(input) == true)
{
  Console.WriteLine("Слово является палиндромом");
}
else
{
  Console.WriteLine("Слово не является палиндромом");
}
