let min = 0;
let max = 9;
let min3 = 100;
let max3 = 999;
// 15. feladat
let random_szam9 = Math.floor(Math.random() * (max - min)) + min;
let random_szam10 = Math.floor(Math.random() * (max3 - min3)) + min3;
// 16. feladat
console.log(`16. feladat: ${random_szam9 * random_szam10}`);
// 17. feladat
if (random_szam9%random_szam10 == 0)
{
    console.log(`17. feladat: ${random_szam9} osztója a ${random_szam10} számnak`);
}
else
{
    console.log(`17. feladat: ${random_szam9} nem osztója a ${random_szam10} számnak`);
}
// 18. feladat
if (random_szam10%random_szam9 == 0)
{
    console.log(`17. feladat: ${random_szam10} osztója a ${random_szam9} számnak`);
}
else
{
    console.log(`17. feladat: ${random_szam10} nem osztója a ${random_szam9} számnak`);
}    
// 19. feladat
if (random_szam9 == random_szam10)
{
    console.log(`19. feladat: a két szám egyenlő`);
}
else
{
    console.log(`19. feladat: a két szám nem egyenlő`);
}
// 20. feladat
console.log(`20. feladat: ${random_szam9} harmadik hatványa: ${Math.pow(random_szam9, 3)}`);
console.log(`20. feladat: ${random_szam10} harmadik hatványa: ${Math.pow(random_szam10, 3)}`);
// 21. feladat
if (Math.pow(random_szam9, 4) > random_szam10)
{
    console.log(`21. feladat: ${random_szam9} negyedik hatványa nagyobb, mint ${random_szam10}`);
}
else if (Math.pow(random_szam9, 4) < random_szam10)
{
    console.log(`21. feladat: ${random_szam9} negyedik hatványa kisebb, mint ${random_szam10}`);
}
else
{
    console.log(`21. feladat: ${random_szam9} negyedik hatványa egyenlő a ${random_szam10} számmal`);
}
