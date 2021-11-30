-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: entreprise
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
-- Current Database: `entreprise`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `entreprise` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `entreprise`;

--
-- Table structure for table `employer`
--

DROP TABLE IF EXISTS `employer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employer` (
  `idEmployer` int(11) NOT NULL AUTO_INCREMENT,
  `nomEmployer` varchar(255) NOT NULL,
  `prenomEmployer` varchar(255) NOT NULL,
  `ageEmployer` int(11) NOT NULL,
  `idVoiture` int(11) DEFAULT NULL,
  PRIMARY KEY (`idEmployer`),
  KEY `FK_Employer_Voiture` (`idVoiture`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employer`
--

LOCK TABLES `employer` WRITE;
/*!40000 ALTER TABLE `employer` DISABLE KEYS */;
INSERT INTO `employer` VALUES (2,'BALAIR','Quentin',22,1),(3,'POIX','Martine',49,2),(4,'MAYEUX','Bruno',47,2),(5,'JeSaisPas','Nacer',23,2),(7,'JeSaisPas','Nacer',23,1),(8,'JeSaisPas','Nacer',23,NULL),(9,'JeSaisPas','Nacer',23,NULL),(10,'JeSaisPas','Nacer',23,NULL),(11,'JeSaisPas','Nacer',23,NULL),(12,'JeSaisPas','Nacer',23,NULL),(13,'JeSaisPas','Nacer',23,NULL),(14,'JeSaisPas','Nacer',23,NULL),(15,'JeSaisPas','Nacer',23,NULL),(16,'JeSaisPas','Nacer',23,NULL),(17,'JeSaisPas','Nacer',23,NULL),(18,'JeSaisPas','Nacer',23,NULL),(19,'JeSaisPas','Nacer',23,NULL),(20,'JeSaisPas','Nacer',23,NULL),(21,'JeSaisPas','Nacer',23,NULL);
/*!40000 ALTER TABLE `employer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `voiture`
--

DROP TABLE IF EXISTS `voiture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `voiture` (
  `idVoiture` int(11) NOT NULL AUTO_INCREMENT,
  `immatriculationVoiture` varchar(9) NOT NULL,
  `kilometrageVoiture` int(6) NOT NULL,
  `dateAchatVoiture` date NOT NULL,
  PRIMARY KEY (`idVoiture`),
  CONSTRAINT `voiture_ibfk_1` FOREIGN KEY (`idVoiture`) REFERENCES `employer` (`idVoiture`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `voiture`
--

LOCK TABLES `voiture` WRITE;
/*!40000 ALTER TABLE `voiture` DISABLE KEYS */;
INSERT INTO `voiture` VALUES (1,'AT-178-CP',245784,'2001-12-14');
/*!40000 ALTER TABLE `voiture` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-30 17:22:02
