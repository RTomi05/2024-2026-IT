-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:

    create database euroskills default charset=utf8 collate=utf8_hungarian_ci;
    \C latin2

-- 3. feladat:

     select count(id) as ermek from versenyzo where pont >= 700;

-- 4. feladat:

    select distinct orszagNev from versenyzo inner join orszag on orszagId = orszag.Id order by 1;

-- 5. feladat:

    select szakmaNev, count(*) as 'versenyzok szama' from szakma inner join versenyzo on szakma.id=szakmaId group by 1 order by 2 desc;

-- 6. feladat:

    select nev, orszagNev,szakmaNev, pont from versenyzo inner join szakma on szakma.id = szakmaId inner join orszag on orszag.id = orszagId order by 4 desc, 1 limit 25;
