-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 10. feladat:

    create database halozat default charset = utf8 collate = utf8_hungarian_ci;
    \C latin2;

-- 12. feladat:

    insert into megallok values(198, "Kőbányai garázs");

-- 13. feladat:

    update jaratok set elsoAjtos = False where id = 20;

-- 14. feladat:

    select jaratSzam from jaratok where elsoAjtos = True;

-- 15. feladat:

    select nev from megallok where nev like "%sétány%" order by nev;

-- 16. feladat:

    select sorszam, nev as megallo from megallok inner join halozat on megallok.id = megallo inner join jaratok on jaratok.id = jarat where irany = "A" and jaratSzam = "CITY" ORDER BY 1;

-- 17. feladat:

    select nev as megallo, count(nev) as jaratokSzama from megallok inner join halozat on megallok.id = megallo group by nev having count(nev) > 3;


