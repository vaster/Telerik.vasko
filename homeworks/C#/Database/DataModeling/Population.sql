USE [master]
GO
/****** Object:  Database [Population]    Script Date: 7/11/2013 9:00:37 PM ******/
CREATE DATABASE [Population]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Population', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Population.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Population_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Population_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Population] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Population].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Population] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Population] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Population] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Population] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Population] SET ARITHABORT OFF 
GO
ALTER DATABASE [Population] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Population] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Population] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Population] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Population] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Population] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Population] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Population] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Population] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Population] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Population] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Population] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Population] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Population] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Population] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Population] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Population] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Population] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Population] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Population] SET  MULTI_USER 
GO
ALTER DATABASE [Population] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Population] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Population] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Population] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Population]
GO
/****** Object:  Table [dbo].[ADDRESS]    Script Date: 7/11/2013 9:00:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADDRESS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address_Text] [text] NOT NULL,
	[Town_Id] [int] NOT NULL,
 CONSTRAINT [PK_ADDRESS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CONTINENT]    Script Date: 7/11/2013 9:00:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTINENT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CONTINENT] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COUNTRY]    Script Date: 7/11/2013 9:00:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COUNTRY](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Continent_Id] [int] NOT NULL,
 CONSTRAINT [PK_COUNTRY] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PERSON]    Script Date: 7/11/2013 9:00:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSON](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Address_Id] [int] NOT NULL,
 CONSTRAINT [PK_PERSON] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TOWN]    Script Date: 7/11/2013 9:00:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOWN](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Country_Id] [int] NOT NULL,
 CONSTRAINT [PK_TOWN] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ADDRESS]  WITH CHECK ADD  CONSTRAINT [FK_ADDRESS_TOWN] FOREIGN KEY([Town_Id])
REFERENCES [dbo].[TOWN] ([Id])
GO
ALTER TABLE [dbo].[ADDRESS] CHECK CONSTRAINT [FK_ADDRESS_TOWN]
GO
ALTER TABLE [dbo].[COUNTRY]  WITH CHECK ADD  CONSTRAINT [FK_COUNTRY_CONTINENT] FOREIGN KEY([Continent_Id])
REFERENCES [dbo].[CONTINENT] ([Id])
GO
ALTER TABLE [dbo].[COUNTRY] CHECK CONSTRAINT [FK_COUNTRY_CONTINENT]
GO
ALTER TABLE [dbo].[PERSON]  WITH CHECK ADD  CONSTRAINT [FK_PERSON_ADDRESS] FOREIGN KEY([Address_Id])
REFERENCES [dbo].[ADDRESS] ([Id])
GO
ALTER TABLE [dbo].[PERSON] CHECK CONSTRAINT [FK_PERSON_ADDRESS]
GO
ALTER TABLE [dbo].[TOWN]  WITH CHECK ADD  CONSTRAINT [FK_TOWN_COUNTRY] FOREIGN KEY([Country_Id])
REFERENCES [dbo].[COUNTRY] ([Id])
GO
ALTER TABLE [dbo].[TOWN] CHECK CONSTRAINT [FK_TOWN_COUNTRY]
GO
USE [master]
GO
ALTER DATABASE [Population] SET  READ_WRITE 
GO
