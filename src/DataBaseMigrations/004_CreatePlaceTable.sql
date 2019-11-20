USE [MpcWinFormsIoCDataBase]
GO

DECLARE @version varchar(50) = '004';
DECLARE @description varchar(50) = 'Create Places Table';
DECLARE @author varchar(50) = 'Diogo Gomes';

INSERT INTO [dbo].[_DbMigrations]([Version],[Description],[Author],[MigrationDate])
  VALUES (@version,@description,@author,GETDATE())
GO
-------------------------------------------------------------------------------

CREATE TABLE [dbo].[Place](
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Name] [nvarchar](255) NOT NULL,
  [Address] [nvarchar](255) NOT NULL,
  [PhoneNumber] [int] NOT NULL,
  [Website] [varchar](50) NOT NULL,
  [Classification] [float] NOT NULL,
  CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED ([Id] ASC)) ON [PRIMARY]
GO

INSERT INTO [dbo].[Place]
    ([Name],[Address],[PhoneNumber], [Website], [Classification])
  VALUES
    ('Restaurante XPTO','R. de Baixo n23',253253253,'www.restaurantexpto.pt', 0);
GO
