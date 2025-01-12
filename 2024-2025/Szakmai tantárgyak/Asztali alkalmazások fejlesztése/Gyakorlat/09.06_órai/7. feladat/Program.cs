Console.WriteLine("7. feladat");

Console.Write("Kérem adja meg, hogy hány eurót szeretne vásárolni: ");
double euro_db = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg az aktuális euró árfolyamát: ");
double euro_ar = double.Parse(Console.ReadLine());

Console.WriteLine();
double ar = euro_db*euro_ar;

Console.WriteLine($"{ar} Ft-ot kell fizetnie a valutáért");