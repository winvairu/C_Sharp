/* Set the value to N. Write a program that outputs
all natural numbers in the range from N to 1. Execute using recursion. */

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
            else if (a < 0 || a > 50)
            {
                WriteLine("Invalid value. Try again or enter \"0\" to exit:");
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

string numberRec(int a, int b)
{
    if ( a <= b)
    {
        return numberRec(a + 1, b) + $"{a} ";
    }
    else
    {
        return String.Empty;
    }
}

int number1 = 1;
WriteLine("Enter an unsigned integer (from 1 to 50) or enter \"0\" to exit:");
int number2 = inputValidation();
WriteLine(numberRec(number1, number2));