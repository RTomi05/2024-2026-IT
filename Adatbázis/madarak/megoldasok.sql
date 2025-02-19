-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 9. feladat:

    create database vedettmadarak default charset = "utf8" collate = "utf8_hungarian_ci"

-- 11. feladat:

    update faj set ertek = 25 where id=352;

-- 12. feladat:

    select nev, latin from faj where evszam is null order by nev;

-- 13. feladat:

    select evszam, count(nev) as "fajok szama" from faj where evszam > 2000 group by evszam;

-- 14. feladat:

    select csalad.nev as nev, avg(ertek) as atlag from faj inner join csalad on csaladId = csalad.id group by csalad.nev;
 
-- 15. feladat:

