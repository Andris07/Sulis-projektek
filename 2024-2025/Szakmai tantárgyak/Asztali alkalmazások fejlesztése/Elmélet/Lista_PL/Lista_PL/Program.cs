List<string> nyariGyumolcsok = new List<string>();
Console.WriteLine($"A lista kapacitása: {nyariGyumolcsok.Capacity}");
Console.WriteLine($"A lista elemszáma: {nyariGyumolcsok.Count}");
nyariGyumolcsok.Add("eper");
Console.WriteLine($"Hozzáadtuk a listához: {nyariGyumolcsok.Last()}");
Console.WriteLine($"A lista kapacitása: {nyariGyumolcsok.Capacity}");
Console.WriteLine($"A lista elemszáma: {nyariGyumolcsok.Count}");
nyariGyumolcsok.Add("cseresznye");
Console.WriteLine($"Hozzáadtuk a listához: {nyariGyumolcsok.Last()}");
Console.WriteLine($"A lista kapacitása: {nyariGyumolcsok.Capacity}");
Console.WriteLine($"A lista elemszáma: {nyariGyumolcsok.Count}");
nyariGyumolcsok.Add("málna");
Console.WriteLine($"Hozzáadtuk a listához: {nyariGyumolcsok.Last()}");
Console.WriteLine($"A lista kapacitása: {nyariGyumolcsok.Capacity}");
Console.WriteLine($"A lista elemszáma: {nyariGyumolcsok.Count}");
nyariGyumolcsok.Add("sárgabarack");
Console.WriteLine($"Hozzáadtuk a listához: {nyariGyumolcsok.Last()}");
Console.WriteLine($"A lista kapacitása: {nyariGyumolcsok.Capacity}");
Console.WriteLine($"A lista elemszáma: {nyariGyumolcsok.Count}");
nyariGyumolcsok.Add("ribizli");
Console.WriteLine($"Hozzáadtuk a listához: {nyariGyumolcsok.Last()}");
Console.WriteLine($"A lista kapacitása: {nyariGyumolcsok.Capacity}");
Console.WriteLine($"A lista elemszáma: {nyariGyumolcsok.Count}");

List<string> osziGyumolcsok = new List<string>() { "alma", "körte", "szilva", "szőlő", "körte" };
Console.WriteLine($"A lista kapacitása: {osziGyumolcsok.Capacity}");
Console.WriteLine($"A lista elemszáma: {osziGyumolcsok.Count}");

string[] teliGyum = new string[] { "narancs", "mandarin", "banán" };
Console.WriteLine($"A téli gyümölcsök száma: {teliGyum.Count()}");

List<string> nyariUj = nyariGyumolcsok;
Console.WriteLine("Régi lista: " + String.Join("; ", nyariGyumolcsok));
nyariUj.Add("egres");
Console.WriteLine("Új lista: " + String.Join("; ", nyariUj));
Console.WriteLine("Régi lista: " + String.Join("; ", nyariGyumolcsok));

List<string> osszesGyumolcs = new List<string>();
osszesGyumolcs.AddRange(nyariGyumolcsok);
Console.WriteLine("A tárolt gyümölcsök: " + String.Join("; ", osszesGyumolcs));
osszesGyumolcs.AddRange(osziGyumolcsok);
Console.WriteLine("A tárolt gyümölcsök: " + String.Join("; ", osszesGyumolcs));
osszesGyumolcs = osszesGyumolcs.Union(teliGyum).ToList();
Console.WriteLine("A tárolt gyümölcsök: " + String.Join("; ", osszesGyumolcs));

osszesGyumolcs.Sort();
Console.WriteLine("A tárolt gyümölcsök: " + String.Join("; ", osszesGyumolcs));

List<string> petiKedveli = new List<string>();
petiKedveli.AddRange(nyariGyumolcsok);
petiKedveli.AddRange(osziGyumolcsok);
List<string> pistiKedveli = new List<string>();
pistiKedveli.AddRange(nyariGyumolcsok);
pistiKedveli.AddRange(teliGyum);

List<string> mindkettoKedveli = petiKedveli.Intersect(pistiKedveli).ToList();
Console.WriteLine("Mindkettő: " + String.Join("; ", mindkettoKedveli));
List<string> valamelyikKedveli = petiKedveli.Union(pistiKedveli).ToList();
Console.WriteLine("Valamelyik: " + String.Join("; ", valamelyikKedveli));
List<string> csakPetiKedveli = petiKedveli.Except(pistiKedveli).ToList();
Console.WriteLine("Csak Peti: " + String.Join("; ", csakPetiKedveli));
List<string> csakPistiKedveli = pistiKedveli.Except(petiKedveli).ToList();
Console.WriteLine("Csak Pisti: " + String.Join("; ", csakPistiKedveli));

