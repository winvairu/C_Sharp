/* Write a program that accepts a digit indicating the day
of the week as input and checks whether this day is a weekend. */

Console.WriteLine("Enter a number indicating the day of the week: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 5 && a <= 7)
{
    Console.WriteLine("You have chosen a day off.");
} else if ( a >= 1 && a <= 5)
        {
            Console.WriteLine("You have chosen a working day.");
        }
else
{
    Console.WriteLine("The number does not correspond to the day of the week.");
}