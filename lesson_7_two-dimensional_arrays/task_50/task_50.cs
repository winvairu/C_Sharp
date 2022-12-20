﻿/* Write a program that takes an integer as input and searches for it in a two-dimensional array.
The program outputs the index of the element or a message that there is no such number. */

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

void indexSearch(int[,] matrix, int a)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == a)
            {
                WriteLine($"The index of the element whose value is {a}: [{i}, {j}]");
                WriteLine();
            }
            else
            {
                temp += 1;
            }
        }
    }
    if (temp == matrix.Length)
    {
        WriteLine($"The number {a} was not found.");
        WriteLine();
    }
}

WriteLine("Enter the number of rows of the two-dimensional array or enter \"0\" to exit:");
int row = inputValidation();
WriteLine("Enter the number of columns of the two-dimensional array or enter \"0\" to exit:");
int column = inputValidation();
WriteLine("Enter an integer to check or enter \"0\" to exit");
int num = inputValidation();
int[,] twoDimensional = createArray(row, column);
printArray(twoDimensional);
indexSearch(twoDimensional, num);