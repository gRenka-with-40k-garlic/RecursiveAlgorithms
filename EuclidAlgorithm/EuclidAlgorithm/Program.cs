
class Program
{

    /*
     * деление с остатком, цикл:
    static long GCD(long a, long b)
    {
        while (b != 0)
            b = a % (a = b);
        return Math.Abs(a);
    }

    * деление с остатком, цикл:
    static long GCD(long a, long b)
    {
	    if (a == 0)
	    	return Math.Abs(b);
	    if (b == 0)
	    	return Math.Abs(a);
	    for ( ; ; )
	    	if ((a %= b) == 0)
	    		return Math.Abs(b);
	    	else if ((b %= a) == 0)
	    		return Math.Abs(a);
    }

    * деление с остатком, рекурсия:
    static long GCD (long a, long b)
    {
        return b == 0 ? Math.Abs(a) : GCD(b, a % b);
    }

    * GCD — greatest common divisor или НОД - наибольший общий делитель
    */

    static int EuclidAlgorithm(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return EuclidAlgorithm(b, a % b);
        }
    }

    static void Main()
    {
        /*
        int num1 = 35;
        int num2 = 15;
        int gcd = EuclideanAlgorithm(num1, num2);
        */

        Console.Write("Введите первое число : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число : ");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = EuclidAlgorithm(num1, num2);

        Console.WriteLine($"НОД чисел {num1} и {num2} равен {gcd}");
    }
}