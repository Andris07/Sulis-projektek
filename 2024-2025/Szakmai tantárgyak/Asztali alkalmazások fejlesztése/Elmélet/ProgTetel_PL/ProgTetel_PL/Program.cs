const int MAX_MERET = 10;
int[] szamok = new int[MAX_MERET];
//Random random = new Random();

Feltoltes(-20, 50);
Console.WriteLine($"Az előállított számok: {String.Join(", ", szamok)}");
Console.WriteLine($"A számok összege: {Osszeg()}");
Console.WriteLine($"A számok négyzetösszege: {NegyzetOsszeg()}");
Console.WriteLine($"A számok szorzata: {Szorzat()}");
Console.WriteLine($"A számok szorzata: {SzorzatHibas()}");
Console.WriteLine($"A tömb elemeinek átlaga: {Atlag()}");
Console.WriteLine($"A tömb elemeinek átlaga: {Osszeg()/MAX_MERET}");
Console.WriteLine($"A tömb elemeinek átlaga: {(double)Osszeg() / MAX_MERET}");
Console.WriteLine($"A tömbben {Pozitivak()} pozitív érték van.");
Console.WriteLine($"Az átlag feletti elemek száma: {AtlagFelettiekSzama()}");
Console.WriteLine($"A legnagyobb érték: {MaximumErtek()}");
Console.WriteLine($"A legnagyobb érték helye: {MaximumIndex()}");
int maxErtek;
int maxIndex;
MaximumErtekEsHely(out maxErtek, out maxIndex);
Console.WriteLine($"A legnagyobb érték: {maxErtek} a helye a tömbben: {maxIndex}");
(maxErtek, maxIndex) = MaximumErtekEsHely2();
Console.WriteLine($"A legnagyobb érték: {maxErtek} a helye a tömbben: {maxIndex}");
int minimumErtek;
int minimumIndex;
MinimumErtekEsHely(out minimumErtek, out minimumIndex);
Console.WriteLine($"A legkisobb érték: {minimumErtek} a helye a tömbben: {minimumIndex}");

void Feltoltes(int alsoHatar, int felsoHatar)
{
    for (int i = 0; i < MAX_MERET; i++)
    {
        //szamok[i] = random.Next(alsoHatar, felsoHatar+1);
        szamok[i] = Random.Shared.Next(alsoHatar, felsoHatar + 1);
    }
}

int Osszeg() //Összegzés tétele
{
    int osszeg = 0;
    for (int i = 0; i < MAX_MERET; i++)
    {
        osszeg += szamok[i];
    }
    return osszeg;
}

double NegyzetOsszeg() //Ez is összegzés tétel
{
    double negyzetOsszeg = 0;
    for (int i = 0; i < MAX_MERET; i++)
    {
        negyzetOsszeg += Math.Pow(szamok[i], 2);
    }
    return negyzetOsszeg;
}

long Szorzat() //Ez is összegzés tétel
{
    long szorzat = 1;
    for (int i = 0; i < MAX_MERET; i++)
    {
        szorzat *= szamok[i];
    }
    return szorzat;
}

int SzorzatHibas() //Ez is összegzés tétel (Túlcsordulás!)
{
    int szorzat = 1;
    for (int i = 0; i < MAX_MERET; i++)
    {
        szorzat *= szamok[i];
    }
    return szorzat;
}

double Atlag() 
{ // Legalább 1 elemnek kell lennie a tömbben, 0 elemű tömbre hibát ad
    double atlag = 0;
    for (int i = 0; i < MAX_MERET; i++)
    {
        atlag += szamok[i];
    }
    atlag /= MAX_MERET;
    return atlag;

}

int Pozitivak() //Megszámlálás tétel
{ //Kell egy tulajdonság, aminek megfelelő értéket megszámolunk
    int db = 0;
    for (int i = 0; i < MAX_MERET; i++)
    {
        if (szamok[i] > 0)
        {
            db++;
        }
    }
    return db;
}

int AtlagFelettiekSzama() //Ez is megszámlálás
{
    int atlagFelettiDb = 0;
    double atlag = Atlag();
    for (int i = 0; i < MAX_MERET; i++)
    {
        if (szamok[i] > atlag)
        {
            atlagFelettiDb++;
        }
    }
    return atlagFelettiDb;
}

int MaximumErtek()
{ // Legalább 1 elemnek kell lennie a tömbben, 0 elemű tömbre hibát ad
    int max = szamok[0];
    for (int i = 1; i < MAX_MERET; i++)
    {
        if (max < szamok[i])
        {
            max = szamok[i];
        }
    }
    return max;
}

int MaximumIndex()
{
    int index = 0;
    for (int i = 1; i < MAX_MERET; i++)
    {
        if (szamok[index] < szamok[i])
        {
            index = i;
        }
    }
    return index;
}

void MaximumErtekEsHely(out int maxErtek, out int maxIndex)
{
    maxErtek = szamok[0];
    maxIndex = 0;
    for (int i = 1; i < MAX_MERET; i++)
    {
        if (maxErtek < szamok[i])
        {
            maxErtek = szamok[i];
            maxIndex = i;
        }
    }
}

(int, int) MaximumErtekEsHely2() //Tuple
{
    int maxErtek = szamok[0];
    int maxIndex = 0;
    for (int i = 1; i < MAX_MERET; i++)
    {
        if (maxErtek < szamok[i])
        {
            maxErtek = szamok[i];
            maxIndex = i;
        }
    }
    return (maxErtek, maxIndex);
}

void MinimumErtekEsHely(out int minErtek, out int minIndex)
{
    minErtek = szamok[0];
    minIndex = 0;
    for (int i = 1; i < MAX_MERET; i++)
    {
        if (minErtek > szamok[i])
        {
            minErtek = szamok[i];
            minIndex = i;
        }
    }
}

