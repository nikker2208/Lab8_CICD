

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
Console.WriteLine("Массив:");
Console.WriteLine("#1");
lab1.PrintArray(arr);
lab1.BubbleSort(arr);
Console.WriteLine("Отсортированный массив:");
lab1.PrintArray(arr);

Console.WriteLine("#2");
Console.WriteLine("Палидром ли шабаш " + lab1.IsPalindrome("ШАБАШ"));
Console.WriteLine("Палидром ли кольцо " + lab1.IsPalindrome("кольцо"));

Console.WriteLine("#3");
Console.WriteLine(lab1.Factorial(5));
Console.WriteLine(lab1.Factorial(3));

Console.WriteLine("#4");
Console.WriteLine(lab1.Fibonacci(10));
Console.WriteLine(lab1.Fibonacci(7));

Console.WriteLine("#5");
Console.WriteLine("4.2 ^ 2.4 = " + Math.Round(lab1.Pow(4.2, 2.4), 3));
Console.WriteLine("2.5 ^ 3.7 = " + Math.Round(lab1.Pow(2.5, 3.7), 3));

Console.WriteLine("#6");
int i = 6, j = 5;
Console.WriteLine($"{i} простое:" + lab1.IsPrimeNumber(6));
Console.WriteLine($"{j} простое:" + lab1.IsPrimeNumber(5));

Console.Read();

public static class lab1
{
    public static int[] BubbleSort(int[] array)
    {

        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
    public static void PrintArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    public static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length; i++)
            if (word[i] != word[word.Length - i - 1]) return false;
        return true;
    }

    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Факториал определен только для неотрицательных чисел");
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static int Fibonacci(int n)
    {
        if (n <= 0)
            throw new ArgumentException("Числа Фибоначчи определены только для положительных чисел");
        if (n == 1 || n == 2)
            return 1;
        int prev = 0;
        int current = 1;
        int temp;
        for (int i = 2; i <= n; i++)
        {
            temp = current;
            current = current + prev;
            prev = temp;
        }
        return current;
    }
    public static double Pow(double number, double pow)
    {
        int wholeExponent = (int)pow;
        double fractionalExponent = pow - wholeExponent;
    
        double result = Math.Pow(number, wholeExponent);
        result *= Math.Pow(number, fractionalExponent);

        return result;
    }

    public static bool IsPrimeNumber(int number)
    {
        if (number < 2)
        {
            return false;
        }
        int result = 0, a = 1;
        while (a <= number)
        {
            number -= a;
            a += 2;
            result += 1;
        }
        for (int i = 2; i <= result; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}


