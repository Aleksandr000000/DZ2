///Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введи число: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
string ThirdNumberText = Convert.ToString(ThirdNumber);

if (ThirdNumberText.Length > 2)
{
  Console.WriteLine($"третья цифра из числа  {ThirdNumber} - "  + ThirdNumberText[2]);
}
else {
  Console.WriteLine($"В числе {ThirdNumber} - третьей цифры нет");
}