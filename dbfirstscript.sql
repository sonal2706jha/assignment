USE [master]
GO
/****** Object:  Database [Entity]    Script Date: 22-03-2020 00:42:17 ******/
CREATE DATABASE [Entity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Entity', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Entity.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Entity_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Entity_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Entity] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Entity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Entity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Entity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Entity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Entity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Entity] SET ARITHABORT OFF 
GO
ALTER DATABASE [Entity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Entity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Entity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Entity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Entity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Entity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Entity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Entity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Entity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Entity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Entity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Entity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Entity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Entity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Entity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Entity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Entity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Entity] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Entity] SET  MULTI_USER 
GO
ALTER DATABASE [Entity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Entity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Entity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Entity] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Entity] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Entity] SET QUERY_STORE = OFF
GO
USE [Entity]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 22-03-2020 00:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NULL,
	[CustomerCity] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22-03-2020 00:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[ProductId] [int] NULL,
	[OrderQuantity] [int] NULL,
	[OrderAddress] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 22-03-2020 00:42:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [CustomerCity]) VALUES (1, N'Abhishek', N'Allahabad')
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [CustomerCity]) VALUES (2, N'Neha', N'Noida')
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [CustomerCity]) VALUES (3, N'Punita', N'Faridabad')
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [CustomerCity]) VALUES (4, N'Sonal', N'Varanasi')
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [CustomerCity]) VALUES (5, N'Vijay', N'Aligadh')
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [CustomerCity]) VALUES (7, N'Punya', NULL)
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [ProductId], [OrderQuantity], [OrderAddress]) VALUES (1, 1, 1, 2, N'Delhi')
GO
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [ProductId], [OrderQuantity], [OrderAddress]) VALUES (2, 1, 2, 5, N'Patna')
GO
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [ProductId], [OrderQuantity], [OrderAddress]) VALUES (3, 2, 3, 4, N'Kerla')
GO
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [ProductId], [OrderQuantity], [OrderAddress]) VALUES (4, 3, 5, 2, N'Allahabad')
GO
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [ProductId], [OrderQuantity], [OrderAddress]) VALUES (5, 4, 6, 8, N'Gaziabad')
GO
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [ProductId], [OrderQuantity], [OrderAddress]) VALUES (7, 5, 4, 3, N'Pune')
GO
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [ProductId], [OrderQuantity], [OrderAddress]) VALUES (8, 2, 6, 1, N'Mysore')
GO
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [ProductId], [OrderQuantity], [OrderAddress]) VALUES (9, 7, 7, 8, N'Mumbai')
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductId], [ProductName]) VALUES (1, N'Watch')
GO
INSERT [dbo].[Products] ([ProductId], [ProductName]) VALUES (2, N'Shirt')
GO
INSERT [dbo].[Products] ([ProductId], [ProductName]) VALUES (3, N'Pen')
GO
INSERT [dbo].[Products] ([ProductId], [ProductName]) VALUES (4, N'Books')
GO
INSERT [dbo].[Products] ([ProductId], [ProductName]) VALUES (5, N'Laptop')
GO
INSERT [dbo].[Products] ([ProductId], [ProductName]) VALUES (6, N'Pencil')
GO
INSERT [dbo].[Products] ([ProductId], [ProductName]) VALUES (7, N'phone')
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
USE [master]
GO
ALTER DATABASE [Entity] SET  READ_WRITE 
GO
