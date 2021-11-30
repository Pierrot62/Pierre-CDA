-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: gestioncommande
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
-- Current Database: `gestioncommande`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `gestioncommande` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `gestioncommande`;

--
-- Table structure for table `commandes`
--

DROP TABLE IF EXISTS `commandes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `commandes` (
  `IdCommande` int(11) NOT NULL AUTO_INCREMENT,
  `DateCommande` date NOT NULL,
  `NumeroCommande` int(11) NOT NULL,
  PRIMARY KEY (`IdCommande`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commandes`
--

LOCK TABLES `commandes` WRITE;
/*!40000 ALTER TABLE `commandes` DISABLE KEYS */;
INSERT INTO `commandes` VALUES (1,'2021-11-30',1247);
/*!40000 ALTER TABLE `commandes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `preparations`
--

DROP TABLE IF EXISTS `preparations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `preparations` (
  `IdPreparation` int(11) NOT NULL AUTO_INCREMENT,
  `IdProduit` int(11) NOT NULL,
  `IdCommande` int(11) NOT NULL,
  `DatePreparation` date NOT NULL,
  PRIMARY KEY (`IdPreparation`),
  KEY `FK_Produits_Preparation` (`IdProduit`) USING BTREE,
  KEY `FK_Commandes_Preparation` (`IdCommande`) USING BTREE,
  CONSTRAINT `FK_Commandes_Preparatation` FOREIGN KEY (`IdCommande`) REFERENCES `commandes` (`IdCommande`),
  CONSTRAINT `FK_Produits_Preparatation` FOREIGN KEY (`IdProduit`) REFERENCES `produits` (`IdProduit`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `preparations`
--

LOCK TABLES `preparations` WRITE;
/*!40000 ALTER TABLE `preparations` DISABLE KEYS */;
INSERT INTO `preparations` VALUES (1,1,1,'2021-11-30');
/*!40000 ALTER TABLE `preparations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produits`
--

DROP TABLE IF EXISTS `produits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produits` (
  `IdProduit` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleProduit` varchar(50) NOT NULL,
  `PrixProduit` decimal(15,2) NOT NULL,
  `QuantiteProduit` int(11) NOT NULL,
  PRIMARY KEY (`IdProduit`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produits`
--

LOCK TABLES `produits` WRITE;
/*!40000 ALTER TABLE `produits` DISABLE KEYS */;
INSERT INTO `produits` VALUES (1,'PS5',499.95,51);
/*!40000 ALTER TABLE `produits` ENABLE KEYS */;
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
