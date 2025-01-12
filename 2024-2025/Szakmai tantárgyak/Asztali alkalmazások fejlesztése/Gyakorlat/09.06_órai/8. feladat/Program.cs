Console.WriteLine("8. feladat");

Console.Write("Kérem adja meg az első tört számlálóját: ");
double szamlalo1 = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg az első tört nevezőjét: ");
double nevezo1 = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a második tört számlálóját: ");
double szamlalo2 = double.Parse(Console.ReadLine());
Console.Write("Kérem adja meg a második tört nevezőjét: ");
double nevezo2 = double.Parse(Console.ReadLine());

Console.WriteLine();
double nevezo = nevezo1*nevezo2;
double osszeg_szamlalo = szamlalo1 * nevezo2 + szamlalo2 * nevezo1;
double kulonbseg_szamlalo = szamlalo1 * nevezo2 - szamlalo2 * nevezo1;
double szorzat_szamlalo = szamlalo1 * szamlalo2;
double hanyados_szamlalo = szamlalo1 * nevezo2;
double hanyados_nevezo = szamlalo2 * nevezo1;

Console.WriteLine($"{osszeg_szamlalo} / {nevezo} a két tört összege");
Console.WriteLine($"{kulonbseg_szamlalo} / {nevezo} a két tört különbsége");
Console.WriteLine($"{szorzat_szamlalo} / {nevezo} a két tört szorzata");
Console.WriteLine($"{hanyados_szamlalo} / {hanyados_nevezo} a két tört hányadosa");