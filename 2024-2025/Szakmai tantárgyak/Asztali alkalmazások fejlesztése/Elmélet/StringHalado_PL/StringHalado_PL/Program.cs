string s = "árvíztűrő tükörfúrógép";

#region IndexOf, IndexOfAny, LastIndexOf, LastIndexOfAny
//int poz = s.IndexOf('t');
//Console.WriteLine($"A 't' karakter első előfordulási helye: {poz}");
//poz = s.IndexOf("zt");
//Console.WriteLine($"A \"zt\" szöveg első előfordulási helye: {poz}");
//poz = s.IndexOf('Á');
//Console.WriteLine($"Az 'Á' karakter első előfordulási helye: {poz}");
//poz = s.IndexOf('t');
//poz = s.IndexOf('t', poz + 1);
//Console.WriteLine($"A 't' karakter második előfordulási helye: {poz}");
//char[] ekezetesMaganhangzok = new char[] { 'á', 'é', 'í', 'ó', 'ö', 'ő', 'ú', 'ü', 'ű' };
//poz = s.IndexOfAny(ekezetesMaganhangzok);
//Console.WriteLine($"Az első ékezetes magánhangzó előfordulási helye: {poz}");
//poz = s.IndexOfAny(new char[] { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' });
//Console.WriteLine($"Az első magánhangzó előfordulási helye: {poz}");
//poz = s.LastIndexOf('t');
//Console.WriteLine($"A 't' karakter utolsó előfordulási helye: {poz}");
//poz = s.LastIndexOfAny(ekezetesMaganhangzok);
//Console.WriteLine($"Az utolsó ékezetes magánhangzó előfordulási helye: {poz}");
#endregion

#region Contains
//bool b = s.Contains("it");
//Console.WriteLine("Az \"it\" szöveg " + (b ? "" : "nem") + " szerepel a szóban.");
//b = s.Contains('t');
//Console.WriteLine("A 't' karakter " + (b ? "" : "nem") + " szerepel a szóban.");
#endregion

#region StartsWith, EndsWith
//b = s.StartsWith("á");
//Console.WriteLine("A szöveg " + (b ? "" : "nem") + " 'á' karakterrel kezdődik.");
//b = s.StartsWith("ááá");
//Console.WriteLine("A szöveg " + (b ? "" : "nem") + " \"ááá\" szöveggel kezdődik.");
//b = s.EndsWith("ááá");
//Console.WriteLine("A szöveg " + (b ? "" : "nem") + " \"ááá\" szöveggel végződik.");
#endregion

#region PadLeft, PadRight
//string t = "tigris";
//string t2 = t.PadLeft(10);
//Console.WriteLine(t2);
//t2 = t.PadLeft(3);
//Console.WriteLine(t2);
//t2 = t.PadLeft(9, '*');
//Console.WriteLine(t2);
//t2 = t.PadLeft(t.Length + 3, '*').PadRight(t.Length + 6, '*');
//Console.WriteLine(t2);
#endregion

#region Trim
//Console.WriteLine("**********************************************************");
//string ws = "\t\n\t\t\n    tigris\ttigris       tigris\n\t   \t\t" + Environment.NewLine;
//Console.WriteLine(ws);
//Console.WriteLine("**********************************************************");
//Console.WriteLine(ws.TrimStart());
//Console.WriteLine("**********************************************************");
//Console.WriteLine(ws);
//Console.WriteLine("**********************************************************");
//Console.WriteLine(ws.TrimEnd());
//Console.WriteLine("**********************************************************");
//Console.WriteLine(ws.Trim());
//Console.WriteLine("**********************************************************");
//string t3 = ".i|tigris|i.";
//t3 = t3.Trim(new char[] { '.', 'i', '|' });
//Console.WriteLine(t3);
#endregion

#region Split
string gy = "alma barack citrom";
string[] gyt = gy.Split();
for (int i = 0; i < gyt.Length; i++)
{
    Console.WriteLine(gyt[i]);
}
gy += ";dió;eper körte;szilva";
Console.WriteLine(gy);
gyt = gy.Split(';');
for (int i = 0; i < gyt.Length; i++)
{
    Console.WriteLine(gyt[i]);
}
gyt = gy.Split(new char[] { ' ', ';' });
for (int i = 0; i < gyt.Length; i++)
{
    Console.WriteLine(gyt[i]);
}
gyt = gy.Split(new char[] { ' ', ';' }, 4);
for (int i = 0; i < gyt.Length; i++)
{
    Console.WriteLine(gyt[i]);
}
gy += ";;dinnye   ; naracs";
Console.WriteLine(gy);
gyt = gy.Split(new char[] { ' ', ';' });
for (int i = 0; i < gyt.Length; i++)
{
    Console.WriteLine(gyt[i]);
}
gyt = gy.Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < gyt.Length; i++)
{
    Console.WriteLine(gyt[i]);
}
#endregion

#region String.Join
string egybe = String.Join(", ", gyt);
Console.WriteLine(egybe);
Console.WriteLine(String.Join(", ", gyt));
Console.WriteLine(String.Join(", ", gyt, 4, 3));

#endregion



