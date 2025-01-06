Console.WriteLine("For");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("While");
int i2 = 0;
while (i2 < 10)
{
    Console.WriteLine(i2);
    i2++;
}

Console.WriteLine("Do...while");

int i3 = 0;
do
{
    Console.WriteLine(i3);
    i3++;
} while (i3 < 10);


int x;
Console.Write("Kérek egy páros számot: ");
do
{
    x = int.Parse(Console.ReadLine()!);
    if (x % 2 != 0)
    {
        Console.WriteLine("Ez nem páros, kérem újra!");
    }
} while (x % 2 != 0);


