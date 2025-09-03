CREATE TABLE szerzo (
  id int,
  nev varchar(33) NOT NULL,
  szulEv int NOT NULL,
  halEv int,
  nemzetiseg varchar(9) NOT NULL,
  CONSTRAINT pk_szerzo PRIMARY KEY (id)
);

CREATE TABLE konyv (
  id int,
  cim varchar(34) NOT NULL,
  szerzoId int NOT NULL,
  helyezes int NOT NULL,
  CONSTRAINT pk_konyv PRIMARY KEY (id),
  CONSTRAINT fk_konyvSzerzo FOREIGN KEY (szerzoId) REFERENCES szerzo(id)
);
