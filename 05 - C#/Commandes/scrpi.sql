DROP DATABASE IF EXISTS GestionCommande;
CREATE DATABASE GestionCommande DEFAULT CHARACTER SET utf8;
USE GestionCommande;

CREATE TABLE Produits(
   IdProduit INT(11) PRIMARY KEY AUTO_INCREMENT,
   LibelleProduit VARCHAR(50) NOT NULL,
   PrixProduit DECIMAL(15,2) NOT NULL,
   QuantiteProduit INT NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Commandes(
   IdCommande INT(11) PRIMARY KEY AUTO_INCREMENT,
   DateCommande DATE NOT NULL,
   NumeroCommande INT NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Preparations(
   IdPreparation INT(11) PRIMARY KEY AUTO_INCREMENT,
   IdProduit INT(11) NOT NULL ,
   IdCommande INT NOT NULL ,
   DatePreparation DATE NOT NULL
)ENGINE=InnoDB;

ALTER TABLE Preparations ADD CONSTRAINT FK_Produits_Preparatation FOREIGN KEY (idProduit) REFERENCES Produits(idProduit);
ALTER TABLE Preparations ADD CONSTRAINT FK_Commandes_Preparatation FOREIGN KEY (idCommande) REFERENCES Commandes(idCommande);