using System;

const int MAX_MERET = 5;
int[] szamok = new int[MAX_MERET];

Feltoltes(-20, 50);
Console.WriteLine($"Az előállított számok: {String.Join(", ", szamok)}");
Console.WriteLine("Lineáris keresések:");
int hely;
if (Elso90nelNagyobb(out hely))
{
    Console.WriteLine($"Volt 90-nél nagyobb, pl. a(z) {hely}. indexen lévő érték: {szamok[hely]}");
}
else Console.WriteLine("Nem volt 90-nél nagyobb.");
if(Elso10zelOszthato(out hely))
{
    Console.WriteLine($"Volt 10-zel osztható, pl. a(z) {hely}. indexen lévő érték: {szamok[hely]}");
}
else Console.WriteLine("Nem volt 10-zel osztható.");
int paros;
if (ElsoParos(out paros))
{
    Console.WriteLine($"Volt páros, pl.: {paros}");
}
else Console.WriteLine("Nem volt páros.");
Console.WriteLine("Eldöntés:");
if (VanNegativ())
    Console.WriteLine("Van negatív érték a számok között.");
else
    Console.WriteLine("Nincs negatív érték a számok között.");
Console.WriteLine("Kiválasztás:");
hely = AtlagnalNagyobbVagyEgyenlo();
Console.WriteLine($"Az első átlagnál nagyobb vagy átlaggal egyenlő elem indexe: {hely} értéke: {szamok[hely]}");


void Feltoltes(int alsoHatar, int felsoHatar)
{
    for (int i = 0; i < MAX_MERET; i++)
    {
        szamok[i] = Random.Shared.Next(alsoHatar, felsoHatar + 1);
    }
}

/*
 * Lineáris keresés: nem tudom, hogy van-e megfelelő elem, de ha igen, akkor visszaadom az első találatot.
 */
bool Elso90nelNagyobb(out int index) //Lineáris keresés
{
    bool van = false; //Megtaláltam már a keresett elemet?
    index = -1; //Ha megtaláltam az elemet, ebben a változóban lesz a helye
    while (!van && index < MAX_MERET - 1) //Nem találtam még ilyen elemet, és van még olyan elem, amit megvizsgálhatok
    {
        index++; //Tovább lépek a következő megvizsgálható elemre
        //if (szamok[index]>90)
        //{
        //    van = true;
        //}
        van = (szamok[index] > 90);
    }
    return van;
}

bool Elso10zelOszthato(out int index)
{
    for (index = 0; index < MAX_MERET; index++)
    {
        if (szamok[index] % 10 == 0) return true;
    }
    return false;
}


bool ElsoParos(out int ertek) //Lineáris keresés
{
    bool van = false; //Megtaláltam már a keresett elemet?
    int index = -1; //Ha megtaláltam az elemet, ebben a változóban lesz a helye
    ertek = int.MinValue;
    while (!van && index < MAX_MERET - 1) //Nem találtam még ilyen elemet, és van még olyan elem, amit megvizsgálhatok
    {
        index++; //Tovább lépek a következő megvizsgálható elemre
        if (szamok[index]%2==0)
        {
            van = true;
            ertek = szamok[index];
        }
    }
    return van;
}

/*
 * Eldöntés: csak az érdekel, hogy van-e megfelelő tulajdonságú elem vagy nincs
 */
bool VanNegativ() //Eldöntés
{
    bool van = false; //Megtaláltam már a keresett elemet?
    int index = -1; //Ha megtaláltam az elemet, ebben a változóban lesz a helye
    while (!van && index < MAX_MERET - 1) //Nem találtam még ilyen elemet, és van még olyan elem, amit megvizsgálhatok
    {
        index++; //Tovább lépek a következő megvizsgálható elemre
        van = szamok[index] < 0;
    }
    return van;
}

double Atlag()
{ 
    double atlag = 0;
    for (int i = 0; i < MAX_MERET; i++)
    {
        atlag += szamok[i];
    }
    atlag /= MAX_MERET;
    return atlag;
}

/*
 * Kiválasztás: tudom, hogy van megfelelő elem, arra keresek választ, hogy melyik az, vagy hogy hol van 
 */
int AtlagnalNagyobbVagyEgyenlo()
{
    bool van = false; //Megtaláltam már a keresett elemet?
    int index = -1; //Ha megtaláltam az elemet, ebben a változóban lesz a helye
    double atlag = Atlag();
    while (!van) //Nem találtam még ilyen elemet
    {
        index++; //Tovább lépek a következő megvizsgálható elemre
        van = szamok[index] >=atlag;
    }
    return index;
}


