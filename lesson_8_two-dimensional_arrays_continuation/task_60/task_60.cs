/* Form a three-dimensional array of non-repeating two-digit numbers.
Write a program that will output an array line by line, adding indexes of each element. */

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
            else if (a < 0 || a > 4)
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

int[,,] createArray(int a, int b, int c)
{
    int[,,] matrix = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
}

void printArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Write("{0,4}({1},{2},{3})", matrix[i, j, k], i, j, k);
            }
            WriteLine();
        }
        WriteLine();
    }
}

WriteLine("Enter an integer from 1 to 4 to build a three-dimensional array,"
        +"or enter 0 to exit:");
int row = inputValidation();
int column = row;
int depth = row;
int[,,] array3D = createArray(row, column, depth);
printArray(array3D);