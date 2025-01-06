int[] a = { 6, 3, 5, 8, 4, 12, 18, 16 };
int[] b = { 2, 11, 5, 7, 9, 6 };
int[] c = { 1, 2, 3, 6};
int[] d;
int an=a.Length, bn=b.Length, cn=c.Length, dn;

Console.WriteLine($"A halmaz elemei: {Kiiras(a, an)}");
Console.WriteLine($"B halmaz elemei: {Kiiras(b, bn)}");
Console.WriteLine($"C halmaz elemei: {Kiiras(c, cn)}");
Unio(a, an, b, bn, out d, out dn);
Console.WriteLine($"A és B halmaz uniója: {Kiiras(d, dn)}");
Unio(a, an, c, cn, out d, out dn);
Console.WriteLine($"A és C halmaz uniója: {Kiiras(d, dn)}");
Unio(b, bn, c, cn, out d, out dn);
Console.WriteLine($"B és C halmaz uniója: {Kiiras(d, dn)}");
Metszet(a, an, b, bn, out d, out dn);
Console.WriteLine($"A és B halmaz metszete: {Kiiras(d, dn)}");
Metszet(a, an, c, cn, out d, out dn);
Console.WriteLine($"A és C halmaz metszete: {Kiiras(d, dn)}");
Metszet(b, bn, c, cn, out d, out dn);
Console.WriteLine($"B és C halmaz metszete: {Kiiras(d, dn)}");
Kulonbseg(a, an, b, bn, out d, out dn);
Console.WriteLine($"A és B halmaz különbsége: {Kiiras(d, dn)}");
Kulonbseg(a, an, c, cn, out d, out dn);
Console.WriteLine($"A és C halmaz különbsége: {Kiiras(d, dn)}");
Kulonbseg(b, bn, c, cn, out d, out dn);
Console.WriteLine($"B és C halmaz különbsége: {Kiiras(d, dn)}");

string Kiiras(int[] h1, int n)
{
    return String.Join(", ", h1.Take(n));
}


void Unio(int[] h1, int n1, int[] h2, int n2, out int[] h3, out int n3)
{
    h3 = new int[n1 + n2];
    for (int i = 0; i < n1; i++) //Első halmaz elemeinek másolása
    {
        h3[i] = h1[i];
    }
    n3 = n1;
    for (int j = 0; j < n2; j++) //Második halmaz elemeinek vizsgálata
    {
        int i = 0;
        while (i < n1 && h2[j] != h1[i]) //Keressük meg H1-ben benne van-e az elem
        {
            i++;
        }
        if (i >= n1) //Ha túlléptünk a feltöltött elemek számát, akkor nincs benne, belerakjuk
        {
            h3[n3] = h2[j];
            n3++;
        }
    }
}

void Metszet(int[] h1, int n1, int[] h2, int n2, out int[] h3, out int n3)
{
    h3 = new int[Math.Min(n1, n2)];
    n3 = 0;
    for (int i = 0; i < n1; i++) //Menjünk végig az első halmaz elemein
    {
        int j = 0;
        while (j < n2 && h2[j] != h1[i]) //Nézzük meg, hogy az aktuális elem megyegyezik-e a második halmaz egyik elemével
        {
            j++;
        }
        if (j < n2) //Ha nem léptük túl az indexhatárt, akkor találtunk egyezést, berakjuk az eredményhalmbazba
        {
            h3[n3] = h1[i];
            n3++;
        }
    }
}


void Kulonbseg(int[] h1, int n1, int[] h2, int n2, out int[] h3, out int n3)
{
    h3 = new int[n1];
    n3 = 0;
    for (int i = 0; i < n1; i++) //Menjünk végig az első halmaz elemein
    {
        int j = 0;
        while (j < n2 && h2[j] != h1[i]) //Nézzük meg, hogy az aktuális elem megyegyezik-e a második halmaz egyik elemével
        {
            j++;
        }
        if (j >= n2) //Ha túlléptük az indexhatárt, akkor nem találtunk egyezést, berakjuk az eredményhalmbazba
        {
            h3[n3] = h1[i];
            n3++;
        }
    }
}




