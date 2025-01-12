Console.WriteLine("9. feladat");

Console.Write("Kérem adja meg a vásárolt mennyiséget (alma/kg): ");
double alma_kg = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a vásárolt mennyiséget (szilva/kg): ");
double szilva_kg = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a vásárolt mennyiséget (szőlő/kg): ");
double szolo_kg = double.Parse(Console.ReadLine());

Console.WriteLine();
double alma_osszeg = alma_kg*240;
double szilva_osszeg = szilva_kg*310;
double szolo_osszeg = szolo_kg*650;
double osszeg = alma_osszeg+szilva_osszeg+szolo_osszeg;

Console.WriteLine($"{alma_osszeg} Ft az almáért");
Console.WriteLine($"{szilva_osszeg} Ft a szilváért");
Console.WriteLine($"{szolo_osszeg} Ft a szőlőért");
Console.WriteLine($"{osszeg} Ft összesen");