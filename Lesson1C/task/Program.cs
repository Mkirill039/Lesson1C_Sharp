void Zadacha2()
{
    //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    int numberFirst = 10;
    int numberSecond = 3;

    if (numberFirst > numberSecond)
    {
        Console.WriteLine("numberFirst больше numberSecond");
    }
    else if (numberFirst < numberSecond)
    {
        Console.WriteLine("numberSecond больше numberFirst");
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

void Zadacha4()
{
    //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    int numberFirst = 10;
    int numberSecond = 22;
    int numberThird = 14;
    int max = numberFirst;

    if (max < numberSecond)
    {
        max = numberSecond;
    }

    if (max < numberThird)
    {
        max = numberThird;
    }
    Console.WriteLine(max);

}


void Zadacha6()
{
    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
    int number = 44;
    if (number % 2 == 0) Console.WriteLine("четное число");
    else Console.WriteLine("Число нечетное");
}

void Zadacha8()
{
    //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    int number = 22;
    int count = 1;
    while (count <= number)
    {
        if (count % 2 == 0) Console.WriteLine(count);
        count++;
    }
}


//Zadacha2();
//Zadacha4();
//Zadacha6();
Zadacha8();