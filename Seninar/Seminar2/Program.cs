// напишите прорамму, которая вводит случайное число из отрезка [10,99] и
// и показывает наибольшую цифру

int CreateNumber() // метод 1 (выводит случайное число)
{
    //int number = new Random().Next(10,100); // ложим в number случайное число от 10 до 100
    //return number; // возвращаем случайное число, которое лежит в number в метод CreateNumber
    return new Random().Next(10,100);
}

int MaxDigit(int number)

{
    int Decimal =number / 10;// находим количество целых десятых (для сравнения с единицами)
    int Ed =number % 10; // находим колечество целых едениц 
    
    if (Decimal>= Ed)
    {
        return Decimal; 
    }
    else 
    {
        return Ed;
    }

}
//int a = CreateNumber(); // вызов метода случайных чисел и ложим его в какую-то переменную 
//Console.WriteLine(a);
//int maxDigit = MaxDigit (a);
//Console.WriteLine(maxDigit);
int a = CreateNumber();
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));