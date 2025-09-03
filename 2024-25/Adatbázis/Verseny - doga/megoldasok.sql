-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 1. feladat:

    create database verseny default charset = utf8 collate = utf8_hungarian_ci;
    \C latin2

-- 3. feladat:

    delete from csapat where id = 21;

-- 4. feladat:

    select nev from versenyzo where nemzetiseg = 'HUN' order by nev;

-- 5. feladat:

    select nemzetiseg, count(*) as "indulokSzama" from versenyzo group by nemzetiseg order by count(*) desc;

-- 6. feladat:

    select szakasz, ido from eredmeny inner join versenyzo on versenyzoId = versenyzo.id where versenyzo.nev = 'Valter Attila';
 
-- 7. feladat:

    select csapatNev, count(nemzetiseg) as magyarokSzama from csapat inner join versenyzo on csapat.id = csapatId where nemzetiseg='HUN' group by csapatNev having count(2) > 1 order by 1;

