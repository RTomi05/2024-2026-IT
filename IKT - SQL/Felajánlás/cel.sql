-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Dec 02. 08:27
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `felajanlas`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cel`
--

CREATE TABLE `cel` (
  `az` int(11) NOT NULL,
  `megnevezes` varchar(100) NOT NULL,
  `civil` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `cel`
--

INSERT INTO `cel` (`az`, `megnevezes`, `civil`) VALUES
(1, 'járdaépítés', 0),
(2, 'sérült gyerekek támogatása', 1),
(3, 'lakótelepi játszótér felújítása', 0),
(4, 'faültetés a főtéren', 0),
(5, 'állatmenhely korszerűsétése', 1),
(6, 'parkosítás az iskola körül', 0),
(7, 'daganatos betegek gondozása', 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `cel`
--
ALTER TABLE `cel`
  ADD PRIMARY KEY (`az`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `cel`
--
ALTER TABLE `cel`
  MODIFY `az` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
