SET sql_mode = 'ANSI,ONLY_FULL_GROUP_BY';
-- 3. feladat
SELECT * FROM `orszagok`;
-- 4. feladat
SELECT `orszag` FROM `orszagok` WHERE `fovaros` IN('Intel', 'Kingston', 'Apple', 'Fujitsu');
-- 5. feladat
SELECT `orszag` FROM `orszagok` WHERE `orszag` LIKE '%d';
-- 6. feladat
SELECT `orszag` FROM `orszagok` WHERE `orszag` LIKE 'v%';
-- 7. feladat
SELECT `orszag` FROM `orszagok` WHERE `orszag` LIKE '%v%' ORDER BY `orszag` ASC;
-- 8. feladat
SELECT `orszag` FROM `orszagok` WHERE `orszag` NOT LIKE 'z%' ORDER BY `orszag` DESC;
-- 9. feladat
SELECT `orszag` FROM `orszagok` WHERE `orszag` NOT LIKE '%o%' ORDER BY `orszag` ASC;
-- 10. feladat
SELECT `orszag`, `autojel` FROM `orszagok` WHERE `orszag` LIKE 'v%' AND `autojel` NOT LIKE 'v%';
-- 11. feladat
SELECT `orszag`, `fovaros` FROM `orszagok` WHERE `foldr_hely` LIKE 'észak-amerika';
-- 12. feladat
SELECT `orszag`, `terulet` FROM `orszagok` ORDER BY `terulet` ASC LIMIT 1;
-- 13. feladat
SELECT `orszag`, `terulet` FROM `orszagok` WHERE `foldr_hely` LIKE '%europa%' ORDER BY `terulet` DESC LIMIT 1;
-- 14. feladat
SELECT `orszag`, `terulet` FROM `orszagok` WHERE `foldr_hely` LIKE '%közép-európa%' ORDER BY `terulet` ASC LIMIT 3;
-- 15. feladat
SELECT `orszag` FROM `orszagok` WHERE `orszag` LIKE '%egyesült%';
-- 16. feladat
SELECT `orszag` FROM `orszagok` WHERE `foldr_hely` LIKE '%törpeállam%';
-- 17. feladat
SELECT `orszag`, `allamforma` FROM `orszagok` WHERE `allamforma` LIKE '%monarchia%';
-- 18. feladat
SELECT `orszag` FROM `orszagok` WHERE `orszag` LIKE '%ország%';
-- 19. feladat
SELECT `orszag` FROM `orszagok` WHERE (`valtopenz` LIKE '%cent' AND `valtopenz` NOT LIKE '%euro%') ORDER BY `orszag` ASC;
-- 20. feladat
SELECT `orszag`, `foldr_hely` FROM `orszagok` WHERE `foldr_hely` LIKE '%európa%' ORDER BY `orszag` ASC;
-- 21. feladat
SELECT `penznem` FROM `orszagok` WHERE (`penzjel` LIKE '%d' AND `penznem` NOT LIKE '%dollár%') ORDER BY `penznem` ASC;
-- 22. feladat
SELECT `orszag` FROM `orszagok` WHERE `allamforma` LIKE '%szövetség%';
-- 23. feladat
SELECT `penznem`, `orszag` FROM `orszagok` WHERE `valtopenz` <> 100;
-- 24. feladat
SELECT `orszag` FROM `orszagok` WHERE `valtopenz` LIKE '%kopejka%';
