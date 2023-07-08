var name = "Łukasz";
var sex = "man";
var age = 33;


if (name == "Łukasz" && age < 30 && age > 18)
{
    if (sex == "man")
    {
        Console.WriteLine("Łukasz, mężczyzna poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("kobieta poniżej 30 lat");
    }
}
else if (age == 33)
{
    if (sex == "man")
    {
        Console.WriteLine("Łukasz, mężczyzna lat 33 lat");
    }
    else
    {
        Console.WriteLine("kobieta lat 33 lat");
    }
}
else if (age < 18)
{
    if (sex == "man")
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
    if (sex == "man")
    {
        Console.WriteLine("Łukasz, doświadczony mężczyzna");
    }
    else
    { 
        Console.WriteLine("Doświadczona kobieta");
    }
}