Console.WriteLine("2. feladat");

StreamReader fajl_beolvasas = new StreamReader("pontszamok.txt");
string[] nevek = new string[50];
int[] pontszamok = new int[50];
int db = 0;

while (!fajl_beolvasas.EndOfStream && db < 50)
{
    nevek[db] = fajl_beolvasas.ReadLine();
    pontszamok[db] = int.Parse(fajl_beolvasas.ReadLine());
    db++;
}
fajl_beolvasas.Close();

// a feladat
Console.WriteLine("a feladat");

for (int i = 0; i < db; i++)
{
    Console.WriteLine($"{nevek[i]} pontszáma: {pontszamok[i]}");
}
Console.WriteLine();

// b feladat
Console.WriteLine("b feladat");
Console.WriteLine($"{db} versenyző adatait tartalmazza a fájl\n");

// c feladat
Console.WriteLine("c feladat");
int legkisebb = 0;
int legnagyobb = 0;

for (int i = 1; i < db; i++)
{
    if (pontszamok[legkisebb] > pontszamok[i])
    {
        legkisebb = i;
    }
    if (pontszamok[legnagyobb] < pontszamok[i])
    {
        legnagyobb = i;
    }
}
Console.WriteLine($"{pontszamok[legkisebb]} volt a legkisebb és {pontszamok[legnagyobb]} volt a legnagyobb pontszám, amit egy döntős versenyző elért\n");

// d feladat
Console.WriteLine("d feladat");
int ossz_pontszam = 0;

for (int i = 0; i < db; i++)
{
    ossz_pontszam += pontszamok[i];
}
double atlag_pontszam = Math.Round((double)ossz_pontszam/db, 2);
Console.WriteLine($"{atlag_pontszam.ToString("0.00")} volt az átlagos pontszám\n");

// e feladat
Console.WriteLine("e feladat");
Console.Write("Kérem adjon meg egy nevet: ");
string nev = Console.ReadLine();

for (int i = 0; i < db; i++)
{
    if (nevek[i] == nev)
    {
        Console.WriteLine($"{nevek[i]} {pontszamok[i]} pontot ért el\n");
    }
}