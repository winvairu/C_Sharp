/* Set an array. Write a program that will determine
whether a given number is present in the array. */

using static System.Console;

void createArray(int a)
{
    int answer = 0;
    int specNum = new Random().Next(-99, 100);
    int[] array = new int[a];
    for (int i = 0; a > 0; a--, i++)
    {
        array[i] = new Random().Next(-99, 100);
        Write(array[i]);
        Write(" ");
        if (array[i] == specNum)
        {
            answer += 1;
        }
    }
    WriteLine();
    WriteLine($"The specified number: {specNum}");
    WriteLine($"The number {specNum} occurs {answer} times among the array elements.");
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