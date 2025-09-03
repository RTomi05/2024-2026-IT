-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:

    select vnev from varos where megyeid in (select megyeid from megye inner join varos on megyeid=megye.id where vnev like"%vásár%") and vnev not like "%vásár%";

-- 2. feladat:

    select vnev from varos where nepesseg + 1000 in (select nepesseg from varos);

-- 3. feladat:

    select vnev, nepesseg from varos where abs(nepesseg-(select nepesseg from varos where vnev ='Nagyatád'))<50 and vnev != 'Nagyatád';

-- 4. feladat:

   select vnev from varos where vtipid in (select vtipid from varos where vtipid=vtipid and megyeid = megyeid and vnev!=vnev);


