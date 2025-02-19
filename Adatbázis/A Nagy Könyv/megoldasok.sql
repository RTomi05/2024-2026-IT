-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:

    create database nagykonyv default charset = utf8 collate = utf8_hungarian_ci;
    \C latin2

-- 3. feladat:

    select distinct nemzetiseg from szerzo where nemzetiseg != "magyar";

-- 4. feladat:

    select nev, 2005-szulEv as kor from szerzo where halEv is NULL;

-- 5. feladat:


-- 6. feladat:

