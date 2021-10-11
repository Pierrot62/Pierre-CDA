#========================================
#             SCRIPT MYSQL
#========================================

DROP DATABASE IF EXISTS immo DEFAULT CHARACTER SET utf8 ;
CREATE DATABASE immo;
USE immo;

#========================================
# Table : agences
#========================================
CREATE TABLE agences(
	id INT ,
	nomAgence VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : communes
#========================================
CREATE TABLE communes(
	id INT ,
	nom VARCHAR(100)  ,
	nombre_habitants BIGINT
)ENGINE = InnoDB;

#========================================
# Table : TypesDeLogement
#========================================
CREATE TABLE TypesDeLogement(
	IdTypeDeLogement INT AUTO_INCREMENT PRIMARY KEY ,
	LibelleTypeLogement VARCHAR(50)  ,
	Charge INT
)ENGINE = InnoDB;

#========================================
# Table : quartiers
#========================================
CREATE TABLE quartiers(
	id INT ,
	nom VARCHAR(100)  ,
	id_1 INT NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : logements
#========================================
CREATE TABLE logements(
	id INT ,
	superficie VARCHAR(50)  ,
	adresse VARCHAR(100)  ,
	loyer INT NOT NULL ,
	IdTypeDeLogement INT  NOT NULL ,
	id_1 INT NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : signataires
#========================================
CREATE TABLE signataires(
	id INT ,
	nom VARCHAR(50)  ,
	prenom VARCHAR(50)  ,
	date_de_naissance DATE ,
	telephone INT ,
	id_1 INT NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : travaille
#========================================
CREATE TABLE travaille(
	idtravaille INT AUTO_INCREMENT PRIMARY KEY ,	id INT ,
	id_1 INT ,
	distance INT
)ENGINE = InnoDB;

#========================================
# Table : contacte
#========================================
CREATE TABLE contacte(
	idcontacte INT AUTO_INCREMENT PRIMARY KEY ,	id INT ,
	id_1 INT
)ENGINE = InnoDB;

ALTER TABLE quartiers ADD CONSTRAINT FK_quartiers_communes FOREIGN KEY(id_1) REFERENCES communes(id);
ALTER TABLE logements ADD CONSTRAINT FK_logements_TypesDeLogement FOREIGN KEY(IdTypeDeLogement) REFERENCES TypesDeLogement(IdTypeDeLogement);
ALTER TABLE logements ADD CONSTRAINT FK_logements_quartiers FOREIGN KEY(id_1) REFERENCES quartiers(id);
ALTER TABLE signataires ADD CONSTRAINT FK_signataires_logements FOREIGN KEY(id_1) REFERENCES logements(id);
ALTER TABLE travaille ADD CONSTRAINT FK_travaille_agences FOREIGN KEY(id) REFERENCES agences(id);
ALTER TABLE travaille ADD CONSTRAINT FK_travaille_communes FOREIGN KEY(id_1) REFERENCES communes(id);
ALTER TABLE contacte ADD CONSTRAINT FK_contacte_signataires FOREIGN KEY(id) REFERENCES signataires(id);
ALTER TABLE contacte ADD CONSTRAINT FK_contacte_agences FOREIGN KEY(id_1) REFERENCES agences(id);