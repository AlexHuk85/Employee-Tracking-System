USE [master]
GO
/****** Object:  Database [EmployeeTrackingDB]    Script Date: 8/11/2018 8:36:19 PM ******/
CREATE DATABASE [EmployeeTrackingDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeTrackingDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\EmployeeTrackingDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeTrackingDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\EmployeeTrackingDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeTrackingDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeTrackingDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeTrackingDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeTrackingDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeTrackingDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeTrackingDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET RECOVERY FULL 
GO
ALTER DATABASE [EmployeeTrackingDB] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeTrackingDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeTrackingDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeTrackingDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeTrackingDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EmployeeTrackingDB', N'ON'
GO
USE [EmployeeTrackingDB]
GO
/****** Object:  Schema [SchemaETS]    Script Date: 8/11/2018 8:36:20 PM ******/
CREATE SCHEMA [SchemaETS]
GO
/****** Object:  Table [dbo].[EmpHoursTbl]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpHoursTbl](
	[EmpHoursID] [int] IDENTITY(1,1) NOT NULL,
	[EmpID] [int] NOT NULL,
	[WorkDate] [date] NOT NULL,
	[Hours] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_EmpHoursTbl] PRIMARY KEY CLUSTERED 
(
	[EmpHoursID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTbl]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTbl](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[LastName] [varchar](20) NOT NULL,
	[Email] [varchar](50) NULL,
	[DOB] [date] NULL,
	[Phone] [varchar](20) NULL,
 CONSTRAINT [PK_EmployeeTbl] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EmpHoursTbl] ON 

INSERT [dbo].[EmpHoursTbl] ([EmpHoursID], [EmpID], [WorkDate], [Hours]) VALUES (1, 1, CAST(N'2018-10-11' AS Date), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[EmpHoursTbl] ([EmpHoursID], [EmpID], [WorkDate], [Hours]) VALUES (2, 2, CAST(N'2018-10-12' AS Date), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[EmpHoursTbl] ([EmpHoursID], [EmpID], [WorkDate], [Hours]) VALUES (3, 3, CAST(N'2018-10-13' AS Date), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[EmpHoursTbl] ([EmpHoursID], [EmpID], [WorkDate], [Hours]) VALUES (4, 4, CAST(N'2018-10-14' AS Date), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[EmpHoursTbl] ([EmpHoursID], [EmpID], [WorkDate], [Hours]) VALUES (5, 5, CAST(N'2018-10-15' AS Date), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[EmpHoursTbl] ([EmpHoursID], [EmpID], [WorkDate], [Hours]) VALUES (23, 1, CAST(N'2018-11-08' AS Date), CAST(9.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[EmpHoursTbl] OFF
SET IDENTITY_INSERT [dbo].[EmployeeTbl] ON 

INSERT [dbo].[EmployeeTbl] ([EmpID], [FirstName], [LastName], [Email], [DOB], [Phone]) VALUES (1, N'Alex', N'Huk', N'222@gmail.com', CAST(N'1985-07-25' AS Date), N'12345678')
INSERT [dbo].[EmployeeTbl] ([EmpID], [FirstName], [LastName], [Email], [DOB], [Phone]) VALUES (2, N'Sample2', N'Last2', N'456@gmail.com', CAST(N'2010-02-02' AS Date), N'234567')
INSERT [dbo].[EmployeeTbl] ([EmpID], [FirstName], [LastName], [Email], [DOB], [Phone]) VALUES (3, N'Sample3', N'Last3', N'789@gmail.com', CAST(N'2010-03-03' AS Date), N'2134565')
INSERT [dbo].[EmployeeTbl] ([EmpID], [FirstName], [LastName], [Email], [DOB], [Phone]) VALUES (4, N'Sample4', N'Last4', N'abc@gmail.com', CAST(N'2010-04-04' AS Date), N'234566')
INSERT [dbo].[EmployeeTbl] ([EmpID], [FirstName], [LastName], [Email], [DOB], [Phone]) VALUES (5, N'Sample5', N'Last5', N'efg@gmail.com', CAST(N'2010-05-05' AS Date), N'1234555')
SET IDENTITY_INSERT [dbo].[EmployeeTbl] OFF
ALTER TABLE [dbo].[EmpHoursTbl]  WITH CHECK ADD  CONSTRAINT [FK_EmpHoursTbl_EmployeeTbl] FOREIGN KEY([EmpID])
REFERENCES [dbo].[EmployeeTbl] ([EmpID])
GO
ALTER TABLE [dbo].[EmpHoursTbl] CHECK CONSTRAINT [FK_EmpHoursTbl_EmployeeTbl]
GO
/****** Object:  StoredProcedure [dbo].[SP_EmpHoursTbl_InsertHours]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Alex Huk Kok Lung
-- Create date: 16/10/2018
-- Description: Insert into EmpHoursTbl
-- =============================================
CREATE PROCEDURE [dbo].[SP_EmpHoursTbl_InsertHours]
	@empid int,
	@workdate date,
	@hours decimal(5, 2)
AS
BEGIN
	Insert Into EmpHoursTbl(EmpID, WorkDate, Hours)
	Values(@empid, @workdate, @hours)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmpHoursTbl_SelectDateHoursByID]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Alex huk Kok Lung
-- Create date: 10/10/2018
-- Description:	Selct work date and hours by ID
-- =============================================
CREATE PROCEDURE [dbo].[SP_EmpHoursTbl_SelectDateHoursByID]
	@empid int
AS
BEGIN
	Select WorkDate, Hours
	From EmpHoursTbl
	Where EmpID = @empid
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmpHoursTbl_SumHours]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Alex Huk Kok Lung
-- Create date: 08/11/2018
-- Description:	Sum total worked hours
-- =============================================
CREATE PROCEDURE [dbo].[SP_EmpHoursTbl_SumHours]
	@empid int
AS
BEGIN
	Select Sum(Hours)
	From EmpHoursTbl
	Where EmpID = @empid
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeTbl_Delete]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Alex Huk
-- Create date: 03/11/2018
-- Description:	Delete From EmployeeTbl amd EmpHoursTbl by EmpID
-- =============================================
CREATE PROCEDURE [dbo].[SP_EmployeeTbl_Delete] 
	@empid int
AS
BEGIN
	Delete From EmpHoursTbl
	Where EmpID = @empid

	Delete From EmployeeTbl
	Where EmpID = @empid


END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeTbl_InsertEmployee]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Alex Huk Kok Lung
-- Create date: 16/10/2018
-- Description:	Insert Employee into EmployeeTbl
-- =============================================
CREATE PROCEDURE [dbo].[SP_EmployeeTbl_InsertEmployee]
	@firstname varchar(20),
	@lastname varchar(20),
	@email varchar(50),
	@dob date,
	@phone varchar(20)
AS
BEGIN
	Insert Into EmployeeTbl(FirstName, LastName, Email, DOB, Phone)
	Values(@firstname, @lastname, @email, @dob, @phone)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeTbl_SelectAll]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Alex Huk Kok Lung
-- Create date: 16/10/2018
-- Description: Select All Employee
-- =============================================
CREATE PROCEDURE [dbo].[SP_EmployeeTbl_SelectAll]
	
AS
BEGIN
	Select *
	From EmployeeTbl
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeTbl_SelectByEmail]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Alex Huk Kok Lung
-- Create date: 16/10/2018
-- Description:Select Employee by Email

-- =============================================
CREATE PROCEDURE [dbo].[SP_EmployeeTbl_SelectByEmail]
	@email varchar(50)
AS
BEGIN
	Select *
	From EmployeeTbl
	Where @email = Email
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeTbl_SelectByID]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Alex Huk Kok Lung
-- Create date: 16/10/2018
-- Description: Select Employee by ID

-- =============================================
CREATE PROCEDURE [dbo].[SP_EmployeeTbl_SelectByID]
	@empid int
AS
BEGIN
	Select *
	From EmployeeTbl
	Where @empid = EmpID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeTbl_UpdateEmployeeTbl]    Script Date: 8/11/2018 8:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Alex Huk Kok Lung
-- Create date: 16/10/2018
-- Description:	Update Employee in EmployeeTbl
-- =============================================
CREATE PROCEDURE [dbo].[SP_EmployeeTbl_UpdateEmployeeTbl] 
	@empid int,
	@firstname varchar(20),
	@lastname varchar(20),
	@email varchar(50),
	@dob date,
	@phone varchar(20)
AS
BEGIN
	Update EmployeeTbl
	Set FirstName = @firstname,
	LastName = @lastname,
	Email = @email,
	DOB = @dob,
	Phone = @phone
	Where EmpID = @empid
END
GO
USE [master]
GO
ALTER DATABASE [EmployeeTrackingDB] SET  READ_WRITE 
GO
