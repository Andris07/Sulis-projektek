List<int> lista = new();
for (int i = 0; i<10;  i++) 
{
    lista.Add(i);
}
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");

Console.WriteLine("A lista elemeihez hozzáfűzzük a másik lista elemeit:");
List<int> lista2 = new List<int>() { 11, 12, 13};
lista.AddRange(lista2);
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");

//Elem beszúrás:
Console.WriteLine("3. indexre beszúrjuk a 66-os értéket");
lista.Insert(3, 66);
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");

//Elemek beszúrása:
Console.WriteLine("3. indexre beszúrjuk a másik lista értékeit");
lista.InsertRange(3, new List<int>(){66, 37, 38  });
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");

//Elem törlése:
Console.WriteLine("66-os érték törlése:");
lista.Remove(66);
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");
Console.WriteLine("66-os érték törlése:");
lista.Remove(66);
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");
Console.WriteLine("66-os érték törlése:");
lista.Remove(66);
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");


//Elem törlése index alapján
Console.WriteLine("6. indexen lévő elem törlése");
lista.RemoveAt(6);
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");

//Elemek törlése index alapján
Console.WriteLine("2. indexen lévő elemtől kezdve 3 elem törlése");
lista.RemoveRange(2,3);
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");

//Elem értékének lekérdezése
Console.WriteLine("6. indexen lévő elem: ");
Console.WriteLine($"{lista[6]}");
Console.WriteLine($"{lista.ElementAt(6)}");

//Listarész lementése
var listaresz = lista.GetRange(3, 3);
Console.WriteLine($"A 3. indextől 3 elem: {String.Join(", ", listaresz)}");
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");

//lista megfordítása
lista.Reverse();
Console.WriteLine("A lista elemeinek megfordítása");
Console.WriteLine($"A lista elemei: {String.Join(", ", lista)}");