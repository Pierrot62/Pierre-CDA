#========================================
#             SCRIPT MYSQL
#========================================

DROP DATABASE IF EXISTS Noel;
CREATE DATABASE Noel;
USE Noel;

#========================================
# Table : Lutins
#========================================
CREATE TABLE Lutins(
	Id_Lutins INT AUTO_INCREMENT PRIMARY KEY ,
	nomLutin VARCHAR(50)  NOT NULL ,
	prenomLutin VARCHAR(50) NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Traineaux
#========================================
CREATE TABLE Traineaux(
	Id_Traineaux INT AUTO_INCREMENT PRIMARY KEY ,
	tailleTraineau INT  NOT NULL,
	dateMiseEnServiceTraineau DATE  NOT NULL,
	dateDerniereRevisionTraineau DATE NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Sexes
#========================================
CREATE TABLE Sexes(
	Id_Sexes INT AUTO_INCREMENT PRIMARY KEY ,
	libelleSexe VARCHAR(10) NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Enfants
#========================================
CREATE TABLE Enfants(
	Id_Enfants INT AUTO_INCREMENT PRIMARY KEY ,
	nomEnfant VARCHAR(50) NOT NULL ,
	prenomEnfant VARCHAR(50) NOT NULL ,
	adresseEnfant VARCHAR(50) NOT NULL ,
	voeuEnfant VARCHAR(50) NOT NULL ,
	sagesseEnfant INT NOT NULL ,
	Id_Sexes INT  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Cadeaux
#========================================
CREATE TABLE Cadeaux(
	Id_Cadeaux INT AUTO_INCREMENT PRIMARY KEY ,
	designationCadeau VARCHAR(100) NOT NULL ,
	Id_Enfants INT  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Rennes
#========================================
CREATE TABLE Rennes(
	Id_Rennes INT AUTO_INCREMENT PRIMARY KEY ,
	nomParticulierRenne VARCHAR(50) NOT NULL ,
	DDNRenne VARCHAR(50) NOT NULL ,
	Id_Sexes INT  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : historique
#========================================
CREATE TABLE historique(
	Id_Traineaux INT AUTO_INCREMENT PRIMARY KEY ,
	idResponsabilite INT NOT NULL UNIQUE ,
	dateResponsabilite DATE NOT NULL,
	Id_Lutins INT  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Tounees
#========================================
CREATE TABLE Tounees(
	idTounees INT AUTO_INCREMENT PRIMARY KEY ,
	Id_Lutins INT  NOT NULL ,
	Id_Traineaux INT  NOT NULL ,
	Id_Cadeaux INT  NOT NULL ,
	Id_Rennes INT  NOT NULL ,
	numTournee INT UNIQUE  NOT NULL,
	heureDepart TIME NOT NULL
)ENGINE = InnoDB;

ALTER TABLE Enfants ADD CONSTRAINT FK_Enfants_Sexes FOREIGN KEY(Id_Sexes) REFERENCES Sexes(Id_Sexes);
ALTER TABLE Cadeaux ADD CONSTRAINT FK_Cadeaux_Enfants FOREIGN KEY(Id_Enfants) REFERENCES Enfants(Id_Enfants);
ALTER TABLE Rennes ADD CONSTRAINT FK_Rennes_Sexes FOREIGN KEY(Id_Sexes) REFERENCES Sexes(Id_Sexes);
ALTER TABLE historique ADD CONSTRAINT FK_historique_Traineaux FOREIGN KEY(Id_Traineaux) REFERENCES Traineaux(Id_Traineaux);
ALTER TABLE historique ADD CONSTRAINT FK_historique_Lutins FOREIGN KEY(Id_Lutins) REFERENCES Lutins(Id_Lutins);
ALTER TABLE Tounees ADD CONSTRAINT FK_Tounees_Lutins FOREIGN KEY(Id_Lutins) REFERENCES Lutins(Id_Lutins);
ALTER TABLE Tounees ADD CONSTRAINT FK_Tounees_Traineaux FOREIGN KEY(Id_Traineaux) REFERENCES Traineaux(Id_Traineaux);
ALTER TABLE Tounees ADD CONSTRAINT FK_Tounees_Cadeaux FOREIGN KEY(Id_Cadeaux) REFERENCES Cadeaux(Id_Cadeaux);
ALTER TABLE Tounees ADD CONSTRAINT FK_Tounees_Rennes FOREIGN KEY(Id_Rennes) REFERENCES Rennes(Id_Rennes);