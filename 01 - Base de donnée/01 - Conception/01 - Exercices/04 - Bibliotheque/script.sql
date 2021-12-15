#========================================
#             SCRIPT MYSQL
#========================================

DROP DATABASE IF EXISTS Bibliotheque;
CREATE DATABASE Bibliotheque DEFAULT CHARACTER SET utf8;
USE Bibliotheque;

#========================================
# Table : EtatsReserves
#========================================
CREATE TABLE EtatsReserves(
	IdEtatReserve INT AUTO_INCREMENT PRIMARY KEY ,
	LibelleEtatReserve VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Themes
#========================================
CREATE TABLE Themes(
	IdTheme INT AUTO_INCREMENT PRIMARY KEY ,
	NomTheme VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Auteurs
#========================================
CREATE TABLE Auteurs(
	IdAuteur INT AUTO_INCREMENT PRIMARY KEY ,
	NomAutheur VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Genres
#========================================
CREATE TABLE Genres(
	IdGenre INT AUTO_INCREMENT PRIMARY KEY ,
	NomGenre VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Editeurs
#========================================
CREATE TABLE Editeurs(
	IdEditeur INT AUTO_INCREMENT PRIMARY KEY ,
	NomEditeur VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Usures
#========================================
CREATE TABLE Usures(
	IdUsure INT AUTO_INCREMENT PRIMARY KEY ,
	CodeUsure VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : CategoriesProfessionnelles
#========================================
CREATE TABLE CategoriesProfessionnelles(
	IdCategorieProfessionnelle INT AUTO_INCREMENT PRIMARY KEY ,
	LibelleCategPro VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : MotsCles
#========================================
CREATE TABLE MotsCles(
	IdMotCle INT AUTO_INCREMENT PRIMARY KEY ,
	LibelleMotCle VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Livres
#========================================
CREATE TABLE Livres(
	IdLivre INT AUTO_INCREMENT PRIMARY KEY ,
	TitreLivre VARCHAR(50)  ,
	CodeCatalogue VARCHAR(50)  ,
	IdEditeur INT  NOT NULL ,
	IdTheme INT  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Exemplaires
#========================================
CREATE TABLE Exemplaires(
	IdExemplaire INT AUTO_INCREMENT PRIMARY KEY ,
	DateAcquisition DATE ,
	Disponibilite BOOLEAN ,
	CodeRayon VARCHAR(50) UNIQUE,
	IdUsure INT  NOT NULL ,
	IdLivre INT  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Abonnes
#========================================
CREATE TABLE Abonnes(
	IdAbonne INT AUTO_INCREMENT PRIMARY KEY ,
	MatriculeAbonne VARCHAR(50) UNIQUE ,
	NomAbonne VARCHAR(50)  ,
	AdresseAbonne VARCHAR(50)  ,
	TelephoneAbonne VARCHAR(50)  ,
	DateAdhesion DATE ,
	DateNaissance DATE ,
	IdCategorieProfessionnelle INT  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Reservations
#========================================
CREATE TABLE Reservations(
	idReservations INT AUTO_INCREMENT PRIMARY KEY ,
	IdEtatReserve INT NOT NULL  ,
	IdLivre INT  NOT NULL  ,
	IdAbonne INT  NOT NULL  ,
	DateDebutReservation DATETIME ,
	DateDemandeReservation DATE
)ENGINE = InnoDB;

#========================================
# Table : Definitions
#========================================
CREATE TABLE Definitions(
	idDefinitions INT AUTO_INCREMENT PRIMARY KEY ,
	IdGenre INT  NOT NULL ,
	IdLivre INT  NOT NULL 
)ENGINE = InnoDB;

#========================================
# Table : Compositions
#========================================
CREATE TABLE Compositions(
	idCompositions INT AUTO_INCREMENT PRIMARY KEY ,
	IdAuteur INT  NOT NULL,
	IdLivre INT  NOT NULL 
)ENGINE = InnoDB;

#========================================
# Table : EmpruntExemplaires
#========================================
CREATE TABLE EmpruntExemplaires(
	idEmpruntExemplaires INT AUTO_INCREMENT PRIMARY KEY ,
	IdExemplaire INT  NOT NULL,
	IdAbonne INT  NOT NULL  ,
	DateEmprunt DATETIME ,
	DateRetourEffective DATETIME
)ENGINE = InnoDB;

#========================================
# Table : Identifications
#========================================
CREATE TABLE Identifications(
	idIdentifications INT AUTO_INCREMENT PRIMARY KEY ,
	IdLivre INT NOT NULL,
	IdMotCle INT  NOT NULL 
)ENGINE = InnoDB;


CREATE TABLE Employes(
	idEmploye INT AUTO_INCREMENT PRIMARY KEY ,
	nomEmploye 
)


ALTER TABLE Livres ADD CONSTRAINT FK_Livres_Editeurs FOREIGN KEY(IdEditeur) REFERENCES Editeurs(IdEditeur);
ALTER TABLE Livres ADD CONSTRAINT FK_Livres_Themes FOREIGN KEY(IdTheme) REFERENCES Themes(IdTheme);
ALTER TABLE Exemplaires ADD CONSTRAINT FK_Exemplaires_Usures FOREIGN KEY(IdUsure) REFERENCES Usures(IdUsure);
ALTER TABLE Exemplaires ADD CONSTRAINT FK_Exemplaires_Livres FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre);
ALTER TABLE Abonnes ADD CONSTRAINT FK_Abonnes_CategoriesProfessionnelles FOREIGN KEY(IdCategorieProfessionnelle) REFERENCES CategoriesProfessionnelles(IdCategorieProfessionnelle);
ALTER TABLE Reservations ADD CONSTRAINT FK_Reservations_EtatsReserves FOREIGN KEY(IdEtatReserve) REFERENCES EtatsReserves(IdEtatReserve);
ALTER TABLE Reservations ADD CONSTRAINT FK_Reservations_Livres FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre);
ALTER TABLE Reservations ADD CONSTRAINT FK_Reservations_Abonnes FOREIGN KEY(IdAbonne) REFERENCES Abonnes(IdAbonne);
ALTER TABLE Definitions ADD CONSTRAINT FK_Definitions_Genres FOREIGN KEY(IdGenre) REFERENCES Genres(IdGenre);
ALTER TABLE Definitions ADD CONSTRAINT FK_Definitions_Livres FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre);
ALTER TABLE Compositions ADD CONSTRAINT FK_Compositions_Auteurs FOREIGN KEY(IdAuteur) REFERENCES Auteurs(IdAuteur);
ALTER TABLE Compositions ADD CONSTRAINT FK_Compositions_Livres FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre);
ALTER TABLE EmpruntExemplaires ADD CONSTRAINT FK_EmpruntExemplaires_Exemplaires FOREIGN KEY(IdExemplaire) REFERENCES Exemplaires(IdExemplaire);
ALTER TABLE EmpruntExemplaires ADD CONSTRAINT FK_EmpruntExemplaires_Abonnes FOREIGN KEY(IdAbonne) REFERENCES Abonnes(IdAbonne);
ALTER TABLE Identifications ADD CONSTRAINT FK_Identifications_Livres FOREIGN KEY(IdLivre) REFERENCES Livres(IdLivre);
ALTER TABLE Identifications ADD CONSTRAINT FK_Identifications_MotsCles FOREIGN KEY(IdMotCle) REFERENCES MotsCles(IdMotCle);