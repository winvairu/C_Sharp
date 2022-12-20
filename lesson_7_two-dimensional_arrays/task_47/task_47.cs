/* Set a two-dimensional array of size m × n filled with random real numbers. */

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

double[,] createArray(int a, int b)
{
    double[,] matrix = new double[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i, j] = new Random().Next(-99999, 100000) / 1000.0;
        }
    }
    return matrix;
}

void printArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write("{0,8:0.000}", matrix[i, j]);
        }
        WriteLine();
    }
    WriteLine();
}

WriteLine("Enter the number of rows of the two-dimensional array or enter \"0\" to exit:");
int row = inputValidation();
WriteLine("Enter the number of columns of the two-dimensional array or enter \"0\" to exit:");
int column = inputValidation();
double[,] twoDimensional = createArray(row, column);
printArray(twoDimensional);