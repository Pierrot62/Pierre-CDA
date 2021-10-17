-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: voitures
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
-- Current Database: `voitures`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `voitures` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `voitures`;

--
-- Table structure for table `marques`
--

DROP TABLE IF EXISTS `marques`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marques` (
  `mar_id` int(11) NOT NULL AUTO_INCREMENT,
  `mar_nom` varchar(20) NOT NULL,
  PRIMARY KEY (`mar_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marques`
--

LOCK TABLES `marques` WRITE;
/*!40000 ALTER TABLE `marques` DISABLE KEYS */;
INSERT INTO `marques` VALUES (1,'Citroën'),(2,'Peugeot'),(3,'Renault');
/*!40000 ALTER TABLE `marques` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modeles`
--

DROP TABLE IF EXISTS `modeles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modeles` (
  `mod_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `mod_mar_id` int(11) NOT NULL,
  `mod_nom` varchar(20) NOT NULL,
  `mod_cylindree` decimal(2,1) unsigned NOT NULL,
  `mod_prix` int(10) unsigned NOT NULL,
  `mod_date_dispo` date DEFAULT NULL,
  `mod_date_ajout` date DEFAULT NULL,
  PRIMARY KEY (`mod_id`),
  KEY `fk_modeles_mar_id` (`mod_mar_id`),
  CONSTRAINT `fk_modeles_mar_id` FOREIGN KEY (`mod_mar_id`) REFERENCES `marques` (`mar_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modeles`
--

LOCK TABLES `modeles` WRITE;
/*!40000 ALTER TABLE `modeles` DISABLE KEYS */;
INSERT INTO `modeles` VALUES (1,1,'C3',1.0,13500,NULL,'2018-10-18'),(2,1,'Cactus',1.0,18470,'2019-01-02','2018-10-18'),(3,3,'Espace',2.0,40000,'2019-01-02','2018-10-18'),(4,3,'Clio',1.0,14080,'2019-01-02','2018-10-18'),(5,2,'5008',1.2,33250,'2019-01-02','2018-10-18'),(6,2,'308',1.2,23630,'2019-01-02','2018-10-18'),(7,3,'Mégane',1.3,26740,'2019-01-02','2018-10-18'),(8,1,'Picasso',1.2,29100,'2019-01-02','2018-10-18'),(9,3,'Kadjar',1.2,26950,'2019-01-02','2018-10-18'),(10,3,'Koléos',1.5,34900,'2019-01-02','2018-10-18'),(11,2,'CLio',2.0,100000,'2021-10-02',NULL);
/*!40000 ALTER TABLE `modeles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modeles_options`
--

DROP TABLE IF EXISTS `modeles_options`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modeles_options` (
  `om_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `om_mod_id` int(11) unsigned NOT NULL COMMENT 'Clé de la table modeles',
  `om_opt_id` int(11) unsigned NOT NULL COMMENT 'Clé de la table options',
  PRIMARY KEY (`om_id`),
  KEY `om_mod_id` (`om_mod_id`),
  KEY `om_opt_id` (`om_opt_id`),
  CONSTRAINT `modeles_options_ibfk_1` FOREIGN KEY (`om_mod_id`) REFERENCES `modeles` (`mod_id`),
  CONSTRAINT `modeles_options_ibfk_2` FOREIGN KEY (`om_opt_id`) REFERENCES `options` (`opt_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modeles_options`
--

LOCK TABLES `modeles_options` WRITE;
/*!40000 ALTER TABLE `modeles_options` DISABLE KEYS */;
INSERT INTO `modeles_options` VALUES (1,6,2),(2,6,4),(3,5,1),(4,5,3),(5,5,4),(6,5,2);
/*!40000 ALTER TABLE `modeles_options` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `options`
--

DROP TABLE IF EXISTS `options`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `options` (
  `opt_id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `opt_libelle` varchar(50) NOT NULL,
  `opt_prix` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`opt_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `options`
--

LOCK TABLES `options` WRITE;
/*!40000 ALTER TABLE `options` DISABLE KEYS */;
INSERT INTO `options` VALUES (1,'Jantes alu',600),(2,'GPS',450),(3,'Toit ouvrant',870),(4,'Peinture métallisée',275);
/*!40000 ALTER TABLE `options` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-17 17:20:01
