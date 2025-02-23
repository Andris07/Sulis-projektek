Console.WriteLine("1. feladat");

// a feladat
StreamReader fajl_beolvasas = new StreamReader("aprilis.txt");
List<Osztaly> osztalyok = new List<Osztaly>();
int osztalyok_db = 0;

while (!fajl_beolvasas.EndOfStream && osztalyok_db < 30)
{
    string[] sor = fajl_beolvasas.ReadLine().Split(";");
    Osztaly osztaly = new Osztaly(sor[0], int.Parse(sor[1]));
    osztalyok.Add(osztaly);
    osztalyok_db++;
}

// b feladat
Console.WriteLine("b feladat");
int max = 0;

for (int i = 1; i < osztalyok_db; i++)
{
    if (osztalyok[max].pontszam < osztalyok[i].pontszam)
    {
        max = i;
    }
}
Console.WriteLine($"A {osztalyok[max].osztaly} érte el áprilisban a legtöbb pontot, {osztalyok[max].pontszam} pont\n");

// c feladat
Console.WriteLine("c feladat");
double atlag = 0;

for (int i = 0; i < osztalyok_db; i++)
{
    atlag += osztalyok[i].pontszam;
}
atlag /= osztalyok_db;
Console.WriteLine($"Átlagosan {atlag} pontot szereztek az osztályok\n");

// d feladat
Console.WriteLine("d feladat");
int kevesebb = 0;

for (int i = 0; i < osztalyok_db; i++)
{
    if (osztalyok[i].pontszam < 100)
    {
        kevesebb++;
    }
}
Console.WriteLine($"{kevesebb} osztály szerzett 100 pontnál kevesebbet\n");

// e feladat
Console.WriteLine("e feladat");
Console.Write($"Kérem adja meg az osztály nevét: ");
string osztaly_nev = Console.ReadLine();

for (int i = 0; i < osztalyok_db; i++)
{
    if (osztaly_nev == osztalyok[i].osztaly)
    {
        Console.WriteLine($"{osztalyok[i].pontszam} pontot sikerült szerezniük\n");
    }
}

// f feladat
Console.WriteLine("f feladat");

for (int i = 0; i < osztalyok_db; i++)
{
    if (osztalyok[i].pontszam < 50)
    {
        Console.Write($"{osztalyok[i].osztaly} ");
    }
}
Console.WriteLine();

public record Osztaly(string osztaly, int pontszam);