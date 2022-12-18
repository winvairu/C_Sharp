/* Set a one-dimensional array of 123 random numbers.
Find the number of array elements whose values lie in the segment [10, 99]. */

using static System.Console;

int createArray(int a)
{
    int numElements = 0;
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(0, 111);
        Write(array[i]);
        Write(" ");
        if (array[i] >= 10 && array[i] <= 99)
        {
            numElements += 1;
        }
    }
    WriteLine();
    return numElements;
}

int num;
while (true)
{
    Write("Enter \"123\" to create an array or \"0\" to complete: ");
    if (int.TryParse(ReadLine(), out num))
    {
        if (num == 0)
        {
            WriteLine("End");
            break;
        }
        else if (num < 123 || num > 123)
        {
            WriteLine("Invalid input.");
        }
        else
        {
            WriteLine("The number of array elements whose"
                    +$"values lie in the segment [10,99]: {createArray(num)}");
            WriteLine();
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}