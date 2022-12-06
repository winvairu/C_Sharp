/* Write a program that accepts a number (A) as input and
outputs the sum of numbers from 1 to A. */

using static System.Console;

int sumDigNum(int a)
{
    int sum = 0;
   for (; a > 0; a--)
   {
    sum +=a;
   }
   return sum;
}

int num = 0;
while (true)
{
    Write("Enter an unsigned integer or \"0\" to complete: ");
    if (int.TryParse(ReadLine(), out num))
    {
        if (num == 0)
        {
            WriteLine($"End");
            break;
        }
        else if (num < 0)
        {
            WriteLine("Invalid input.");
        }
        else
        {
            int s = sumDigNum(num);
            WriteLine($"{s}");
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}