-- ALLEKÉRDEZÉSEK


-- 1. feladat:

    select nev, (select min(helyezes) from konyv where szerzo.id = szerzoId) from szerzo;
    select nev,helyezes from szerzo inner join konyv on szerzo.id = szerzoId group by 1;

-- 2. feladat:

    

-- 3. feladat:

select nev from szerzo where szulEv = (select szulEv from szerzo where nev = 'Kertész Imre') and nev != 'Kertész Imre';

-- 4. feladat:



-- 5. feladat:


