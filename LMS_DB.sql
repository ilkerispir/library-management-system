CREATE DATABASE LMS_DB
GO
USE [LMS_DB]
GO
/****** Object:  Table [dbo].[BookCategories]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCategories](
	[BookCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BookTypes] PRIMARY KEY CLUSTERED 
(
	[BookCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[BookCategoryID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[BookName] [nvarchar](200) NOT NULL,
	[Author] [nvarchar](100) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Edition] [nvarchar](50) NOT NULL,
	[NoOfCopies] [int] NOT NULL,
	[DateOfRegister] [date] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[EstablishDate] [date] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Designations]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designations](
	[DesignationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Designations] PRIMARY KEY CLUSTERED 
(
	[DesignationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fines]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fines](
	[FineID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[FineAmount] [int] NOT NULL,
	[RecivedAmount] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Fines] PRIMARY KEY CLUSTERED 
(
	[FineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IssueBooks]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IssueBooks](
	[IssueID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[BookID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[NoOfCopies] [int] NOT NULL,
	[DateOfIssue] [date] NOT NULL,
	[DateOfReturn] [date] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Issues] PRIMARY KEY CLUSTERED 
(
	[IssueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Programs]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Programs](
	[ProgramID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Programs] PRIMARY KEY CLUSTERED 
(
	[ProgramID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnBooks]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnBooks](
	[ReturnID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[IssueDate] [date] NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_ReturnBooks] PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sessions]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sessions](
	[SessionID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK_Sessions] PRIMARY KEY CLUSTERED 
(
	[SessionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[DesignationID] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[TCNO] [nvarchar](11) NOT NULL,
	[Gender] [int] NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[ContactNo] [nvarchar](13) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[SessionID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[ProgramID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[TCNO] [nvarchar](11) NOT NULL,
	[Status] [int] NOT NULL,
	[Gender] [int] NOT NULL,
	[EnrollNo] [nvarchar](100) NOT NULL,
	[ContactNo] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserPrivileges]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPrivileges](
	[UserPrivilege] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NOT NULL,
	[Configuration] [int] NOT NULL,
	[Staff] [int] NOT NULL,
	[Student] [int] NOT NULL,
	[Book] [int] NOT NULL,
	[IssueBook] [int] NOT NULL,
	[ReturnBook] [int] NOT NULL,
	[Report] [int] NOT NULL,
	[Gsm] [int] NOT NULL,
	[Email] [int] NOT NULL,
 CONSTRAINT [PK_UserPrivileges] PRIMARY KEY CLUSTERED 
(
	[UserPrivilege] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 19.12.2019 23:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookCategories] ON 

INSERT [dbo].[BookCategories] ([BookCategoryID], [Name]) VALUES (1, N'Bilim')
INSERT [dbo].[BookCategories] ([BookCategoryID], [Name]) VALUES (2, N'Edebiyat')
INSERT [dbo].[BookCategories] ([BookCategoryID], [Name]) VALUES (3, N'Tarih')
INSERT [dbo].[BookCategories] ([BookCategoryID], [Name]) VALUES (4, N'Programlama')
SET IDENTITY_INSERT [dbo].[BookCategories] OFF
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookID], [BookCategoryID], [StaffID], [DepartmentID], [BookName], [Author], [Title], [Edition], [NoOfCopies], [DateOfRegister], [Price]) VALUES (1, 4, 1, 1, N'C# OOP Giriş', N'Jeffrey Richter', N'Programlama Dilleri', N'3', 2, CAST(N'2019-04-10' AS Date), 15)
INSERT [dbo].[Books] ([BookID], [BookCategoryID], [StaffID], [DepartmentID], [BookName], [Author], [Title], [Edition], [NoOfCopies], [DateOfRegister], [Price]) VALUES (2, 4, 1, 2, N'Mantık Devreleri', N'R. Marston', N'Elektronik', N'6', 5, CAST(N'2017-10-20' AS Date), 20)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DepartmentID], [Name], [EstablishDate]) VALUES (1, N'Bilgisayar Mühendisliği', CAST(N'2008-07-05' AS Date))
INSERT [dbo].[Departments] ([DepartmentID], [Name], [EstablishDate]) VALUES (2, N'Elektrik-Elektronik Mühendisliği', CAST(N'2009-06-02' AS Date))
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Designations] ON 

INSERT [dbo].[Designations] ([DesignationID], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Designations] ([DesignationID], [Name]) VALUES (2, N'Manager')
SET IDENTITY_INSERT [dbo].[Designations] OFF
SET IDENTITY_INSERT [dbo].[Fines] ON 

INSERT [dbo].[Fines] ([FineID], [StudentID], [BookID], [StaffID], [Date], [FineAmount], [RecivedAmount], [Status]) VALUES (1, 8, 2, 1, CAST(N'2019-12-18' AS Date), 75, 0, 1)
INSERT [dbo].[Fines] ([FineID], [StudentID], [BookID], [StaffID], [Date], [FineAmount], [RecivedAmount], [Status]) VALUES (2, 7, 2, 1, CAST(N'2019-12-19' AS Date), 0, 20, 0)
INSERT [dbo].[Fines] ([FineID], [StudentID], [BookID], [StaffID], [Date], [FineAmount], [RecivedAmount], [Status]) VALUES (3, 9, 1, 1, CAST(N'2019-12-19' AS Date), 105, 0, 1)
INSERT [dbo].[Fines] ([FineID], [StudentID], [BookID], [StaffID], [Date], [FineAmount], [RecivedAmount], [Status]) VALUES (4, 7, 1, 1, CAST(N'2019-12-19' AS Date), 0, 105, 0)
SET IDENTITY_INSERT [dbo].[Fines] OFF
SET IDENTITY_INSERT [dbo].[IssueBooks] ON 

INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (1, 7, 1, 1, 1, CAST(N'2019-12-18' AS Date), CAST(N'2019-12-19' AS Date), 0)
INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (2, 8, 2, 1, 1, CAST(N'2019-12-02' AS Date), CAST(N'2019-12-04' AS Date), 0)
INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (3, 8, 1, 1, 1, CAST(N'2019-12-18' AS Date), CAST(N'2019-12-19' AS Date), 1)
INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (4, 7, 2, 1, 1, CAST(N'2019-12-12' AS Date), CAST(N'2019-12-17' AS Date), 0)
INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (5, 10, 1, 1, 1, CAST(N'2019-12-19' AS Date), CAST(N'2019-12-29' AS Date), 1)
INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (6, 10, 2, 1, 1, CAST(N'2019-12-19' AS Date), CAST(N'2019-12-29' AS Date), 1)
INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (7, 7, 1, 1, 1, CAST(N'2019-11-28' AS Date), CAST(N'2019-11-29' AS Date), 0)
INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (8, 9, 1, 1, 1, CAST(N'2019-11-28' AS Date), CAST(N'2019-11-29' AS Date), 0)
INSERT [dbo].[IssueBooks] ([IssueID], [StudentID], [BookID], [StaffID], [NoOfCopies], [DateOfIssue], [DateOfReturn], [Status]) VALUES (9, 7, 1, 1, 1, CAST(N'2019-12-19' AS Date), CAST(N'2019-12-20' AS Date), 1)
SET IDENTITY_INSERT [dbo].[IssueBooks] OFF
SET IDENTITY_INSERT [dbo].[Programs] ON 

INSERT [dbo].[Programs] ([ProgramID], [Name]) VALUES (1, N'Lisans')
INSERT [dbo].[Programs] ([ProgramID], [Name]) VALUES (2, N'Yüksek Lisans')
INSERT [dbo].[Programs] ([ProgramID], [Name]) VALUES (3, N'Doktora')
SET IDENTITY_INSERT [dbo].[Programs] OFF
SET IDENTITY_INSERT [dbo].[ReturnBooks] ON 

INSERT [dbo].[ReturnBooks] ([ReturnID], [BookID], [StudentID], [StaffID], [IssueDate], [ReturnDate], [Date]) VALUES (1, 2, 8, 1, CAST(N'2019-12-02' AS Date), CAST(N'2019-12-04' AS Date), CAST(N'2019-12-18' AS Date))
INSERT [dbo].[ReturnBooks] ([ReturnID], [BookID], [StudentID], [StaffID], [IssueDate], [ReturnDate], [Date]) VALUES (2, 1, 7, 1, CAST(N'2019-12-18' AS Date), CAST(N'2019-12-19' AS Date), CAST(N'2019-12-18' AS Date))
INSERT [dbo].[ReturnBooks] ([ReturnID], [BookID], [StudentID], [StaffID], [IssueDate], [ReturnDate], [Date]) VALUES (3, 2, 7, 1, CAST(N'2019-12-12' AS Date), CAST(N'2019-12-17' AS Date), CAST(N'2019-12-19' AS Date))
INSERT [dbo].[ReturnBooks] ([ReturnID], [BookID], [StudentID], [StaffID], [IssueDate], [ReturnDate], [Date]) VALUES (4, 1, 9, 1, CAST(N'2019-11-28' AS Date), CAST(N'2019-11-29' AS Date), CAST(N'2019-12-19' AS Date))
INSERT [dbo].[ReturnBooks] ([ReturnID], [BookID], [StudentID], [StaffID], [IssueDate], [ReturnDate], [Date]) VALUES (5, 1, 7, 1, CAST(N'2019-11-28' AS Date), CAST(N'2019-11-29' AS Date), CAST(N'2019-12-19' AS Date))
SET IDENTITY_INSERT [dbo].[ReturnBooks] OFF
SET IDENTITY_INSERT [dbo].[Sessions] ON 

INSERT [dbo].[Sessions] ([SessionID], [Name], [StartDate], [EndDate]) VALUES (1, N'2019-20 Güz', CAST(N'2019-09-01' AS Date), CAST(N'2020-01-30' AS Date))
INSERT [dbo].[Sessions] ([SessionID], [Name], [StartDate], [EndDate]) VALUES (2, N'2019-20 Bahar', CAST(N'2020-02-01' AS Date), CAST(N'2020-06-30' AS Date))
SET IDENTITY_INSERT [dbo].[Sessions] OFF
SET IDENTITY_INSERT [dbo].[Staffs] ON 

INSERT [dbo].[Staffs] ([StaffID], [DesignationID], [Name], [TCNO], [Gender], [Address], [ContactNo], [Status]) VALUES (1, 1, N'İlker İspir', N'45485125184', 0, N'Maltepe', N'53444584581', 1)
INSERT [dbo].[Staffs] ([StaffID], [DesignationID], [Name], [TCNO], [Gender], [Address], [ContactNo], [Status]) VALUES (2, 2, N'Ada Lovelace', N'5848515618', 1, N'London', N'54848784512', 1)
INSERT [dbo].[Staffs] ([StaffID], [DesignationID], [Name], [TCNO], [Gender], [Address], [ContactNo], [Status]) VALUES (3, 2, N'Temp', N'11111111111', 1, N'Ankara', N'4444444444', 0)
SET IDENTITY_INSERT [dbo].[Staffs] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentID], [SessionID], [DepartmentID], [ProgramID], [StaffID], [Name], [TCNO], [Status], [Gender], [EnrollNo], [ContactNo], [Address], [RegisterDate]) VALUES (7, 1, 1, 1, 1, N'James Gosling', N'54546488521', 1, 0, N'190101041', N'15484561484', N'New York', CAST(N'2019-12-18T08:51:54.530' AS DateTime))
INSERT [dbo].[Students] ([StudentID], [SessionID], [DepartmentID], [ProgramID], [StaffID], [Name], [TCNO], [Status], [Gender], [EnrollNo], [ContactNo], [Address], [RegisterDate]) VALUES (8, 1, 1, 1, 1, N'Grace Hopper', N'56165485152', 1, 1, N'180102025', N'154885152546', N'Arlington', CAST(N'2019-12-18T20:03:01.550' AS DateTime))
INSERT [dbo].[Students] ([StudentID], [SessionID], [DepartmentID], [ProgramID], [StaffID], [Name], [TCNO], [Status], [Gender], [EnrollNo], [ContactNo], [Address], [RegisterDate]) VALUES (9, 1, 1, 1, 1, N'ilker', N'445', 0, 0, N'34324', N'343', N'sdfsdf', CAST(N'2019-12-19T11:28:52.080' AS DateTime))
INSERT [dbo].[Students] ([StudentID], [SessionID], [DepartmentID], [ProgramID], [StaffID], [Name], [TCNO], [Status], [Gender], [EnrollNo], [ContactNo], [Address], [RegisterDate]) VALUES (10, 1, 1, 1, 1, N'Trinity ', N'35435545544', 1, 1, N'34234325', N'5452352312', N'LA', CAST(N'2019-12-19T20:03:34.573' AS DateTime))
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[UserPrivileges] ON 

INSERT [dbo].[UserPrivileges] ([UserPrivilege], [StaffID], [Configuration], [Staff], [Student], [Book], [IssueBook], [ReturnBook], [Report], [Gsm], [Email]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[UserPrivileges] ([UserPrivilege], [StaffID], [Configuration], [Staff], [Student], [Book], [IssueBook], [ReturnBook], [Report], [Gsm], [Email]) VALUES (2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[UserPrivileges] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [StaffID], [UserName], [Password]) VALUES (1, 1, N'ilker', N'asd')
INSERT [dbo].[Users] ([UserID], [StaffID], [UserName], [Password]) VALUES (2, 2, N'ada', N'asd')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Staffs] ADD  CONSTRAINT [DF_Staffs_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_Configuration]  DEFAULT ((0)) FOR [Configuration]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_Staff]  DEFAULT ((0)) FOR [Staff]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_Student]  DEFAULT ((0)) FOR [Student]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_Book]  DEFAULT ((0)) FOR [Book]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_IssueBook]  DEFAULT ((0)) FOR [IssueBook]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_ReturnBook]  DEFAULT ((0)) FOR [ReturnBook]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_Report]  DEFAULT ((0)) FOR [Report]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_Gsm]  DEFAULT ((0)) FOR [Gsm]
GO
ALTER TABLE [dbo].[UserPrivileges] ADD  CONSTRAINT [DF_UserPrivileges_Email]  DEFAULT ((0)) FOR [Email]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_BookTypes] FOREIGN KEY([BookCategoryID])
REFERENCES [dbo].[BookCategories] ([BookCategoryID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_BookTypes]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Departments]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Staffs]
GO
ALTER TABLE [dbo].[Fines]  WITH CHECK ADD  CONSTRAINT [FK_Fines_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[Fines] CHECK CONSTRAINT [FK_Fines_Books]
GO
ALTER TABLE [dbo].[Fines]  WITH CHECK ADD  CONSTRAINT [FK_Fines_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffID])
GO
ALTER TABLE [dbo].[Fines] CHECK CONSTRAINT [FK_Fines_Staffs]
GO
ALTER TABLE [dbo].[Fines]  WITH CHECK ADD  CONSTRAINT [FK_Fines_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[Fines] CHECK CONSTRAINT [FK_Fines_Students]
GO
ALTER TABLE [dbo].[IssueBooks]  WITH CHECK ADD  CONSTRAINT [FK_IssueBooks_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[IssueBooks] CHECK CONSTRAINT [FK_IssueBooks_Books]
GO
ALTER TABLE [dbo].[IssueBooks]  WITH CHECK ADD  CONSTRAINT [FK_IssueBooks_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffID])
GO
ALTER TABLE [dbo].[IssueBooks] CHECK CONSTRAINT [FK_IssueBooks_Staffs]
GO
ALTER TABLE [dbo].[IssueBooks]  WITH CHECK ADD  CONSTRAINT [FK_IssueBooks_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[IssueBooks] CHECK CONSTRAINT [FK_IssueBooks_Students]
GO
ALTER TABLE [dbo].[ReturnBooks]  WITH CHECK ADD  CONSTRAINT [FK_ReturnBooks_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[ReturnBooks] CHECK CONSTRAINT [FK_ReturnBooks_Books]
GO
ALTER TABLE [dbo].[ReturnBooks]  WITH CHECK ADD  CONSTRAINT [FK_ReturnBooks_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffID])
GO
ALTER TABLE [dbo].[ReturnBooks] CHECK CONSTRAINT [FK_ReturnBooks_Staffs]
GO
ALTER TABLE [dbo].[ReturnBooks]  WITH CHECK ADD  CONSTRAINT [FK_ReturnBooks_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[ReturnBooks] CHECK CONSTRAINT [FK_ReturnBooks_Students]
GO
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD  CONSTRAINT [FK_Staffs_Designations] FOREIGN KEY([DesignationID])
REFERENCES [dbo].[Designations] ([DesignationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Staffs] CHECK CONSTRAINT [FK_Staffs_Designations]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Departments] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Departments]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Programs] FOREIGN KEY([ProgramID])
REFERENCES [dbo].[Programs] ([ProgramID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Programs]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Sessions] FOREIGN KEY([SessionID])
REFERENCES [dbo].[Sessions] ([SessionID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Sessions]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Staffs]
GO
ALTER TABLE [dbo].[UserPrivileges]  WITH CHECK ADD  CONSTRAINT [FK_UserPrivileges_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserPrivileges] CHECK CONSTRAINT [FK_UserPrivileges_Staffs]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Staffs]
GO
