#region Nap sorszámból nap név
////Olvasd be egy nap sorszámát, és írd ki a nap nevét!
//Console.Write("Kérem adja meg a nap sorszámát: ");
//int sorszam = int.Parse(Console.ReadLine()!);

//switch (sorszam)
//{
//    case 1: Console.WriteLine("Hétfő"); break;
//    case 2: Console.WriteLine("Kedd"); break;
//    case 3: Console.WriteLine("Szerda"); break;
//    case 4: Console.WriteLine("Csütörtök"); break;
//    case 5: Console.WriteLine("Péntek"); break;
//    case 6: Console.WriteLine("Szombat"); break;
//    case 7: Console.WriteLine("Vasárnap"); break;

//    default:
//        Console.WriteLine("Ilyen sorszámú nap nincs.");
//        break;
//}
#endregion

#region Nap névből hétköznap vagy hétvége
////Olvasd be egy nap nevét, és írd ki, hogy hétköznapra vagy hétvégére esik
//Console.Write("Kérem adja meg a nap nevét: ");
//string nap = Console.ReadLine()!;
//switch (nap)
//{
//    case "hétfő":
//    case "kedd":
//    case "szerda":
//    case "csütörtök":
//    case "péntek":
//        Console.WriteLine("Hétköznap");
//        break;
//    case "szombat":
//    case "vasárnap":
//        Console.WriteLine("Hétvége");
//        break;
//    default:
//        Console.WriteLine("Ilyen napnevet nem ismerek");
//        break;
//}
#endregion

Random random = new();
#region Hőmérséklet minősítés - valós számokkal
//double homerseklet = random.NextDouble() * 60 - 20;
//Console.Write($"{homerseklet:N3} ");
//switch (homerseklet)
//{
//    case < -10.0:
//        Console.WriteLine("Nagyon hideg van");
//        break;
//    case < 5.0:
//        Console.WriteLine("Hideg van");
//        break;
//    case > 30.0:
//        Console.WriteLine("Nagyon meleg van");
//        break;
//    case > 25.0:
//        Console.WriteLine("Meleg van");
//        break;
//    default:
//        Console.WriteLine("Átlagos idő van");
//        break;
//}
#endregion

#region Switch Expression
//Switch Expression 
//var napNev = sorszam switch
//{
//    1 => "hétfő",
//    2 => "kedd",
//    3 => "szerda",
//    4 => "csütörtök",
//    5 => "péntek",
//    6 => "szombat",
//    7 => "vasárnap",
//    _ => "Ilyen sorszámú nap nincs."
//};
//Console.WriteLine(napNev);
#endregion

#region Switch Expression feltétel megadással
int x = random.Next(-1, 2);
int y = random.Next(-1, 2);
var siknegyed = (x, y) switch
{
    { x: 0, y: 0 } => "origó",
    { x: 0, y: _ } => "X tengely",
    { x: _, y: 0 } => "Y tengely",
    { } when x > 0 && y > 0 => "1. negyed",
    { } when x < 0 && y > 0 => "2. negyed",
    { } when x < 0 && y < 0 => "3. negyed",
    { x: var xx, y: var yy } when xx > 0 && yy < 0 => "4. negyed",
    _ => "Ez az eset nem lehetséges",
};
Console.WriteLine($"x:{x}, y:{y}, síknegyed: {siknegyed}");
#endregion





