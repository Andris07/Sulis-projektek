/* Alapértelmezett kódolás: UTF8
 * Ha valami más van, akkor kell csak megadni a kódolást, UTF8-nál nem kötelező
 */

//StreamReader r1 = new StreamReader("atlag.txt", System.Text.Encoding.UTF8);
//1. verzió
//Fájl 1. sorában az adatok száma
StreamReader r1 = new StreamReader("atlag.txt");
int db1 = int.Parse(r1.ReadLine()!);
double[] tomb1 = new double[db1];
for (int i = 0; i < db1; i++)
{
    tomb1[i] = double.Parse(r1.ReadLine()!);
}
r1.Close();
//for (int i = 0; i < db1; i++)
//{
//    Console.WriteLine(tomb1[i]);
//}
//Console.WriteLine($"A tömb elemei: {String.Join(" ",tomb1)}");

//2. verzió
//Nincs megadva, hogy pontosan hány érték lesz, csak a maximális elemszám
StreamReader r2 = new StreamReader("szamok1.txt");
int n2 = 0; //Ennyi elemet tartalmazott a fájl
const int MAX_ELEMSZAM = 50; //A feladat szerint max. 50 szám van
int[] tomb2 = new int[MAX_ELEMSZAM];
while (!r2.EndOfStream && n2<MAX_ELEMSZAM) //Még nem értem a fájl végére, és még van hely a tömbben
{
    tomb2[n2] = int.Parse(r2.ReadLine());
    n2++;
}
r2.Close();
for (int i = 0; i < n2; i++) //A ténylegesen eltárolt elemszámig megy a ciklus!
{
    Console.WriteLine(tomb2[i]);
}

//3. verzió
//Több, összetartozó adatom van, de külön sorokban
StreamReader r3 = new StreamReader("doli.txt",System.Text.Encoding.Latin1);
int n3 = 0;
const int MAX_ELEMSZAM_DOLI = 1000;
string[] nev = new string[MAX_ELEMSZAM_DOLI];
int[] pontszam = new int[MAX_ELEMSZAM_DOLI];
while (!r3.EndOfStream && n3<MAX_ELEMSZAM_DOLI)
{
    nev[n3] = r3.ReadLine()!;
    pontszam[n3] = int.Parse(r3.ReadLine()!);
    n3++;
}
r3.Close();
//Konzolra és fájlba is kiírom egymás mellé
StreamWriter w3 = new StreamWriter("adatok2.txt");
for (int i = 0; i < n3; i++)
{
    Console.WriteLine($"{nev[i]}: {pontszam[i]}");
    w3.WriteLine($"{nev[i]}: {pontszam[i]}");
}
w3.Close();

//4. verzió
//Több, összetartozó adatom van, egy sorban valamilyen speciális jellel elválasztva
StreamReader r4 = new StreamReader("adatok.txt");
int n4 = 0;
string[] nev4 = new string[MAX_ELEMSZAM_DOLI];
int[] pontszam4 = new int[MAX_ELEMSZAM_DOLI];
while (!r4.EndOfStream && n4<MAX_ELEMSZAM_DOLI)
{
    string[] adatElemek = r4.ReadLine()!.Split(';');
    nev4[n4] = adatElemek[0];
    pontszam4[n4] = int.Parse(adatElemek[1]);
    n4++;
}
r4.Close();
for (int i = 0; i < n3; i++)
{
    Console.WriteLine($"{nev[i]}: {pontszam[i]}");
}

