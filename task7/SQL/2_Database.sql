USE Task6DB;

CREATE TABLE [dbo].[Student](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[DateofBirth] [date] NOT NULL,
	[GroupID] [int] NOT NULL,
	[Gender] [int] NOT NULL,
);

CREATE TABLE [dbo].[Examination](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[GroupID] [int] NOT NULL,
	[SessionID] [int] NOT NULL,
);

CREATE TABLE [dbo].[Group](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
);

CREATE TABLE [dbo].[Session](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
);

CREATE TABLE [dbo].[StudentGrade](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[ExaminationID] [int] NULL,
	[StudentID] [int] NOT NULL,
	[Grade] [int] NOT NULL,
);

CREATE TABLE [dbo].[Subject](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
);