// Task 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int VozvedenieStepenu(int num1, int num2)
{
    int result = 1;
    for(int i = 0; i < num2; i++)
        result = result * num1;

    return result;
}

Console.Write("Введите первое число которое будем возводить в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число в какую степень будет возводить число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int otvet = VozvedenieStepenu(num1, num2);

Console.Write($"Число {num1} в степени {num2} равно {otvet}");

*/


// Task 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumChisla(int num)
{
    int ostatok = 0;
    int result = 0;
    while(num % 10 !=0)
    {
        ostatok = num % 10;
        result = result + ostatok;
        num = num / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int otvet = SumChisla(num);

Console.Write("Сумма цифр числа равна " + otvet);

*/


// Task 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


/*
int[] ArrayUser(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Введите колличество элемнтов массива ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = ArrayUser(size);
ShowArray(myArray);

*/