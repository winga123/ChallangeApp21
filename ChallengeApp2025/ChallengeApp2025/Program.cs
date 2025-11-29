var myName = "Sylwia";
var mySex = "women";
var myAge = 37;

if (myAge < 30)
{
    if (mySex == "women")
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}

if (myAge == 30)
{
    if (myName == "Ewa")
    {
        Console.WriteLine("Ewa, lat 30");
    }
}

if (mySex == "men")
{
    if (myAge < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}
