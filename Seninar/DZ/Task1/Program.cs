///Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");

int number = Convert.ToInt32(Console.ReadLine());

int SeconDigit(int number) //метод вывод вророй цифры

{
    int Dec = (number/10) % 10;

    return Dec;
}
int a = SeconDigit(number);
Console.WriteLine ($"Вторая цифра от {number} - {a}" );