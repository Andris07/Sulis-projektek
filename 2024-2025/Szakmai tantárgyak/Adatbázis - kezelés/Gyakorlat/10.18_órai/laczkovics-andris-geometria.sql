-- 3. feladat
SELECT * FROM `teglalapok`;
-- 4. feladat
SELECT `szin`, `a`, `b`, ROUND(`a`*`b`, 1) AS `terulet` FROM `teglalapok`;
-- 5. feladat
SELECT ROUND(`a`*`b`) AS `terulet`, 2*(`a`+`b`) AS `kerulet` FROM `teglalapok` WHERE `szin`='sárga';
-- 6. feladat
SELECT `szin`, ROUND(`a`*`b`) AS `terulet`, 2*(`a`+`b`) AS `kerulet` FROM `teglalapok` WHERE (`a`*`b`) >= 4;
-- 7. feladat
SELECT * FROM `haromszogek`;
-- 8. feladat
SELECT `szin`, ROUND(`a`+`b`+`c`, 1) AS `kerulet` FROM `haromszogek`;
-- 9. feladat
SELECT CONCAT(2*(`a`+`b`), ' cm') AS `kerulet` FROM `haromszogek` WHERE `szin`='sárga';
-- 10. feladat
SELECT ROUND(`a`+`b`+`c`, 1) AS `kerulet` FROM `haromszogek` WHERE `szin`='piros';
-- 11. feladat
SELECT `szin`, `a`, `b`, `c`, ROUND(`a`+`b`+`c`, 1) AS `kerulet` FROM `haromszogek` ORDER BY ROUND(`a`+`b`+`c`, 1) DESC;
-- 12. feladat
SELECT `szin`, ROUND(`a`+`b`+`c`, 1) AS `kerulet` FROM `haromszogek` WHERE (`a`+`b`+`c`) > 9;
-- 13. feladat
SELECT `szin` FROM `haromszogek` WHERE (`a`+`b` > `c` AND `a`+`c` > `b` AND `b`+`c` > `a`);
-- 14. feladat
SELECT `szin` FROM `haromszogek` WHERE NOT (`a`+`b` > `c` AND `a`+`c` > `b` AND `b`+`c` > `a`);
-- 15. feladat
SELECT * FROM `korok`;
-- 16. feladat
SELECT `szin`, 2*`r`*PI() AS `kerulet`, POW(`r`, 2)*PI() AS `terulet` FROM `korok`;
-- 17. feladat
SELECT ROUND(2*`r`*PI(), 2) AS `kerulet`, ROUND(POW(`r`, 2)*PI()) AS `terulet` FROM `korok` WHERE `szin`='lila';
-- 18. feladat
SELECT `szin`, `r`, 2*`r` AS `d` FROM `korok` WHERE (`szin`='piros' OR `szin`='kék');
-- 19. feladat
SELECT `szin`, CONCAT(ROUND(((PI()*POW(`r`, 2)) * 100), 3), ' mm') AS `terulet` FROM `korok` WHERE (`szin`='piros' OR `szin`='kék' OR `szin`='sárga') ORDER BY (PI()*POW(`r`, 2)) ASC;