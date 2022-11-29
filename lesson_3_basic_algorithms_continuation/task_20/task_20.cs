/* Write a program that takes the coordinates of two points as input and
finds the distance between them in 2D space. */

Console.WriteLine("Coordinates of point A:");
int x1 = new Random().Next(-100, 100);
int y1 = new Random().Next(-100, 100);
Console.WriteLine($"x = {x1}, y = {y1}");

Console.WriteLine("Coordinates of point B:");
int x2 = new Random().Next(-100, 100);
int y2 = new Random().Next(-100, 100);
Console.WriteLine($"x = {x2}, y = {y2}");

double ab = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
ab = Math.Sqrt(ab);
Console.WriteLine("Distance: {0:f2}", ab);