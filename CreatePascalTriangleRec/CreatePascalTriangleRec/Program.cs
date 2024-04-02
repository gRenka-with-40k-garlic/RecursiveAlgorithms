
class Program
{
    static int PascalTriangle(int row, int col)
    {
        if (col == 0 || col == row)
        {
            return 1;
        }
        else
        {
            return PascalTriangle(row - 1, col - 1) + PascalTriangle(row - 1, col);
        }
    }

    static void PrintPascalTriangleRow(int row)
    {
        for (int col = 0; col <= row; col++)
        {
            Console.Write(PascalTriangle(row, col) + " ");
        }
        Console.WriteLine();
    }

    static void PrintPascalTriangle(int numRows)
    {
        for (int row = 0; row < numRows; row++)
        {
            PrintPascalTriangleRow(row);
        }
    }

    static void Main()
    {
        //int numRows = 5;

        Console.Write("Введите количество строк : ");
        int numRows = int.Parse(Console.ReadLine());

        PrintPascalTriangle(numRows);
    }
}