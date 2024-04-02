
class Program
{
    static int BinaryToDecimal(string binary, int index)
    {
        if (index == binary.Length - 1)
        {
            return binary[index] == '1' ? 1 : 0;
        }
        else
        {
            int bit = binary[index] == '1' ? 1 : 0;
            return bit * (int)Math.Pow(2, binary.Length - index - 1) + BinaryToDecimal(binary, index + 1);
        }
    }

    static void Main()
    {
        Console.Write("Введите двоичное число: ");
        string binaryNumber = Console.ReadLine();

        // это чтобы нельзя было ввести 104, ибо ответ он выдает даже если число не двоичное
        foreach (char c in binaryNumber)
        {
            if (c != '0' && c != '1')
            {
                Console.WriteLine("Ошибка: Введено не двоичное число. Пожалуйста, введите двоичное число.");
                return;
            }
        }

        int decimalNumber = BinaryToDecimal(binaryNumber, 0);

        Console.WriteLine($"Двоичное число {binaryNumber} эквивалентно десятичному числу {decimalNumber}");
    }
}
