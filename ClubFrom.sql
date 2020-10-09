drop database if exists ClubFromage;
create Database ClubFromage;
use ClubFromage;

 

create table Pays(
idPays int,
nom varchar(100),
Primary key (idPays)
)
engine innodb;

 

create table Fromage(
identifiant int auto_increment,
idPays int,
nom varchar(75),
DureeAffinage date,
DateCreation date,
image varchar(255),
recette varchar(4000),
histoire varchar(400),
Primary key (identifiant),
foreign key(idPays) references Pays(idPays)
)
engine innodb;

 

/* create table membre(
Id int auto_increment,
nom_utilisateur varchar(25),
pseudo varchar(50),
email varchar(100),
motPasse varchar(25),
dateDerniereConnexion DateTime,
LeRole varchar(1500),
actif boolean,
Primary key (Id)
)
engine innodb; */

 

/* create table avis(
nombreEtoile int,
texte varchar(2000),
Id_membre int,
id_fromage int,
Primary key (Id_membre, id_fromage),
foreign key(Id_membre) references membre(Id),
foreign key(Id_fromage) references Fromage(Id)
)
engine innodb;*/ 