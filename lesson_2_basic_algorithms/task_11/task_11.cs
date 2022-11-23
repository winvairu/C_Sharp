/* Write a program that outputs a random three-digit number and
deletes the second digit of that number. */

int a = new Random().Next(100, 999);
Console.WriteLine($"{a}");
int b = a / 100;
int c = a % 10;
a = b * 10 + c;
Console.WriteLine($"{a}");