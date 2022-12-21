/* Set a rectangular two-dimensional array.
Write a program that will find the string with the smallest sum of elements. */

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

int[] createNewArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    WriteLine("Sum of row values:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        WriteLine("Row {0,3}: {1,6}", (i + 1), sum);
        array[i] = sum;
    }
    WriteLine();
    return array;
}

void printMinAmount(int[] array)
{
    int min = array[0];
    int rowMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            rowMin = i + 1;
        }
    }
    WriteLine($"The minimum amount is in {rowMin} row: {min}.");
    WriteLine();
}

WriteLine("Enter the number of rows of the two-dimensional array or enter \"0\" to exit:");
int row = inputValidation();
WriteLine("Enter the number of columns of the two-dimensional array or enter \"0\" to exit:");
int column = inputValidation();
int[,] twoDimensional = createArray(row, column);
printArray(twoDimensional);
int[] newArray = createNewArray(twoDimensional);
printMinAmount(newArray);