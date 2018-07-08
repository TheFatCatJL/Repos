CREATE DATABASE  IF NOT EXISTS `sa46team09db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `sa46team09db`;
-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: sa46team09db
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `activity`
--

DROP TABLE IF EXISTS `activity`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `activity` (
  `activityid` int(11) NOT NULL AUTO_INCREMENT,
  `activityname` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`activityid`),
  UNIQUE KEY `activityid_UNIQUE` (`activityid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activity`
--

LOCK TABLES `activity` WRITE;
/*!40000 ALTER TABLE `activity` DISABLE KEYS */;
INSERT INTO `activity` VALUES (1,'Badminton'),(2,'Room');
/*!40000 ALTER TABLE `activity` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `booking` (
  `bookingid` int(11) NOT NULL AUTO_INCREMENT,
  `memberid` int(11) DEFAULT NULL,
  `dateofbooking` date DEFAULT NULL,
  `slotid` int(11) DEFAULT NULL,
  `bookingstatus` tinyint(4) DEFAULT NULL,
  `maintenancestatus` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`bookingid`),
  UNIQUE KEY `bookingid_UNIQUE` (`bookingid`),
  KEY `slotid_idx` (`slotid`),
  CONSTRAINT `slotid` FOREIGN KEY (`slotid`) REFERENCES `slots` (`slotid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booking`
--

LOCK TABLES `booking` WRITE;
/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bookingdetail`
--

DROP TABLE IF EXISTS `bookingdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `bookingdetail` (
  `bookingdetailid` int(11) NOT NULL AUTO_INCREMENT,
  `bookingid` int(11) DEFAULT NULL,
  `facilitytimeslotid` int(11) DEFAULT NULL,
  PRIMARY KEY (`bookingdetailid`),
  UNIQUE KEY `bookingdetailid_UNIQUE` (`bookingdetailid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bookingdetail`
--

LOCK TABLES `bookingdetail` WRITE;
/*!40000 ALTER TABLE `bookingdetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `bookingdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facility`
--

DROP TABLE IF EXISTS `facility`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `facility` (
  `facilityid` int(11) NOT NULL AUTO_INCREMENT,
  `facilityname` varchar(45) DEFAULT NULL,
  `activityid` int(11) DEFAULT NULL,
  `isdeleted` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`facilityid`),
  UNIQUE KEY `facilityid_UNIQUE` (`facilityid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='		';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facility`
--

LOCK TABLES `facility` WRITE;
/*!40000 ALTER TABLE `facility` DISABLE KEYS */;
INSERT INTO `facility` VALUES (1,'Badminton',1,0),(2,'Basketball',1,0),(3,'Meetingroom',2,0);
/*!40000 ALTER TABLE `facility` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facilitytimeslot`
--

DROP TABLE IF EXISTS `facilitytimeslot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `facilitytimeslot` (
  `facilitytimeslotid` int(11) NOT NULL AUTO_INCREMENT,
  `facilityid` int(11) DEFAULT NULL,
  `slotid` int(11) DEFAULT NULL,
  `activityid` int(11) DEFAULT NULL,
  `bookdate` datetime DEFAULT NULL,
  `isdeleted` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`facilitytimeslotid`),
  UNIQUE KEY `facilitytimeslotid_UNIQUE` (`facilitytimeslotid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facilitytimeslot`
--

LOCK TABLES `facilitytimeslot` WRITE;
/*!40000 ALTER TABLE `facilitytimeslot` DISABLE KEYS */;
/*!40000 ALTER TABLE `facilitytimeslot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `slots`
--

DROP TABLE IF EXISTS `slots`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `slots` (
  `slotid` int(11) NOT NULL AUTO_INCREMENT,
  `slottimings` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`slotid`),
  UNIQUE KEY `Slotid_UNIQUE` (`slotid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `slots`
--

LOCK TABLES `slots` WRITE;
/*!40000 ALTER TABLE `slots` DISABLE KEYS */;
INSERT INTO slots 
VALUES ('1','09.00-10.00'),
('2','10.00-11.00'),
('3','11.00-12.00'),
('4','12.00-13.00'),
('5','13.00-14.00'),
('6','14.00-15.00'),
('7','15.00-16.00'),
('8','16.00-17.00'),
('9','17.00-18.00'),
('10','18.00-19.00'),
('11','19.00-20.00'),
('12','20.00-21.00');

/*!40000 ALTER TABLE `slots` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `user` (
  `memberid` int(11) NOT NULL AUTO_INCREMENT,
  `membertype` varchar(20) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `mobile` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `isdeleted` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`memberid`),
  UNIQUE KEY `MemberID_UNIQUE` (`memberid`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='		';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'admin','Chandrika',' Haridasachar Gundachar','95782622','chandrika@gmail.com','admin123',0),(2,'member','Han','Myint Tun','91267934','han@gmail.com','han123',0),(3,'member','Jason','Lim Eng Hwee','97934126','jason@gmail.com','jason@123',0),(4,'member','Liang','Jing Yu','91793426','liang@gmail.com','lancer123',0),(5,'member','Noel','Noel Han','91267934','noelnoel@gmail.com','noel123',0),(6,'member','Subash','Machavel','83441720','subash@gmail.com','subash123',0),(7,'member','Manikandan','Shanmugam','87476821','mani@gmail.com','mani123',0),(8,'member','BBAA','EW','99883785','ww@gmail.com',123,0),(9,'member','Thura','Aung','9988378523','thuraaung@gmail.com',765,0);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-12 11:21:48
