/* Find the product of pairs of numbers in a one-dimensional array.
We consider the first and last element as a pair, the second and penultimate, etc.
Write the result in a new array. */

using static System.Console;

void createArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(-99, 100);
        Write(array[i]);
        Write(" ");
    }
    WriteLine();

    int b = 0;
    if (array.Length % 2 == 0)
    {
        b = array.Length / 2;
    }
    else
    {
        b = (array.Length / 2) + 1;
    }
    int[] newArray = new int[b];
    for (int j = 0; b > 0; b--, j++)
    {
        if (array[j] == array[array.Length - 1 - j])
        {
            newArray[j] = array[j];
        }
        else
        {
            newArray[j] = array[j] * array[array.Length - 1 - j];
        }
        Write(newArray[j]);
        Write(" ");
    }
    WriteLine();
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
            createArray(num);
            WriteLine();
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}