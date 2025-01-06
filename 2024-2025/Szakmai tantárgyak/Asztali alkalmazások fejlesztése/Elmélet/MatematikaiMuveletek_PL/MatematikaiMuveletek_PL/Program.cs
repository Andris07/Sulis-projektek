////Abszulút érték
//Console.Write("Kérem adjon meg egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);
//int abszolut = Math.Abs(szam);
//Console.WriteLine($"A szám abszolút értéke: {abszolut}");

////Hatványozás: 
//Console.Write("Kérem adjon meg egy számot: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("Kérem adjon meg egy kitevőt: ");
//int y = Convert.ToInt32(Console.ReadLine());
//double eredmeny = Math.Pow(x, y);
//Console.WriteLine($"A hatvány értéke: {eredmeny}");

////Gyökvonás:
//Console.Write("Kérem adjon meg egy számot (gyökvonás): ");
//int a = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"A beolvasott szám gyöke: {Math.Sqrt(a).ToString("0.00")}");

//Console.WriteLine($"PI értéke: {Math.PI}");

//Véletlenszám generálás
//Random random1 = new Random();
Random random = new(); //Véletlenszám generátor változó, csak 1 legyen a programban!!!
//Egész véletlenszám generálása
int v = random.Next(); //Nem negatív egész szám
int v2 = random.Next(10); //0..9  r.Next(n) 0..(n-1) pozitív véletlenszámot generál
int v3 = random.Next(-50,10); //-50..9 r.Next(ah, fh) ah..(fh-1) véletlenszámot generál
Console.WriteLine($"Első véletlenszám: {v} második véletlenszám: {v2} harmadik véletlenszám: {v3}");

//Valós véletlenszám generálása
double w = random.NextDouble(); //0 és 1 közötti valós véletlenszámot generál
//feladat: [5,12) közötti valós véletlen szám generálása
double w2 = random.NextDouble()*(12-5)+5;
//Általános képlet: [ah,fh) --> r.NextDouble()*(fh-ah)+ah
//r.NextDouble() --> [0,1)
//r.NextDouble()*(fh-ah) --> [0, fh-ah)
//r.NextDouble()*(fh-ah)+ah --> [ah, fh)
Console.WriteLine($"Az első valós véletlenszám: {w}\n a második valós véletlenszám: {w2}");