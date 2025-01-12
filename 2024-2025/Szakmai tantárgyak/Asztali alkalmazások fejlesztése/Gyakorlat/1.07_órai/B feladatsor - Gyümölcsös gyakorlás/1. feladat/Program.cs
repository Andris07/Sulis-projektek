Console.WriteLine("Gyümölcsös feladat");

// 1. feladat
StreamReader fajl_beolvasas = new StreamReader("gyumolcsok.txt");
string[] gyumolcsok = new string[30];
int[] mennyisegek = new int[30];
int db = 0;

while (!fajl_beolvasas.EndOfStream && db < 30)
{
    string[] adatok = fajl_beolvasas.ReadLine().Split(";");
    gyumolcsok[db] = adatok[0];
    mennyisegek[db] = int.Parse(adatok[1]);
    db++;
}

// 2. feladat
Console.WriteLine("2. feladat");

for (int i = 0; i < db; i++)
{
    Console.WriteLine($"{gyumolcsok[i]} ({mennyisegek[i]} kg)");
}
Console.WriteLine();

// 3. feladat
Console.WriteLine("3. feladat");
Console.WriteLine($"Összesen {db} gyümölcs termett\n");

// 4. feladat
Console.WriteLine("4. feladat");
int ossz_mennyiseg = 0;

for (int i = 0; i < db; i++)
{
    ossz_mennyiseg += mennyisegek[i];
}
double atlag_mennyiseg = Math.Round((double)ossz_mennyiseg/db);
Console.WriteLine($"{atlag_mennyiseg} kg gyümölcs termett átlagosan a kertben\n");

// 5. feladat
Console.WriteLine("5. feladat");
int pontosan = 0;

for (int i = 0; i < db; i++)
{
    if (mennyisegek[i] == 10)
    {
        pontosan++;
    }
}
Console.WriteLine($"{pontosan} gyümölcsből termett pontosan 10 kg\n");

// 6. feladat
Console.WriteLine("6. feladat");
int legtobb = 0;

for (int i = 0; i < db; i++)
{
    if (mennyisegek[legtobb] < mennyisegek[i])
    {
        legtobb = i;
    }
}
Console.WriteLine($"{gyumolcsok[legtobb]} gyümölcsből termett a legtöbb idén, és {mennyisegek[legtobb]} kg termett belőle\n");

// 7. feladat
Console.WriteLine("7. feladat");

for (int i = 0; i < db; i++)
{
    if (mennyisegek[i] >= 30)
    {
        Console.WriteLine($"{gyumolcsok[i]}-ból/ből legalább 30 kg termett az idén");
    }
}
Console.WriteLine();

// 8. feladat
Console.WriteLine("8. feladat");
int kevesebb = 0;

for (int i = 0; i < db; i++)
{
    if (10 > mennyisegek[i])
    {
        Console.WriteLine($"{gyumolcsok[i]} gyümölcsből 10 kg-nál kevesebb termett az idén"); break;
    }
}