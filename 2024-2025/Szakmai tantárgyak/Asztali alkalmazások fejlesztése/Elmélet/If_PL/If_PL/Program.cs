using System.Net.Security;

int x = 10;
int y = 20;

//Relációs operátorok
//Console.WriteLine($"x>y (nagyobb) {x>y}");
//Console.WriteLine($"x>=y (nagyobb egyenlő) {x >= y}");
//Console.WriteLine($"x==y (egyenlő) {x == y}");
//Console.WriteLine($"x!=y (nem egyenlő) {x != y}");
//Console.WriteLine($"x<y (kisebb) {x < y}");
//Console.WriteLine($"x<=y (kisebb egyenlő) {x <= y}");

//Logikai operátorok
bool a = true;
bool b = false;
Console.WriteLine($"a értéke: {a}: tagadása: {!a}"); //! - nem (tagadás)
Console.WriteLine($"b értéke: {b}: tagadása: {!b}");

//És: && - akkor igaz, ha mindkét oldalán a kifejezés igaz (rövid záras!)
Console.WriteLine($"a és a: {a&&a}");
Console.WriteLine($"a és b: {a && b}");
Console.WriteLine($"b és a: {b && a}");
Console.WriteLine($"b és b: {b && b}");

//Vagy: || - akkor igaz, ha valamelyik oldalán a kifejezés igaz (rövid záras!)
Console.WriteLine($"a vagy a: {a || a}");
Console.WriteLine($"a vagy b: {a || b}");
Console.WriteLine($"b vagy a: {b || a}");
Console.WriteLine($"b vagy b: {b || b}");

Console.WriteLine($"Az x páros: {x%2==0}");
int z = -5;
int zm = z % 2;
Console.WriteLine(zm);
//Console.WriteLine($"A z páratlan: {z%2==1}"); //Negatív szám maradéka negatív! - ez így nem jó
Console.WriteLine($"A z páratlan: {z % 2 != 0}");

if (x<0)
{
    Console.WriteLine("Az x értéke negatív");
}
else if (x>0)
    Console.WriteLine("Az x értéke pozitív");
else
    Console.WriteLine("Az x értéke 0");

if (x>0)
{
    if (x % 2 == 0)
    {
        Console.WriteLine("x 2-vel osztható pozitív szám");
    }
    else 
    { 
        Console.WriteLine("x 2-vel nem osztható pozitív szám"); 
    }
}
else
{
    Console.WriteLine("x nem pozitív szám");
}

//https://csharptutorial.hu/docs/hellovilag-hellocsharp/2-a-nyelv-alapjai/boole-algebra/