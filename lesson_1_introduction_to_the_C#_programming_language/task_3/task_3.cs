/* Write a program that will give out the name of the day of the week by a given number.*/

Console.WriteLine("Enter a number indicating the day of the week: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        Console.WriteLine("Your day is Monday");
        break;

    case 2:
        Console.WriteLine("Your day is Tuesday");
        break;

    case 3:
        Console.WriteLine("Your day is Wednesday");
        break;

    case 4:
        Console.WriteLine("Your day is Thursday");
        break;

    case 5:
        Console.WriteLine("Your day is Friday");
        break;

    case 6:
        Console.WriteLine("Your day is Saturday");
        break;

    case 7:
        Console.WriteLine("Your day is Sunday");
        break;

    default:
        Console.WriteLine("Incorrect data");
        break;
}