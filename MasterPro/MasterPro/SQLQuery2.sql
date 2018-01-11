DROP TABLE IF EXISTS userInfo;
CREATE TABLE userInfo
(
u_id		CHAR(12) NOT NULL PRIMARY KEY,
u_name		CHAR(12) NOT NULL,
u_password	CHAR(12) NOT NULL,
u_role		CHAR(8)	 NOT NULL,
);

--DROP TABLE IF EXISTS masterInfo;
--CREATE TABLE masterInfo
--(
--m_id		CHAR(12) NOT NULL PRIMARY KEY,
--m_name		CHAR(12) NOT NULL,
--sexy		CHAR(2)  NOT NULL,
--birthday	SMALLDATETIME NOT NULL,
--yearIn		INT  NOT NULL,
--college		CHAR(12) NOT NULL,
--dept		CHAR(12) NOT NULL,
--majorID		CHAR(6)	 NOT NULL,
--major		CHAR(16) NOT NULL,
--grade		TINYINT  NOT NULL,
--class		TINYINT  NOT NULL, 
--FOREIGN KEY(m_id) REFERENCES userInfo(u_id),
--);

DROP TABLE IF EXISTS masterInfo;
CREATE TABLE masterInfo
(
m_id		CHAR(12) NOT NULL PRIMARY KEY,
m_name		CHAR(12) NOT NULL,
sexy		CHAR(2),
birthday	SMALLDATETIME,
yearIn		INT		 ,
college		CHAR(12) ,
dept		CHAR(12) ,
majorID		CHAR(6)	 ,
major		CHAR(16) ,
grade		TINYINT  ,
class		TINYINT  , 
FOREIGN KEY(m_id) REFERENCES userInfo(u_id),
);

DROP TABLE IF EXISTS tutorInfo;
CREATE TABLE tutorInfo
(
t_id			CHAR(12) NOT NULL PRIMARY KEY,
t_name	CHAR(12) NOT NULL,
sexy		CHAR(2)	 NOT NULL,
title		CHAR(8)	 NOT NULL,
college		CHAR(12) NOT NULL,
FOREIGN KEY(t_id) REFERENCES userInfo(u_id),
);

--DROP TABLE IF EXISTS courseInfo;
--CREATE TABLE courseInfo
--(
--c_id		CHAR(12) NOT NULL PRIMARY KEY,
--c_name		CHAR(12) NOT NULL,
--teacher		CHAR(12) ,
--kind		CHAR(8)  , 
--);

DROP TABLE IF EXISTS master_course;
CREATE TABLE master_course
(
m_id		CHAR(12) NOT NULL PRIMARY KEY,
c_id		CHAR(12) ,
c_name		CHAR(12) ,
t_id		CHAR(12) ,
score		TINYINT  ,
teacher		CHAR(12) ,
FOREIGN KEY(m_id) REFERENCES masterInfo(m_id),
--FOREIGN KEY(c_id) REFERENCES courseInfo(c_id),
FOREIGN KEY(t_id) REFERENCES tutorInfo(t_id),
);