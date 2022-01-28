USE [CSTSDB]
GO

/****** Object: SqlProcedure [dbo].[GetAllTopics] Script Date: 1/27/2022 4:54:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllTopics]
AS
BEGIN
	SELECT * FROM Topics
END
