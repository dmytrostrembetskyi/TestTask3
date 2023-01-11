CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] varchar(255) not null,
	[Surname] varchar(255) not null,
	Age int not null,
);
