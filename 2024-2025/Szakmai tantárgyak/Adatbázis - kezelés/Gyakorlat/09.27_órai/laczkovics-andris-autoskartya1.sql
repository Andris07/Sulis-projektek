SET sql_mode = 'ANSI,ONLY_FULL_GROUP_BY';
-- 3. feladat
SELECT * FROM `autoskartya`;
-- 4. feladat
SELECT `gyartmany`, `tipus` FROM `autoskartya` WHERE `orszag`='Németország' AND (`vegsebesseg` > 240 OR `loero` >= 200) ORDER BY `tipus` DESC;
-- 5. feladat
SELECT * FROM `autoskartya` WHERE (`orszag`='Japán' OR `fogyasztas` <= 6 OR `hengerurtartalom` <= 1400 AND `fogyasztas` <= 7);
-- 6. feladat
SELECT `gyartmany`, `tipus`, `gyartasi_ev` FROM `autoskartya` WHERE (`gyartmany`='Bentley' OR `gyartmany`='BMW' OR `gyartmany`='Mercedes' OR `gyartmany`='Volvo') AND `kilowatt` >= 150;
-- 7. feladat
SELECT DISTINCT `gyartmany` FROM `autoskartya` ORDER BY `gyartmany` ASC;
-- 8. feladat
SELECT `gyartmany`, `tipus`, `loero` FROM `autoskartya` ORDER BY `loero` DESC;
-- 9. feladat
SELECT `tipus`, `orszag`, `vegsebesseg` FROM `autoskartya` ORDER BY `orszag` ASC;
-- 10. feladat
SELECT `gyartmany`, `tipus`, `orszagkod` FROM `autoskartya` WHERE `fogyasztas` < 5 AND `orszag` IN('Németország', 'Franciaország');
