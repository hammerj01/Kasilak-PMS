-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.43-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema dbparish
--

CREATE DATABASE IF NOT EXISTS dbparish;
USE dbparish;

--
-- Definition of table `tblbaptismal`
--

DROP TABLE IF EXISTS `tblbaptismal`;
CREATE TABLE `tblbaptismal` (
  `BaptismalID` varchar(20) NOT NULL,
  `PersonID` int(10) unsigned NOT NULL,
  `BookID` varchar(10) NOT NULL,
  `MinisterNo` int(10) unsigned NOT NULL,
  `ParentsIDForFather` int(10) unsigned NOT NULL,
  `ParentsIDForMother` int(10) unsigned NOT NULL,
  `DateofBaptism` varchar(45) NOT NULL,
  `Resident` varchar(200) NOT NULL,
  `Annotation` varchar(45) NOT NULL,
  `PlaceofBaptism` varchar(200) NOT NULL,
  PRIMARY KEY (`BaptismalID`) USING BTREE,
  KEY `FK_tblbaptismal_1` (`PersonID`),
  KEY `FK_tblbaptismal_2` (`BookID`),
  KEY `FK_tblbaptismal_3` (`MinisterNo`),
  KEY `FK_tblbaptismal_4` (`ParentsIDForFather`),
  KEY `FK_tblbaptismal_5` (`ParentsIDForMother`),
  CONSTRAINT `FK_tblbaptismal_1` FOREIGN KEY (`PersonID`) REFERENCES `tblperson` (`PersonID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblbaptismal_3` FOREIGN KEY (`MinisterNo`) REFERENCES `tblminister` (`MinisterNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblbaptismal_4` FOREIGN KEY (`ParentsIDForFather`) REFERENCES `tblparent` (`ParentsNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblbaptismal_5` FOREIGN KEY (`ParentsIDForMother`) REFERENCES `tblparent` (`ParentsNo`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `tblbaptismal`
--

/*!40000 ALTER TABLE `tblbaptismal` DISABLE KEYS */;
INSERT INTO `tblbaptismal` (`BaptismalID`,`PersonID`,`BookID`,`MinisterNo`,`ParentsIDForFather`,`ParentsIDForMother`,`DateofBaptism`,`Resident`,`Annotation`,`PlaceofBaptism`) VALUES 
 ('106-1987-0001',7,'106',1,1,2,'Saturday, May 28, 2011','Agsoso, Loon, Bohol','','Loon, Bohol'),
 ('106-1987-0002',6,'106',1,1,2,'Wednesday, May 25, 2011','Agsoso, Loon, Bohol','','Loon, Bohol'),
 ('106-1987-0003',8,'106',1,1,2,'Saturday, May 28, 2011','Canpatud, Loon, Bohol','','Loon, Bohol'),
 ('106-1987-0004',9,'106',1,1,2,'Saturday, May 28, 2011','Canpatud, Loon, Bohol','','Loon, Bohol'),
 ('106-1987-0005',10,'106',1,1,2,'Saturday, May 28, 2011','Canpatud, Loon, Bohol','','Loon'),
 ('106-1987-0006',11,'106',1,1,2,'Saturday, May 28, 2011','Agsoso, Loon, Bohol','','Loon');
/*!40000 ALTER TABLE `tblbaptismal` ENABLE KEYS */;


--
-- Definition of table `tblbarangay`
--

DROP TABLE IF EXISTS `tblbarangay`;
CREATE TABLE `tblbarangay` (
  `BarangayID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TownID` int(10) unsigned NOT NULL,
  `BarangayName` varchar(85) NOT NULL,
  PRIMARY KEY (`BarangayID`),
  KEY `FK_tblbarangay_1` (`TownID`),
  CONSTRAINT `FK_tblbarangay_1` FOREIGN KEY (`TownID`) REFERENCES `tbltown` (`TownID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbarangay`
--

/*!40000 ALTER TABLE `tblbarangay` DISABLE KEYS */;
INSERT INTO `tblbarangay` (`BarangayID`,`TownID`,`BarangayName`) VALUES 
 (1,4,'Agsoso'),
 (2,4,'Canpatud');
/*!40000 ALTER TABLE `tblbarangay` ENABLE KEYS */;


--
-- Definition of table `tblbook`
--

DROP TABLE IF EXISTS `tblbook`;
CREATE TABLE `tblbook` (
  `BookID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `BookNo` varchar(10) NOT NULL,
  `Status` varchar(45) NOT NULL,
  `Category` varchar(45) NOT NULL,
  `DateAdded` datetime NOT NULL,
  PRIMARY KEY (`BookID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbook`
--

/*!40000 ALTER TABLE `tblbook` DISABLE KEYS */;
INSERT INTO `tblbook` (`BookID`,`BookNo`,`Status`,`Category`,`DateAdded`) VALUES 
 (1,'101','Inactive','Baptismal','0000-00-00 00:00:00'),
 (2,'102','Inactive','Confirmation','0000-00-00 00:00:00'),
 (3,'103','Inactive','Death','0000-00-00 00:00:00'),
 (4,'104','Inactive','Marriage','0000-00-00 00:00:00'),
 (5,'105','Inactive','Baptismal','0000-00-00 00:00:00'),
 (6,'106','Active','Baptismal','0000-00-00 00:00:00'),
 (7,'107','Inactive','Marriage','0000-00-00 00:00:00'),
 (8,'108','Active','Confirmation','0000-00-00 00:00:00'),
 (9,'109','Inactive','Confirmation','0000-00-00 00:00:00'),
 (10,'110','Inactive','Baptismal','0000-00-00 00:00:00'),
 (11,'105','Inactive','Confirmation','0000-00-00 00:00:00'),
 (12,'105','Active','Marriage','0000-00-00 00:00:00'),
 (13,'105','Active','Death','0000-00-00 00:00:00');
/*!40000 ALTER TABLE `tblbook` ENABLE KEYS */;


--
-- Definition of table `tblchapel`
--

DROP TABLE IF EXISTS `tblchapel`;
CREATE TABLE `tblchapel` (
  `ChapelID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `BarangayID` int(10) unsigned NOT NULL,
  `ChapelName` varchar(200) NOT NULL,
  PRIMARY KEY (`ChapelID`),
  KEY `FK_tblchapel_1` (`BarangayID`),
  CONSTRAINT `FK_tblchapel_1` FOREIGN KEY (`BarangayID`) REFERENCES `tblbarangay` (`BarangayID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblchapel`
--

/*!40000 ALTER TABLE `tblchapel` DISABLE KEYS */;
INSERT INTO `tblchapel` (`ChapelID`,`BarangayID`,`ChapelName`) VALUES 
 (1,1,'San Isidro'),
 (2,2,'San Vicente Chapel'),
 (3,1,'San Roque');
/*!40000 ALTER TABLE `tblchapel` ENABLE KEYS */;


--
-- Definition of table `tblcluster`
--

DROP TABLE IF EXISTS `tblcluster`;
CREATE TABLE `tblcluster` (
  `ClusterID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ChapelID` int(10) unsigned NOT NULL,
  `ClusterName` varchar(50) NOT NULL,
  PRIMARY KEY (`ClusterID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcluster`
--

/*!40000 ALTER TABLE `tblcluster` DISABLE KEYS */;
INSERT INTO `tblcluster` (`ClusterID`,`ChapelID`,`ClusterName`) VALUES 
 (1,3,'Cluster 1'),
 (2,2,'Cluster 1'),
 (3,3,'Cluster 2');
/*!40000 ALTER TABLE `tblcluster` ENABLE KEYS */;


--
-- Definition of table `tbllicense`
--

DROP TABLE IF EXISTS `tbllicense`;
CREATE TABLE `tbllicense` (
  `LicenseNo` varchar(15) NOT NULL,
  `Date` varchar(45) NOT NULL,
  `Place` varchar(45) NOT NULL,
  `Observation` varchar(100) NOT NULL,
  `ObservationDate` varchar(45) NOT NULL,
  `ObservationPlace` varchar(45) NOT NULL,
  PRIMARY KEY (`LicenseNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbllicense`
--

/*!40000 ALTER TABLE `tbllicense` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbllicense` ENABLE KEYS */;


--
-- Definition of table `tblmarriage`
--

DROP TABLE IF EXISTS `tblmarriage`;
CREATE TABLE `tblmarriage` (
  `MarriageID` varchar(20) NOT NULL,
  `PersonID_Husband` int(10) unsigned NOT NULL,
  `BookID` int(10) unsigned NOT NULL,
  `MinisterNo` int(10) unsigned NOT NULL,
  `ParentsIDForMotherHusband` int(10) unsigned NOT NULL,
  `ParentsIDForFatherHusband` int(10) unsigned NOT NULL,
  `ParentsIDForMotherWife` int(10) unsigned NOT NULL,
  `ParentsIDForFatherWife` int(10) unsigned NOT NULL,
  `LicenseNo` varchar(15) NOT NULL,
  `DateofMarriage` varchar(45) NOT NULL,
  `Annotation` varchar(45) NOT NULL,
  `DateofBaptism` varchar(45) NOT NULL,
  `PlaceofBaptism` varchar(200) NOT NULL,
  `PersonID_Wife` int(10) unsigned NOT NULL,
  PRIMARY KEY (`MarriageID`),
  KEY `FK_tblMarriage_4` (`ParentsIDForMotherHusband`),
  KEY `FK_tblMarriage_5` (`ParentsIDForFatherHusband`),
  KEY `FK_tblMarriage_6` (`ParentsIDForMotherWife`),
  KEY `FK_tblMarriage_7` (`ParentsIDForFatherWife`),
  KEY `FK_tblmarriage_8` (`LicenseNo`),
  KEY `FK_tblmarriage_9` (`PersonID_Wife`),
  KEY `FK_tblMarriage_1` (`PersonID_Husband`) USING BTREE,
  KEY `FK_tblmarriage_2` (`BookID`),
  KEY `FK_tblmarriage_3` (`MinisterNo`),
  CONSTRAINT `FK_tblmarriage_1` FOREIGN KEY (`PersonID_Husband`) REFERENCES `tblperson` (`PersonID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblmarriage_2` FOREIGN KEY (`BookID`) REFERENCES `tblbook` (`BookID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblmarriage_3` FOREIGN KEY (`MinisterNo`) REFERENCES `tblminister` (`MinisterNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblMarriage_4` FOREIGN KEY (`ParentsIDForMotherHusband`) REFERENCES `tblparent` (`ParentsNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblMarriage_5` FOREIGN KEY (`ParentsIDForFatherHusband`) REFERENCES `tblparent` (`ParentsNo`),
  CONSTRAINT `FK_tblMarriage_6` FOREIGN KEY (`ParentsIDForMotherWife`) REFERENCES `tblparent` (`ParentsNo`),
  CONSTRAINT `FK_tblMarriage_7` FOREIGN KEY (`ParentsIDForFatherWife`) REFERENCES `tblparent` (`ParentsNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblmarriage_8` FOREIGN KEY (`LicenseNo`) REFERENCES `tbllicense` (`LicenseNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblmarriage_9` FOREIGN KEY (`PersonID_Wife`) REFERENCES `tblperson` (`PersonID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblmarriage`
--

/*!40000 ALTER TABLE `tblmarriage` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblmarriage` ENABLE KEYS */;


--
-- Definition of table `tblminister`
--

DROP TABLE IF EXISTS `tblminister`;
CREATE TABLE `tblminister` (
  `MinisterNo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `PersonID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`MinisterNo`),
  KEY `FK_tblminister_1` (`PersonID`),
  CONSTRAINT `FK_tblminister_1` FOREIGN KEY (`PersonID`) REFERENCES `tblperson` (`PersonID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblminister`
--

/*!40000 ALTER TABLE `tblminister` DISABLE KEYS */;
INSERT INTO `tblminister` (`MinisterNo`,`PersonID`) VALUES 
 (1,3);
/*!40000 ALTER TABLE `tblminister` ENABLE KEYS */;


--
-- Definition of table `tblparent`
--

DROP TABLE IF EXISTS `tblparent`;
CREATE TABLE `tblparent` (
  `ParentsNo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `PersonID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ParentsNo`),
  KEY `FK_tblparent_1` (`PersonID`),
  CONSTRAINT `FK_tblparent_1` FOREIGN KEY (`PersonID`) REFERENCES `tblperson` (`PersonID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblparent`
--

/*!40000 ALTER TABLE `tblparent` DISABLE KEYS */;
INSERT INTO `tblparent` (`ParentsNo`,`PersonID`) VALUES 
 (1,1),
 (2,2);
/*!40000 ALTER TABLE `tblparent` ENABLE KEYS */;


--
-- Definition of table `tblperson`
--

DROP TABLE IF EXISTS `tblperson`;
CREATE TABLE `tblperson` (
  `PersonID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Lastname` varchar(45) NOT NULL,
  `Middlename` varchar(45) NOT NULL,
  `Firstname` varchar(45) NOT NULL,
  `Birthdate` varchar(45) NOT NULL,
  `BirthPlace` varchar(45) NOT NULL,
  `Gender` varchar(45) NOT NULL,
  `Status` varchar(45) DEFAULT NULL,
  `ClusterID` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`PersonID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblperson`
--

/*!40000 ALTER TABLE `tblperson` DISABLE KEYS */;
INSERT INTO `tblperson` (`PersonID`,`Lastname`,`Middlename`,`Firstname`,`Birthdate`,`BirthPlace`,`Gender`,`Status`,`ClusterID`) VALUES 
 (1,'Merto','Acer','Hipolito','3/1/2011 10:20:44 AM','Cebu City','Male','Single',0),
 (2,'Sagisabal','Ricalde','Estrella','5/20/1982 11:59:49 AM','Corella, Bohol','Female','Single',0),
 (3,'Royeras','X.','Joel','5/20/1982 11:59:49 AM','Loon, Bohol','Male','Single',0),
 (4,'Sagisabal','Ricalde','Nino','MM-dd-yyyy','Poblacion, Baclayon, Bohol','Male','Single',1),
 (5,'Bonifacio','X.','Andres','Wednesday, May 25, 2011','Albur, Bohol','Male','Single',1),
 (6,'Aquino','Testing','Melchora','Wednesday, May 25, 2011','Poblacion, Tubigon, Bohol','Female','Single',3),
 (7,'Rizal','Protacio','Jose','Saturday, May 28, 2011','Poblacion, Albur, Bohol','Male','Single',1),
 (8,'Aquino','X.','Benigno','Saturday, May 28, 2011','Tubigon, Bohol','Male','Single',2),
 (9,'Estrada','Ejercito','Joseph','Saturday, May 28, 2011','Albur, Bohol','Male','Single',2),
 (10,'Ramos','Valmonte','Fidel','Saturday, May 28, 2011','Albur, Bohol','Male','Single',2),
 (11,'Arroyo','Macapagal','Gloria','Saturday, May 28, 2011','Albur, Bohol','Male','Single',1);
/*!40000 ALTER TABLE `tblperson` ENABLE KEYS */;


--
-- Definition of table `tblprovince`
--

DROP TABLE IF EXISTS `tblprovince`;
CREATE TABLE `tblprovince` (
  `ProvinceID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ProvinceName` varchar(100) NOT NULL,
  PRIMARY KEY (`ProvinceID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblprovince`
--

/*!40000 ALTER TABLE `tblprovince` DISABLE KEYS */;
INSERT INTO `tblprovince` (`ProvinceID`,`ProvinceName`) VALUES 
 (1,'Bohol'),
 (2,'Cebu'),
 (3,'Iloilo');
/*!40000 ALTER TABLE `tblprovince` ENABLE KEYS */;


--
-- Definition of table `tblsponsor`
--

DROP TABLE IF EXISTS `tblsponsor`;
CREATE TABLE `tblsponsor` (
  `SponsorID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `PersonID` int(10) unsigned NOT NULL,
  `EventNo` varchar(45) NOT NULL,
  `Event` varchar(45) NOT NULL,
  PRIMARY KEY (`SponsorID`),
  KEY `FK_tblsponsor_1` (`PersonID`),
  CONSTRAINT `FK_tblsponsor_1` FOREIGN KEY (`PersonID`) REFERENCES `tblperson` (`PersonID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsponsor`
--

/*!40000 ALTER TABLE `tblsponsor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblsponsor` ENABLE KEYS */;


--
-- Definition of table `tbltown`
--

DROP TABLE IF EXISTS `tbltown`;
CREATE TABLE `tbltown` (
  `TownID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ProvinceID` int(10) unsigned NOT NULL,
  `TownName` varchar(45) NOT NULL,
  `Status` tinyint(1) NOT NULL,
  PRIMARY KEY (`TownID`) USING BTREE,
  KEY `FK_tbltown_1` (`ProvinceID`),
  CONSTRAINT `FK_tbltown_1` FOREIGN KEY (`ProvinceID`) REFERENCES `tblprovince` (`ProvinceID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltown`
--

/*!40000 ALTER TABLE `tbltown` DISABLE KEYS */;
INSERT INTO `tbltown` (`TownID`,`ProvinceID`,`TownName`,`Status`) VALUES 
 (1,1,'Albur',0),
 (2,1,'Baclayon',0),
 (3,1,'Candijay',0),
 (4,1,'Loon',0),
 (5,1,'Jagna',0),
 (6,1,'Bilar',0),
 (7,1,'Maribojoc',0),
 (8,1,'Calape',0),
 (9,1,'Tubigon',0),
 (10,1,'Sagbayan',0),
 (11,1,'Tagbilaran',0);
/*!40000 ALTER TABLE `tbltown` ENABLE KEYS */;

--
-- Create schema dbsystem
--

CREATE DATABASE IF NOT EXISTS dbsystem;
USE dbsystem;

--
-- Definition of table `tblseriesnumber`
--

DROP TABLE IF EXISTS `tblseriesnumber`;
CREATE TABLE `tblseriesnumber` (
  `Year` varchar(10) NOT NULL,
  `BaptismalSeries` int(10) unsigned NOT NULL,
  `ConfirmationSeries` int(10) unsigned NOT NULL,
  `DeathSeries` int(10) unsigned NOT NULL,
  `MarriageSeries` int(10) unsigned NOT NULL,
  `Status` varchar(45) NOT NULL,
  PRIMARY KEY (`Year`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblseriesnumber`
--

/*!40000 ALTER TABLE `tblseriesnumber` DISABLE KEYS */;
INSERT INTO `tblseriesnumber` (`Year`,`BaptismalSeries`,`ConfirmationSeries`,`DeathSeries`,`MarriageSeries`,`Status`) VALUES 
 ('1987',6,0,0,0,'Active'),
 ('2011',0,0,0,0,'Inactive');
/*!40000 ALTER TABLE `tblseriesnumber` ENABLE KEYS */;


--
-- Definition of table `tbluser`
--

DROP TABLE IF EXISTS `tbluser`;
CREATE TABLE `tbluser` (
  `UserID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `UserTypeID` int(10) unsigned NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  PRIMARY KEY (`UserID`),
  KEY `FK_tbluser_1` (`UserTypeID`),
  CONSTRAINT `FK_tbluser_1` FOREIGN KEY (`UserTypeID`) REFERENCES `tblusertype` (`UserTypeID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
INSERT INTO `tbluser` (`UserID`,`UserTypeID`,`Username`,`Password`) VALUES 
 (1,1,'administrator','admin');
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;


--
-- Definition of table `tblusertype`
--

DROP TABLE IF EXISTS `tblusertype`;
CREATE TABLE `tblusertype` (
  `UserTypeID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `UserType` varchar(45) NOT NULL,
  PRIMARY KEY (`UserTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblusertype`
--

/*!40000 ALTER TABLE `tblusertype` DISABLE KEYS */;
INSERT INTO `tblusertype` (`UserTypeID`,`UserType`) VALUES 
 (1,'Administrator');
/*!40000 ALTER TABLE `tblusertype` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
