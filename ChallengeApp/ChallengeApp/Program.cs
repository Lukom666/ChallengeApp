// zadanie dzień 4
var name = "Łukasz";
var age = 33;
bool isMale = true;


if (age < 30 && age > 18)
{
    if (isMale)
    {
        Console.WriteLine($"{name}, mężczyzna poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("kobieta poniżej 30 lat");
    }
}
else if (age == 33)
{
    if (isMale)
    {
        Console.WriteLine($"{name}, mężczyzna lat 33");
    }
    else
    {
        Console.WriteLine($"kobieta lat 33");
    }
}
else if (age < 18)
{
    if (isMale)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Niepełnoletnia kobieta");
    }
}
else if (age > 30)
{
    if (isMale)
    {
        Console.WriteLine($"{name}, doświadczony mężczyzna");
    }
    else
    {
        Console.WriteLine("Doświadczona kobieta");
    }
}
