
DROP TABLE IF EXISTS `film`;
CREATE TABLE `film` (
  `id` int(11) NOT NULL,
  `cim` varchar(100) NOT NULL,
  `kiadasiev` int(4) NOT NULL,
  `kocka` int(11) NOT NULL,
  `szinese` tinyint(1) NOT NULL,
  `kiadoid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kiado`
--

DROP TABLE IF EXISTS `kiado`;
CREATE TABLE `kiado` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `kiado`
--
ALTER TABLE `kiado`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `kiado`
--
ALTER TABLE `kiado`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;