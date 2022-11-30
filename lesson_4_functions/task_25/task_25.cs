/* Write a loop that takes two numbers (A and B) as input and
raises the number A to the natural power of B. */

using static System.Console;
{
int numToPow(int a, int b)
{
    int c = 1;
    for (int i = 1; i <= b; i++)
    {
        c *= a;
    }
    return c;
}
WriteLine("Enter the first unsigned integer:");
int x = Convert.ToInt32(ReadLine());
WriteLine("Enter the second unsigned integer:");
int y= Convert.ToInt32(ReadLine());
WriteLine($"{x} to the degree of {y} is equal to {numToPow(x, y)}");
}