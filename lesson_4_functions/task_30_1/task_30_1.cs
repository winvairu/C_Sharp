/* Write a program that outputs an array of 8 elements filled with zeros and
ones in random order. */

using static System.Console;

void createArray(int a)
{
    
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(0, 2);
        Write(array[i]);
        Write(" ");
    }
    WriteLine();
}
int num = 0;
while (true)
{
    Write("Enter the number 8 or \"0\" to complete: ");
    if (int.TryParse(ReadLine(), out num))
    {
        if (num == 0)
        {
            WriteLine("End");
            break;
        }
        else if (num < 8 || num > 8)
        {
            WriteLine("Invalid input.");
        }
        else
        {
            createArray(num);
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}