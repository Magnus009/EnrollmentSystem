IF OBJECT_ID ('dbo.Accounts') IS NOT NULL
	DROP TABLE dbo.Accounts
GO

CREATE TABLE dbo.Accounts
	(
	ID          NVARCHAR (6) NOT NULL,
	Name        VARCHAR (200) NULL,
	UserName    VARCHAR (50) NOT NULL,
	Password    VARCHAR (50) NOT NULL,
	UserLevelID INT NOT NULL,
	Question1ID INT NULL,
	Answer1     VARCHAR (150) NULL,
	Question2ID INT NULL,
	Answer2     VARCHAR (150) NULL,
	isActive    BIT DEFAULT ((1)) NULL,
	isDeleted   BIT DEFAULT ((0)) NULL,
	CreatedDate DATETIME NOT NULL,
	DeletedDate DATETIME NULL,
	PRIMARY KEY (ID, UserLevelID)
	)
GO
INSERT INTO dbo.Accounts (ID, Name, UserName, Password, UserLevelID, Question1ID, Answer1, Question2ID, Answer2, isActive, isDeleted, CreatedDate, DeletedDate)
VALUES ('000001', 'Rizal, Jose ', 'rizal', 'password', 1, 1, 'test', 1, 'test', 1, 0, '2020-03-27 11:00:25.23', NULL)
GO

INSERT INTO dbo.Accounts (ID, Name, UserName, Password, UserLevelID, Question1ID, Answer1, Question2ID, Answer2, isActive, isDeleted, CreatedDate, DeletedDate)
VALUES ('000002', 'Bonifacio, Andress Bato', 'abonifacio', 'password', 2, 1, '123 street', 1, 'school', 1, 0, '2020-07-26 14:07:24.24', NULL)
GO

IF OBJECT_ID ('dbo.AudtTrail') IS NOT NULL
	DROP TABLE dbo.AudtTrail
GO

CREATE TABLE dbo.AudtTrail
	(
	Seq          INT IDENTITY NOT NULL,
	UserID       NVARCHAR (6) NULL,
	Action       VARCHAR (10) NULL,
	DateOfAction DATE NULL,
	TimeOfAction TIME NULL,
	Remarks      VARCHAR (250) NULL,
	CreatedDate  DATE NULL,
	DeletedDate  DATE NULL,
	UpdatedDate  DATE NULL,
	UpdatedBy    NVARCHAR (6) NULL,
	PRIMARY KEY (Seq)
	)
GO
IF OBJECT_ID ('dbo.Department') IS NOT NULL
	DROP TABLE dbo.Department
GO

CREATE TABLE dbo.Department
	(
	DeptCode    NVARCHAR (6) NULL,
	DeptName    VARCHAR (100) NULL,
	CreatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedDate DATE NULL,
	UpdatedBy   VARCHAR (20) NULL
	)
GO

