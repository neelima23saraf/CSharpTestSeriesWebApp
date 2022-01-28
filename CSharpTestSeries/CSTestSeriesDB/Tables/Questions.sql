CREATE TABLE [dbo].[Questions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Question] NVARCHAR(1000) NOT NULL, 
    [Answer] NVARCHAR(50) NOT NULL, 
    [OptionA] NVARCHAR(100) NOT NULL, 
    [OptionB] NVARCHAR(100) NOT NULL, 
    [OptionC] NVARCHAR(100) NULL, 
    [OptionD] NVARCHAR(100) NULL, 
    [Explanation] NVARCHAR(1000) NULL, 
    [TopicId] INT NOT NULL
)
