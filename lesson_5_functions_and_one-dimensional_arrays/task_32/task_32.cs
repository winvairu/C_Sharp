/* Write a program replacing array elements: replace the positive elements with the
corresponding negative ones, and vice versa. */

using static System.Console;

int[] createArray(int a)
{
    
    int[] array = new int[a];
    int[] array2 = new int[a]; 
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(-99, 99);
        Write(array[i]);
        Write(" ");
        array2[i] = array[i] * (-1);
    }
    WriteLine();
    return array2;
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
            int[] t = createArray(num);
            for (int j = 0; j < num; j++)
            {
                Write(t[j]);
                Write(" ");
            }
            WriteLine();
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}