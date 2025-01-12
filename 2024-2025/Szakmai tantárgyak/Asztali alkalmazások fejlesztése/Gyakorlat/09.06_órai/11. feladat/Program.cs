Console.WriteLine("11. feladat");

Console.Write("Kérem adja meg a szoba hosszát (cm): ");
double szoba_hossz = double.Parse(Console.ReadLine());

Console.Write("Kérem adja meg a szoba szélességét (cm): ");
double szoba_szel = double.Parse(Console.ReadLine());

Console.Write("Kérem adja meg a szoba magasságát (cm): ");
double szoba_mag = double.Parse(Console.ReadLine());

Console.Write("Kérem adja meg az ablak hosszát (cm): ");
double ablak_hossz = double.Parse(Console.ReadLine());

Console.Write("Kérem adja meg az ablak magasságát (cm): ");
double ablak_mag = double.Parse(Console.ReadLine());

Console.Write("Kérem adja meg az ajtó hosszát (cm): ");
double ajto_hossz = double.Parse(Console.ReadLine());

Console.Write("Kérem adja meg az ajtó magasságát (cm): ");
double ajto_mag = double.Parse(Console.ReadLine());

Console.WriteLine();
double teljes_terulet = 2*(szoba_hossz*szoba_szel+szoba_hossz*szoba_mag+szoba_szel*szoba_mag);
double nyilaszarok_terulete = ablak_hossz*ablak_mag+ajto_hossz*ajto_mag;
double tapeta = 1.1*((teljes_terulet-nyilaszarok_terulete)/10000);

Console.WriteLine($"{tapeta} m² tapétára lesz szükség");