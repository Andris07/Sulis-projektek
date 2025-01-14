using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Csipetcsapat feladat");

string fajl_olvasas_nev = "gyujtemeny.txt";
int[] mogyorok = fajlbeolvasas_method(fajl_olvasas_nev);
bool volt_nap = volt_nap_method(mogyorok);
int hanyszor_db_elofordulas = hanyszor_db_elofordulas_method(mogyorok);
int volt_nap_index = volt_index_method(mogyorok);
int hanyszor_db_nemegyenlo = hanyszor_db_nemegyenlo_method(mogyorok);
int elso_nap_index = elso_nap_index_method(mogyorok);
string fajl_iras_nev = "turbo.txt";
string turbo = turbo_method(mogyorok, fajl_iras_nev);

Console.WriteLine("3. feladat");
Console.WriteLine($"Volt olyan nap, amikor egyáltalán nem gyűjtöttek egyetlen mogyorót és diót sem? {volt_nap}\n");
Console.WriteLine("4. feladat");
Console.WriteLine($"{hanyszor_db_elofordulas} alkalommal szedtek legalább 45 darab mogyorót és diót\n");
Console.WriteLine("5. feladat");
Console.WriteLine($"{volt_nap_index+1}. nap volt olyan nap, amikor pontosan ennyi diót és mogyorót gyűjtöttek\n");
Console.WriteLine("6. feladat");
Console.WriteLine($"{hanyszor_db_nemegyenlo}x volt olyan, hogy nem tudták egymás közt egyenlő részre szétosztani maguk között az elemózsiát\n");
Console.WriteLine("7. feladat");
Console.WriteLine($"{elso_nap_index+1}. az első olyan nap, amikor 5 felé szétosztható volt az élelem a csapattagok számára");

// 2. feladat
int[] fajlbeolvasas_method(string fajl)
{
    StreamReader fajl_beolvasas = new StreamReader(fajl);
    int db = int.Parse(fajl_beolvasas.ReadLine());
    int[] tomb = new int[db];

    for (int i = 0; i < db; i++)
    {
        tomb[i] = int.Parse(fajl_beolvasas.ReadLine());
    }
    fajl_beolvasas.Close();
    return tomb;
}

// 3. feladat
bool volt_nap_method(int[] tomb)
{
    for (int i = 0; i < tomb.Length; i++)
    {
        if (tomb[i] == 0)
        {
            return true;
        }
    }
    return false;
}

// 4. feladat
int hanyszor_db_elofordulas_method(int[] tomb)
{
    int db = 0;

    for (int i = 0; i < tomb.Length; i++)
    {
        if (tomb[i] >= 45)
        {
            db++;
        }
    }
    return db;
}

// 5. feladat
int volt_index_method(int[] tomb)
{
    Console.WriteLine("Kérem adjon meg egy számot: ");
    int szam = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int index = 0;

    for (int i = 0; i < tomb.Length; i++)
    {
        if (tomb[i] == szam)
        {
            index = i;
        }
    }
    return index;
}

// 6. feladat
int hanyszor_db_nemegyenlo_method(int[] tomb)
{
    int db = 0;

    for (int i = 0; i < tomb.Length; i++)
    {
        if (tomb[i] % 2 != 0)
        {
            db++;
        }
    }
    return db;
}

// 7. feladat
int elso_nap_index_method(int[] tomb)
{
    int index = 0;

    for (int i = 0; i < tomb.Length; i++)
    {
        if (i % 5 == 0)
        {
            index = i; break;
        }
    }
    return index;
}

// 8. feladat
string turbo_method(int[] tomb, string fajl)
{
    StreamWriter fajl_iras = new StreamWriter(fajl);
    for (int i = 0; i < tomb.Length; i++)
    {
        int db = tomb[i]*3;
        fajl_iras.WriteLine($"{i+1}. nap: {db}");
    }
    fajl_iras.Close();
    return fajl;
}