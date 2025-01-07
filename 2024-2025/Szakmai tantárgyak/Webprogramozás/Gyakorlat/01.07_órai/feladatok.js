let szamok = [-10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10];

// 1. feladat
function paros_paratlan(szamok_tomb = [])
{
    let paros = [];
    let paratlan = [];
    
    for (let i = 0; i < szamok_tomb.length; i++)
    {
        if (szamok_tomb[i]%2 == 0)
        {
            paros.push(szamok_tomb[i]);
        }
        else
        {
            paratlan.push(szamok_tomb[i]);
        }
    }

    return `A páros számok: ${paros}, a páratlan számok: ${paratlan}`;
}

console.log(paros_paratlan(szamok));

// 2. feladat
function osszeg(szamok_tomb = [])
{
    let pozitiv = [];
    let negativ = [];
    let pozitiv_osszeg = 0;
    let negativ_osszeg = 0;

    for (let i = 0; i < szamok_tomb.length; i++)
    {
        if (szamok_tomb[i] >= 0)
        {
            pozitiv_osszeg += szamok_tomb[i];
        }
        else
        {
            negativ_osszeg += szamok_tomb[i];
        }
    }
    return `A pozitív számok összege: ${pozitiv_osszeg}, a negatív számok összege ${negativ_osszeg}`;
}

console.log(osszeg(szamok));

// 3. feladat
function oszto(szamok_tomb = [], oszto_szam)
{
    let oszthato = [];
    let nem_oszthato = [];

    for (let i = 0; i < szamok_tomb.length; i++)
    {
        if (szamok_tomb[i]%oszto_szam == 0)
        {
            oszthato.push(szamok_tomb[i]);
        }
        else
        {
            nem_oszthato.push(szamok_tomb[i]);
        }
    }
    
    return `Az osztható számok: ${oszthato}, a nem osztható számok: ${nem_oszthato}`;
}

console.log(oszto(szamok, 2));

// 4. feladat
function atlag(szamok_tomb = [], atlag_szam)
{
    let atlag_felettiek = [];
    let atlag_alattiak = [];

    for (let i = 0; i < szamok_tomb.length; i++)
    {
        if (szamok_tomb[i] >= atlag_szam)
        {
            atlag_felettiek.push(szamok_tomb[i]);
        }
        else
        {
            atlag_alattiak.push(szamok_tomb[i]);
        }
    }

    return `Az átlag felettiek: ${atlag_felettiek}, az átlag alattiak ${atlag_alattiak}`;
}

console.log(atlag(szamok, 3));

// 5. feladat
function modusz(szamok_tomb = [])
{
    let gyakorisag_db = [];
    let max_gyakorisag_db = 0;
    let modusz_szam = null;

    for (let i = 0; i < szamok_tomb.length; i++)
    {
        let szam = szamok_tomb[i];
        
        if (gyakorisag_db[szam] === undefined)
        {
            gyakorisag_db[szam] = 1;
        }
        else
        {
            gyakorisag_db[szam]++;
        }
        if (gyakorisag_db[szam] > max_gyakorisag_db)
        {
            max_gyakorisag_db = gyakorisag_db[szam];
            modusz_szam = szam;
        }
    }

    return `A legtöbbet előforduló szám: ${modusz_szam}`;
}

console.log(modusz(szamok));