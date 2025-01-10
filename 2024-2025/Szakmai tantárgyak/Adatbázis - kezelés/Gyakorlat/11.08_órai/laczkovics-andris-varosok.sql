SET sql_mode = 'ANSI,ONLY_FULL_GROUP_BY';
-- 3. feladat
SELECT * FROM `magyarorszag` ORDER BY `nepesseg` DESC;
-- 4. feladat
SELECT DISTINCT `tipus` FROM `magyarorszag` ORDER BY `tipus` ASC;
-- 5. feladat
SELECT COUNT(`id`) AS `varosok_szama` FROM `magyarorszag`;
-- 6. feladat
SELECT COUNT(DISTINCT `tipus`) AS `tipus_db` FROM `magyarorszag`;
-- 7. feladat
SELECT COUNT(*) AS `db` FROM `magyarorszag` WHERE `megye`='Csongrád-Csanád';
-- 8. feladat
SELECT COUNT(*) AS `db` FROM `magyarorszag` WHERE LENGTH(`nev`)=4;
-- 9. feladat
SELECT COUNT(*) FROM `magyarorszag` WHERE (`megye`='Békés' OR `megye`='Fejér');
-- 10. feladat
SELECT `megye`, COUNT(*) AS `db` FROM `magyarorszag` GROUP BY `megye` ORDER BY COUNT(*) DESC;
-- 11. feladat
SELECT `varos_cim_elnyerese` AS `ev` FROM `magyarorszag` WHERE `varos_cim_elnyerese` IS NOT NULL ORDER BY `varos_cim_elnyerese` DESC LIMIT 1;
-- 12. feladat
SELECT `megye`, `varos_cim_elnyerese` AS `ev` FROM `magyarorszag` WHERE `varos_cim_elnyerese` IS NOT NULL GROUP BY `megye` ORDER BY `varos_cim_elnyerese` DESC;
-- 13. feladat
SELECT `nepesseg` AS `minimum_lakossag` FROM `magyarorszag` ORDER BY `nepesseg` ASC LIMIT 1;
-- 14. feladat
SELECT `nepesseg` AS `maximum_lakossag` FROM `magyarorszag` ORDER BY `nepesseg` DESC LIMIT 1;
-- 15. feladat
SELECT `terulet` AS `maximum_terulet` FROM `magyarorszag` ORDER BY `terulet` DESC LIMIT 1;
-- 16. feladat
SELECT `nev`, `terulet` FROM `magyarorszag` ORDER BY `terulet` DESC LIMIT 3;
-- 17. feladat
SELECT `nev`, `terulet` FROM `magyarorszag` WHERE `megye`='Somogy' ORDER BY `terulet` DESC LIMIT 3;
-- 18. feladat
SELECT `nev`, ROUND(`nepesseg`/`terulet`, 4) AS `nepsuruseg` FROM `magyarorszag` ORDER BY ROUND(`nepesseg`/`terulet`, 4) DESC LIMIT 1;
-- 19. feladat
SELECT SUM(`nepesseg`) AS `lakossag` FROM `magyarorszag` WHERE `tipus`='járásszékhely város';
-- 20. feladat
SELECT ROUND(SUM(`terulet`), 2) AS `osszterulet` FROM `magyarorszag` WHERE `varos_cim_elnyerese` IS NOT NULL AND `varos_cim_elnyerese` <= 2012 AND `varos_cim_elnyerese` >= 2000;
-- 21. feladat
SELECT `megye`, SUM(`nepesseg`) AS `lakossag` FROM `magyarorszag` GROUP BY `megye` ORDER BY `megye` ASC;
-- 22. feladat
SELECT `megye`, ROUND(AVG(`nepesseg`)) AS `lakossag` FROM `magyarorszag` GROUP BY `megye` ORDER BY `lakossag` DESC, `megye` ASC;
-- 23. feladat
SELECT `jaras`, ROUND(AVG(`terulet`), 2) AS `atlag_terulet` FROM `magyarorszag` GROUP BY `jaras` ORDER BY AVG(`terulet`) ASC;
-- 24. feladat
SELECT `nev`, CONCAT(`nepesseg`, ' fő') AS `lakossag` FROM `magyarorszag` WHERE `tipus` LIKE '%megyei jogú város%' ORDER BY `nepesseg` DESC LIMIT 1;
-- 25. feladat
SELECT `jaras`, CONCAT(ROUND(AVG(`terulet`*1000000)), ' négyzetméter') AS `terulet` FROM `magyarorszag` GROUP BY `jaras` ORDER BY AVG(`terulet`*1000000) ASC;
