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
-- Definition of table `baptismalwithsponsor`
--

DROP TABLE IF EXISTS `baptismalwithsponsor`;
CREATE TABLE `baptismalwithsponsor` (
  `IDNo` varchar(5) NOT NULL,
  `SponsorNo` int(10) unsigned NOT NULL,
  KEY `FK_baptismalwithsponsor_1` (`IDNo`),
  KEY `FK_baptismalwithsponsor_2` (`SponsorNo`),
  CONSTRAINT `FK_baptismalwithsponsor_1` FOREIGN KEY (`IDNo`) REFERENCES `tblbaptismal` (`IDNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_baptismalwithsponsor_2` FOREIGN KEY (`SponsorNo`) REFERENCES `tblsponsor` (`SponsorNo`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `baptismalwithsponsor`
--

/*!40000 ALTER TABLE `baptismalwithsponsor` DISABLE KEYS */;
/*!40000 ALTER TABLE `baptismalwithsponsor` ENABLE KEYS */;


--
-- Definition of table `marriagewithsponsor`
--

DROP TABLE IF EXISTS `marriagewithsponsor`;
CREATE TABLE `marriagewithsponsor` (
  `MarriageNo` int(10) unsigned NOT NULL,
  `SponsorNo` int(10) unsigned NOT NULL,
  KEY `FK_MarriageWithSponsor_1` (`SponsorNo`),
  KEY `FK_marriagewithsponsor_2` (`MarriageNo`),
  CONSTRAINT `FK_MarriageWithSponsor_1` FOREIGN KEY (`SponsorNo`) REFERENCES `tblsponsor` (`SponsorNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_marriagewithsponsor_2` FOREIGN KEY (`MarriageNo`) REFERENCES `tblmarriage` (`MarriageNo`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `marriagewithsponsor`
--

/*!40000 ALTER TABLE `marriagewithsponsor` DISABLE KEYS */;
/*!40000 ALTER TABLE `marriagewithsponsor` ENABLE KEYS */;


--
-- Definition of table `tblbaptismal`
--

DROP TABLE IF EXISTS `tblbaptismal`;
CREATE TABLE `tblbaptismal` (
  `IDNo` varchar(5) NOT NULL,
  `Resident` varchar(100) DEFAULT NULL,
  `DateofBaptism` datetime DEFAULT NULL,
  `Notes` varchar(500) DEFAULT NULL,
  `Year` varchar(45) DEFAULT NULL,
  `Status` int(10) unsigned DEFAULT NULL,
  `ParentsNoForFather` int(10) unsigned NOT NULL,
  `ParentsNoForMother` int(10) unsigned NOT NULL,
  `MinisterNo` int(10) unsigned NOT NULL,
  `PersonID` int(10) unsigned NOT NULL,
  `SponsorNo` int(10) unsigned NOT NULL,
  PRIMARY KEY (`IDNo`),
  KEY `FK_tblbaptismal_1` (`PersonID`),
  KEY `FK_tblbaptismal_2` (`SponsorNo`),
  KEY `FK_tblbaptismal_3` (`ParentsNoForFather`),
  KEY `FK_tblbaptismal_4` (`ParentsNoForMother`),
  KEY `FK_tblbaptismal_5` (`MinisterNo`),
  CONSTRAINT `FK_tblbaptismal_1` FOREIGN KEY (`PersonID`) REFERENCES `tblperson` (`PersonID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblbaptismal_2` FOREIGN KEY (`SponsorNo`) REFERENCES `tblsponsor` (`SponsorNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblbaptismal_3` FOREIGN KEY (`ParentsNoForFather`) REFERENCES `tblparent` (`ParentsNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblbaptismal_4` FOREIGN KEY (`ParentsNoForMother`) REFERENCES `tblparent` (`ParentsNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblbaptismal_5` FOREIGN KEY (`MinisterNo`) REFERENCES `tblminister` (`MinisterNo`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbaptismal`
--

/*!40000 ALTER TABLE `tblbaptismal` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblbaptismal` ENABLE KEYS */;


--
-- Definition of table `tblmarriage`
--

DROP TABLE IF EXISTS `tblmarriage`;
CREATE TABLE `tblmarriage` (
  `MarriageNo` int(10) unsigned NOT NULL,
  `WedNo_Husband` int(10) unsigned NOT NULL,
  `WedNo_Wife` int(10) unsigned NOT NULL,
  `DateofMarriage` datetime NOT NULL,
  `LicenseNo` varchar(45) NOT NULL,
  `MinisterNo` int(10) unsigned NOT NULL,
  `Notes` varchar(100) NOT NULL,
  PRIMARY KEY (`MarriageNo`),
  KEY `FK_tblMarriage_1` (`WedNo_Husband`),
  KEY `FK_tblmarriage_2` (`WedNo_Wife`),
  KEY `FK_tblmarriage_3` (`MinisterNo`),
  CONSTRAINT `FK_tblMarriage_1` FOREIGN KEY (`WedNo_Husband`) REFERENCES `tblwed` (`WedNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblmarriage_2` FOREIGN KEY (`WedNo_Wife`) REFERENCES `tblwed` (`WedNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblmarriage_3` FOREIGN KEY (`MinisterNo`) REFERENCES `tblminister` (`MinisterNo`) ON UPDATE CASCADE
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
  `TitleID` int(10) unsigned NOT NULL,
  `PersonID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`MinisterNo`),
  KEY `FK_tblminister_1` (`PersonID`),
  KEY `FK_tblminister_2` (`TitleID`),
  CONSTRAINT `FK_tblminister_1` FOREIGN KEY (`PersonID`) REFERENCES `tblperson` (`PersonID`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblminister_2` FOREIGN KEY (`TitleID`) REFERENCES `tbltitleforminister` (`TitleID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblminister`
--

/*!40000 ALTER TABLE `tblminister` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblparent`
--

/*!40000 ALTER TABLE `tblparent` DISABLE KEYS */;
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
  `Gender` tinyint(1) NOT NULL,
  PRIMARY KEY (`PersonID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblperson`
--

/*!40000 ALTER TABLE `tblperson` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblperson` ENABLE KEYS */;


--
-- Definition of table `tblsponsor`
--

DROP TABLE IF EXISTS `tblsponsor`;
CREATE TABLE `tblsponsor` (
  `SponsorNo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `PersonID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`SponsorNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsponsor`
--

/*!40000 ALTER TABLE `tblsponsor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblsponsor` ENABLE KEYS */;


--
-- Definition of table `tbltitleforminister`
--

DROP TABLE IF EXISTS `tbltitleforminister`;
CREATE TABLE `tbltitleforminister` (
  `TitleID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) NOT NULL,
  `Description` varchar(100) NOT NULL,
  PRIMARY KEY (`TitleID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltitleforminister`
--

/*!40000 ALTER TABLE `tbltitleforminister` DISABLE KEYS */;
INSERT INTO `tbltitleforminister` (`TitleID`,`Title`,`Description`) VALUES 
 (1,'Reverent',''),
 (2,'Atty.','Attorney');
/*!40000 ALTER TABLE `tbltitleforminister` ENABLE KEYS */;


--
-- Definition of table `tblwed`
--

DROP TABLE IF EXISTS `tblwed`;
CREATE TABLE `tblwed` (
  `WedNo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Lastname` varchar(45) NOT NULL,
  `Middlename` varchar(45) NOT NULL,
  `Firstname` varchar(45) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `PlaceofBirth` varchar(100) NOT NULL,
  `DateofBirth` datetime NOT NULL,
  `PlaceofBaptism` varchar(100) NOT NULL,
  `DateofBaptism` datetime NOT NULL,
  `ParentsNoForFather` int(10) unsigned NOT NULL,
  `ParentsNoForMother` int(10) unsigned NOT NULL,
  `Status` int(10) unsigned NOT NULL,
  PRIMARY KEY (`WedNo`),
  KEY `FK_tblWed_1` (`ParentsNoForFather`),
  KEY `FK_tblwed_2` (`ParentsNoForMother`),
  CONSTRAINT `FK_tblWed_1` FOREIGN KEY (`ParentsNoForFather`) REFERENCES `tblparent` (`ParentsNo`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tblwed_2` FOREIGN KEY (`ParentsNoForMother`) REFERENCES `tblparent` (`ParentsNo`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblwed`
--

/*!40000 ALTER TABLE `tblwed` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblwed` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
