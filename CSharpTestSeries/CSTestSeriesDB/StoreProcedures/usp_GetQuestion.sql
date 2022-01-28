USE [CSTSDB]
GO

/****** Object: SqlProcedure [dbo].[GetQuestion] Script Date: 1/27/2022 4:55:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetQuestion]
	@Id int
AS
BEGIN
	SELECT * FROM dbo.Questions WHERE TopicId = @Id	
END
