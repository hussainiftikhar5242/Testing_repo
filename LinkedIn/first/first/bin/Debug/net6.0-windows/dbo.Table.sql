CREATE TABLE [dbo].[User_Informtion]
(
	[First_Name] TEXT NULL, 
    [Last_Name] TEXT NULL, 
    [Email] CHAR(10) NOT NULL, 
    [Password] TEXT NULL, 
    CONSTRAINT [PK_User_Information] PRIMARY KEY ([Email]) 
)
