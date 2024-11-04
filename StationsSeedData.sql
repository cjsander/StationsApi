USE [StationsDb]
GO

INSERT INTO [dbo].[Difficulties]
           ([Id]
           ,[Name])
     VALUES
           (NEWID()
           ,'SLOW')
GO

INSERT INTO [dbo].[Difficulties]
           ([Id]
           ,[Name])
     VALUES
           (NEWID()
           ,'MEDIOCRE')
GO

INSERT INTO [dbo].[Difficulties]
           ([Id]
           ,[Name])
     VALUES
           (NEWID()
           ,'FAST')
GO

INSERT INTO [dbo].[Difficulties]
           ([Id]
           ,[Name])
     VALUES
           (NEWID()
           ,'HYPER')
GO


INSERT INTO [dbo].[Regions]
           ([Id]
           ,[GeoCode]
           ,[Name]
           ,[RegionImageUrl])
     VALUES
           (NEWID()
           ,'37.79912187714303, -92.13184784957491'
           ,'UsFlwCtr52'
           ,'/image.png')
GO

INSERT INTO [dbo].[Regions]
           ([Id]
           ,[GeoCode]
           ,[Name]
           ,[RegionImageUrl])
     VALUES
           (NEWID()
           ,'38.62545865404169, -90.21384433248116'
           ,'UsStlArch03'
           ,'/image.png')
GO

INSERT INTO [dbo].[Regions]
           ([Id]
           ,[GeoCode]
           ,[Name]
           ,[RegionImageUrl])
     VALUES
           (NEWID()
           ,'37.66056344742115, -92.16214891650522'
           ,'UsFlwRange24'
           ,'/image.png')
GO

INSERT INTO [dbo].[Regions]
           ([Id]
           ,[GeoCode]
           ,[Name]
           ,[RegionImageUrl])
     VALUES
           (NEWID()
           ,'38.54263580456969, -89.85470434398275'
           ,'UsSafbRange119'
           ,'/image.png')
GO


INSERT INTO [dbo].[PathRouters]
           ([Id]
           ,[Name]
           ,[Description]
           ,[LengthInKm]
           ,[StationImageUrl]
           ,[DifficultyId]
           ,[RegionId])
     VALUES
           (NEWID()
           ,'UsSafbRange119_Alpha'
           ,'Air Base'
           ,500.26
           ,'/image.png'
           ,'8348F8A9-9CE5-433D-84F5-26559ACD9A83'
           ,'A803098C-2297-4E2B-924B-53AE6748FD8D')
GO

INSERT INTO [dbo].[PathRouters]
           ([Id]
           ,[Name]
           ,[Description]
           ,[LengthInKm]
           ,[StationImageUrl]
           ,[DifficultyId]
           ,[RegionId])
     VALUES
           (NEWID()
           ,'UsFlwRange24'
           ,'Air Base'
           ,1500.26
           ,'/image.png'
           ,'8348F8A9-9CE5-433D-84F5-26559ACD9A83'
           ,'97AA96D5-A0D1-4479-B584-D8D42D7CD3CF')
GO

SELECT PathRouters.Name, PathRouters.Description, PathRouters.LengthInKm, Difficulties.Name AS Expr1, Regions.Name AS Expr2, Regions.GeoCode
FROM Difficulties 
INNER JOIN PathRouters ON Difficulties.Id = PathRouters.DifficultyId 
INNER JOIN Regions ON PathRouters.RegionId = Regions.Id

GO