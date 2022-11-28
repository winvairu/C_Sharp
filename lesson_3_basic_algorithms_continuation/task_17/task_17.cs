/* Write a program that takes the coordinates of a point (X and Y) as input,
with X ≠ 0 and Y ≠ 0 and outputs the number of the quarter of the plane
in which this point is located. */

Console.WriteLine("Enter the coordinates of point X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates of point Y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("The point is in the first quarter:");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("The point is in the second quarter.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("The point is in the third quarter.");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("The point is in the fourth quarter.");
}
else
{
    Console.WriteLine("X or Y cannot be equal to zero.");
}