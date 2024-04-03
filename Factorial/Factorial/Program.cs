class Program
{
    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Введите число:");
        int num = int.Parse(Console.ReadLine());
        long result = Factorial(num);
        Console.WriteLine($"Факториал {num} равен " + result);
    }
}