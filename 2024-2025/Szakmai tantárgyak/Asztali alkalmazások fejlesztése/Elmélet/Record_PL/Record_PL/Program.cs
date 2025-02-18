Ember ember1 = new("Kiss", "Pista");
string vnev = "Kiss";
string knev = "Pista";
Ember ember2 = new(vnev, knev);

Ember[] embertomb = new Ember[5];
embertomb[0] = ember1;
embertomb[1] = ember2;
embertomb[2] = new("Nagy", "Alma");


List<Ember> emberek = new List<Ember> { ember1, ember2 };
emberek.Add(new Ember("Nagy","Márk"));
foreach (var item in emberek)
{
    Console.WriteLine(item);
}
if (emberek[0] == emberek[1])
{
    Console.WriteLine("Az első 2 ember ugyanaz.");
}
else
{
    Console.WriteLine("Az első 2 ember nem ugyanaz.");
}
if (emberek[^1] == emberek[^2])
{
    Console.WriteLine("Az utolsó 2 ember ugyanaz.");
}
else
{
    Console.WriteLine("Az utolsó 2 ember nem ugyanaz.");
}

Console.WriteLine($"Az 1. ember vezetékneve: {emberek[0].VezetekNev}.");
Console.WriteLine($"Az utolsó ember vezetékneve: {emberek[^1].VezetekNev}.");
//ember1.VezetekNev = "Mókus";

public record Ember(string VezetekNev, string KeresztNev);
