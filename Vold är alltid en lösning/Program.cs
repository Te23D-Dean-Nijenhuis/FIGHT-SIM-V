Console.WriteLine("Skriv in ditt namn:");
string name = Console.ReadLine();

while (name.Length <= 2)
{
    Console.WriteLine("slow down there buckaroo. Skriv in ditt riktiga namn:");
    name = Console.ReadLine();
}

Console.WriteLine($"Hej {name}");




Console.ReadLine();
