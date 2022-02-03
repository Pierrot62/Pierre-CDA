DROP DATABASE IF EXISTS Automate;
CREATE DATABASE Automate DEFAULT CHARACTER SET utf8;
Use Automate;
--
-- Table  'Afpa_Seuils'
--


CREATE TABLE Afpa_Seuils(
   IdSeuil INT AUTO_INCREMENT PRIMARY KEY,
   SeuilBas FLOAT NOT NULL,
   SeuilHaut FLOAT NOT NULL,
   DateSeuil DATE NOT NULL,
   Temps INT NOT NULL,
   Nature INT NOT NULL
)ENGINE=InnoDB;


--
-- Table  'Afpa_Temperatures'
--


CREATE TABLE Afpa_Temperatures(
   IdTemperature INT AUTO_INCREMENT PRIMARY KEY,
   ValeurTemperature FLOAT NOT NULL,
   DateTemperature DATETIME NOT NULL
)ENGINE=InnoDB;


--
-- Table  'Afpa_Sons'
--


CREATE TABLE Afpa_Sons(
   IdSon INT AUTO_INCREMENT PRIMARY KEY,
   ValeurSon FLOAT NOT NULL,
   DateSon DATETIME NOT NULL
)ENGINE=InnoDB;


--
-- Table  'Afpa_Lumieres'
--


CREATE TABLE Afpa_Lumieres(
   IdLumiere INT AUTO_INCREMENT PRIMARY KEY,
   ValeurLumiere FLOAT NOT NULL,
   DateLumiere DATETIME NOT NULL
)ENGINE=InnoDB;

--
-- Table  'Afpa_Couleurs'
--


CREATE TABLE Afpa_Couleurs(
   IdCouleur INT AUTO_INCREMENT PRIMARY KEY,
   Red INT NOT NULL,
   Green INT NOT NULL,
   Blue INT NOT NULL
)ENGINE=InnoDB;


--
-- Table  'Afpa_Erreurs'
--


CREATE TABLE Afpa_Erreurs(
   IdErreur INT AUTO_INCREMENT PRIMARY KEY,
   MessageErreur TEXT NOT NULL
 
)ENGINE=InnoDB;

--
-- Table  'Afpa_Objectifs'
--


CREATE TABLE Afpa_Objectifs(
   IdObjectif INT AUTO_INCREMENT PRIMARY KEY,
   Rendement INT NOT NULL,
   MaxNombreArretTemperature INT NOT NULL,
   MaxNombreArretDecibel INT NOT NULL,
   MaxPourcentDeclasses INT NOT NULL,
   Date DATETIME NOT NULL
)ENGINE=InnoDB;

--
-- Table  'Afpa_Cadences'
--


CREATE TABLE Afpa_Cadences(
   IdCadence INT AUTO_INCREMENT PRIMARY KEY,
   NbProduit INT NOT NULL,
   DateCadence DATETIME NOT NULL
)ENGINE=InnoDB;


--
-- Table  'Afpa_Anomalies'
--


CREATE TABLE Afpa_Anomalies(
   IdAnomalie INT AUTO_INCREMENT PRIMARY KEY,
   DateAnomalie DATETIME NOT NULL,
   TypeAnomalie VARCHAR(50) NOT NULL,
   NbDeclasses INT NOT NULL,
   IdErreur INT NOT NULL
  
)ENGINE=InnoDB;


ALTER TABLE Afpa_Anomalies 
ADD CONSTRAINT Afpa_Anomalies_Afpa_Erreurs FOREIGN KEY(IdErreur) REFERENCES Afpa_Erreurs(IdErreur);




INSERT INTO `afpa_couleurs` (`IdCouleur`, `Red`, `Green`, `Blue`) VALUES
(1, 198, 8, 0),
(2, 158, 253, 56),
(3, 254, 27, 0);

INSERT INTO `afpa_erreurs` (`IdErreur`, `MessageErreur`) VALUES
(1, 'Luminosité trop basse '),
(2, 'Son trop haut '),
(3, 'Luminosité trop haute'),
(4, 'Son trop bas'),
(5, 'Température trop élevé. '),
(6, 'Température trop basse. '),
(7, 'Son ne fonctionne pas '),
(8, 'Lumière ne fonctionne pas '),
(9, 'Température ne fonctionne pas '),
(10, 'Lumière saccadée '),
(11, 'Son grésillement '),
(12, 'Température Instable');

