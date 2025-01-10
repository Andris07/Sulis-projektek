SET sql_mode = 'ANSI,ONLY_FULL_GROUP_BY';
-- 3. feladat
SELECT * FROM `napfogyatkozas` ORDER BY `datum` ASC;
-- 4. feladat
SELECT DISTINCT `tipus` FROM `napfogyatkozas`;
-- 5. feladat
SELECT * FROM `napfogyatkozas` WHERE `szelesseg` IS NULL;
-- 6. feladat
SELECT `datum`, `ido`, `tipus` FROM `napfogyatkozas` WHERE `megfigyelheto`='Észak-Amerika';
-- 7. feladat
SELECT `datum`, `ido`, `megfigyelheto` FROM `napfogyatkozas` WHERE (`tipus`='teljes' OR `tipus`='gyűrűs');
-- 8. feladat
SELECT `datum`, `ido` FROM `napfogyatkozas` WHERE `megfigyelheto` LIKE '%Afrika%' AND CURRENT_DATE() < `datum` AND(`tipus`='teljes' OR `tipus`='gyűrűs');
-- 9. feladat
SELECT `datum`, `ido`, `megfigyelheto` FROM `napfogyatkozas` WHERE `megfigyelheto` IS NOT NULL;
-- 10. feladat
SELECT `datum`, `ido` FROM `napfogyatkozas` WHERE `tipus`='teljes' AND `megfigyelheto` LIKE '%magyarorszag%';
-- 11. feladat
SELECT DISTINCT `tipus` FROM `napfogyatkozas` ORDER BY `tipus` ASC;
-- 12. feladat
SELECT `datum`, `ido`, `idotartam` FROM `napfogyatkozas` WHERE `tipus`='teljes' ORDER BY `idotartam` DESC;
-- 13. feladat
SELECT * FROM `napfogyatkozas` WHERE `megfigyelheto` LIKE '%,%';
-- 14. feladat
SELECT * FROM `napfogyatkozas` WHERE `tipus`='részleges' AND (`megfigyelheto` LIKE '%alaszka' OR `megfigyelheto` LIKE '%hawaii');
