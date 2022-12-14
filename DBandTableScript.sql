USE [master]
GO
/****** Object:  Database [AffinitySoftwarePraticalDb]    Script Date: 2022/08/07 12:21:37 AM ******/
CREATE DATABASE [AffinitySoftwarePraticalDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AffinitySoftwarePraticalDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AffinitySoftwarePraticalDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AffinitySoftwarePraticalDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AffinitySoftwarePraticalDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AffinitySoftwarePraticalDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET RECOVERY FULL 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET  MULTI_USER 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AffinitySoftwarePraticalDb', N'ON'
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET QUERY_STORE = OFF
GO
USE [AffinitySoftwarePraticalDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2022/08/07 12:21:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2022/08/07 12:21:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK__Customer__3214EC07EB4AAC98] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2022/08/07 12:21:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
 CONSTRAINT [PK__Order__3214EC077B3A5799] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 2022/08/07 12:21:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [numeric](15, 3) NOT NULL,
	[ItemDescription] [varchar](200) NOT NULL,
 CONSTRAINT [PK__OrderDet__3214EC079C88C554] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF__Order__OrderDate__267ABA7A]  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Customer] FOREIGN KEY([Id])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
USE [master]
GO
ALTER DATABASE [AffinitySoftwarePraticalDb] SET  READ_WRITE 
GO
