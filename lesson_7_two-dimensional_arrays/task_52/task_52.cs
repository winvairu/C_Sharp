/* Set a two-dimensional array of integers.
Find the arithmetic mean of the elements in each column. */

using static System.Console;

int inputValidation()
{
    int a = 0;
    while (true)
    {
        if (int.TryParse(ReadLine(), out a))
        {
            if (a == 0)
            {
                WriteLine("End");
                Environment.Exit(0);
            }
            else if (a < 0)
            {
                WriteLine("Invalid value. Try again or enter \"0\" to exit:");
            }
            else
            {
                break;
            }
        }
        else
        {
            WriteLine("Invalid value. Try again or enter \"0\" to exit:");
        }
    }
    return a;
}

int[,] createArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i, j] = new Random().Next(-99, 100);
        }
    }
    return matrix;
}

void printArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write("{0,4:}", matrix[i, j]);
        }
        WriteLine();
    }
    WriteLine();
}

void arithmeticColumns(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        int s = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += (matrix[i, j]);
            s++;
        }
        float arith = (float)sum / (float)s;
        Write("{0:0.00}", arith);
        Write(" ");
    }
    WriteLine();
    WriteLine();
}

WriteLine("Enter the number of rows of the two-dimensional array or enter \"0\" to exit:");
int row = inputValidation();
WriteLine("Enter the number of columns of the two-dimensional array or enter \"0\" to exit:");
int column = inputValidation();
int[,] twoDimensional = createArray(row, column);
printArray(twoDimensional);
arithmeticColumns(twoDimensional);