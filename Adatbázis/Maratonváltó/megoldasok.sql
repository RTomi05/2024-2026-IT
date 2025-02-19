A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat:

    -

3. feladat:

    insert into eredmenyek values(1044, 4, 15765);

4. feladat:

    select fnev as futo, szulev from futok where ffi=0 order by fnev;

5. feladat:

    select fnev as futo, 2016-szulev as kor from futok where 2016-szulev >= 42 order by szulev,szulho;

6. feladat:

    select fnev, ido from futok inner join eredmenyek on fid = futo where ffi order by ido asc limit 10;

7. feladat:

    select csapat, sum(ido) as csapatido from futok inner join eredmenyek on fid = futo group by csapat order by csapatido;

