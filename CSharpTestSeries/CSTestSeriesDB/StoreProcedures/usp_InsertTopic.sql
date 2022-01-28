USE [CSTSDB]
GO

/****** Object: SqlProcedure [dbo].[InsertTopic] Script Date: 1/27/2022 4:56:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertTopic]
    @TopicName nvarchar(500)
    ,@VideoName nvarchar(500)
    ,@VideoURL nvarchar(500)
AS
BEGIN
	INSERT INTO Topics (TopicName, VideoName, VideoURL) VALUES (@TopicName, @VideoName, @VideoURL)
END
