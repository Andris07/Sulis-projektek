using System.Linq;
using ViragBolt_Lambda_PL;

List<Virag> viragok = new();

//Console.WriteLine(viragok.Average(x=>x.Ar));

//Beolvasás
viragok.AddRange(
    File.ReadAllLines("viragok.txt")
    .Select(
        x => new Virag(x.Split(';')[0], int.Parse(x.Split(';')[1]))
        )
    );

//Minden elem kiírása beépített ToString() metódusssal
viragok.ForEach(x => Console.WriteLine(x));
Console.WriteLine();

//Minden elem kiírása a minta szerint
viragok.ForEach(x=> Console.WriteLine($"{x.Nev} ({x.Ar} Ft)"));
Console.WriteLine();

Console.WriteLine($"Átlagosan egy szál virág " +
    $"{viragok.Average(x => x.Ar)} Ft-ba kerül");
int max = viragok.Max(x => x.Ar);
Virag v = viragok.First(x => x.Ar == max);
Console.WriteLine($"A legdrágább virág: {v.Nev}");

Virag v2 = viragok.MaxBy(x => x.Ar)!;
Console.WriteLine($"A legdrágább virág: {v2.Nev}");

Console.WriteLine($"{viragok.Count(x => x.Ar >= 1000)} " +
    $"virág kerül legalább 1000 Ft-ba.");

Console.Write("Kérem adja meg a virág nevét: ");
string nev = Console.ReadLine()!;
if (viragok.Exists(x => x.Nev == nev))
{
    Virag v3 = viragok.First(x => x.Nev == nev);
    Console.WriteLine($"A virág ára: {v3.Ar}");
}
else
{
    Console.WriteLine("Nem létezik ilyen virág");
}

Virag? v4 = viragok.Find(x=>x.Nev == nev);
if (v4 is null) Console.WriteLine("Nem létezik ilyen virág");
else Console.WriteLine($"A virág ára: {v4.Ar}");

//v2.Keszlet = 500;

