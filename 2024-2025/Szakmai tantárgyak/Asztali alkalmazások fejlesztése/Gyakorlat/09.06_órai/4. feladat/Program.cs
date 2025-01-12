Console.WriteLine("4. feladat");

Console.Write("Kérem adja meg, hogy hány pontot ért el az informatika érettségin: ");
int pontszam = int.Parse(Console.ReadLine());

Console.WriteLine();
double szazalek = ((double)pontszam/120)*100;

Console.WriteLine($"{szazalek}%");