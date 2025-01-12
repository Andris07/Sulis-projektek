Console.WriteLine("1. feladat");

// a feladat
StreamReader fajl_beolvasas = new StreamReader("valaszok.txt");
int db = int.Parse(fajl_beolvasas.ReadLine());
int nehez = int.Parse(fajl_beolvasas.ReadLine());
int konnyu = int.Parse(fajl_beolvasas.ReadLine());
int[] helyes_valaszok = new int[db];

for (int i = 0; i < db; i++)
{
    helyes_valaszok[i] = int.Parse(fajl_beolvasas.ReadLine());
}

// c feladat
Console.WriteLine("c feladat");

for (int i = 0; i < db; ++i)
{
    Console.WriteLine($"{i+1}. nap: {helyes_valaszok[i]} helyes válasz - {Nehezseg(helyes_valaszok[i])}");
}
Console.WriteLine();

// d feladat
Console.Write("Kiemelkedő nehézségű feladatok: ");

for (int i = 1; i < db-1; ++i)
{
    if (helyes_valaszok[i] < nehez && helyes_valaszok[i-1] > konnyu && helyes_valaszok[i+1] > konnyu)
    {
        Console.Write($"{helyes_valaszok[i]} ");
    }
    else if (i == 1 && helyes_valaszok[i-1] < nehez && helyes_valaszok[i] > konnyu)
    {
        Console.Write($"{helyes_valaszok[i-1]} ");
    }
    else if (i == db-2 && helyes_valaszok[db-1] < nehez && helyes_valaszok[db-2] > konnyu)
    {
        Console.Write($"{helyes_valaszok[db-1]}");
    }
}
Console.WriteLine();

// b feladat
string Nehezseg(int helyes_valasz)
{
    if (helyes_valasz > konnyu)
    {
        return "Könnyű";
    }
    else if (helyes_valasz < nehez)
    {
        return "Nehéz";
    }
    else
    {
        return "Közepes";
    }
}