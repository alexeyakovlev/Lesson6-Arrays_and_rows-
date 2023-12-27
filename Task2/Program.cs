//Задайте строку, содержащую латинские буквы в обоих регистрах.
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Clear();

string ReadString(string msg)
{
  Console.Write(msg);
  return Console.ReadLine();
}

string Output(string row)
{
  string output = row.ToLower();
  return output;
}

string input = ReadString("Введите строку: ");
Console.Write(Output(input));



