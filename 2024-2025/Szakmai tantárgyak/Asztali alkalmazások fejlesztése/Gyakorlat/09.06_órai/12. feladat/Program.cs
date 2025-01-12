Console.WriteLine("12. feladat");

Console.Write("Kérem adja meg a kert hosszúságát (m): ");
int hossz = int.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a kert szélességét (m): ");
int szel = int.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a kapu hosszúságát (m): ");
double kapu_hossz = double.Parse(Console.ReadLine());

Console.WriteLine();
double kerulet = 2*(hossz+szel) - kapu_hossz;
double lec_db = kerulet/0.2;

Console.WriteLine($"{lec_db} lécet kell vásárolni");