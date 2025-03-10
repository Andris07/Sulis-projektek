SET sql_mode = 'ANSI,ONLY_FULL_GROUP_BY';
-- 3. feladat
SELECT * FROM `hirdetesek`;
-- 4. feladat
SELECT `gyarto`, `nev` FROM `hirdetesek` WHERE `nem`='n';
-- 5. feladat
SELECT `gyarto`, `nev`, DATE(`lejarat`) AS `lejarat` FROM `hirdetesek` WHERE `aktiv`=0;
-- 6. feladat
SELECT `gyarto`, `nev`, `meret` FROM `hirdetesek` WHERE `meret` <= 40 ORDER BY `ar` DESC;
-- 7. feladat
SELECT * FROM `hirdetesek` WHERE `lejarat` <= '2024-12-31 23:59:59';
-- 8. feladat
SELECT `nev`, `gyarto`, `meret` FROM `hirdetesek` WHERE `meret` >= 42;
-- 9. feladat
SELECT * FROM `hirdetesek` WHERE `gyarto` IN('Gabika', 'Para');
-- 10. feladat
select `gyarto`, `ar` FROM `hirdetesek` WHERE `ar` <= 30000 AND `ar` >= 20000;
-- 11. feladat
SELECT * FROM `hirdetesek` WHERE `gyarto`='Nipie' AND `szin`='fekete' AND MONTH(`lejarat`)=1;
-- 12. feladat
SELECT * FROM `hirdetesek` WHERE `nem`='n' OR `nem`='u';
-- 13. feladat
SELECT * FROM `hirdetesek` ORDER BY `ar` ASC;
-- 14. feladat
SELECT * FROM `hirdetesek` WHERE `aktiv`=1 AND `lejarat` > NOW() ORDER BY `lejarat` ASC;
-- 15. feladat
SELECT `gyarto`, `nev`, `ar` FROM `hirdetesek` ORDER BY `ar` DESC LIMIT 3;
-- 16. feladat
SELECT * FROM `hirdetesek` WHERE `meret` > 40 ORDER BY `meret` ASC;
-- 17. feladat
SELECT * FROM `hirdetesek` WHERE `lejarat` <= '2025-01-01 00:00:00';
-- 18. feladat
SELECT * FROM `hirdetesek` WHERE `lejarat` >= NOW();
-- 19. feladat
SELECT * FROM `hirdetesek` WHERE weekday(`lejarat`)=6;
