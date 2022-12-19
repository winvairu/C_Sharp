/* The user enters M numbers from the keyboard.
Count how many numbers greater than 0 the user entered. */

using static System.Console;

int[] createArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(-99, 100);
        Write(array[i]);
        Write(" ");
    }
    WriteLine();

    return array;
}

int numberCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count += 1;
        }
    }

    return count;
}

int num = 0;
while (true)
{
    Write("Enter the number of elements of the integer array or enter \"0\" to exit: ");
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
            int[] temp = createArray(num);
            WriteLine($"The number of numbers greater than zero: {numberCounter(temp)}");
            WriteLine();
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}