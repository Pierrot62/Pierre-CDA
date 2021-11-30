-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: aeroport
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
-- Current Database: `aeroport`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `aeroport` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `aeroport`;

--
-- Table structure for table `avions`
--

DROP TABLE IF EXISTS `avions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `avions` (
  `IdAvion` int(11) NOT NULL AUTO_INCREMENT,
  `Compagnie` varchar(200) DEFAULT NULL,
  `Type` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdAvion`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `avions`
--

LOCK TABLES `avions` WRITE;
/*!40000 ALTER TABLE `avions` DISABLE KEYS */;
INSERT INTO `avions` VALUES (2,'test','dfsdf');
/*!40000 ALTER TABLE `avions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pilotes`
--

DROP TABLE IF EXISTS `pilotes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pilotes` (
  `IdPilote` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(100) DEFAULT NULL,
  `Prenom` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdPilote`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pilotes`
--

LOCK TABLES `pilotes` WRITE;
/*!40000 ALTER TABLE `pilotes` DISABLE KEYS */;
/*!40000 ALTER TABLE `pilotes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trajets`
--

DROP TABLE IF EXISTS `trajets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trajets` (
  `IdTrajet` int(11) NOT NULL AUTO_INCREMENT,
  `AeroportArrivee` varchar(200) DEFAULT NULL,
  `AeroportDepart` varchar(200) DEFAULT NULL,
  `DureeVol` time DEFAULT NULL,
  PRIMARY KEY (`IdTrajet`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trajets`
--

LOCK TABLES `trajets` WRITE;
/*!40000 ALTER TABLE `trajets` DISABLE KEYS */;
/*!40000 ALTER TABLE `trajets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vols`
--

DROP TABLE IF EXISTS `vols`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vols` (
  `IdVol` int(11) NOT NULL AUTO_INCREMENT,
  `IdPilote` int(11) DEFAULT NULL,
  `IdTrajet` int(11) DEFAULT NULL,
  `IdAvion` int(11) DEFAULT NULL,
  `DateVol` datetime DEFAULT NULL,
  PRIMARY KEY (`IdVol`),
  KEY `FK_Vols_Pilotes` (`IdPilote`),
  KEY `FK_Vols_Avions` (`IdAvion`),
  KEY `FK_Vols_Trajets` (`IdTrajet`),
  CONSTRAINT `FK_Vols_Avions` FOREIGN KEY (`IdAvion`) REFERENCES `avions` (`IdAvion`),
  CONSTRAINT `FK_Vols_Pilotes` FOREIGN KEY (`IdPilote`) REFERENCES `pilotes` (`IdPilote`),
  CONSTRAINT `FK_Vols_Trajets` FOREIGN KEY (`IdTrajet`) REFERENCES `trajets` (`IdTrajet`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vols`
--

LOCK TABLES `vols` WRITE;
/*!40000 ALTER TABLE `vols` DISABLE KEYS */;
/*!40000 ALTER TABLE `vols` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-30 12:22:45
