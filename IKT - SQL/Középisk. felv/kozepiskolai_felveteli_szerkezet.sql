
DROP TABLE IF EXISTS jelentkezes;
CREATE TABLE jelentkezes (
  id int(11) NOT NULL,
  jelentkezoid int(11) NOT NULL,
  kepzesid int(11) NOT NULL,
  sorrend int(11) NOT NULL,
  szerzett int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

DROP TABLE IF EXISTS jelentkezo;
CREATE TABLE jelentkezo (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL,
  nem varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

DROP TABLE IF EXISTS kepzes;
CREATE TABLE kepzes (
  id int(11) NOT NULL,
  nev varchar(100) NOT NULL,
  felveheto int(11) NOT NULL,
  minimum int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;


ALTER TABLE jelentkezes
  ADD PRIMARY KEY (id);

ALTER TABLE jelentkezo
  ADD PRIMARY KEY (id);

ALTER TABLE kepzes
  ADD PRIMARY KEY (id);


ALTER TABLE jelentkezes
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE jelentkezo
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE kepzes
  MODIFY id int(11) NOT NULL AUTO_INCREMENT;
