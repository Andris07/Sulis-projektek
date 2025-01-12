Console.WriteLine("5. feladat");

Console.Write("Kérem adja meg a háromszög első oldalát: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a háromszög második oldalát: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a háromszög harmadik oldalát: ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine();
double kerulet = a+b+c;

Console.WriteLine($"{kerulet} a háromszög kerülete");