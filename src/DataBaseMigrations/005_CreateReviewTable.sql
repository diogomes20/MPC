USE [MpcWinFormsIoCDataBase]
GO

DECLARE @version varchar(50) = '005';
DECLARE @description varchar(50) = 'Create Review Table';
DECLARE @author varchar(50) = 'Diogo Gomes';

INSERT INTO [dbo].[_DbMigrations]([Version],[Description],[Author],[MigrationDate])
  VALUES (@version,@description,@author,GETDATE())
GO
-------------------------------------------------------------------------------

CREATE TABLE [dbo].[Review](
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Classification] [int] NOT NULL,
  [Comments] [varchar](255) NOT NULL,
  [UserId] [int] NOT NULL,
  [PlaceId] [int] NOT NULL,
  FOREIGN KEY (UserId) REFERENCES Users(Id),
  FOREIGN KEY (PlaceId) REFERENCES Place(Id),
  CONSTRAINT [PK_Place] PRIMARY KEY CLUSTERED ([Id] ASC)) ON [PRIMARY]
GO

