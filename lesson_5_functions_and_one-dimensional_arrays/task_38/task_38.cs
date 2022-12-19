/* Set an array of real numbers. Find the difference between the maximum and
minimum array elements. */

using static System.Console;

void createArray(int a)
{
    double[] array = new double[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(1000, 100000) / 1000.0;
        Write(array[i]);
        Write(" ");
    }
    WriteLine();
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min) 
        {
            min = array[i];
        }
    }
    double s = max - min;
    WriteLine("MAX - MIN = {0:0.000}", s);
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