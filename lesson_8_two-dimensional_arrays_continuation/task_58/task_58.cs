/* Set two matrices. Write a program that will find the product of two matrices. */

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
            Write("{0,10:}", matrix[i, j]);
        }
        WriteLine();
    }
    WriteLine();
}

int[,] productTwoMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            matrix[i, j] = sum;
        }
    }
    return matrix;
}

WriteLine("Enter an integer to build two two-dimensional arrays or enter \"0\" to exit");
int row = inputValidation();
int column = row;
int[,] firstTwoDimensional = createArray(row, column);
int[,] secondTwoDimensional = createArray(row, column);
WriteLine("First:");
printArray(firstTwoDimensional);
WriteLine("Second:");
printArray(secondTwoDimensional);
int[,] newTwoDimensional = productTwoMatrices(firstTwoDimensional, secondTwoDimensional);
WriteLine("The result of the product:");
printArray(newTwoDimensional);