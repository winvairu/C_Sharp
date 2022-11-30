/* Write a program that accepts a number as input and
outputs the sum of the digits in the number. */

using static System.Console;

int sumDigits(int a)
{
    int sum = 0;
    for (int n = a * 10, remains = 0; n > 0; n = n / 10)
    {
        remains = n % 10;
        sum += remains;
    }
    return sum;
}

WriteLine("Enter an unsigned integer:");
int x = Convert.ToInt32(ReadLine());
WriteLine($"Sum of all digits: {sumDigits(x)}");