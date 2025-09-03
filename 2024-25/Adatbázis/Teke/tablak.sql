CREATE TABLE egyesuletek (
  id int,
  nev varchar(30) NOT NULL,
  CONSTRAINT pk_egyesuletek PRIMARY KEY (id)
);

CREATE TABLE versenyzok (
  rajtszam int,
  nev varchar(25) NOT NULL,
  egyid int NOT NULL,
  korcsop varchar(1) NOT NULL,
  CONSTRAINT pk_versenyzok PRIMARY KEY (rajtszam),
  CONSTRAINT fk_versenyzok FOREIGN KEY (egyid) REFERENCES egyesuletek(id)
);

CREATE TABLE eredmenyek (
  sorsz int,
  versenyzo int NOT NULL,
  teli int NOT NULL,
  tarolas int NOT NULL,
  ures int NOT NULL,
  CONSTRAINT pk_eredmenyek PRIMARY KEY (sorsz),
  CONSTRAINT fk_eredmenyek FOREIGN KEY (versenyzo) REFERENCES versenyzok(rajtszam)
);

