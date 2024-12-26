DROP DATABASE IF EXISTS`napfogyatkozas`;

CREATE DATABASE IF NOT EXISTS `napfogyatkozas` 
CHARACTER SET utf8
collate utf8_hungarian_ci;

use napfogyatkozas;

CREATE TABLE IF NOT EXISTS `napfogyatkozas` (
  `id` int primary key auto_increment,
  `datum` date DEFAULT NULL,
  `ido` time DEFAULT NULL,
  `tipus` varchar(10) DEFAULT NULL,
  `szarosz` int(3) DEFAULT NULL,
  `gamma` decimal(5,3) DEFAULT NULL,
  `meret` decimal(4,3) DEFAULT NULL,
  `idotartam` time DEFAULT NULL,
  `szelesseg` int(11) DEFAULT NULL,
  `megfigyelheto` varchar(150) DEFAULT NULL
);
