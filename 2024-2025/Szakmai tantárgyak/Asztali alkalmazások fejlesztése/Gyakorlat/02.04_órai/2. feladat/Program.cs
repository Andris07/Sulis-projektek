Console.WriteLine("2. feladat");

// a feladat
StreamReader fajl_beolvasas = new StreamReader("like.txt");
List<Poszt> posztok = new List<Poszt>();
int posztok_db = 0;

while (!fajl_beolvasas.EndOfStream && posztok_db < 20)
{
    string[] sor = fajl_beolvasas.ReadLine().Split(";");
    Poszt poszt = new Poszt(sor[0], int.Parse(sor[1]));
    posztok.Add(poszt);
    posztok_db++;
}
fajl_beolvasas.Close();

// b feladat
Console.WriteLine("b feladat");

for (int i = 0; i < posztok_db; i++)
{
    Console.WriteLine($"{i+1}. poszt: {posztok[i].monogram} {posztok[i].like} like");
}
Console.WriteLine();

// c feladat
Console.WriteLine("c feladat");
int likeok_db = 0;

for (int i = 0; i < posztok_db; i++)
{
    likeok_db += posztok[i].like;
}
Console.WriteLine($"A tegnapi nap összesen {likeok_db} like érkezett\n");

// d feladat
Console.WriteLine("d feladat");
double likeok_atlag = likeok_db/posztok_db;
Console.WriteLine($"Átlagosan {likeok_atlag} like érkezett egy-egy posztra\n");

// e feladat
Console.WriteLine("e feladat");
int min = 0;

for (int i = 1; i < posztok_db; i++)
{
    if (posztok[min].like > posztok[i].like)
    {
        min = i;
    }
}
Console.WriteLine($"A {min+1} poszt kapta a legkevesebb like-ot és {posztok[min].monogram} készítette a posztot\n");

// f feladat
Console.WriteLine("f feladat");
int max = 0;

for (int i = 1; i < posztok_db; i++)
{
    if (posztok[max].like < posztok[i].like)
    {
        max = i;
    }
}
Console.WriteLine($"A {max+1} poszt kapta a legtöbb like-ot és {posztok[min].monogram} készítette a posztot\n");

// g feladat
Console.WriteLine("g feladat");
Console.Write("Kérem adjon meg egy egész értéket: ");
int like_ertek = int.Parse(Console.ReadLine());
bool volt = false;

for (int i = 0; i < posztok_db; i++)
{
    if (posztok[i].like >= like_ertek)
    {
        Console.WriteLine($"A(z) {i+1}. poszt ért el legalább {like_ertek} like-ot és {posztok[i].monogram} posztolta\n");
        volt = true;
        break;
    }
}
if (!volt)
{
    Console.WriteLine($"Nem volt olyan poszt, ami legalább annyi like-ot kapott volna, mint {like_ertek}\n");
}

// h feladat
Console.WriteLine("h feladat");

for (int i = 0; i < posztok_db; i++)
{
    if (posztok[i].like > 1500)
    {
        Console.WriteLine($"{posztok[i].monogram}-nak/-nek nem kell a következő napra álhírt kitalálnia");
    }
}
Console.WriteLine();

// i feladat
Console.WriteLine("i feladat");
Console.Write("Kérem adjon meg egy munkatárs nevét: ");
string nev = Console.ReadLine();
string[] nev_tomb = nev.Split(" ");
string nev_monogram = "";
bool posztolt = false;

for (int i = 0; i < nev_tomb.Length; i++)
{
    nev_monogram += nev_tomb[i][0] + ".";
}
for (int i = 0; i < posztok_db; i++)
{
    if (posztok[i].monogram == nev_monogram)
    {
        Console.WriteLine($"{posztok[i].like} érkezett {nev} ({nev_monogram}) posztjára");
        posztolt = true;
        break;
    }
}

if (!posztolt)
{
    Console.WriteLine($"{nev} ({nev_monogram}) nem posztolt tegnap\n");
}

public record Poszt(string monogram, int like);