INSERT INTO dbo.Department (DeptCode, DeptName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ABM', 'ACCOUNTANCY AND BUSINESS MANAGEMENT DEPARTMENT', '2020-03-15', NULL, '2020-03-15', NULL)
GO

INSERT INTO dbo.Department (DeptCode, DeptName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('AD', 'ARTS AND DESIGN DEPARTMENT', '2020-03-15', NULL, '2020-03-15', NULL)
GO

INSERT INTO dbo.Department (DeptCode, DeptName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CSS', 'COMPUTER SYSTEMS SERVICING DEPARTMENT', '2020-03-15', NULL, '2020-03-15', NULL)
GO

INSERT INTO dbo.Department (DeptCode, DeptName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EIM', 'ELECTRICAL INSTALLATION AND MAINTENANCE DEPARTMENT', '2020-03-15', NULL, '2020-03-15', NULL)
GO

INSERT INTO dbo.Department (DeptCode, DeptName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('HE', 'HOME ECONOMICS DEPARTMENT', '2020-03-15', NULL, '2020-03-15', NULL)
GO

INSERT INTO dbo.Department (DeptCode, DeptName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('HUMSS', 'HUMANITIES AND SOCIAL SCIENCES DEPARTMENT', '2020-03-15', NULL, '2020-03-15', NULL)
GO

INSERT INTO dbo.Department (DeptCode, DeptName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('STEM', 'SCIENCE, TECHNOLOGY, ENGINEERING AND MATHEMATICS DEPARTMENT', '2020-03-15', NULL, '2020-03-15', NULL)
GO

INSERT INTO dbo.Department (DeptCode, DeptName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('TD', 'TECHNICAL DRAFTING DEPARTMENT', '2020-03-15', NULL, '2020-03-15', NULL)
GO

IF OBJECT_ID ('dbo.FamilyBackground') IS NOT NULL
	DROP TABLE dbo.FamilyBackground
GO

CREATE TABLE dbo.FamilyBackground
	(
	StudentLRN       NVARCHAR (15) NOT NULL,
	FatherLastName   VARCHAR (50) NULL,
	FatherFirstName  VARCHAR (50) NULL,
	FatherMiddleName VARCHAR (50) NULL,
	MotherLastName   VARCHAR (50) NULL,
	MotherFirstName  VARCHAR (50) NULL,
	MotherMiddleName VARCHAR (50) NULL,
	GuardianName     VARCHAR (150) NULL,
	Address          VARCHAR (250) NULL,
	ContactNo        NVARCHAR (15) NULL,
	CreatedDate      DATE NULL,
	DeletedDate      DATE NULL,
	UpdatedDAte      DATE NULL,
	UpdatedBy        VARCHAR (6) NULL,
	PRIMARY KEY (StudentLRN)
	)
GO

INSERT INTO dbo.FamilyBackground (StudentLRN, FatherLastName, FatherFirstName, FatherMiddleName, MotherLastName, MotherFirstName, MotherMiddleName, GuardianName, Address, ContactNo, CreatedDate, DeletedDate, UpdatedDAte, UpdatedBy)
VALUES ('201210009', 'DELLOSA', 'RICHARD', 'REYES', 'DELLOSA', 'ROSARIO', 'HERNANDEZ', 'DOLORES D. LABOLABO', 'SAME AS ABOVE', '099999998', '2021-02-10', NULL, '2021-02-10', '')
GO

INSERT INTO dbo.FamilyBackground (StudentLRN, FatherLastName, FatherFirstName, FatherMiddleName, MotherLastName, MotherFirstName, MotherMiddleName, GuardianName, Address, ContactNo, CreatedDate, DeletedDate, UpdatedDAte, UpdatedBy)
VALUES ('202004290001', 'Bonifacio', 'Fidel', 'Torres', 'Bonifacio', 'Mercy', 'Villa', 'Mercy Bonifacio', '123 Bayani St Cavite City', '09785458456', '2020-04-04', NULL, '2021-02-10', NULL)
GO

INSERT INTO dbo.FamilyBackground (StudentLRN, FatherLastName, FatherFirstName, FatherMiddleName, MotherLastName, MotherFirstName, MotherMiddleName, GuardianName, Address, ContactNo, CreatedDate, DeletedDate, UpdatedDAte, UpdatedBy)
VALUES ('202005290001', 'Abaño', 'Crisaldo', 'Tabios', 'Abaño', 'Wilma', 'Cruz', 'Crisaldo Abaño', '1111 Cavite city', '09358555012', '2020-05-29', NULL, '2020-05-29', NULL)
GO

INSERT INTO dbo.FamilyBackground (StudentLRN, FatherLastName, FatherFirstName, FatherMiddleName, MotherLastName, MotherFirstName, MotherMiddleName, GuardianName, Address, ContactNo, CreatedDate, DeletedDate, UpdatedDAte, UpdatedBy)
VALUES ('202005310001', 'Rollamas', 'Fredrick', 'Baroc', 'Rollamas', 'Wyane Irish', 'Brosas', 'Wyane Irish Rollamas', '1234 Cabuco St., Caridad, Cavite City', '09358555012', '2020-05-31', NULL, '2020-07-25', NULL)
GO

INSERT INTO dbo.FamilyBackground (StudentLRN, FatherLastName, FatherFirstName, FatherMiddleName, MotherLastName, MotherFirstName, MotherMiddleName, GuardianName, Address, ContactNo, CreatedDate, DeletedDate, UpdatedDAte, UpdatedBy)
VALUES ('202007250001', 'Manansala', 'Roberto', 'Santos', 'Manansala', 'Vicky', 'Student Information', 'Vicky Manansala', '123 Rodriguez St. Cavite City', '09845685956', '2020-07-25', NULL, '2020-07-26', NULL)
GO

IF OBJECT_ID ('dbo.IrregSchedules') IS NOT NULL
	DROP TABLE dbo.IrregSchedules
GO

CREATE TABLE dbo.IrregSchedules
	(
	ScheduleCode NVARCHAR (15) NOT NULL,
	StudentID    VARCHAR (6) NOT NULL,
	CreatedDate  DATETIME NULL,
	DroppedDate  DATETIME NULL,
	DeletedDate  DATETIME NULL,
	UpdatedDate  DATETIME NULL,
	UpdatedBy    VARCHAR (50) NULL,
	PRIMARY KEY (ScheduleCode, StudentID)
	)
GO

INSERT INTO dbo.IrregSchedules (ScheduleCode, StudentID, CreatedDate, DroppedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('202006002', '000001', '2020-07-22 18:57:30.347', '2020-07-22 18:57:34.22', NULL, '2020-07-22 18:57:34.22', '0')
GO

INSERT INTO dbo.IrregSchedules (ScheduleCode, StudentID, CreatedDate, DroppedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('202007001', '000001', '2020-07-26 02:38:39.48', '2020-07-26 14:01:52.693', NULL, '2020-07-26 14:01:52.693', '1')
GO

INSERT INTO dbo.IrregSchedules (ScheduleCode, StudentID, CreatedDate, DroppedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('202007001', '000004', '2020-07-26 01:52:05.013', '2020-07-26 14:01:52.693', NULL, '2020-07-26 14:01:52.693', '1')
GO

INSERT INTO dbo.IrregSchedules (ScheduleCode, StudentID, CreatedDate, DroppedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('202007002', '000001', '2020-07-26 01:44:42.17', NULL, NULL, '2020-07-26 01:44:42.17', 'rizal')
GO

INSERT INTO dbo.IrregSchedules (ScheduleCode, StudentID, CreatedDate, DroppedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('202007003', '000001', '2020-07-26 14:01:43.117', NULL, NULL, '2020-07-26 14:01:43.117', 'rizal')
GO

INSERT INTO dbo.IrregSchedules (ScheduleCode, StudentID, CreatedDate, DroppedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('202007003', '000004', '2020-07-26 01:58:01.413', NULL, NULL, '2020-07-26 01:58:01.413', 'rizal')
GO

IF OBJECT_ID ('dbo.Schedules') IS NOT NULL
	DROP TABLE dbo.Schedules
GO

CREATE TABLE dbo.Schedules
	(
	SchoolYear   NVARCHAR (10) NOT NULL,
	ScheduleCode NVARCHAR (15) NOT NULL,
	CourseCode   NVARCHAR (12) NOT NULL,
	SubjectCode  NVARCHAR (20) NOT NULL,
	TeacherCode  NVARCHAR (6) NULL,
	SectionCode  NVARCHAR (6) NULL,
	RoomNo       NVARCHAR (10) NULL,
	TimeFrom     TIME NULL,
	TimeTo       TIME NULL,
	CreatedDate  DATE NULL,
	DeletedDate  DATE NULL,
	UpdatedDate  DATE NULL,
	UpdatedBy    VARCHAR (50) NULL,
	PRIMARY KEY (SchoolYear, ScheduleCode, CourseCode, SubjectCode)
	)
GO

INSERT INTO dbo.Schedules (SchoolYear, ScheduleCode, CourseCode, SubjectCode, TeacherCode, SectionCode, RoomNo, TimeFrom, TimeTo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2020-2021', '202006002', 'AD', 'KPWKF', '000001', 'AD12A', '204', '09:30:00', '12:00:00', '2020-06-28', NULL, '2020-06-28', '')
GO

INSERT INTO dbo.Schedules (SchoolYear, ScheduleCode, CourseCode, SubjectCode, TeacherCode, SectionCode, RoomNo, TimeFrom, TimeTo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2020-2021', '202007001', 'AD', 'OCC', '000003', 'AD12A', '201', '13:00:00', '14:00:00', '2020-07-26', NULL, '2020-07-26', 'rizal')
GO

INSERT INTO dbo.Schedules (SchoolYear, ScheduleCode, CourseCode, SubjectCode, TeacherCode, SectionCode, RoomNo, TimeFrom, TimeTo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2020-2021', '202007002', 'STEM', 'GMath', '000002', 'AD12A', '205', '15:30:00', '16:30:00', '2020-07-26', NULL, '2020-07-26', 'rizal')
GO

INSERT INTO dbo.Schedules (SchoolYear, ScheduleCode, CourseCode, SubjectCode, TeacherCode, SectionCode, RoomNo, TimeFrom, TimeTo, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2020-2021', '202007003', 'CSS', 'test18', '000001', 'AD12A', '103', '17:00:00', '19:00:00', '2020-07-26', NULL, '2020-07-26', 'rizal')
GO

IF OBJECT_ID ('dbo.SecretQuestion') IS NOT NULL
	DROP TABLE dbo.SecretQuestion
GO

CREATE TABLE dbo.SecretQuestion
	(
	QID         NVARCHAR (5) NOT NULL,
	QIndex      INT NOT NULL,
	Question    VARCHAR (150) NULL,
	CreatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedDate DATE NULL,
	UpdatedBy   VARCHAR (50) NULL,
	PRIMARY KEY (QID, QIndex)
	)
GO

INSERT INTO dbo.SecretQuestion (QID, QIndex, Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1', 1, 'What was the house number and street name you lived in as a child?', '2020-03-27', NULL, '2020-03-27', NULL)
GO

INSERT INTO dbo.SecretQuestion (QID, QIndex, Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('1', 2, 'What primary school did you attend?', '2020-03-27', NULL, '2020-03-27', NULL)
GO

INSERT INTO dbo.SecretQuestion (QID, QIndex, Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2', 1, 'In what town or city was your first full time job?', '2020-03-27', NULL, '2020-03-27', NULL)
GO

INSERT INTO dbo.SecretQuestion (QID, QIndex, Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2', 2, 'What was your childhood nickname?', '2020-03-27', NULL, '2020-03-27', NULL)
GO

INSERT INTO dbo.SecretQuestion (QID, QIndex, Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('3', 1, 'In what town or city did your mother and father meet?', '2020-03-27', NULL, '2020-03-27', NULL)
GO

INSERT INTO dbo.SecretQuestion (QID, QIndex, Question, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('3', 2, 'What is your favorite movie?', '2020-03-27', NULL, '2020-03-27', NULL)
GO

IF OBJECT_ID ('dbo.Sections') IS NOT NULL
	DROP TABLE dbo.Sections
GO

CREATE TABLE dbo.Sections
	(
	SectionCode NVARCHAR (6) NOT NULL,
	CourseCode  NVARCHAR (12) NOT NULL,
	GradeLevel  INT NOT NULL,
	SectionName VARCHAR (50) NULL,
	CreatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedDate DATE NULL,
	UpdatedBy   VARCHAR (50) NULL,
	PRIMARY KEY (SectionCode, CourseCode, GradeLevel)
	)
GO

INSERT INTO dbo.Sections (SectionCode, CourseCode, GradeLevel, SectionName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ABM11A', 'ABM', 11, 'ABM-11A', '2020-04-03', NULL, '2020-04-03', 'rizal')
GO

INSERT INTO dbo.Sections (SectionCode, CourseCode, GradeLevel, SectionName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('AD12A', 'AD', 12, 'AD-12A', '2020-03-25', NULL, '2020-03-25', '')
GO

INSERT INTO dbo.Sections (SectionCode, CourseCode, GradeLevel, SectionName, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CSS11A', 'CSS', 11, 'CSS-11A', '2020-03-25', NULL, '2020-03-25', '')
GO

IF OBJECT_ID ('dbo.Specialization') IS NOT NULL
	DROP TABLE dbo.Specialization
GO

CREATE TABLE dbo.Specialization
	(
	Code           VARCHAR (10) NOT NULL,
	CourseCode     NVARCHAR (12) NOT NULL,
	Specialization VARCHAR (100) NULL,
	CreatedDate    DATE NULL,
	DeletedDate    DATE NULL,
	UpdatedDate    DATE NULL,
	UpdatedBy      VARCHAR (50) NULL,
	PRIMARY KEY (Code, CourseCode)
	)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('AEcon', 'ABM', 'Applied Economics', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('AEPA', 'AD', 'Apprenticeship and Exploration in the Performing Arts/Arts Production', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('BCalc', 'STEM', 'Basic Calculus', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('BFin', 'ABM', 'Business Finance', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Bio1', 'STEM', 'General Biology1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Bio2', 'STEM', 'General Biology 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('BMath', 'ABM', 'Business Mathematics', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('BPP1', 'HE', 'Bread and Pastry Production NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('BPP2', 'HE', 'Bread and Pastry Production NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CA', 'HUMSS', 'Career Advocacy (Culminating Activity)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CESC', 'HUMSS', 'Community Engagement, Solidarity and Citizenship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Chem 2', 'STEM', 'General Chemistry 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Chem1', 'STEM', 'General Chemistry I', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CI1', 'AD', 'Creative Industries I: Applied Arts and Design', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CI2', 'AD', 'Creative Industries II: Applied Arts and Design', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('COK1', 'HE', 'Cookery NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('COK2', 'HE', 'Cookery NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CSS1', 'CSS', 'Computer Systems Servicing NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CSS2', 'CSS', 'Computer Systems Servicing NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CSS3', 'CSS', 'Computer Systems Servicing NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CSS4', 'CSS', 'Computer Systems Servicing NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CW', 'HUMSS', 'Creative Writing', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('DFIA', 'AD', 'Developing Filipino Identity in the Arts', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('DIASS', 'HUMSS', 'Disciplines and Ideas in the Applied Social Sciences', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('DISS', 'HUMSS', 'Disciplines and Ideas in the Social Sciences', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EAPP', 'ABM', 'English for Academic and Professional Purposes', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EAPP', 'AD', 'English for Academic and Professional Purposes', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EAPP', 'HUMSS', 'English for Academic and professional Purposes', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EAPP', 'STEM', 'English for Academic and Professional Purposes', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EIM1', 'EIM', 'Electrical Installation and Management NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EIM2', 'EIM', 'Electrical Installation and Management NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EIM3', 'EIM', 'Electrical Installation and Management NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EIM4', 'EIM', 'Electrical Installation and Management NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Entrep', 'ABM', 'Entrepreneurship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Entrep', 'AD', 'Entrepreneurship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Entrep', 'CSS', 'Entrepreneurship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Entrep', 'EIM', 'Entrepreneurship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Entrep', 'HE', 'Entrepreneurship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Entrep', 'HUMSS', 'Entrepreneurship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Entrep', 'STEM', 'Entrepreneurship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Entrep', 'TD', 'Entrepreneurship', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ETech', 'ABM', 'Empowerment Technologies (E-Tech: ICT for Professional Tracks)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ETech', 'AD', 'Empowerment Technologies (E-Tech: ICT for Professional Tracks)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ETech', 'CSS', 'Empowerment Technologies (E-Tech: ICT for Professional Tracks)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ETech', 'EIM', 'Empowerment Technologies (E-Tech: ICT for Professional Tracks)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ETech', 'HE', 'Empowerment Technologies (E-Tech: ICT for Professional Tracks)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Etech', 'HUMSS', 'Empowerment Technologies (E-Tech: ICT for Professional Tracks)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ETech', 'STEM', 'Empowerment Technologies (E-Tech: ICT for Professional Tracks)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ETech', 'TD', 'Empowerment Technologies (E-Tech: ICT for Professional Tracks)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Ethics', 'ABM', 'Business Ethics and Social Responsibility', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('FABM1', 'ABM', 'Fundamentals of Accountancy, Business and Management 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('FABM2', 'ABM', 'Fundamentals of Accountancy, Business and Management 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('FBS1', 'HE', 'Food and Beverages Services NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('FBS2', 'HE', 'Food and Beverages Services NCII', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('IEPDAA', 'AD', 'Integrating Elements and Principles of the Different Arts and Applications ', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('IWRBS', 'HUMSS', 'Introduction to World Religions and Belief Systems', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('LMDAF', 'AD', 'Leadership and Management in the Different Arts Fields', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('OrgMan', 'ABM', 'Organization and Management', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PAP/EAP', 'AD', 'Performing Arts Production/Exhibit for Arts Production', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PFPL', 'ABM', 'Pagsulat sa Filipino sa Piling Larangan', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PFPL', 'AD', 'Pagsulat sa Filipino sa Piling larangan', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PFPL', 'EIM', 'Pagsulat sa Filipino sa Piling larangan', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PFPL', 'HE', 'Pagsulat sa Filipino sa Piling larangan', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PFPL', 'HUMSS', 'Pagsulat sa Filipino sa Piling larangan', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PFPL', 'TD', 'Pagsulat sa Filipino sa Piling larangan', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Phys1', 'STEM', 'General Physic 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('Phys2', 'STEM', 'General Physics 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PM', 'ABM', 'Principles of Marketing', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PPDA', 'AD', 'Personal and Physical Development in the Arts', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PPG', 'HUMSS', 'Philippine Politics and Governance', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('PreCalc', 'STEM', 'Pre-Calculus', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R1', 'ABM', 'Research in Daily Life 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R1', 'AD', 'Research in Daily Life 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R1', 'CSS', 'Research in Daily Life 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R1', 'EIM', 'Research in Daily Life 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R1', 'HE', 'Research in Daily Life 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R1', 'HUMSS', 'Research in Daily Life 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R1', 'STEM', 'Research in Daily Life 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R1', 'TD', 'Research in Daily Life 1', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R2', 'ABM', 'Research in Daily Life 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R2', 'AD', 'Research in Daily Life 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R2', 'CSS', 'Research in Daily Life 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R2', 'EIM', 'Research in Daily Life 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R2', 'HE', 'Research in Daily Life 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R2', 'HUMSS', 'Research in Daily Life 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R2', 'STEM', 'Research in Daily Life 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('R2', 'TD', 'Research in Daily Life 2', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RCap', 'STEM', 'Research Capstone', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RProj', 'AD', 'Inquiries. Investigations and Immersion (Research Project)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RProj', 'CSS', 'Inquiries. Investigations and Immersion (Research Project)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RProj', 'EIM', 'Inquiries. Investigations and Immersion (Research Project)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RProj', 'HE', 'Inquiries. Investigations and Immersion (Research Project)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RProj', 'HUMSS', 'Inquiries. Investigations and Immersion (Research Project)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RProj', 'STEM', 'Inquiries. Investigations and Immersion (Research Project)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RProj', 'TD', 'Inquiries. Investigations and Immersion (Research Project)', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('RWS', 'CSS', 'Reading and Writing Skills', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('TD1', 'TD', 'Technical Drafting', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('TD2', 'TD', 'Technical Drafting', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('TD3', 'TD', 'Technical Drafting', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('TD4', 'TD', 'Technical Drafting', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('TNCT', 'HUMSS', 'Trends, Networks, and Critical Thinking in the 21st Century Culture', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('WI', 'ABM', 'Work Immersion/Business Simulation', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('WI', 'CSS', 'Work Immersion', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('WI', 'EIM', 'Work Immersion', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('WI', 'HE', 'Work Immersion', '2020-04-04', NULL, '2020-04-04', NULL)
GO

INSERT INTO dbo.Specialization (Code, CourseCode, Specialization, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('WI', 'TD', 'Work Immersion', '2020-04-04', NULL, '2020-04-04', NULL)
GO

IF OBJECT_ID ('dbo.Strand') IS NOT NULL
	DROP TABLE dbo.Strand
GO

CREATE TABLE dbo.Strand
	(
	CourseCode  NVARCHAR (12) NOT NULL,
	CourseName  VARCHAR (50) NULL,
	Description VARCHAR (50) NULL,
	CreatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedDate DATE NULL,
	UpdatedBy   NVARCHAR (6) NULL,
	PRIMARY KEY (CourseCode)
	)
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('ABM', 'ACCOUNTANCY AND BUSINESS MANAGEMENT', 'test', '2020-03-08', NULL, '2020-04-04', '')
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('AD', 'ARTS AND DESIGN', NULL, '2020-03-08', NULL, '2020-03-08', NULL)
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('CSS', 'COMPUTER SYSTEMS SERVICING', NULL, '2020-03-08', NULL, '2020-03-08', NULL)
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('EIM', 'ELECTRICAL INSTALLATION AND MAINTENANCE', NULL, '2020-03-08', NULL, '2020-03-08', NULL)
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('HE', 'HOME ECONOMICS', NULL, '2020-03-08', NULL, '2020-03-08', NULL)
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('HUMSS', 'HUMANITIES AND SOCIAL SCIENCES', NULL, '2020-03-08', NULL, '2020-03-08', NULL)
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('STEM', 'SCIENCE, TECHNOLOGY, ENGINEERING AND MATHEMATICS', NULL, '2020-03-08', NULL, '2020-03-08', NULL)
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('TD', 'TECHNICAL DRAFTING', NULL, '2020-03-08', NULL, '2020-03-08', NULL)
GO

INSERT INTO dbo.Strand (CourseCode, CourseName, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test', 'test', 'test', '2020-04-04', NULL, '2020-04-04', '')
GO

IF OBJECT_ID ('dbo.StudentGrades') IS NOT NULL
	DROP TABLE dbo.StudentGrades
GO

CREATE TABLE dbo.StudentGrades
	(
	SchoolYear  NVARCHAR (10) NOT NULL,
	StudentID   VARCHAR (6) NOT NULL,
	TeacherID   VARCHAR (6) NOT NULL,
	SectionCD   NVARCHAR (6) NOT NULL,
	SubjectCD   NVARCHAR (12) NOT NULL,
	Semester    INT NULL,
	Quarter1    NVARCHAR (5) NULL,
	Quarter2    NVARCHAR (5) NULL,
	FinalGrade  NVARCHAR (5) NULL,
	CreatedDate DATE NULL,
	UpdatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedBy   VARCHAR (50) NULL,
	PRIMARY KEY (SchoolYear, StudentID, TeacherID, SectionCD, SubjectCD)
	)
GO

INSERT INTO dbo.StudentGrades (SchoolYear, StudentID, TeacherID, SectionCD, SubjectCD, Semester, Quarter1, Quarter2, FinalGrade, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('2020-2021', '000001', '000003', 'AD12A', 'GMATH', 0, '86.2', '88', '', '2020-04-16', '2020-04-17', '2020-04-16', '')
GO

IF OBJECT_ID ('dbo.Students') IS NOT NULL
	DROP TABLE dbo.Students
GO

CREATE TABLE dbo.Students
	(
	StudentID        VARCHAR (6) NOT NULL,
	LRN              VARCHAR (15) NOT NULL,
	FirstName        VARCHAR (50) NULL,
	MiddleName       VARCHAR (50) NULL,
	LastName         VARCHAR (50) NULL,
	ExtName          VARCHAR (50) NULL,
	Birthday         DATE NULL,
	Age              INT NULL,
	Sex              VARCHAR (10) NULL,
	Religion         VARCHAR (50) NULL,
	HouseNo          VARCHAR (50) NULL,
	BrgyNo           VARCHAR (50) NULL,
	City             VARCHAR (50) NULL,
	ContactNo        VARCHAR (20) NULL,
	ZipCode          VARCHAR (50) NULL,
	isIndigenous     BIT NULL,
	Classification   VARCHAR (20) NULL,
	PreviousSchool   VARCHAR (150) NULL,
	GradeLevel       INT NULL,
	TrackID          VARCHAR (6) NULL,
	StrandCode       VARCHAR (5) NULL,
	SpecializationCD VARCHAR (10) NULL,
	havePSA          BIT NULL,
	haveReportCard   BIT NULL,
	haveTOR          BIT NULL,
	CreatedDate      DATE NULL,
	UpdatedDate      DATE NULL,
	DeletedDate      DATE NULL,
	UpdatedBy        VARCHAR (6) NULL,
	PRIMARY KEY (StudentID, LRN)
	)
GO

INSERT INTO dbo.Students (StudentID, LRN, FirstName, MiddleName, LastName, ExtName, Birthday, Age, Sex, Religion, HouseNo, BrgyNo, City, ContactNo, ZipCode, isIndigenous, Classification, PreviousSchool, GradeLevel, TrackID, StrandCode, SpecializationCD, havePSA, haveReportCard, haveTOR, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('000001', '202004290001', 'Andres', 'Santos', 'Bonifacio', 'III', '2000-04-15', 21, 'Male', 'Catholic', '123 Bayani St.', 'Brgy 11-Mabuhay', 'Cavite City', '09050002222', '4100', 0, '2', 'San Sebastian College', 11, '1', 'AD', 'AEPA', 0, 1, 1, '2020-04-04', '2021-02-10', '2020-04-04', NULL)
GO

INSERT INTO dbo.Students (StudentID, LRN, FirstName, MiddleName, LastName, ExtName, Birthday, Age, Sex, Religion, HouseNo, BrgyNo, City, ContactNo, ZipCode, isIndigenous, Classification, PreviousSchool, GradeLevel, TrackID, StrandCode, SpecializationCD, havePSA, haveReportCard, haveTOR, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('000002', '202005290001', 'Macross', 'Rollamas', 'Abaño', '', '2003-01-25', 17, 'Male', 'Roman Catholic', '1111', 'Brgy. 37', 'Cavite City', '09358555012', '4100', 0, '1', 'Cavite National High School', 11, '1', 'ABM', 'AEcon', 1, 1, 1, '2020-05-29', '2020-05-29', '2020-05-29', NULL)
GO

INSERT INTO dbo.Students (StudentID, LRN, FirstName, MiddleName, LastName, ExtName, Birthday, Age, Sex, Religion, HouseNo, BrgyNo, City, ContactNo, ZipCode, isIndigenous, Classification, PreviousSchool, GradeLevel, TrackID, StrandCode, SpecializationCD, havePSA, haveReportCard, haveTOR, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('000003', '202005310001', 'Magnus Levi', 'Brosas', 'Rollamas', '', '2004-04-09', 16, 'Male', 'Catholic', '1234 Cabuco St.', 'Baranggay 37', 'Cavite City', '09970841629', '4100', 1, '1', 'CNHS', 11, '1', 'STEM', 'BCalc', 1, 1, 1, '2020-05-31', '2020-07-25', '2020-05-31', NULL)
GO

INSERT INTO dbo.Students (StudentID, LRN, FirstName, MiddleName, LastName, ExtName, Birthday, Age, Sex, Religion, HouseNo, BrgyNo, City, ContactNo, ZipCode, isIndigenous, Classification, PreviousSchool, GradeLevel, TrackID, StrandCode, SpecializationCD, havePSA, haveReportCard, haveTOR, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('000004', '202007250001', 'Roberta', 'Manansala', 'Gomez', 'Jr.', '2002-11-03', 18, 'Female', 'Catholic', '123 Rodriguez St.', 'Barangay 29', 'Cavite City, Cavite', '09956484256', '4100', 0, '2', 'Cavite National High School', 11, '1', 'HUMSS', 'Entrep', 1, 1, 1, '2020-07-25', '2020-07-26', '2020-07-25', NULL)
GO

INSERT INTO dbo.Students (StudentID, LRN, FirstName, MiddleName, LastName, ExtName, Birthday, Age, Sex, Religion, HouseNo, BrgyNo, City, ContactNo, ZipCode, isIndigenous, Classification, PreviousSchool, GradeLevel, TrackID, StrandCode, SpecializationCD, havePSA, haveReportCard, haveTOR, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('000005', '201210009', 'CHRIS JEREMIE', 'HERNANDEZ', 'DELLOSA', '', '1995-02-13', 26, 'Male', 'BORN-AGAIN', '135 PURA BALLESTEROS ST., SAN ROQUE', 'BRGY 58-M PATOLA', 'CAVITE CITY', '099999999', '4100', 0, '1', 'SANGLEY POINT HIGH SCHOOL', 11, '2', 'STEM', 'BCalc', 1, 0, 1, '2021-02-10', NULL, '2021-02-10', '')
GO

IF OBJECT_ID ('dbo.StudentSection') IS NOT NULL
	DROP TABLE dbo.StudentSection
GO

CREATE TABLE dbo.StudentSection
	(
	SchoolYear  NVARCHAR (15) NOT NULL,
	StudentID   VARCHAR (6) NOT NULL,
	SectionCode NVARCHAR (6) NOT NULL,
	CreatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedDate DATE NULL,
	UpdatedBy   VARCHAR (50) NULL,
	PRIMARY KEY (SchoolYear, StudentID, SectionCode)
	)
GO

INSERT INTO dbo.StudentSection (SchoolYear, StudentID, SectionCode, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2020 - 2021', '000001', 'AD12A', '2020-07-05', NULL, '2020-07-05', '')
GO

INSERT INTO dbo.StudentSection (SchoolYear, StudentID, SectionCode, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2020 - 2021', '000002', 'AD12A', '2020-07-22', NULL, '2020-07-22', 'rizal')
GO

INSERT INTO dbo.StudentSection (SchoolYear, StudentID, SectionCode, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2020 - 2021', '000003', 'AD12A', '2020-07-26', NULL, '2020-07-26', 'rizal')
GO

INSERT INTO dbo.StudentSection (SchoolYear, StudentID, SectionCode, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('2020 - 2021', '000004', 'AD12A', '2020-07-26', NULL, '2020-07-26', 'rizal')
GO

IF OBJECT_ID ('dbo.StudentType') IS NOT NULL
	DROP TABLE dbo.StudentType
GO

CREATE TABLE dbo.StudentType
	(
	TypeID      INT NOT NULL,
	Description VARCHAR (15) NULL,
	PRIMARY KEY (TypeID)
	)
GO

INSERT INTO dbo.StudentType (TypeID, Description)
VALUES (1, 'Regular')
GO

INSERT INTO dbo.StudentType (TypeID, Description)
VALUES (2, 'Irregular')
GO

INSERT INTO dbo.StudentType (TypeID, Description)
VALUES (3, 'Dropped')
GO

IF OBJECT_ID ('dbo.Subject') IS NOT NULL
	DROP TABLE dbo.Subject
GO

CREATE TABLE dbo.Subject
	(
	SubjectCode NVARCHAR (12) NOT NULL,
	Description VARCHAR (100) NULL,
	Units       INT NULL,
	SubjectType NVARCHAR (2) NULL,
	CreatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedDate DATE NULL,
	UpdatedBy   NVARCHAR (6) NULL,
	PRIMARY KEY (SubjectCode)
	)
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('GMath', 'GENERAL MATHEMATICS', 80, '2', '2020-03-21', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('KPWKF', 'Komunikasyon at Pananliksik sa Wika at Kulturang Filipino', 80, '1', '2020-04-03', NULL, '2020-04-03', 'rizal')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('OCC', 'Oral Communication in Context', 80, '1', '2020-03-21', NULL, '2020-03-21', NULL)
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test1', 'test1', 80, '2', '2020-03-21', NULL, '2020-03-21', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test10', 'test10', 80, '1', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test11', 'test11', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test12', 'test12', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test13', 'test13', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test14', 'test14', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test15', 'test15', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test16', 'test16', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test17', 'TEST17', 80, '1', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test18', 'TEST18', 80, '1', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test2', 'test2', 80, '1', '2020-03-23', NULL, '2020-03-23', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test3', 'test3', 80, '1', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test4', 'test4', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test5', 'test5', 80, '1', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test6', 'test6', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test7', 'test7', 80, '1', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test8', 'test8', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

INSERT INTO dbo.Subject (SubjectCode, Description, Units, SubjectType, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('test9', 'test9', 80, '2', '2020-03-24', NULL, '2020-03-24', '')
GO

IF OBJECT_ID ('dbo.SubjectRelation') IS NOT NULL
	DROP TABLE dbo.SubjectRelation
GO

CREATE TABLE dbo.SubjectRelation
	(
	SubjectCode      NVARCHAR (12) NOT NULL,
	PreRequisiteCode NVARCHAR (12) NOT NULL,
	CreatedDate      DATE NULL,
	DeletedDate      DATE NULL,
	UpdatedDate      DATE NULL,
	UpdatedBy        NVARCHAR (6) NULL,
	PRIMARY KEY (SubjectCode, PreRequisiteCode)
	)
GO

IF OBJECT_ID ('dbo.SubjectType') IS NOT NULL
	DROP TABLE dbo.SubjectType
GO

CREATE TABLE dbo.SubjectType
	(
	TypeCode    NVARCHAR (2) NULL,
	Description VARCHAR (35) NULL
	)
GO

IF OBJECT_ID ('dbo.Teachers') IS NOT NULL
	DROP TABLE dbo.Teachers
GO

CREATE TABLE dbo.Teachers
	(
	TeacherCode  VARCHAR (6) NOT NULL,
	LastName     VARCHAR (50) NULL,
	FirstName    VARCHAR (50) NULL,
	MiddleName   VARCHAR (50) NULL,
	ExtName      VARCHAR (50) NULL,
	DeptCode     NVARCHAR (6) NULL,
	ContactNo    VARCHAR (20) NULL,
	EmailAddress VARCHAR (50) NULL,
	CreatedDate  DATE NULL,
	DeletedDate  DATE NULL,
	UpdatedDate  DATE NULL,
	UpdatedBy    VARCHAR (20) NULL,
	PRIMARY KEY (TeacherCode)
	)
GO

INSERT INTO dbo.Teachers (TeacherCode, LastName, FirstName, MiddleName, ExtName, DeptCode, ContactNo, EmailAddress, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('000001', 'Lightwood', 'Alexander', 'Nephilim', '', 'ABM', '09051234569', 'aleclightwood@gmail.com', '2020-03-15', NULL, '2020-04-03', 'rizal')
GO

INSERT INTO dbo.Teachers (TeacherCode, LastName, FirstName, MiddleName, ExtName, DeptCode, ContactNo, EmailAddress, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('000002', 'Tizon', 'Andres', 'Morales', 'N/A', 'AD', '09127561234', 'dizonandres@gmail.com', '2020-03-15', NULL, '2020-04-03', 'rizal')
GO

INSERT INTO dbo.Teachers (TeacherCode, LastName, FirstName, MiddleName, ExtName, DeptCode, ContactNo, EmailAddress, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES ('000003', 'Bane', 'Magnus', 'Warlock', 'N/A', 'CSS', '09050001234', 'magnusbane@gmail.com', '2020-03-15', NULL, '2020-03-15', '')
GO

IF OBJECT_ID ('dbo.Tracks') IS NOT NULL
	DROP TABLE dbo.Tracks
GO

CREATE TABLE dbo.Tracks
	(
	TrackID     VARCHAR (6) NOT NULL,
	Track       VARCHAR (20) NULL,
	CreatedDate DATE NULL,
	UpdatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedBy   VARCHAR (50) NULL,
	PRIMARY KEY (TrackID)
	)
GO

INSERT INTO dbo.Tracks (TrackID, Track, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('1', 'ACADEMICS', '2020-04-04', '2020-04-04', NULL, NULL)
GO

INSERT INTO dbo.Tracks (TrackID, Track, CreatedDate, UpdatedDate, DeletedDate, UpdatedBy)
VALUES ('2', 'TVL', '2020-04-04', '2020-04-04', NULL, NULL)
GO

IF OBJECT_ID ('dbo.UserLevel') IS NOT NULL
	DROP TABLE dbo.UserLevel
GO

CREATE TABLE dbo.UserLevel
	(
	ID          INT NOT NULL,
	Description VARCHAR (50) NULL,
	CreatedDate DATE NULL,
	DeletedDate DATE NULL,
	UpdatedDate DATE NULL,
	UpdatedBy   VARCHAR (50) NULL,
	PRIMARY KEY (ID)
	)
GO

INSERT INTO dbo.UserLevel (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (1, 'Admin', '2020-03-27', NULL, '2020-03-27', 'L')
GO

INSERT INTO dbo.UserLevel (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (2, 'Teacher/Professor', '2020-03-27', NULL, '2020-03-27', 'L')
GO

INSERT INTO dbo.UserLevel (ID, Description, CreatedDate, DeletedDate, UpdatedDate, UpdatedBy)
VALUES (3, 'Registrar/PSA', '2020-03-27', NULL, '2020-03-27', 'L')
GO


