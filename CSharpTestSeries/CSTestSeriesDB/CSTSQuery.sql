select * from Topics

--insert into dbo.Topics(TopicName) values ()

--insert into dbo.Topics(TopicName) values ('ACCESS MODIFIER')

--insert into dbo.Topics(TopicName) values ('GENERICS')
--insert into dbo.Topics(TopicName) values ('ABSTRACT CLASS')
--insert into dbo.Topics(TopicName) values ('INTERFACES')
--insert into dbo.Topics(TopicName) values ('EXTENTION METHODS')
--insert into dbo.Topics(TopicName) values ('DYNAMICS VS VAR')
--insert into dbo.Topics(TopicName) values ('DRY')



select * from dbo.Questions 

--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Can a class have any access specifier ?','B','Yes','No','','','Elements defined in a namespace cannot be explicitly declared as private, protected, protected internal or private protected. A Class within a namespace can only be declared public or internal.',1)


--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('A class is declared without a namsespace as below private class Person{}Will the file compile?','B','Yes','No','','','The following example generates CS1527 error.  Because a class should be declared in with in a namsepace, when no namespace is explicitly declared all type declarations are located implicitly within the global namespace. A class can not be declared private within a namespace.',1)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('What is the scope of Internal methods ?','B','Within the class','Within the assembly','Across the assemby','Across the assembly in the derived class','Internal types can only be accessed within a dll. ',1)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('What is the scope of private protected members ?','C','With in the class only','With in the derived class','With in the class and derived class','Across the assembly in the derived class','Private protected types can only be accessecd by the Parent and its child class.',1)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('What is the scope of  protected internal members ?','D','With in the class only','With in the derived class','With in the class and derived class','Across the assembly in the derived class','',1)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('What is the default access modifier of an Interfaces ?','D','Public','Private','Protected','Internal','',1)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('What is the default access modifier of a class ?','D','Public','Private','Protected','Internal','',1)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Can a constructor be internal?','A','Yes','No','','','',1)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Can any memebre of the class can have higher access than the class it it declared in?','B','Yes','No','','','',1)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('How to declare a generic class ?','A','Public class GenericClass<T>','Public class GenericClass<>T','Public classGenericClassT<>','Public class GenericClass<>','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Generic classes and methods combine 1) Reusability 2) type safety 3) efficiency','A','Only 1','Only 2','Only 3','1, 2, 3','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('What can we implement using Generics?','A','Reflection','Retraction','Unit testing','Progression','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('The most common use of generics is to create ','A','Collection of classes','Public class','Collection of namespace','Private class','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('The .NET class library contains several generic collection classes in','A','System.Collections.Generic','System.Collections','System.Data','System.Generics','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Information on the types that are used in a generic data type may be obtained at run-time by using','D','Exporting','Retraction','Unit testing','Reflection','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Boxing and unboxing are computationally expensive processes','A','Yes','No','','','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Where is value type stored?','A','Stack','Heap','','','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Where is reference type stored?','B','Stack','Heap','','','',2)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('An abstract class should have atleast one abstract method and class implementing this abstract class should override this method','A','Yes','No','','','',3)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('We can create an object of an abstract class','B','Yes','No','','','',3)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('We can have virtual methods in an abstract class','A','Yes','No','','','',3)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Interface is a contract. Whichever class inherits the Interface has to  implement these contract','B','Yes','No','','','An interface can not be inherited. It can only be implemented. ',4)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Everything in an interface is public?','A','Yes','No','','','',4)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values(' While inheriting from base class, base class name should be first thing after colon(:)','A','Yes','No','','','',4)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Can we create an object of an Interface?','B','Yes','No','','','',4)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('We can implement  from multiple infterfaces ','A','Yes','No','','','',4)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('We inherit class but ------ interface','B','Inherit','Implements','Derive','Create','',4)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Extention function works in the same namespace. Else we have to import the namespace','A','Yes','No','','','',5)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('We can merge extention methoods with System or microsoft namespaces','A','Yes','No','','','',5)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('can extention method only be static?','A','Yes','No','','','',5)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Dynamic varibales can be assigned at ','A','Run time','Compile time','No error at all','Both a and b','',6)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('var variables can be assigned at ','B','Run time','Compile time','No error at all','Both a and b','',6)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('var testVar = 2;testVar = 1.1;Above statement will give ','A','Run time','Compile time','No error at all','Both a and b','',6)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('var is strongly typed','A','Yes','No','','','',6)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('What is the output of following code snippet? static void Main(string[] args)         {            dynamic testDynamic;            testDynamic = 1.1;            testDynamic = testDynamic + ""Hi"";            Console.WriteLine(testDynamic);        }','C','1.1','Hi','1.1Hi','Error','',6)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Dynamic can be used when retriving data from third party APIs','A','Yes','No','','','',6)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('What is the full form of DRY','B','Do Repeat Yourself','Do Not Repeat Yourself','Dynamic Rrefactorng  Yield','No fullf form exist','',7)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Unit testing does help to achieve DRY principle ','A','Yes','No','','','Using unitesting we are not repeating ourselves by entring each data input in the UI and run the code ',7)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('Is the Class Library (.NET Standard) and the Class Library (.NET Framework) same?','B','Yes','No','','','.NET standard - cover .NET framework as well as .NET core, xamrin',7)
--insert into dbo.Questions (Question,Answer, OptionA,OptionB,OptionC,OptionD,Explanation,TopicID) values('DRY is not limited to writing the code but testing as well.','A','Yes','No','','','',7)



-----**************************STORE PROCEDURES*********************************--------------


--CREATE PROCEDURE [dbo].[GetAllQuestions]
--AS
--BEGIN
--SELECT * FROM dbo.Questions
--END


--CREATE PROCEDURE [dbo].[GetQuestion]
--	@Id int
--AS
--BEGIN
--	SELECT * FROM dbo.Questions WHERE TopicId = @Id	
--END


--CREATE PROCEDURE [dbo].[GetAllTopics]
--AS
--BEGIN
--	SELECT * FROM Topics
--END

--CREATE PROCEDURE [DBO].[GetTopic]
--    @Id int
--AS
--BEGIN
--	SELECT * FROM TOPICS WHERE Id = @Id
--END

--CREATE PROCEDURE [dbo].[InsertTopic]
--    @TopicName nvarchar(500)
--    ,@VideoName nvarchar(500)
--    ,@VideoURL nvarchar(500)
--AS
--BEGIN
--	INSERT INTO Topics (TopicName, VideoName, VideoURL) VALUES (@TopicName, @VideoName, @VideoURL)
--END


--create procedure [dbo].[DeleteTopic]
--    @id int
--as
--begin
--	delete from topics where id = @id
--end



CREATE PROCEDURE [dbo].[Procedure]
	@param1 int = 0,
	@param2 int
AS
	SELECT @param1, @param2
RETURN 0

