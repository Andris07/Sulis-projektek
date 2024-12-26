-- 3. feladat
SELECT * FROM `papirpenz`;
-- 4. feladat
SELECT *, ROUND((`ertek`/420), 2) AS `Euróban` FROM `papirpenz` WHERE `penznem`='HUF';
-- 5. feladat
SELECT DISTINCT `penznem` FROM `papirpenz`;
-- 6. feladat
SELECT DISTINCT `penznem`, `ertek` FROM `papirpenz` ORDER BY `penznem` ASC;
-- 7. feladat
SELECT COUNT(*) AS `Sorok száma` FROM `papirpenz`;
-- 8. feladat
SELECT COUNT(DISTINCT `penznem`) AS `Pénznemek` FROM `papirpenz`;
-- 9. feladat
SELECT COUNT(`penznem`) AS `db` FROM `papirpenz` WHERE `penznem`='HUF';
-- 10. feladat
SELECT * FROM `papirpenz` ORDER BY `ertek` ASC LIMIT 1;
-- 11. feladat
SELECT * FROM `papirpenz` ORDER BY `ertek` DESC LIMIT 1;
-- 12. feladat
SELECT SUM(`ertek`) AS `EUR összesen` FROM `papirpenz` WHERE `penznem`='EUR';
-- 13. feladat
SELECT (SUM(`ertek`)*420) AS `Ft` FROM `papirpenz` WHERE `penznem`='EUR';
-- 14. feladat
SELECT COUNT(*) AS `db`, CONCAT(SUM(`ertek`), ' lej') AS `osszeg` FROM `papirpenz` WHERE `penznem`='RON';
-- 15. feladat
SELECT COUNT(*) AS `db` FROM `papirpenz` WHERE `penznem`='HUF' AND `azon` LIKE '%y%';
-- 16. feladat
SELECT MIN(`ertek`) AS `minimum` FROM `papirpenz` WHERE `penznem`='HUF';
-- 17. feladat
SELECT MAX(`ertek`) AS `maximum` FROM `papirpenz` WHERE `penznem`='EUR';