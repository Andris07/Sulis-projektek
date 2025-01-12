Console.WriteLine("10. feladat");

Console.BackgroundColor = ConsoleColor.Red;
Console.Write("Hány ilyen színű lufit kér? ");
int piros_db = int.Parse(Console.ReadLine());
int piros_ar = piros_db*125;

Console.BackgroundColor = ConsoleColor.Green;
Console.Write("Hány ilyen színű lufit kér? ");
int zold_db = int.Parse(Console.ReadLine());
int zold_ar = zold_db*150;

Console.BackgroundColor = ConsoleColor.Blue;
Console.Write("Hány ilyen színű lufit kér? ");
int kek_db = int.Parse(Console.ReadLine());
int kek_ar = kek_db*135;

Console.WriteLine();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{piros_ar} Ft a fizetendő ár");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{zold_ar} Ft a fizetendő ár");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"{kek_ar} Ft a fizetendő ár");

Console.ResetColor();

// Laczkovics András Gergő