//задание 1
//PrintHeader("Отчёт");
//PrintHeader("кофе");
//static void PrintHeader(string title) {
//    PrintLine();
//    Console.WriteLine(title);
//    PrintLine();
//}
//static void PrintLine() {
//    Console.WriteLine("^_^");
//}

//задание 2.1

//Console.WriteLine(Max(7, 77));
//Console.WriteLine(Max(42, 67));
//Console.WriteLine(Max(8, 11));
//static int Max(int a, int b) 
//{
//    return a > b ? a : b;
//}

//задание 2.2

//Console.WriteLine(IsEven(4));
//Console.WriteLine(IsEven(7));
//Console.WriteLine(IsEven(0));
//static bool IsEven(int n) 
//{
//    return n % 2 == 0;
//}

//задание 4

//Console.WriteLine($"0 градусов C = {ToFahrenheit(0)} градусов F");
//Console.WriteLine($"100 градусов C = {ToFahrenheit(100)} градусов F");
//Console.WriteLine($"37 градусов C = {ToFahrenheit(37)} градусов F");
//static double ToFahrenheit(double celsius)
//{
//    return celsius * 9 / 5 + 32;
//}

//задание 5

//Console.Write("Простые числа от 2 до 50: ");
//for (int i = 2; i <= 50; i++)
//{
//    if (IsPrime(i))
//    {
//        Console.Write($"{i} ");
//    }
//}
//Console.WriteLine();
//Console.WriteLine($"Factorial(8) = {Factorial(8)}");
//static long Factorial(int n)
//{
//    long result = 1;
//    for (int i = 2; i <= n; i++)
//    {
//        result *= i;
//    }
//    return result;
//}
//static bool IsPrime(int n)
//{
//    if (n < 2) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0) return false;
//    }
//    return true;
//}

