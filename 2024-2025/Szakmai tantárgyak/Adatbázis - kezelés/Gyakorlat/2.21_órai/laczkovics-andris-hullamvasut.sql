-- 2. feladat
DROP DATABASE IF EXISTS `laczkovics-hullamvasut`;

-- 3 feladat
CREATE DATABASE IF NOT EXISTS `laczkovics-hullamvasut`
CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

-- 4. feladat
USE `laczkovics-hullamvasut`;

-- 5. feladat
CREATE TABLE `tipus`
(
    `id` BIGINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'A sor egyedi azonosítója.',
    `tipus` VARCHAR(30) NOT NULL COMMENT 'A hullámvasút típusának a neve.',
    `beszuntetett` BOOLEAN NOT NULL COMMENT 'Igaz, ha beszüntették a gyártását.',
    `elso` BIGINT UNSIGNED NOT NULL COMMENT 'Az első ilyen hullámvasút évszáma.',
    `darab` BIGINT UNSIGNED NOT NULL COMMENT 'Hány darabot gyártottak belőle.',
    `rogzites` VARCHAR(20) NOT NULL COMMENT 'Hol rögzití az utasokat.',

    PRIMARY KEY (`id`)
);

-- 6. feladat
DELETE FROM `tipus`;

-- 7. feladat
INSERT INTO `tipus` (`tipus`, `beszuntetett`, `elso`, `darab`, `rogzites`)

VALUES
    ('4th Dimension roller coaster', 0, 2002, 8, 'váll fölött'),
    ('Bobsled roller coaster', 0, 1929, 21, 'ölben'),
    ('Dive Coaster', 0, 1998, 14, 'váll fölött'),
    ('Floorless Coaster', 0, 1999, 14, 'váll fölött'),
    ('Flying roller coaster', 0, 1997, 26, 'váll fölött'),
    ('Inverted roller coaster', 0, 1992, 189, 'váll fölött'),
    ('Pipeline roller coaster', 1, 1984, 12, 'váll fölött'),
    ('Stand-up roller coaster', 0, 1982, 21, NULL),
    ('Suspended roller coaster', 0, 1902, 37, NULL);