DROP DATABASE IF EXISTS LaPoste;
CREATE DATABASE LaPoste;
USE LaPoste;

CREATE TABLE Bureaux(
   idBureau INT AUTO_INCREMENT PRIMARY KEY,
   codePostal VARCHAR(6)
)ENGINE=InnoDB;

CREATE TABLE Types(
   idType INT AUTO_INCREMENT PRIMARY KEY,
   libelleType VARCHAR(50)
)ENGINE=InnoDB;


CREATE TABLE Courriers(
   idCourrier INT AUTO_INCREMENT PRIMARY KEY,
   rueDestinataire VARCHAR(150)  NOT NULL,
   numDestintaire VARCHAR(5)  NOT NULL,
   rueEmetteur VARCHAR(150) ,
   numEmetteur VARCHAR(50) ,
   idType INT NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Transports(
   idTransport INT AUTO_INCREMENT PRIMARY KEY,
   libelleTransport VARCHAR(50) ,
   taxeCarbonne INT
)ENGINE=InnoDB;

CREATE TABLE Centres_de_tri(
   idCentresDeTri INT AUTO_INCREMENT PRIMARY KEY,
   nomCentreDeTri VARCHAR(50)
)ENGINE=InnoDB;

CREATE TABLE Acheminements(
   idAcheminement INT AUTO_INCREMENT PRIMARY KEY,
   idBureau INT,
   idTransport INT,
   idCentresDeTri INT
)ENGINE=InnoDB;


CREATE TABLE Livraisons(
   idLivraison INT AUTO_INCREMENT PRIMARY KEY,
   idBureau INT,
   idCourrier INT,
   dateEnvoi DATE,
   dateReception DATE
)ENGINE=InnoDB;

ALTER TABLE Courriers ADD CONSTRAINT fk_Courriers_Types FOREIGN KEY (idType) REFERENCES Types(idType);

ALTER TABLE Acheminements ADD CONSTRAINT fk_Achemine_Bureaux FOREIGN KEY (idBureau) REFERENCES Bureaux(idBureau);
ALTER TABLE Acheminements ADD CONSTRAINT fk_Achemine_Transports FOREIGN KEY (idTransport) REFERENCES Centres_de_tri(idCentresDeTri);
ALTER TABLE Acheminements ADD CONSTRAINT fk_Achemine_Centres_de_tri FOREIGN KEY (idCentresDeTri) REFERENCES Transports(idTransport);

ALTER TABLE Livraisons ADD CONSTRAINT fk_Gere_Bureaux FOREIGN KEY (idBureau) REFERENCES Bureaux(idBureau);
ALTER TABLE Livraisons ADD CONSTRAINT fk_Gere_Courriers FOREIGN KEY (idCourrier) REFERENCES Courriers(idCourrier);
