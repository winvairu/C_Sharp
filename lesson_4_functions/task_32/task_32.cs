/* Fill the array with random numbers (the number of elements from the keyboard).
Filling in methods, array output, even if via string join,
then in the method (just return a string). */

using static System.Console;

int[] createArray(int a)
{
    
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
int num = 0;
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
            for (int j = 0; j < t.Length; j++)
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