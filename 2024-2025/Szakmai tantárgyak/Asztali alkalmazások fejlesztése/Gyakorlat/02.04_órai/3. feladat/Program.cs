Console.WriteLine("3. feladat");

// a feladat
Console.WriteLine("a feladat");
StreamReader fajl_beolvasas = new StreamReader("alkoto.txt");
List<Alkoto> alkotok = new List<Alkoto>();
int alkotok_db = 0;

while (!fajl_beolvasas.EndOfStream && alkotok_db < 60)
{
    string nev = fajl_beolvasas.ReadLine();
    string[] sor = fajl_beolvasas.ReadLine().Split(" ");
    Alkoto alkoto = new Alkoto(nev, int.Parse(sor[0]), int.Parse(sor[1]));
    alkotok.Add(alkoto);
    alkotok_db++;
}
for (int i = 0; i < alkotok_db; i++)
{
    Console.WriteLine($"{alkotok[i].nev} {alkotok[i].ervenytelen+alkotok[i].ervenyes} szavazat, {alkotok[i].ervenytelen} érvénytelen és {alkotok[i].ervenyes} érvényes");
}
Console.WriteLine();

// b feladat
Console.WriteLine("b feladat");
int ervenyes_db = 0;

for (int i = 0; i < alkotok_db; i++)
{
    ervenyes_db += alkotok[i].ervenyes;
}
Console.WriteLine($"Összesen {ervenyes_db} érvényes szavazat érkezett a pályaművekre\n");

// c feladat
Console.WriteLine("c feladat");
double ervenytelen_atlag = 0;

for (int i = 0; i < alkotok_db; i++)
{
    ervenytelen_atlag += alkotok[i].ervenytelen;
}
ervenytelen_atlag /= alkotok_db;
Console.WriteLine($"Átlagosan {ervenytelen_atlag} érvénytelen szavazat érkezett a pályaművekre\n");

// d feladat
Console.WriteLine("d feladat");
int ervenyes_max = 0;

for (int i = 1; i < alkotok_db; i++)
{
    if (alkotok[ervenyes_max].ervenyes < alkotok[i].ervenyes)
    {
        ervenyes_max = i;
    }
}
Console.WriteLine($"{alkotok[ervenyes_max].nev} pályaművére érkezett a legtöbb érvényes szavazat, {alkotok[ervenyes_max].ervenyes} érvényes és {alkotok[ervenyes_max].ervenytelen} érvénytelen szavazatot kapott\n");

// e feladat
Console.WriteLine("e feladat");
bool volt = false;

for (int i = 0; i < alkotok_db; i++)
{
    if (alkotok[i].ervenytelen > 10)
    {
        Console.WriteLine($"{alkotok[i].nev} pályaművére érkezett több, mint 10 érvénytelen szavazat\n");
        volt = true;
        break;
    }
}
if (!volt)
{
    Console.WriteLine($"Nem volt olyan, akire 10-nél is több érvénytelen szavazat érkezett\n");
}

// f feladat
Console.WriteLine("f feladat");

for (int i = 0; i < alkotok_db; i++)
{
    if (alkotok[i].ervenyes >= 50)
    {
        Console.WriteLine($"{alkotok[i].nev} legalább 50 érvényes szavazatott gyűjtött");
    }
}

public record Alkoto(string nev, int ervenytelen, int ervenyes);