/* Set a one-dimensional array filled with random numbers.
Find the sum of the elements standing in odd positions. */

using static System.Console;

int createArray(int a)
{
    int sum = 0;
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(-99, 100);
        Write(array[i]);
        Write(" ");
        if (i % 2 > 0)
        {
            sum += array[i];
        }
    }
    WriteLine();
    return sum;
}

int num;
while (true)
{
    Write("Enter the number of array elements or \"0\" to complete: ");
    if (int.TryParse(ReadLine(), out num))
    {
        if (num == 0)
        {
            WriteLine("End");
            break;
        }
        else if (num < 0)
        {
            WriteLine("Invalid input.");
        }
        else
        {
            WriteLine($"The sum of the elements in odd positions.: {createArray(num)}");
            WriteLine();
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}