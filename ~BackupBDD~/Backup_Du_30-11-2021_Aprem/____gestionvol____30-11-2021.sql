-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: gestionvol
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
-- Current Database: `gestionvol`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `gestionvol` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `gestionvol`;

--
-- Table structure for table `avion`
--

DROP TABLE IF EXISTS `avion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `avion` (
  `IdAvion` int(50) NOT NULL,
  `CompagnieAvion` varchar(50) DEFAULT NULL,
  `ModeleAvion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdAvion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `avion`
--

LOCK TABLES `avion` WRITE;
/*!40000 ALTER TABLE `avion` DISABLE KEYS */;
/*!40000 ALTER TABLE `avion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pilote`
--

DROP TABLE IF EXISTS `pilote`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pilote` (
  `IdPilote` int(50) NOT NULL,
  `NomPilote` varchar(50) DEFAULT NULL,
  `PrenomPilote` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdPilote`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pilote`
--

LOCK TABLES `pilote` WRITE;
/*!40000 ALTER TABLE `pilote` DISABLE KEYS */;
/*!40000 ALTER TABLE `pilote` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trajet`
--

DROP TABLE IF EXISTS `trajet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trajet` (
  `IdTrajet` int(50) NOT NULL,
  `AeroportDepart` varchar(50) DEFAULT NULL,
  `AeroportArrivee` varchar(50) DEFAULT NULL,
  `DureeVol` decimal(2,2) DEFAULT NULL,
  PRIMARY KEY (`IdTrajet`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trajet`
--

LOCK TABLES `trajet` WRITE;
/*!40000 ALTER TABLE `trajet` DISABLE KEYS */;
/*!40000 ALTER TABLE `trajet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vol`
--

DROP TABLE IF EXISTS `vol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vol` (
  `IdVol` int(50) NOT NULL,
  `IdPilote` int(50) DEFAULT NULL,
  `IdAvion` int(50) DEFAULT NULL,
  `IdTrajet` int(50) DEFAULT NULL,
  `DateVol` datetime DEFAULT NULL,
  PRIMARY KEY (`IdVol`),
  KEY `FK_Vol_Pilote` (`IdPilote`),
  KEY `FK_Vol_Avion` (`IdAvion`),
  KEY `FK_Vol_Trajet` (`IdTrajet`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vol`
--

LOCK TABLES `vol` WRITE;
/*!40000 ALTER TABLE `vol` DISABLE KEYS */;
/*!40000 ALTER TABLE `vol` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-30 17:22:03
