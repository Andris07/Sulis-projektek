const int MAX_MERET = 5;
int[] szamok = new int[MAX_MERET];

Feltoltes(-20, 50);
Console.WriteLine($"Az előállított számok: {String.Join(", ", szamok)}");
int[] pozitivak;
int pozitivakSzama;
PozitivElemek(out pozitivak, out pozitivakSzama);
Console.Write($"A tömb pozitív elemei: ");
for (int i = 0; i < pozitivakSzama; i++)
{
    Console.Write($"{pozitivak[i]} ");
}
Console.WriteLine();
int[] parosak;
int parosakSzama;
int[] paratlanok;
int paratlanokSzama;
ParosParatlan(out parosak, out parosakSzama, out paratlanok, out paratlanokSzama);
Console.Write("A tömb páros elemei: ");
for (int i = 0; i < parosakSzama; i++)
{
    Console.Write($"{parosak[i]} ");
}
Console.WriteLine();
Console.Write("A tömb páratlan elemei: ");
for (int i = 0; i < paratlanokSzama; i++)
{
    Console.Write($"{paratlanok[i]} ");
}
Console.WriteLine();

void Feltoltes(int alsoHatar, int felsoHatar)
{
    for (int i = 0; i < MAX_MERET; i++)
    {
        szamok[i] = Random.Shared.Next(alsoHatar, felsoHatar + 1);
    }
}

void PozitivElemek(out int[] pozitivElemek, out int pozitivElemekSzama) //Kiválogatás
{
    pozitivElemek = new int[MAX_MERET];
    pozitivElemekSzama = 0;
    for (int i = 0; i < MAX_MERET; i++)
    {
        if (szamok[i]>0)
        {
            pozitivElemek[pozitivElemekSzama] = szamok[i];
            pozitivElemekSzama++;
        }
    }
}

void ParosParatlan(out int[] parosElemek, out int parosElemekSzama, 
    out int[] paratlanElemek, out int paratlanElemekSzama) //Szétválogatás
{
    paratlanElemek=new int[MAX_MERET];
    paratlanElemekSzama = 0;
    parosElemek = new int[MAX_MERET];
    parosElemekSzama = 0;
    for (int i = 0; i < MAX_MERET; i++)
    {
        if (szamok[i]%2==0)
        {
            parosElemek[parosElemekSzama++] = szamok[i];
        }
        else
        {
            paratlanElemek[paratlanElemekSzama++] = szamok[i];
        }
    }
}


