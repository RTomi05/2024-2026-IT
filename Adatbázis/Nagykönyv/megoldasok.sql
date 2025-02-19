-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:

    create database nagykonyv default character set = utf8 collate = utf8_hungarian_ci;

-- 3. feladat:

    select nemzetiseg from szerzo where nemzetiseg!= 'magyar' group by nemzetiseg;
    --Vagy
    select distinct nemzetiseg from szerzo where nemzetiseg!= 'magyar';

-- 4. feladat:

    select nev, 2005 - szulEv as kor from szerzo where halEv is NULL;

-- 5. feladat:


-- 6. feladat:

