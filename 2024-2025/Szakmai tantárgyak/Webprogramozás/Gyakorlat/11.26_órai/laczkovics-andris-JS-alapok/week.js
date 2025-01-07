// 11. feladat
let nap = prompt("Kérem adja meg a hét egyik napját: ");

// 10. és 12. feladat
switch (nap)
{
    case "Hétfő":
    {
        console.log("A Hétfő a hét első napja");
        break;
    }
    case "Kedd":
    {
        console.log("A Kedd a hét második napja");
        break;
    }
    case "Szerda":
    {
        console.log("A Szerda a hét harmadik napja");
        break;
    }
    case "Csütörtök":
    {
        console.log("A Csütörtök a hét negyedik napja");
        break;
    }
    case "Péntek":
    {
        console.log("A Péntek a hét ötödik napja");
        break;
    }
    case "Szombat":
    {
        console.log("A Szombat a hét hatodik napja");
        break;
    }
    case "Vasárnap":
    {
        console.log("A Vasárnap a hét hetedik napja");
        break;
    }
    // 13. feladat
    default:
    {
        console.log("Nem megfelelő bemenet");
        break;
    }
}