const int MERET = 30;
Random r = new Random();

int[] tomb = new int[MERET];
for (int i = 0; i<MERET; i++)
{
    tomb[i] = r.Next(2, 6);
}

for (int i = 0;i<MERET; i++)
{
    Console.WriteLine($"{i+1}. diák érdemjegye: {tomb[i]}");
}

int[] osztaly;
Console.Write("Kérem adja meg az osztály létszámát: ");
int letszam = int.Parse(Console.ReadLine()!);
osztaly = new int[letszam];
for (int i = 0; i<letszam; i++)
{
    osztaly[i] = r.Next(2, 6);
}
for (int i = 0; i < letszam; i++)
{
    Console.WriteLine($"{i + 1}. diák érdemjegye: {osztaly[i]}");
}

int[] fib = new int[10];
fib[0] = 0;
fib[1] = 1;
for (int i = 2; i < 10; i++)
{
    fib[i] = fib[i - 1] + fib[i - 2];
}
Console.WriteLine($"A Fibonacci sorozat első 10 értéke: {String.Join(" ", fib)}");
