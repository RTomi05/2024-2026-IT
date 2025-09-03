-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 10. feladat:

    CREATE DATABASE Tisza DEFAULT CHARACTER SET=utf8 COLLATE=utf8_hungarian_ci;
    \C latin2
    use Tisza;

-- 12. feladat:

    delete from meres where nap="2020-03-27";

-- 13. feladat:

    update vizmerce set idID=2 where varos="Tokaj";

-- 14. feladat:

    select varos, nullPont from vizmerce order by nullPont Limit 1;

-- 15. feladat:

    select varos, lnv-lkv as ingadozas from vizmerce order by ingadozas desc;

-- 16. feladat:

    select nev, count(varos) as merceszam from igazgatosag inner join vizmerce on igazgatosag.id=igId group by nev;
  
-- 17. feladat:

    select avg(vizAllas) as atlag from meres inner join vizmerce on vizmerce.id=vmid where varos="Szolnok" and month(nap)=4;

