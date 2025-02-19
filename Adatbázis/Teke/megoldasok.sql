A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat:

    create database teke default character set=utf8 collate=utf8_hungarian_ci;

3. feladat:

    select nev from versenyzok where korcsop='A' order by nev;

4. feladat:

    select versenyzo from eredmenyek where ures!=0 group by versenyzo;

5. feladat:

    select nev, avg(tarolas) as atlagpont from eredmenyek inner join versenyzok on rajtszam=versenyzo group by nev order by 2 desc;

6. feladat:

    select egyesuletek.nev from egyesuletek inner join versenyzok on egyid=id group by egyesuletek.nev order by count(egyesuletek.nev) desc limit 1;

7. feladat:

    select nev, sum(teli+tarolas) as eredmeny, sum(tarolas) as tarolas, sum(ures) as ures from versenyzok inner join eredmenyek on versenyzo=rajtszam group by nev order by 2 desc, 3 desc, 4 asc;
