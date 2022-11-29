/* Divide the watermelon for Petya and Vasya so that the
share of each weighs exactly an even number of kilograms,
while it is not necessary that the shares are equal in size.
The weight of the watermelon is 10 kilograms. */

int weight = 10;
int forPetya;
int forVasya;

for (forPetya = 1; forPetya < 10; forPetya++)
{
    if (forPetya % 2 == 0)
    {
        forVasya = weight - forPetya;
        Console.WriteLine("Sizes of watermelon pieces for Petya and Vasya:");
        Console.WriteLine($"{forPetya}, {forVasya};");
    }
}