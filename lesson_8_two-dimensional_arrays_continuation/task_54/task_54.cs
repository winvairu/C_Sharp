/* Set a two-dimensional array.
Write a program that arranges the elements of each row of a
two-dimensional array in descending order. */

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

int[,] sortingRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
        {
            for (int k = j; k >= 0; k--)
            {
                if (matrix[i, j] <= matrix[i, k])
                {
                    continue;
                }
                else
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

WriteLine("Enter the number of rows of the two-dimensional array or enter \"0\" to exit:");
int row = inputValidation();
WriteLine("Enter the number of columns of the two-dimensional array or enter \"0\" to exit:");
int column = inputValidation();
int[,] twoDimensional = createArray(row, column);
printArray(twoDimensional);
int[,] newTwoDimensional = sortingRows(twoDimensional);
printArray(newTwoDimensional);