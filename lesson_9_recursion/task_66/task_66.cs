/* Set the values of M and N. Write a program that finds the sum of
natural elements in the range from M to N. */

using static System.Console;

int inputValidation()
{
    int a = 0;
    while (true)
    {
        if (int.TryParse(ReadLine(), out a))
        {
            if (a == 0)
            {
                WriteLine("End");
                Environment.Exit(0);
            }
            else
            {
                break;
            }
        }
        else
        {
            WriteLine("Invalid value. Try again or enter \"0\" to exit:");
        }
    }
    return a;
}

int sumRec(int a, int b)
{
    if (b == a - 1)
    {
        return 0;
    }
    else if (a > b)
    {
        int temp = a;
        a = b;
        b = temp;
        return b + sumRec(a, b - 1);
    }
    else
    {
        return b + sumRec(a, b - 1);
    }
}

WriteLine("Enter the first number or enter \"0\" to exit:");
int m = inputValidation();
WriteLine("Enter the first number or enter \"0\" to exit:");
int n = inputValidation();
WriteLine(sumRec(m, n));