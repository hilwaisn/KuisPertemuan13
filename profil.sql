CREATE DATABASE profil;
USE profil;

CREATE TABLE pegawai(
Id INT PRIMARY KEY,
Nama VARCHAR(32),
Alamat VARCHAR(32),
Agama VARCHAR(20),
Umur INT
);

INSERT INTO pegawai VALUES
(12345,	"Imran Sialoho",	"Balige",	"Islam",	20),
(12346,	"Yanti Nurhayati",	"Ciamis",	"Hindu",	21),
(12347,	"Fadli Ariansyah",	"Sipirok",	"Kristen",	19),
(12348,	"Arya Duta",		"Bandung",	"Kristen",	18),
(12349,	"Tisatun Riza",		"Banjar",	"Hindu",	20),
(12350,	"Sandi Andrian",	"Sibolga",	"Islam",	19),
(12351,	"Hilwa Isnaini",	"Salatiga",	"Islam",	20);