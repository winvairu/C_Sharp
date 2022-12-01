/* Write a program that sets an array of N elements and displays them on the screen. */

using static System.Console;

WriteLine("Enter the number of array elements (from 1 to 99):");
int size = Convert.ToInt32(ReadLine());
int[] array = new int[size];

if (size >=1 && size <= 99)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(0, 99);
    Write("{0} ", array[i]);
    }
}
else
{
    WriteLine("Invalid value entered");
}