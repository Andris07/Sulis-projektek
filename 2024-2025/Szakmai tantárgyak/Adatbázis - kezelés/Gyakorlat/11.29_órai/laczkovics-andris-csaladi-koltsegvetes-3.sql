-- 3. feladat
SELECT `nap` FROM `kiadasok` GROUP BY `nap` HAVING SUM(`mennyiseg`*`egysegar`) >= 20000;
-- 4. feladat
SELECT `nap` FROM `kiadasok` WHERE `nev`='Lajos' GROUP BY `nap` HAVING SUM(`mennyiseg`*`egysegar`) >= 16000;
-- 5. feladat
SELECT `nap` FROM `kiadasok` WHERE `nev`='Emese' GROUP BY `nap` HAVING SUM(`mennyiseg`*`egysegar`) <= 50000;
-- 6. feladat
SELECT `kategoria`, SUM(`mennyiseg`*`egysegar`) AS `koltes` FROM `kiadasok` WHERE `nev`='Lajos' OR `nev`='Mariann' GROUP BY `kategoria` ORDER BY `koltes` ASC;
-- 7. feladat
SELECT `kategoria` FROM `kiadasok` WHERE `nev`='Lajos' OR `nev`='Mariann' GROUP BY `kategoria` HAVING SUM(`mennyiseg` * `egysegar`) > 30000;