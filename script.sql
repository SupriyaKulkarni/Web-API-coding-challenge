USE [VehicleDB]
GO

/****** Object: Table [dbo].[Vehicle] Script Date: 5/9/2016 5:42:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vehicle] (
    [Id]    INT  PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    [Year]  INT            NULL,
    [Make]  NVARCHAR (MAX) NULL,
    [Model] NVARCHAR (MAX) NULL
);


