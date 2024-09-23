using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.Arm;

int A_hp = 100; //ditt hp
int B_hp = 100; //motståndarens hp
string slag = "L"; // val av attack

Console.WriteLine("Skriv in ditt namn:");
string name = Console.ReadLine();

while (name.Length <= 2)
{
    Console.WriteLine("slow down there buckaroo. Skriv in ditt riktiga namn:");
    name = Console.ReadLine();
}

Console.WriteLine($"Hej {name}");


while (B_hp > 0 && A_hp > 0)
{
    (A_hp, B_hp) = Attack(name, slag, B_hp, A_hp);
}

 static (int, int) Attack(string name, string slag, int B_hp, int A_hp)
 {
    int r = Random.Shared.Next(1,3); //en random int som gör så att en attack är bättre än den andra
    if (r == 1)
    {
        while (slag.ToLower() != "a" && slag.ToLower() != "b")
        {
            Console.WriteLine($"{name}, välj mellan attack A och attack B");
            slag = Console.ReadLine();
        }

        if (slag.ToLower() == "a" )
        {
            B_hp -= Random.Shared.Next(15,26);
        }else if (slag.ToLower() == "b")
        {
            B_hp -= Random.Shared.Next(10,21);
        }
    }
    if (r == 2)
    {
        while (slag.ToLower() != "a" && slag.ToLower() != "b")
        {
            Console.WriteLine($"{name}, välj mellan attack A och attack B");
            slag = Console.ReadLine();
        }

        if (slag.ToLower() == "a" )
        {
            B_hp -= Random.Shared.Next(10,21);
        }else if (slag.ToLower() == "b")
        {
            B_hp -= Random.Shared.Next(15,26);
        }


    }
    A_hp -= Random.Shared.Next(10,26);

    Console.WriteLine($"Din motståndare attackerade och ditt hp är nu {A_hp}."); 
    Console.ReadLine();
    Console.WriteLine($"efter din attack, {name} så har din motståndare {B_hp} hp kvar.");  

    return (A_hp, B_hp);


 }

if (A_hp > B_hp)
{
    Console.WriteLine($"grattis {name}, du vann");
}
if (A_hp < B_hp)
{
Console.WriteLine($"hahahahahahah sämst");
}
Console.ReadLine();
