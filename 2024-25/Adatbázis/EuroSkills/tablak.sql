CREATE TABLE szakma (
  id varchar(2),
  szakmaNev varchar(31) NOT NULL,
  CONSTRAINT pk_szakma PRIMARY KEY (id)
);

CREATE TABLE orszag (
  id varchar(2),
  orszagNev varchar(31) NOT NULL,
  CONSTRAINT pk_orszag PRIMARY KEY (id)
);

CREATE TABLE versenyzo (
  id int,
  nev varchar(31) NOT NULL,
  szakmaId varchar(2) NOT NULL,
  orszagId varchar(2) NOT NULL,
  pont int NOT NULL,
  CONSTRAINT pk_versenyzo PRIMARY KEY (id),
  CONSTRAINT fk_versenyzoSzakma FOREIGN KEY (szakmaId) REFERENCES szakma(id),
  CONSTRAINT fk_versenyzoOrszag FOREIGN KEY (orszagId) REFERENCES orszag(id)
);
