#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------

#------------------------------------------------------------
# Table: TypesEnvoie
#------------------------------------------------------------

DROP TABLE IF EXISTS TypesEnvoie
CREATE TABLE TypesEnvoie(
   IdTypeEnvoie INT AUTO_INCREMENT,
   LibelleEnvoie VARCHAR(50) ,
   PRIMARY KEY(IdTypeEnvoie)
);

ALTER TABLE TypesEnvoie ENGINE = InnoDB;
ALTER TABLE TypesEnvoie CHARSET = UTF8;


#------------------------------------------------------------
# Table: BureauxDePostes
#------------------------------------------------------------

DROP TABLE IF EXISTS BureauxDePostes
CREATE TABLE BureauxDePostes(
   IdBureauDePoste INT AUTO_INCREMENT,
   CpBureau INT,
   PRIMARY KEY(IdBureauDePoste)
);

ALTER TABLE BureauxDePostes ENGINE = InnoDB;
ALTER TABLE BureauxDePostes CHARSET = UTF8;


#------------------------------------------------------------
# Table: Transports
#------------------------------------------------------------

DROP TABLE IF EXISTS Transports
CREATE TABLE Transports(
   IdTransport INT AUTO_INCREMENT,
   LibelleTransport VARCHAR(50) ,
   ValeurTaxeCarbone DECIMAL(15,2)  ,
   PRIMARY KEY(IdTransport)
);

ALTER TABLE Transports ENGINE = InnoDB;
ALTER TABLE Transports CHARSET = UTF8;


#------------------------------------------------------------
# Table: CentreDeTri
#------------------------------------------------------------

DROP TABLE IF EXISTS CentreDeTri
CREATE TABLE CentreDeTri(
   IdCentreDeTri INT AUTO_INCREMENT,
   PRIMARY KEY(IdCentreDeTri)
);

ALTER TABLE CentreDeTri ENGINE = InnoDB;
ALTER TABLE CentreDeTri CHARSET = UTF8;


#------------------------------------------------------------
# Table: Destinataires
#------------------------------------------------------------

DROP TABLE IF EXISTS Destinataires
CREATE TABLE Destinataires(
   IdDestinataire INT AUTO_INCREMENT,
   RueDestinataire VARCHAR(50)  NOT NULL,
   NumeroRueDestinataire INT NOT NULL,
   AdresseEmetteur VARCHAR(50) ,
   NumeroRueEmetteur INT,
   DateEnvoie DATE,
   DateReception DATE,
   IdBureauDePoste INT NOT NULL,
   PRIMARY KEY(IdDestinataire),
   FOREIGN KEY(IdBureauDePoste) REFERENCES BureauxDePostes(IdBureauDePoste)
);

ALTER TABLE Destinataires ENGINE = InnoDB;
ALTER TABLE Destinataires CHARSET = UTF8;


#------------------------------------------------------------
# Table: recois
#------------------------------------------------------------

DROP TABLE IF EXISTS recois
CREATE TABLE recois(
   IdDestinataire INT,
   IdTypeEnvoie INT,
   PRIMARY KEY(IdDestinataire, IdTypeEnvoie),
   FOREIGN KEY(IdDestinataire) REFERENCES Destinataires(IdDestinataire),
   FOREIGN KEY(IdTypeEnvoie) REFERENCES TypesEnvoie(IdTypeEnvoie)
);

ALTER TABLE recois ENGINE = InnoDB;
ALTER TABLE recois CHARSET = UTF8;


#------------------------------------------------------------
# Table: relis
#------------------------------------------------------------

DROP TABLE IF EXISTS relis
CREATE TABLE relis(
   IdBureauDePoste INT,
   IdTransport INT,
   IdCentreDeTri INT,
   PRIMARY KEY(IdBureauDePoste, IdTransport, IdCentreDeTri),
   FOREIGN KEY(IdBureauDePoste) REFERENCES BureauxDePostes(IdBureauDePoste),
   FOREIGN KEY(IdTransport) REFERENCES Transports(IdTransport),
   FOREIGN KEY(IdCentreDeTri) REFERENCES CentreDeTri(IdCentreDeTri)
);

ALTER TABLE relis ENGINE = InnoDB;
ALTER TABLE relis CHARSET = UTF8;
