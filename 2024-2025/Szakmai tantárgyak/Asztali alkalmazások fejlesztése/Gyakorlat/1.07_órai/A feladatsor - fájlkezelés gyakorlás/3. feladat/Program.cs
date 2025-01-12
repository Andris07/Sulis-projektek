Console.WriteLine("3. feladat");

StreamReader fajl_beolvasas = new StreamReader("felveteli.csv");
string[] nevek = new string[1000];
int[] hozott = new int[1000];
int[] szerzett = new int[1000];
int db = 0;

while (!fajl_beolvasas.EndOfStream && db < 1000)
{
    string[] adatok = fajl_beolvasas.ReadLine().Split(";");
    nevek[db] = adatok[0];
    hozott[db] = int.Parse(adatok[1]);
    szerzett[db] = int.Parse(adatok[2]);
    db++;
}
fajl_beolvasas.Close();

// a feladat
Console.WriteLine("a feladat");
int[] osszpontszamok = new int[db];

for (int i = 0; i < db; i++)
{
    osszpontszamok[i] = hozott[i]+szerzett[i];
    Console.WriteLine($"{nevek[i]} hozott pontjai: {hozott[i]}, szerzett pontjai: {szerzett[i]}, összpontszáma: {osszpontszamok[i]}");
}
Console.WriteLine();

// b feladat
Console.WriteLine("b feladat");
int legnagyobb = 0;

for (int i = 1; i < db; i++)
{
    if (osszpontszamok[legnagyobb] < osszpontszamok[i])
    {
        legnagyobb = i;
    }
}
Console.WriteLine($"{nevek[legnagyobb]}-nak/nek volt a legnagyobb az összpontszáma\n");

// c feladat
Console.WriteLine("c feladat");
int ossz_pontszam = 0;

for (int i = 0; i < db; i++)
{
    ossz_pontszam += osszpontszamok[i];
}
double atlag_pontszam = Math.Round((double)ossz_pontszam / db, 1);
Console.WriteLine($"{atlag_pontszam.ToString("0.0")} volt az átlagos összpontszám\n");

// d feladat
Console.WriteLine("d feladat");
Console.Write("Kérem adjon meg egy nevet: ");
string nev = Console.ReadLine();

for (int i = 0; i < db; i++)
{
    if (nevek[i] == nev)
    {
        Console.WriteLine($"{nevek[i]} hozott pontjai: {hozott[i]}, szerzett pontjai: {szerzett[i]}, összpontszáma: {osszpontszamok[i]}\n");
    }
}

// e feladat
StreamWriter fajl_iras = new StreamWriter("osszpontok.csv");
fajl_iras.WriteLine($"{db} diák adatait tartalmazza a fájl");

for (int i = 0; i < db; i++)
{
    fajl_iras.WriteLine($"{nevek[i]};{osszpontszamok[i]}");
}