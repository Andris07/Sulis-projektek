Console.WriteLine("2. feladat");

Console.Write("Kérem adjon meg egy egész számot: ");
int egesz1 = int.Parse(Console.ReadLine());
Console.Write("Kérem adjon meg egy másik egész számot: ");
int egesz2 = int.Parse(Console.ReadLine());

Console.WriteLine();
int osszeg = egesz1 + egesz2;
int kulonbseg = egesz1 - egesz2;
int szorzat = egesz1 * egesz2;
int hanyados = egesz1 / egesz2;
int maradek = egesz1 % egesz2;
double hanyados_valos = (double)egesz1 / egesz2;

Console.WriteLine($"A két szám összege: {egesz1} + {egesz2} = {osszeg}");
Console.WriteLine($"A két szám különbsége: {egesz1} - {egesz2} = {kulonbseg}");
Console.WriteLine($"A két szám szorzata: {egesz1} * {egesz2} = {szorzat}");
Console.WriteLine($"{hanyados}x van meg a második szám az első számban");
Console.WriteLine($"{maradek} az osztási maradék");
Console.WriteLine($"{hanyados_valos} a valós osztás eredménye");