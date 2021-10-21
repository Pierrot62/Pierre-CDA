-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: noel
-- ------------------------------------------------------
-- Server version	5.7.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `noel`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `noel` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `noel`;

--
-- Table structure for table `cadeaux`
--

DROP TABLE IF EXISTS `cadeaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cadeaux` (
  `Id_Cadeaux` int(11) NOT NULL AUTO_INCREMENT,
  `designationCadeau` varchar(100) NOT NULL,
  `Id_Enfants` int(11) NOT NULL,
  PRIMARY KEY (`Id_Cadeaux`),
  KEY `FK_Cadeaux_Enfants` (`Id_Enfants`),
  CONSTRAINT `FK_Cadeaux_Enfants` FOREIGN KEY (`Id_Enfants`) REFERENCES `enfants` (`Id_Enfants`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadeaux`
--

LOCK TABLES `cadeaux` WRITE;
/*!40000 ALTER TABLE `cadeaux` DISABLE KEYS */;
/*!40000 ALTER TABLE `cadeaux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enfants`
--

DROP TABLE IF EXISTS `enfants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enfants` (
  `Id_Enfants` int(11) NOT NULL AUTO_INCREMENT,
  `nomEnfant` varchar(50) NOT NULL,
  `prenomEnfant` varchar(50) NOT NULL,
  `adresseEnfant` varchar(50) NOT NULL,
  `voeuEnfant` varchar(50) NOT NULL,
  `sagesseEnfant` int(11) NOT NULL,
  `Id_Sexes` int(11) NOT NULL,
  PRIMARY KEY (`Id_Enfants`),
  KEY `FK_Enfants_Sexes` (`Id_Sexes`),
  CONSTRAINT `FK_Enfants_Sexes` FOREIGN KEY (`Id_Sexes`) REFERENCES `sexes` (`Id_Sexes`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfants`
--

LOCK TABLES `enfants` WRITE;
/*!40000 ALTER TABLE `enfants` DISABLE KEYS */;
/*!40000 ALTER TABLE `enfants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historique`
--

DROP TABLE IF EXISTS `historique`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historique` (
  `Id_Traineaux` int(11) NOT NULL AUTO_INCREMENT,
  `idResponsabilite` int(11) NOT NULL,
  `dateResponsabilite` date NOT NULL,
  `Id_Lutins` int(11) NOT NULL,
  PRIMARY KEY (`Id_Traineaux`),
  UNIQUE KEY `idResponsabilite` (`idResponsabilite`),
  KEY `FK_historique_Lutins` (`Id_Lutins`),
  CONSTRAINT `FK_historique_Lutins` FOREIGN KEY (`Id_Lutins`) REFERENCES `lutins` (`Id_Lutins`),
  CONSTRAINT `FK_historique_Traineaux` FOREIGN KEY (`Id_Traineaux`) REFERENCES `traineaux` (`Id_Traineaux`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historique`
--

LOCK TABLES `historique` WRITE;
/*!40000 ALTER TABLE `historique` DISABLE KEYS */;
/*!40000 ALTER TABLE `historique` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lutins`
--

DROP TABLE IF EXISTS `lutins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lutins` (
  `Id_Lutins` int(11) NOT NULL AUTO_INCREMENT,
  `nomLutin` varchar(50) NOT NULL,
  `prenomLutin` varchar(50) NOT NULL,
  PRIMARY KEY (`Id_Lutins`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lutins`
--

LOCK TABLES `lutins` WRITE;
/*!40000 ALTER TABLE `lutins` DISABLE KEYS */;
/*!40000 ALTER TABLE `lutins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rennes`
--

DROP TABLE IF EXISTS `rennes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rennes` (
  `Id_Rennes` int(11) NOT NULL AUTO_INCREMENT,
  `nomParticulierRenne` varchar(50) NOT NULL,
  `DDNRenne` varchar(50) NOT NULL,
  `Id_Sexes` int(11) NOT NULL,
  PRIMARY KEY (`Id_Rennes`),
  KEY `FK_Rennes_Sexes` (`Id_Sexes`),
  CONSTRAINT `FK_Rennes_Sexes` FOREIGN KEY (`Id_Sexes`) REFERENCES `sexes` (`Id_Sexes`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rennes`
--

LOCK TABLES `rennes` WRITE;
/*!40000 ALTER TABLE `rennes` DISABLE KEYS */;
/*!40000 ALTER TABLE `rennes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sexes`
--

DROP TABLE IF EXISTS `sexes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sexes` (
  `Id_Sexes` int(11) NOT NULL AUTO_INCREMENT,
  `libelleSexe` varchar(10) NOT NULL,
  PRIMARY KEY (`Id_Sexes`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sexes`
--

LOCK TABLES `sexes` WRITE;
/*!40000 ALTER TABLE `sexes` DISABLE KEYS */;
/*!40000 ALTER TABLE `sexes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tounees`
--

DROP TABLE IF EXISTS `tounees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tounees` (
  `idTounees` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Lutins` int(11) NOT NULL,
  `Id_Traineaux` int(11) NOT NULL,
  `Id_Cadeaux` int(11) NOT NULL,
  `Id_Rennes` int(11) NOT NULL,
  `numTournee` int(11) NOT NULL,
  `heureDepart` time NOT NULL,
  PRIMARY KEY (`idTounees`),
  UNIQUE KEY `numTournee` (`numTournee`),
  KEY `FK_Tounees_Lutins` (`Id_Lutins`),
  KEY `FK_Tounees_Traineaux` (`Id_Traineaux`),
  KEY `FK_Tounees_Cadeaux` (`Id_Cadeaux`),
  KEY `FK_Tounees_Rennes` (`Id_Rennes`),
  CONSTRAINT `FK_Tounees_Cadeaux` FOREIGN KEY (`Id_Cadeaux`) REFERENCES `cadeaux` (`Id_Cadeaux`),
  CONSTRAINT `FK_Tounees_Lutins` FOREIGN KEY (`Id_Lutins`) REFERENCES `lutins` (`Id_Lutins`),
  CONSTRAINT `FK_Tounees_Rennes` FOREIGN KEY (`Id_Rennes`) REFERENCES `rennes` (`Id_Rennes`),
  CONSTRAINT `FK_Tounees_Traineaux` FOREIGN KEY (`Id_Traineaux`) REFERENCES `traineaux` (`Id_Traineaux`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tounees`
--

LOCK TABLES `tounees` WRITE;
/*!40000 ALTER TABLE `tounees` DISABLE KEYS */;
/*!40000 ALTER TABLE `tounees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `traineaux`
--

DROP TABLE IF EXISTS `traineaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `traineaux` (
  `Id_Traineaux` int(11) NOT NULL AUTO_INCREMENT,
  `tailleTraineau` int(11) NOT NULL,
  `dateMiseEnServiceTraineau` date NOT NULL,
  `dateDerniereRevisionTraineau` date NOT NULL,
  PRIMARY KEY (`Id_Traineaux`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `traineaux`
--

LOCK TABLES `traineaux` WRITE;
/*!40000 ALTER TABLE `traineaux` DISABLE KEYS */;
/*!40000 ALTER TABLE `traineaux` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-21 17:20:01
