CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(500) NULL, 
    [Age] INT NULL, 
    [IsAdmin] BIT NULL
)