INSERT INTO `afpa_lumieres` (`IdLumiere`, `ValeurLumiere`, `DateLumiere`) VALUES
(1, 350, '2022-02-02 14:08:16'),
(2, 120, '2022-02-01 14:08:16');


INSERT INTO `afpa_seuils` (`IdSeuil`, `SeuilBas`, `SeuilHaut`, `DateSeuil`, `Temps`,`Nature`) VALUES
(1, 10, 30, '2022-02-01', 1,3),
(2, 73, 80, '2022-02-02', 2,2),
(3, 21, 23, '2022-02-25', 1,1);

INSERT INTO `afpa_sons` (`IdSon`, `ValeurSon`, `DateSon`) VALUES
(1, 120, '2022-02-01 13:58:44'),
(2, 100, '2022-02-02 13:58:44');

INSERT INTO `afpa_temperatures` (`IdTemperature`, `ValeurTemperature`, `DateTemperature`) VALUES
(1, '21.0', '2022-02-01 13:57:57'),
(2, '-3.0', '2022-02-01 14:57:57');


INSERT INTO `afpa_objectifs` (`IdObjectif`, `Rendement`, `MaxNombreArretTemperature`,`MaxNombreArretDecibel`,`MaxPourcentDeclasses`, `Date`) VALUES
(1, 100, 4,5,60, '2022-02-15 10:00:00' ),
(2, 200, 5,4,70, '2022-02-25 10:00:00');

INSERT INTO `afpa_cadences` (`IdCadence`, `NbProduit`, `DateCadence`) VALUES
(1, 100, '2022-02-01 14:20:30'),
(2, 150, '2022-02-01 14:22:30');


INSERT INTO `afpa_anomalies` (`IdAnomalie`, `DateAnomalie`, `TypeAnomalie`,`NbDeclasses`, `IdErreur`) VALUES
(1, '2022-02-01 14:20:30', 'Lumière ',10, 3),
(2, '2022-02-01 14:21:52', 'Son',10, 2);

CREATE TABLE IF NOT EXISTS Afpa_Utilisateurs (
idUtilisateur int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
nom varchar(50) NOT NULL,
prenom varchar(50) NOT NULL,
adresseMail varchar(50) UNIQUE NOT NULL,
motDePasse varchar(50) NOT NULL,
role int(11) NOT NULL COMMENT '2 Admin 1 User'
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

CREATE TABLE IF NOT EXISTS Afpa_Textes (
idTexte int (11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
codeTexte varchar (50) NOT NULL,
fr LONGTEXT NOT NULL,
en LONGTEXT NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET = utf8;

INSERT INTO `Afpa_Textes` (`idTexte`, `codeTexte`, `FR`, `EN`) VALUES (NULL, 'Bonjour', 'Bonjour', 'Hello') ,  
(NULL, 'Connexion', 'Connexion', 'Log in') ,
(NULL, 'Deconnexion', 'Deconnexion', 'Log out') ,
(NULL, 'Accueil', 'Accueil', 'Home') ,
(NULL, 'AdresseEmail', 'Adresse email', 'Email address') , 
(NULL, 'Mdp', 'Mot de passe', 'Password') ,
(NULL, 'Inscription', 'Inscription', 'Registration') , 
(NULL, 'Nom', 'Nom', 'Surname'), 
(NULL, 'Prenom', 'Prenom', 'Name'), 
(NULL, 'InfoMdpLegend', 'Veuillez saisir au moins', 'Please enter at least'), 
(NULL, 'UneMajuscule', '1 majuscule', '1 uppercase'), 
(NULL, 'UneMinuscule', '1 minuscule', '1 lowercase'), 
(NULL, 'UnChiffre', '1 chiffre', '1 number'), 
(NULL, 'UnCaractereSpecial', '1 caractère spécial ( ! @ & # * ^ $ % +)', '1 special character ( ! @ & # * ^ $ % +)'), 
(NULL, 'MinimumCaractere', '8 caractères', '8 character'), 
(NULL, 'Confirmation', 'Confirmation', 'Confirmation'), 
(NULL, 'Reset', 'Réinitialisation', 'Reset'), 
(NULL, 'Envoyer', 'Envoyer', 'Send'); 