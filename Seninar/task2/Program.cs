// напишите прорамму, которая вводит случайное трехзначное  число и удаляет вторую цифру этого числа 

int CreateNumber() // метод 1 (выводит случайное число)
{
    int number = new Random().Next(100,1000); // ложим в number случайное число от 10 до 100
    return number; // возвращаем случайное число, которое лежит в number в метод CreateNumber
    //return new Random().Next(100,1000);
}

int DelSecond(int number)
{
    int Sot = number/100;
    int Dec = number/10;
    int Ed = number%10;
    return Sot *10+Ed;
}

int a = CreateNumber();
Console.WriteLine(a);
Console.WriteLine(DelSecond(a));