/* Set an array filled with random positive three-digit numbers.
Write a program that will show the number of even numbers in the array. */

using static System.Console;

int createArray(int a)
{
    int evenNumbers = 0;
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(100, 1000);
        Write(array[i]);
        Write(" ");
        if (array[i] % 2 == 0)
        {
            evenNumbers += 1;
        }
    }
    WriteLine();
    return evenNumbers;
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
            WriteLine($"The number of even numbers in the array: {createArray(num)}");
            WriteLine();
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}