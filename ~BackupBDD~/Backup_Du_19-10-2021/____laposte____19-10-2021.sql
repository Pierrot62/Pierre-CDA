-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: laposte
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
-- Current Database: `laposte`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `laposte` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `laposte`;

--
-- Table structure for table `acheminements`
--

DROP TABLE IF EXISTS `acheminements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acheminements` (
  `idAcheminement` int(11) NOT NULL AUTO_INCREMENT,
  `idBureau` int(11) DEFAULT NULL,
  `idTransport` int(11) DEFAULT NULL,
  `idCentresDeTri` int(11) DEFAULT NULL,
  PRIMARY KEY (`idAcheminement`),
  KEY `fk_Achemine_Bureaux` (`idBureau`),
  KEY `fk_Achemine_Transports` (`idTransport`),
  KEY `fk_Achemine_Centres_de_tri` (`idCentresDeTri`),
  CONSTRAINT `fk_Achemine_Bureaux` FOREIGN KEY (`idBureau`) REFERENCES `bureaux` (`idBureau`),
  CONSTRAINT `fk_Achemine_Centres_de_tri` FOREIGN KEY (`idCentresDeTri`) REFERENCES `transports` (`idTransport`),
  CONSTRAINT `fk_Achemine_Transports` FOREIGN KEY (`idTransport`) REFERENCES `centres_de_tri` (`idCentresDeTri`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acheminements`
--

LOCK TABLES `acheminements` WRITE;
/*!40000 ALTER TABLE `acheminements` DISABLE KEYS */;
/*!40000 ALTER TABLE `acheminements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bureaux`
--

DROP TABLE IF EXISTS `bureaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bureaux` (
  `idBureau` int(11) NOT NULL AUTO_INCREMENT,
  `codePostal` int(6) DEFAULT NULL,
  PRIMARY KEY (`idBureau`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bureaux`
--

LOCK TABLES `bureaux` WRITE;
/*!40000 ALTER TABLE `bureaux` DISABLE KEYS */;
INSERT INTO `bureaux` VALUES (1,NULL),(2,62200),(3,NULL),(5,62200),(6,62201),(7,62202),(8,62203),(9,62204),(10,62205),(11,62206),(12,62207),(13,62208),(14,62209),(15,62210),(16,62211),(17,62212),(18,62213),(19,62214),(20,62215),(21,62216),(22,62217),(23,55555);
/*!40000 ALTER TABLE `bureaux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `centres_de_tri`
--

DROP TABLE IF EXISTS `centres_de_tri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `centres_de_tri` (
  `idCentresDeTri` int(11) NOT NULL AUTO_INCREMENT,
  `nomCentreDeTri` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idCentresDeTri`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `centres_de_tri`
--

LOCK TABLES `centres_de_tri` WRITE;
/*!40000 ALTER TABLE `centres_de_tri` DISABLE KEYS */;
/*!40000 ALTER TABLE `centres_de_tri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courriers`
--

DROP TABLE IF EXISTS `courriers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courriers` (
  `idCourrier` int(11) NOT NULL AUTO_INCREMENT,
  `rueDestinataire` varchar(150) NOT NULL,
  `numDestintaire` varchar(5) NOT NULL,
  `rueEmetteur` varchar(150) DEFAULT NULL,
  `numEmetteur` varchar(50) DEFAULT NULL,
  `idType` int(11) NOT NULL,
  PRIMARY KEY (`idCourrier`),
  KEY `fk_Courriers_Types` (`idType`),
  CONSTRAINT `fk_Courriers_Types` FOREIGN KEY (`idType`) REFERENCES `types` (`idType`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courriers`
--

LOCK TABLES `courriers` WRITE;
/*!40000 ALTER TABLE `courriers` DISABLE KEYS */;
/*!40000 ALTER TABLE `courriers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `livraisons`
--

DROP TABLE IF EXISTS `livraisons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `livraisons` (
  `idLivraison` int(11) NOT NULL AUTO_INCREMENT,
  `idBureau` int(11) DEFAULT NULL,
  `idCourrier` int(11) DEFAULT NULL,
  `dateEnvoi` date DEFAULT NULL,
  `dateReception` date DEFAULT NULL,
  PRIMARY KEY (`idLivraison`),
  KEY `fk_Gere_Bureaux` (`idBureau`),
  KEY `fk_Gere_Courriers` (`idCourrier`),
  CONSTRAINT `fk_Gere_Bureaux` FOREIGN KEY (`idBureau`) REFERENCES `bureaux` (`idBureau`),
  CONSTRAINT `fk_Gere_Courriers` FOREIGN KEY (`idCourrier`) REFERENCES `courriers` (`idCourrier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livraisons`
--

LOCK TABLES `livraisons` WRITE;
/*!40000 ALTER TABLE `livraisons` DISABLE KEYS */;
/*!40000 ALTER TABLE `livraisons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transports`
--

DROP TABLE IF EXISTS `transports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transports` (
  `idTransport` int(11) NOT NULL AUTO_INCREMENT,
  `libelleTransport` varchar(50) DEFAULT NULL,
  `taxeCarbonne` int(11) DEFAULT NULL,
  PRIMARY KEY (`idTransport`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transports`
--

LOCK TABLES `transports` WRITE;
/*!40000 ALTER TABLE `transports` DISABLE KEYS */;
/*!40000 ALTER TABLE `transports` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `types`
--

DROP TABLE IF EXISTS `types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `types` (
  `idType` int(11) NOT NULL AUTO_INCREMENT,
  `libelleType` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idType`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `types`
--

LOCK TABLES `types` WRITE;
/*!40000 ALTER TABLE `types` DISABLE KEYS */;
/*!40000 ALTER TABLE `types` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-19 12:25:02
