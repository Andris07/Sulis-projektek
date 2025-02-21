-- 2. feladat
DROP DATABASE IF EXISTS `laczkovics-nba`;

-- 3. feladat
CREATE DATABASE IF NOT EXISTS `laczkovics-nba`
CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

-- 4. feladat
USE `laczkovics-nba`;

-- 5. feladat
CREATE TABLE `jatekos`
(
    `id` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'A játékos azonosítója.',
    `nev` VARCHAR(25) NOT NULL COMMENT 'A játékos neve.',
    `kor` TINYINT NOT NULL COMMENT 'A játékos kora.',
    `magassag` FLOAT(5, 2) NOT NULL COMMENT 'A játékos magassága centiméterben.',
    `csapat` VARCHAR(30) NOT NULL COMMENT 'A csapat nevének rövidítése',

    PRIMARY KEY (`id`)
);

-- 6. feladat
DELETE FROM `jatekos`;

-- 7. feladat
INSERT INTO `jatekos` (`nev`, `kor`, `magassag`, `csapat`)

VALUES
    ('Matt Fish', 27, 210.82, 'MIA');

-- 8. feladat
INSERT INTO `jatekos` (`nev`, `kor`, `magassag`, `csapat`)

VALUES
    ('Walter McCarty', 27, 208.28, 'BOS'),
    ('James Posey', 31, 203.2, 'BOS'),
    ('James Michael McAdoo', 22, 205.74, 'GSW');

-- 9. feladat
-- SELECT AVG(`magassag`) AS `átlagmagasság csapatonként` FROM `jatekos` GROUP BY `csapat`;
-- 10. feladat
-- SELECT `nev` AS `legmagasabb játékos` FROM `jatekos` ORDER BY `magassag` ASC LIMIT 1;
-- 11. feladat
-- SELECT `csapat`, `kor` FROM `jatekos` ORDER BY `kor` DESC LIMIT 1;