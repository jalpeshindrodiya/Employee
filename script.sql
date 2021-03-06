USE [EmployeesManagement]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 7/6/2022 10:07:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[DepID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](100) NULL,
	[Description] [varchar](200) NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[DepID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 7/6/2022 10:07:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EMPID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Email] [varchar](255) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Salary] [float] NULL,
	[ImageName] [varchar](100) NULL,
	[DepID] [int] NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[EMPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DepID], [DepartmentName], [Description], [IsActive]) VALUES (1, N'HR', N'HR Description', 1)
INSERT [dbo].[Department] ([DepID], [DepartmentName], [Description], [IsActive]) VALUES (7, N'Marketing', N'Marketing Description', 1)
INSERT [dbo].[Department] ([DepID], [DepartmentName], [Description], [IsActive]) VALUES (8, N'Finace', N'Finace Desc', 1)
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EMPID], [FirstName], [LastName], [Email], [PhoneNumber], [Salary], [ImageName], [DepID], [IsActive]) VALUES (1, N'jalpesh', N'Indrodiya', N'jalpeshindrodiya@gmail.com', N'+919898347461', 200000, NULL, 1, 1)
INSERT [dbo].[Employee] ([EMPID], [FirstName], [LastName], [Email], [PhoneNumber], [Salary], [ImageName], [DepID], [IsActive]) VALUES (6, N'divya', N'mehta', N'div@gmail.com', N'+912345346789', 50000, NULL, 7, 1)
INSERT [dbo].[Employee] ([EMPID], [FirstName], [LastName], [Email], [PhoneNumber], [Salary], [ImageName], [DepID], [IsActive]) VALUES (7, N'dhara', N'patel', N'dhara@gmail.com', N'+912345346789', 20000, NULL, 8, 1)
INSERT [dbo].[Employee] ([EMPID], [FirstName], [LastName], [Email], [PhoneNumber], [Salary], [ImageName], [DepID], [IsActive]) VALUES (8, N'dharanew', N'patelnew', N'dharanew@gmail.com', N'+919725639461', 20000, NULL, 7, 1)
INSERT [dbo].[Employee] ([EMPID], [FirstName], [LastName], [Email], [PhoneNumber], [Salary], [ImageName], [DepID], [IsActive]) VALUES (9, N'test1', N'tes', N'tes@gmail.com', NULL, 20000, NULL, 7, 1)
INSERT [dbo].[Employee] ([EMPID], [FirstName], [LastName], [Email], [PhoneNumber], [Salary], [ImageName], [DepID], [IsActive]) VALUES (10, N'te', N'st', N'te', NULL, 50000, N'20220706094603.png', 1, 1)
SET IDENTITY_INSERT [dbo].[Employee] OFF
