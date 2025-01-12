Console.WriteLine("3. feladat");

Console.Write("Kérem adja meg a diák születési évét: ");
int szuletesi_ev = int.Parse(Console.ReadLine());

Console.WriteLine();
int kor = 2024-szuletesi_ev;

Console.WriteLine($"{kor} éves");