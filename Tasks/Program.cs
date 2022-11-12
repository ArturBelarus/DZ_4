// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите два числа");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

if (!isParsedA || !isParsedB || b <= 0)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}

long aToDegreeOfB = MatchPow(a, b);
Console.WriteLine($"{a}^{b} = {aToDegreeOfB}");

long MatchPow(int number, int pow)
{
    long result = number;
    for (int i = 1; i < pow; i++)
    {
        result *= number;
    }
    return result;
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
bool isParsedNum = int.TryParse(Console.ReadLine(), out int num);

if (!isParsedNum)
{
    Console.WriteLine("Не правильное число");
    return;
}

int sum = SumOfDigits(num);
Console.WriteLine($"сумма цифр в числе = {sum}");

int SumOfDigits(int number)
{
    int result;

    for (result = 0; number > 0; number /= 10)
    {
        int digit = number % 10;
        result += digit;
    }
    return result;
}

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите размер массива");
bool isParsedElement = int.TryParse(Console.ReadLine(), out int sizeArray);

if (!isParsedElement)
{
    Console.WriteLine("Не правильнные данные");
    return;
}

Console.WriteLine("Введите числа для массива");
int[] newArray = EnteringArray(sizeArray);

PrintArray(newArray);

int[] EnteringArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        bool isParsedElement = int.TryParse(Console.ReadLine(), out int element);
        if (!isParsedElement)
        {
            Console.WriteLine("Не провильнные данные");
            i = i - 1;
        }
        else
        {
            array[i] = element;
        }
    }
    return array;
}    

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}]");
}