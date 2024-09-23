using System.Runtime.InteropServices.Marshalling;

int A_hp = 100; //ditt hp
int B_hp = 100; //motståndarens hp
string slag; // val av attack

Console.WriteLine("Skriv in ditt namn:");
string name = Console.ReadLine();

while (name.Length <= 2)
{
    Console.WriteLine("slow down there buckaroo. Skriv in ditt riktiga namn:");
    name = Console.ReadLine();
}

Console.WriteLine($"Hej {name}");

 static void Attack()
 {
    int r = Random.Shared.Next(1,3); //en random int som gör så att en attack är bättre än den andra
    if (r == 1)
    {
        Console.WriteLine($"{name}, välj mellan attack A och attack B");
        while (slag.ToLower != "a" || slag.ToLower != "b")
        {
            slag = Console.ReadLine();
        }

        if ()


    }
 }


Console.ReadLine();
