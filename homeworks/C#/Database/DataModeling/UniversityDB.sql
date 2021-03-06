USE [master]
GO
/****** Object:  Database [UniversityDB]    Script Date: 7/12/2013 9:36:51 PM ******/
CREATE DATABASE [UniversityDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UniversityDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\UniversityDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UniversityDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\UniversityDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UniversityDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UniversityDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UniversityDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UniversityDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UniversityDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [UniversityDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UniversityDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [UniversityDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UniversityDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UniversityDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UniversityDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UniversityDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UniversityDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UniversityDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UniversityDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UniversityDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UniversityDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UniversityDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UniversityDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UniversityDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UniversityDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UniversityDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UniversityDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UniversityDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UniversityDB] SET  MULTI_USER 
GO
ALTER DATABASE [UniversityDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UniversityDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UniversityDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UniversityDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [UniversityDB]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 7/12/2013 9:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Professor_Id] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Courses_Students_Relation]    Script Date: 7/12/2013 9:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses_Students_Relation](
	[Course_Id] [int] NOT NULL,
	[Student_Id] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 7/12/2013 9:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Faculty_Id] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 7/12/2013 9:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 7/12/2013 9:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors_Tittles_Relation]    Script Date: 7/12/2013 9:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors_Tittles_Relation](
	[Professor_Id] [int] NOT NULL,
	[Tittle_Id] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Science_Tittles]    Script Date: 7/12/2013 9:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Science_Tittles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Degree] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Science_Tittles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 7/12/2013 9:36:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Faculty_Id] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Professors] FOREIGN KEY([Professor_Id])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Professors]
GO
ALTER TABLE [dbo].[Courses_Students_Relation]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Students_Relation_Courses] FOREIGN KEY([Course_Id])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[Courses_Students_Relation] CHECK CONSTRAINT [FK_Courses_Students_Relation_Courses]
GO
ALTER TABLE [dbo].[Courses_Students_Relation]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Students_Relation_Students] FOREIGN KEY([Student_Id])
REFERENCES [dbo].[Students] ([Id])
GO
ALTER TABLE [dbo].[Courses_Students_Relation] CHECK CONSTRAINT [FK_Courses_Students_Relation_Students]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([Faculty_Id])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Professors_Tittles_Relation]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Tittles_Relation_Professors] FOREIGN KEY([Professor_Id])
REFERENCES [dbo].[Professors] ([Id])
GO
ALTER TABLE [dbo].[Professors_Tittles_Relation] CHECK CONSTRAINT [FK_Professors_Tittles_Relation_Professors]
GO
ALTER TABLE [dbo].[Professors_Tittles_Relation]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Tittles_Relation_Science_Tittles] FOREIGN KEY([Tittle_Id])
REFERENCES [dbo].[Science_Tittles] ([Id])
GO
ALTER TABLE [dbo].[Professors_Tittles_Relation] CHECK CONSTRAINT [FK_Professors_Tittles_Relation_Science_Tittles]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([Id])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
USE [master]
GO
ALTER DATABASE [UniversityDB] SET  READ_WRITE 
GO
