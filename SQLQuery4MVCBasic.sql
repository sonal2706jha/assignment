USE [master]
GO
/****** Object:  Database [MVC]    Script Date: 19-04-2020 23:28:53 ******/
CREATE DATABASE [MVC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MVC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MVC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MVC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MVC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MVC] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MVC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MVC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MVC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MVC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MVC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MVC] SET ARITHABORT OFF 
GO
ALTER DATABASE [MVC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MVC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MVC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MVC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MVC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MVC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MVC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MVC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MVC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MVC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MVC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MVC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MVC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MVC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MVC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MVC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MVC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MVC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MVC] SET  MULTI_USER 
GO
ALTER DATABASE [MVC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MVC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MVC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MVC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MVC] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MVC] SET QUERY_STORE = OFF
GO
USE [MVC]
GO
/****** Object:  Table [dbo].[Emp]    Script Date: 19-04-2020 23:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19-04-2020 23:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeFirstName] [varchar](50) NULL,
	[EmployeeLastName] [varchar](50) NULL,
	[EmployeeAddress] [varchar](50) NULL,
	[EmployeeGender] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Emp] ON 
GO
INSERT [dbo].[Emp] ([ID], [Name], [Password], [City], [Address]) VALUES (1, N'Sonal', N'sss', N'MGS', N'MUGHALSARAI')
GO
INSERT [dbo].[Emp] ([ID], [Name], [Password], [City], [Address]) VALUES (2, N'Neha', N'nnn', N'NOIDA', N'DELHI')
GO
INSERT [dbo].[Emp] ([ID], [Name], [Password], [City], [Address]) VALUES (3, N'Abhishek', N'aaa', N'ALD', N'ALLAHABAD')
GO
INSERT [dbo].[Emp] ([ID], [Name], [Password], [City], [Address]) VALUES (4, N'Vishesh', N'vvv', N'VNS', N'VARANASI')
GO
INSERT [dbo].[Emp] ([ID], [Name], [Password], [City], [Address]) VALUES (6, N'Punita', NULL, N'DEL', N'DELHI')
GO
INSERT [dbo].[Emp] ([ID], [Name], [Password], [City], [Address]) VALUES (7, N'Shivam', NULL, N'DDU', N'VARANASI')
GO
INSERT [dbo].[Emp] ([ID], [Name], [Password], [City], [Address]) VALUES (9, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Emp] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeFirstName], [EmployeeLastName], [EmployeeAddress], [EmployeeGender]) VALUES (1, N'sonal', N'jha', N'varanasi ', N'female')
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeFirstName], [EmployeeLastName], [EmployeeAddress], [EmployeeGender]) VALUES (2, N'Abhishek ', N'srivastava', N'Allahabad ', N'Male')
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeFirstName], [EmployeeLastName], [EmployeeAddress], [EmployeeGender]) VALUES (3, N'Neha', N'Goel', N'Delhi ', N'Female')
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeFirstName], [EmployeeLastName], [EmployeeAddress], [EmployeeGender]) VALUES (4, N'Vijay', N'Kumar', N'Delhi ', N'Male')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
/****** Object:  StoredProcedure [dbo].[AddNewEmpDetails]    Script Date: 19-04-2020 23:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddNewEmpDetails] 
(  
   @Name varchar (50),
   @Password varchar(50),
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Insert into Emp values(@Name,@Password,@City,@Address)  
End  
GO
USE [master]
GO
ALTER DATABASE [MVC] SET  READ_WRITE 
GO
