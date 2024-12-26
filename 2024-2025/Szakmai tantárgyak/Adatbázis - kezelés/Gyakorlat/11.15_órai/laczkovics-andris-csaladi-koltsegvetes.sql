-- 3. feladat
SELECT * FROM `kiadasok`;
-- 4. feladat
SELECT DISTINCT `kategoria` FROM `kiadasok`;
-- 5. feladat
SELECT SUM(`egysegar`*`mennyiseg`) AS `osszkoltseg` FROM `kiadasok`;
-- 6. feladat
SELECT COUNT(`megnevezes`) AS `vett_mennyiseg` FROM `kiadasok`;
-- 7. feladat
SELECT SUM(`mennyiseg`) AS `termekek_szama` FROM `kiadasok`;
-- 8. feladat
SELECT COUNT(DISTINCT `megnevezes`) AS `kulonbozo_db` FROM `kiadasok`;
-- 9. feladat
SELECT AVG(`egysegar`) AS `atlagos_egysegar` FROM `kiadasok`;
-- 10. feladat
SELECT MIN(`egysegar`) AS `legolcsobb` FROM `kiadasok`;
-- 11. feladat
SELECT MAX(`egysegar`) AS `legdragabb` FROM `kiadasok`;
-- 12. feladat
SELECT `megnevezes` FROM `kiadasok` WHERE `nev`='Bence';
-- 13. feladat
SELECT COUNT(`megnevezes`) FROM `kiadasok` WHERE `nev`='Bence';
-- 14. feladat
SELECT `megnevezes`, (`mennyiseg`*`egysegar`) AS `fizetett` FROM `kiadasok` WHERE `nev`='Emese' ORDER BY (`mennyiseg`*`egysegar`) ASC;
-- 15. feladat
SELECT SUM(`mennyiseg`*`egysegar`) AS `koltott` FROM `kiadasok` WHERE `nev`='Emese';
-- 16. feladat
SELECT `megnevezes`, `kategoria`, (`mennyiseg`*`egysegar`) AS `koltes` FROM `kiadasok` WHERE `nev`='Bence' OR `nev`='Emese' ORDER BY (`mennyiseg`*`egysegar`) DESC;
-- 17. feladat
SELECT `nev`, `megnevezes` FROM `kiadasok` ORDER BY (`mennyiseg`*`egysegar`) DESC LIMIT 5;
-- 18. feladat
SELECT `nev`, `megnevezes`, `egysegar` FROM `kiadasok` ORDER BY (`mennyiseg`*`egysegar`) DESC LIMIT 1;