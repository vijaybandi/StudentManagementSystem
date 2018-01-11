use master

CREATE DATABASE MasterSQL ON(  
NAME = N'MasterSQL_Data', 
FILENAME = 'E:\\MasterSQL_Data.MDF',  
SIZE = 30, 
FILEGROWTH = 20% 
) 
LOG ON(  
NAME = N'MasterSQL_Log', 
FILENAME = 'E:\\MasterSQL.LDF',  
SIZE = 3, 
FILEGROWTH = 1 
);

ALTER DATABASE MasterSQL COLLATE Chinese_PRC_CI_AS;