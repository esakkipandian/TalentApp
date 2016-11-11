CREATE TABLE `college` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(5) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedBy` varchar(100) DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`PK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='College List';


CREATE TABLE `university` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(5) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedBy` varchar(100) DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`PK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='All Universities List';


CREATE TABLE `state` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(5) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedBy` varchar(100) DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`PK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='State List';



CREATE TABLE `country` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(5) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedBy` varchar(100) DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`PK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Country List';



CREATE TABLE `skill` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(5) DEFAULT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedBy` varchar(100) DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`PK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='List of Skill Sets';



CREATE TABLE `addresstype` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `Code` varchar(50) NOT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `IsActive` bit(1) NOT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedBy` varchar(100) DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`PK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='List the types of address';



CREATE TABLE `candidate` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `DOB` datetime NOT NULL,
  `FatherName` varchar(100) DEFAULT NULL,
  `MotherName` varchar(100) DEFAULT NULL,
  `Nationality` varchar(45) DEFAULT NULL,
  `Email` varchar(100) NOT NULL,
  `Mobile` varchar(15) DEFAULT NULL,
  `AlternateContact` varchar(15) DEFAULT NULL,
  `IsExperienced` bit(1) DEFAULT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PK`),
  KEY `idx_name` (`FirstName`),
  KEY `idx_fathername` (`FatherName`),
  KEY `idx_mobile` (`Mobile`),
  KEY `idx_email` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `candidateaddress` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `CandidateId` int(11) NOT NULL,
  `AddressTypeId` int(11) NOT NULL,
  `AddressLine1` varchar(150) DEFAULT NULL,
  `AddressLine2` varchar(150) DEFAULT NULL,
  `City` varchar(150) DEFAULT NULL,
  `StateId` int(11) DEFAULT NULL,
  `CountryId` int(11) DEFAULT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PK`),
  KEY `FK_CANDIDATE_idx` (`CandidateId`),
  KEY `FK_ADDRESSTYPE_idx` (`AddressTypeId`),
  KEY `FK_STATE_idx` (`StateId`),
  KEY `FK_COUNTRY_idx` (`CountryId`),
  CONSTRAINT `FK_ADDRESSTYPE` FOREIGN KEY (`AddressTypeId`) REFERENCES `addresstype` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_CANDIDATE` FOREIGN KEY (`CandidateId`) REFERENCES `candidate` (`pk`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_COUNTRY` FOREIGN KEY (`CountryId`) REFERENCES `country` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_STATE` FOREIGN KEY (`StateId`) REFERENCES `state` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `candidateeducation` (
  `PK` int(11) NOT NULL AUTO_INCREMENT,
  `CandidateId` int(11) NOT NULL,
  `DegreeName` varchar(100) DEFAULT NULL,
  `Specialization` varchar(200) DEFAULT NULL,
  `CollegeId` int(11) DEFAULT NULL,
  `College` varchar(200) DEFAULT NULL,
  `UniversityId` int(11) DEFAULT NULL,
  `University` varchar(200) DEFAULT NULL,
  `YearOfPassing` date DEFAULT NULL,
  `Percentage` decimal(10,0) DEFAULT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PK`),
  KEY `FK_CANDIDATEID_idx` (`CandidateId`),
  KEY `FK_UNIVERSITYID_idx` (`UniversityId`),
  CONSTRAINT `FK_CANDIDATEID` FOREIGN KEY (`CandidateId`) REFERENCES `candidate` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_COLLEGEID` FOREIGN KEY (`PK`) REFERENCES `college` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_UNIVERSITYID` FOREIGN KEY (`UniversityId`) REFERENCES `university` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE `candidateskill` (
  `PK` int(11) NOT NULL,
  `CandidateId` int(11) NOT NULL,
  `SkillId` int(11) NOT NULL,
  `Rating` int(11) NOT NULL,
  `SinceLastUsed` date DEFAULT NULL,
  `IsPrimary` bit(1) DEFAULT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PK`),
  KEY `FK_CANDIATE_idx` (`CandidateId`),
  KEY `FK_SKILL_idx` (`SkillId`),
  CONSTRAINT `FK_CANDIATE` FOREIGN KEY (`CandidateId`) REFERENCES `candidate` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_SKILL` FOREIGN KEY (`SkillId`) REFERENCES `skill` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;



CREATE TABLE `candidateworkexperience` (
  `PK` int(11) NOT NULL,
  `CandidateId` int(11) NOT NULL,
  `OrganizationName` varchar(300) DEFAULT NULL,
  `Designation` varchar(200) DEFAULT NULL,
  `Roles` varchar(1000) DEFAULT NULL,
  `StartDate` datetime DEFAULT NULL,
  `EndDate` datetime DEFAULT NULL,
  `LeavingReason` varchar(200) DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(100) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PK`),
  KEY `FK_CANDIATE_idx` (`CandidateId`),
  CONSTRAINT `FK_CANDIATEID` FOREIGN KEY (`CandidateId`) REFERENCES `candidate` (`PK`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


