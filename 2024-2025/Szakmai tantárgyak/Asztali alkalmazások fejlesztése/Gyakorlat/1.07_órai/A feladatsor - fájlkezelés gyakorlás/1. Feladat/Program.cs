Console.WriteLine("1. feladat");

StreamReader fajl_beolvasas = new StreamReader("adatok.txt");
int[] kezdesevek = new int[1000];
string[] osztalyok = new string[1000];
string[] nevek = new string[1000];
int db = 0;

while (!fajl_beolvasas.EndOfStream && db < 1000)
{
    string[] adatok = fajl_beolvasas.ReadLine().Split(" ");
    kezdesevek[db] = int.Parse(adatok[0]);
    osztalyok[db] = adatok[1];
    nevek[db] = adatok[2] + " " + adatok[3];
    if (adatok.Length == 5)
    {
        nevek[db] += " " + adatok[4];
    }
    db++;
}
fajl_beolvasas.Close();

// a feladat
Console.WriteLine("a feladat");
Console.WriteLine($"{db} diák adatai kerültek rögzítésre\n");

// b feladat
Console.WriteLine("b feladat");
Console.Write("Kérem adjon meg egy évszámot: ");
int evszam = int.Parse(Console.ReadLine());
int evszam_db = 0;

for (int i = 0; i < db; i++)
{
    if (kezdesevek[i] == evszam)
    {
        evszam_db++;
    }
}
Console.WriteLine($"{evszam_db} olyan diák van, aki ebben az évben kezdte az iskolát\n");

// c feladat
Console.WriteLine("c feladat");
Console.Write("Kérem adjon meg egy nevet: ");
string nev = Console.ReadLine();

for (int i = 0; i < db; i++)
{
    if (nevek[i] == nev)
    {
        Console.WriteLine($"{kezdesevek[i]} évben kezdte az iskolát és {osztalyok[i]} volt az osztályának a betűjele\n");
    }
}

// d feladat
Console.WriteLine("d feladat");
Console.Write("Kérem adjon meg egy név részletét: ");
string nev_reszlet = Console.ReadLine();

for (int i = 0; i < db; i++)
{
    if (nevek[i].ToLower().Contains(nev_reszlet.ToLower()))
    {
        Console.WriteLine($"{nevek[i]} {osztalyok[i]} {kezdesevek[i]}");
    }
}
Console.WriteLine();

// e feladat
Console.WriteLine("e feladat");
int leghosszabb = 0;
for (int i = 1; i < db; i++)
{
    if (nevek[leghosszabb].Length < nevek[i].Length)
    {
        leghosszabb = i;
    }
}
Console.WriteLine($"{nevek[leghosszabb]} a leghosszabb nevű tanuló, {kezdesevek[leghosszabb]} évben és {osztalyok[leghosszabb]} osztályban kezdte a tanulmányait\n");

// f feladat
StreamWriter fajl_iras = new StreamWriter("nevsor.txt");

for (int i = 0; i < db; i++)
{
    fajl_iras.WriteLine($"{nevek[i]}");
}
fajl_iras.Close();