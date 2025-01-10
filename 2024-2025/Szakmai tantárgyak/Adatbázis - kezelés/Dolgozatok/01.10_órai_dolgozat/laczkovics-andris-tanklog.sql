SET sql_mode = 'ANSI,ONLY_FULL_GROUP_BY';
-- 3. feladat
SELECT CONCAT(`vnev`, ' ', `knev`) AS `nev`, `varos`, `email` FROM `vasarlok` WHERE `kartya`='MasterCard' ORDER BY `nev` DESC;
-- 4. feladat
SELECT CONCAT(`vnev`, ' ', `knev`) AS `nev`, `kor`, `cim` FROM `vasarlok` WHERE `cim` LIKE '%krt.%' ORDER BY `kor` ASC;
-- 5. feladat
SELECT SUM(`liter`) AS `osszmennyiseg` FROM `tankolasok` WHERE `nev`='PB' AND `hatosagi`=0;
-- 6. feladat
SELECT COUNT(`knev`) AS `fo` FROM `vasarlok` WHERE `knev`='Izabella';
-- 7. feladat
SELECT * FROM `vasarlok` INNER JOIN `tankolasok` ON(`vasarlok`.`id`=`tankolasok`.`vasarlo_id`);
-- 8. feladat
SELECT `nem`, CONCAT(SUM(`tankolasok`.`liter`*`tankolasok`.`egysegar`), ' Ft') AS `mennyiseg` FROM `vasarlok` INNER JOIN `tankolasok` ON(`vasarlok`.`id`=`tankolasok`.`vasarlo_id`) WHERE `kartya` IS NOT NULL GROUP BY `nem` ORDER BY `tankolasok`.`liter`*`tankolasok`.`egysegar` DESC;
-- 9. feladat
SELECT CONCAT(SUM(`liter`), ' liter') AS `mennyiseg` FROM `tankolasok` INNER JOIN `vasarlok` ON(`tankolasok`.`vasarlo_id`=`vasarlok`.`id`) WHERE `tipus`='diesel' AND `nev`='Pearl' AND `vasarlok`.`kor` >= 52;
-- 10. feladat
SELECT CONCAT(`vnev`, ' ', `knev`) AS `vasarlo`, `tankolasok`.`datum`, `tankolasok`.`nev`, `tankolasok`.`liter`*`tankolasok`.`egysegar` AS `osszeg` FROM `vasarlok` INNER JOIN `tankolasok` ON(`vasarlok`.`id`=`tankolasok`.`vasarlo_id`) WHERE `tankolasok`.`liter` <= 44 AND `tankolasok`.`liter` >= 21 AND (`vasarlok`.`varos`='Budapest' OR `vasarlok`.`varos`='Tamási' OR `vasarlok`.`varos`='Nyíregyháza' OR `vasarlok`.`varos`='Tarján') AND `tankolasok`.`egysegar` < 627;
-- 11. feladat
SELECT CONCAT(`vnev`, ' ', `knev`) AS `vasarlo`, `tankolasok`.`datum`, `tankolasok`.`liter`*`tankolasok`.`egysegar` AS `fizetett` FROM `vasarlok` INNER JOIN `tankolasok` ON(`vasarlok`.`id`=`tankolasok`.`vasarlo_id`) ORDER BY `fizetett` ASC LIMIT 1;
-- 12. feladat
SELECT CONCAT(`vnev`, ' ', `knev`) AS `vasarlo`, SUM(`tankolasok`.`liter`*`tankolasok`.`egysegar`) AS `fizetett` FROM `vasarlok` INNER JOIN `tankolasok` ON(`vasarlok`.`id`=`tankolasok`.`vasarlo_id`) WHERE `vasarlok`.`varos`=`tankolasok`.`varos` GROUP BY `vasarlo` ORDER BY `fizetett` ASC;
-- 13. feladat
SELECT CONCAT(`vnev`, ' ', `knev`) AS `nev` FROM `vasarlok` LEFT OUTER JOIN `tankolasok` ON(`vasarlok`.`id`=`tankolasok`.`vasarlo_id`) WHERE `tankolasok`.`liter` IS NULL ORDER BY `nev` ASC;