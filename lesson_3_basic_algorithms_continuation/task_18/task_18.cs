/* Write a program that, according to a given number of quarters,
shows the range of possible coordinates of points in this quarter (X and Y). */

Console.WriteLine("Enter the number of the coordinate quarter (1-4):");
int z = Convert.ToInt32(Console.ReadLine());
int x, y;

if (z == 1)
{
    Console.WriteLine("x > 0, y > 0");
    x = new Random().Next(1, 999);
    y = new Random().Next(1, 999);
    Console.WriteLine($"Example: x = {x}, y = {y}");
}
else if (z == 2)
{
    Console.WriteLine("x > 0, y < 0");
    x = new Random().Next(1, 999);
    y = new Random().Next(1, 999);
    Console.WriteLine($"Example: x = {x}, y = {y}");
}
else if (z == 3)
{
    Console.WriteLine("x < 0, y < 0");
    x = new Random().Next(1, 999);
    y = new Random().Next(1, 999);
    Console.WriteLine($"Example: x = {x}, y = {y}");
}
else if (z == 4)
{
    Console.WriteLine("x < 0, y > 0");
    x = new Random().Next(1, 999);
    y = new Random().Next(1, 999);
    Console.WriteLine($"Example: x = {x}, y = {y}");
}
else
{
    Console.WriteLine("Wrong quarter.");
}