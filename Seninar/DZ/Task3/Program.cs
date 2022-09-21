///Напишите программу, Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 1)
{
    Console.WriteLine($"сегодня рабочий день");
}
if (Number == 2)
{
    Console.WriteLine($"сегодня рабочий день");
}
if (Number == 3) 
{
    Console.WriteLine($"сегодня рабочий день");

}
if (Number == 4)
{
    Console.WriteLine($"сегодня рабочий день");

}
if (Number == 5)
{
    Console.WriteLine($"сегодня рабочий день");
}
if (Number == 6)
{
    Console.WriteLine($"сегодня выходной");
}
if (Number == 7)
{
    Console.WriteLine($"сегодня выходной");
}
else if (Number > 7)
{
    Console.WriteLine($"не верно введенное число");
}