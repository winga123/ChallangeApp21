var myName = "Sylwia";
var mySex = "women";
var myAge = 37;

if (myAge < 30 && mySex == "women")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (myAge == 30 && myName == "Ewa")
{
    Console.WriteLine("Ewa, lat 30");
}
else if (mySex == "men" && myAge < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}