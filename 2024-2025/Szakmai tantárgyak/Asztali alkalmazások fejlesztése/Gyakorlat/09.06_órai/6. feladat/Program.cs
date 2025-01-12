Console.WriteLine("6. feladat");

Console.Write("Kérem adja meg a súlyát (kg): ");
double suly = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a magasságát (cm): ");
double magassag = double.Parse(Console.ReadLine())/100;

Console.WriteLine();
double testtomegindex = suly/(magassag*magassag);

Console.WriteLine($"{testtomegindex.ToString("0.00")} a testtömegindexe");