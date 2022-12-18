/* Set an array of 12 elements filled with random numbers from the interval [-9, 9].
Find the sum of the negative and positive elements of the array. */

using static System.Console;

int[] createArray(int a)
{
    
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
    return array;
}
int num;
while (true)
{
    Write("Enter \"12\" to create an array or \"0\" to complete: ");
    if (int.TryParse(ReadLine(), out num))
    {
        if (num == 0)
        {
            WriteLine("End");
            break;
        }
        else if (num < 12 || num > 12)
        {
            WriteLine("Invalid input.");
        }
        else
        {
            int[] t = createArray(num);
            int sum1 = 0, sum2 = 0;
            for (int j = 0; j < t.Length; j++)
            {
                Write(t[j]);
                Write(" ");
                if (t[j] > 0)
                {
                    sum1 += t[j];
                }
                else if (t[j] < 0)
                {
                    sum2 += t[j];
                }
            }
            WriteLine();
            WriteLine($"Sum of positive numbers: {sum1}");
            WriteLine($"Sum of negative numbers: {sum2}");
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}