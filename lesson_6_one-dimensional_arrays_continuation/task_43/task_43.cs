/* Write a program that finds the intersection point of
two straight lines given by the equations y = k1 * x + b1, y = k2 * x + b2;
the values b1, k1, b2 and k2 are set by the user. */

using static System.Console;

int checkingNumber()
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

void checkingIntersection(int a, int b, int c, int d)
{
    if (b == d)
    {
        WriteLine("Straight lines don't intersect.");
        WriteLine("End");
        Environment.Exit(0);
    }
}

void intersectionCoordinates(int a, int b, int c, int d)
{
    double a1 = a;
    double b1 = b;
    double c1 = c;
    double d1 = d;
    double x = (c1 - a1) / (b1 - d1);
    double y = (b1 * x) + a1;
    WriteLine("Coordinates of the intersection point of the lines:");
    WriteLine($"({x}; {y})");
    WriteLine();
}

WriteLine("Enter the number b1 or enter \"0\" to exit:");
int b1 = checkingNumber();
WriteLine("Enter the number k1 or enter \"0\" to exit:");
int k1 = checkingNumber();
WriteLine("Enter the number b2 or enter \"0\" to exit:");
int b2 = checkingNumber();
WriteLine("Enter the number k2 or enter \"0\" to exit:");
int k2 = checkingNumber();
checkingIntersection(b1, k1, b2, k2);
intersectionCoordinates(b1, k1, b2, k2);