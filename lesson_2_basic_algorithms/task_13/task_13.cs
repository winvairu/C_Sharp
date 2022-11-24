/* Write a program that outputs the third digit of a given number or
reports that there is no third digit. */

Console.WriteLine("Enter a three-digit integer:");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
{
    a = a * (-1);
}
int b = a / 100;

if (b >= 1)
{
    int temp = a;
    int index = 0;
    while (temp > 0)
    {
        temp = temp / 10;
        index++;
    }
    int power = index - 3;
    int c = Convert.ToInt32(Math.Pow(10, power));
    int d = (a / c) % 10;
    Console.WriteLine($"The third number: {d}");
}
else
{
    Console.WriteLine("There is no third digit.");
}