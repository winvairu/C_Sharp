/* Write a program that accepts a five-digit number as input and
checks whether it is a palindrome. */

Console.WriteLine("Enter an unsigned five-digit integer:");
int x = Convert.ToInt32(Console.ReadLine());
int y = x / 10000;

if (y >= 1 && y <= 9)
{
    int a1 = y;
    int a5 = x % 10;
    int a2 = (x / 1000) % 10;
    int a4 = (x / 10) % 10;
    if ((a1 == a5) && (a2 == a4))
    {
        Console.WriteLine($"The number {x} is a palindrome.");
    }
    else
    {
        Console.WriteLine($"The number {x} is not a palindrome.");
    }
}
else
{
    Console.WriteLine("This number is not a five-digit number or it is signed.");
}