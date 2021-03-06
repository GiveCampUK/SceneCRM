USE [master]
GO
/****** Object:  Database [SceneCRM]    Script Date: 10/22/2011 12:22:02 ******/
CREATE DATABASE [SceneCRM] ON  PRIMARY 
( NAME = N'SceneCRM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SceneCRM.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SceneCRM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SceneCRM_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SceneCRM] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SceneCRM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SceneCRM] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SceneCRM] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SceneCRM] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SceneCRM] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SceneCRM] SET ARITHABORT OFF
GO
ALTER DATABASE [SceneCRM] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SceneCRM] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SceneCRM] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SceneCRM] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SceneCRM] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SceneCRM] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SceneCRM] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SceneCRM] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SceneCRM] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SceneCRM] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SceneCRM] SET  DISABLE_BROKER
GO
ALTER DATABASE [SceneCRM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SceneCRM] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SceneCRM] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SceneCRM] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SceneCRM] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SceneCRM] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SceneCRM] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SceneCRM] SET  READ_WRITE
GO
ALTER DATABASE [SceneCRM] SET RECOVERY FULL
GO
ALTER DATABASE [SceneCRM] SET  MULTI_USER
GO
ALTER DATABASE [SceneCRM] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SceneCRM] SET DB_CHAINING OFF
GO
USE [SceneCRM]
GO
/****** Object:  Table [dbo].[CourseType]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CourseType](
	[CourseTypeCode] [varchar](8) NOT NULL,
	[CourseTypeName] [varchar](64) NULL,
 CONSTRAINT [PK_CourseType] PRIMARY KEY CLUSTERED 
(
	[CourseTypeCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Production]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Production](
	[ProductionId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](64) NULL,
 CONSTRAINT [PK_Production] PRIMARY KEY CLUSTERED 
(
	[ProductionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Child]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Child](
	[ChildId] [int] NOT NULL,
	[Reference] [varchar](16) NOT NULL,
	[FirstName] [varchar](64) NULL,
	[Surname] [varchar](64) NOT NULL,
 CONSTRAINT [PK_Child] PRIMARY KEY CLUSTERED 
(
	[ChildId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Play]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Play](
	[PlayId] [int] IDENTITY(1,1) NOT NULL,
	[ChildId] [int] NOT NULL,
	[Title] [varchar](128) NULL,
 CONSTRAINT [PK_Play] PRIMARY KEY CLUSTERED 
(
	[PlayId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Performance]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Performance](
	[PerformanceId] [int] NULL,
	[ProductionId] [int] NULL,
	[PerformanceDateTime] [datetime] NULL,
	[EventBriteId] [varchar](64) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Job]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Job](
	[JobId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](64) NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Defines the various roles - director, dramaturge, box office, etc - filled by volunteers' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Job'
GO
/****** Object:  Table [dbo].[Volunteer]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Volunteer](
	[VolunteerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](64) NULL,
	[Surname] [varchar](64) NULL,
 CONSTRAINT [PK_Volunteer] PRIMARY KEY CLUSTERED 
(
	[VolunteerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Term]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Term](
	[TermId] [int] NOT NULL,
	[TermName] [varchar](16) NULL,
 CONSTRAINT [PK_Term] PRIMARY KEY CLUSTERED 
(
	[TermId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VolunteerCapability]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VolunteerCapability](
	[VolunteerId] [int] NOT NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK_VolunteerCapability] PRIMARY KEY CLUSTERED 
(
	[VolunteerId] ASC,
	[JobId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductionVolunteer]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductionVolunteer](
	[VounteerId] [int] NOT NULL,
	[JobId] [int] NOT NULL,
	[ProductionId] [int] NOT NULL,
	[Notes] [varchar](2048) NULL,
 CONSTRAINT [PK_ProductionVolunteer] PRIMARY KEY CLUSTERED 
(
	[VounteerId] ASC,
	[JobId] ASC,
	[ProductionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CrbCheck]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CrbCheck](
	[CrbCheckId] [int] IDENTITY(1,1) NOT NULL,
	[VolunteerId] [int] NULL,
	[CheckDate] [datetime] NULL,
	[CrbNumber] [varchar](32) NULL,
	[OnlineFormSent] [datetime] NULL,
	[FormFilledOut] [datetime] NULL,
	[DateCheckExpires] [datetime] NULL,
	[IdComplete] [datetime] NULL,
 CONSTRAINT [PK_CrbCheck] PRIMARY KEY CLUSTERED 
(
	[CrbCheckId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Course]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] NOT NULL,
	[CourseTypeCode] [varchar](8) NULL,
	[TermId] [int] NULL,
	[Year] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PlayVolunteer]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PlayVolunteer](
	[PlayId] [int] NOT NULL,
	[VolunteerId] [int] NOT NULL,
	[JobId] [int] NOT NULL,
	[Notes] [varchar](2048) NULL,
 CONSTRAINT [PK_PlayVolunteer] PRIMARY KEY CLUSTERED 
(
	[PlayId] ASC,
	[VolunteerId] ASC,
	[JobId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CourseAttendance]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseAttendance](
	[ChildId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
	[Completed] [bit] NULL,
 CONSTRAINT [PK_CourseAttendance] PRIMARY KEY CLUSTERED 
(
	[ChildId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseVolunteer]    Script Date: 10/22/2011 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CourseVolunteer](
	[CourseId] [int] NOT NULL,
	[VolunteerId] [int] NOT NULL,
	[JobId] [int] NOT NULL,
	[Notes] [varchar](2048) NULL,
 CONSTRAINT [PK_CourseVolunteer] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC,
	[VolunteerId] ASC,
	[JobId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_VolunteerCapability_Job]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[VolunteerCapability]  WITH CHECK ADD  CONSTRAINT [FK_VolunteerCapability_Job] FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[VolunteerCapability] CHECK CONSTRAINT [FK_VolunteerCapability_Job]
GO
/****** Object:  ForeignKey [FK_VolunteerCapability_Volunteer]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[VolunteerCapability]  WITH CHECK ADD  CONSTRAINT [FK_VolunteerCapability_Volunteer] FOREIGN KEY([VolunteerId])
REFERENCES [dbo].[Volunteer] ([VolunteerId])
GO
ALTER TABLE [dbo].[VolunteerCapability] CHECK CONSTRAINT [FK_VolunteerCapability_Volunteer]
GO
/****** Object:  ForeignKey [FK_ProductionVolunteer_Production]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[ProductionVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_ProductionVolunteer_Production] FOREIGN KEY([ProductionId])
REFERENCES [dbo].[Production] ([ProductionId])
GO
ALTER TABLE [dbo].[ProductionVolunteer] CHECK CONSTRAINT [FK_ProductionVolunteer_Production]
GO
/****** Object:  ForeignKey [FK_ProductionVolunteer_Volunteer]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[ProductionVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_ProductionVolunteer_Volunteer] FOREIGN KEY([VounteerId])
REFERENCES [dbo].[Volunteer] ([VolunteerId])
GO
ALTER TABLE [dbo].[ProductionVolunteer] CHECK CONSTRAINT [FK_ProductionVolunteer_Volunteer]
GO
/****** Object:  ForeignKey [FK_CrbCheck_Volunteer]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[CrbCheck]  WITH CHECK ADD  CONSTRAINT [FK_CrbCheck_Volunteer] FOREIGN KEY([VolunteerId])
REFERENCES [dbo].[Volunteer] ([VolunteerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CrbCheck] CHECK CONSTRAINT [FK_CrbCheck_Volunteer]
GO
/****** Object:  ForeignKey [FK_Course_CourseType]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_CourseType] FOREIGN KEY([CourseTypeCode])
REFERENCES [dbo].[CourseType] ([CourseTypeCode])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_CourseType]
GO
/****** Object:  ForeignKey [FK_Course_Term]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Term] FOREIGN KEY([TermId])
REFERENCES [dbo].[Term] ([TermId])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Term]
GO
/****** Object:  ForeignKey [FK_PlayVolunteer_Job]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[PlayVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_PlayVolunteer_Job] FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[PlayVolunteer] CHECK CONSTRAINT [FK_PlayVolunteer_Job]
GO
/****** Object:  ForeignKey [FK_PlayVolunteer_Play]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[PlayVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_PlayVolunteer_Play] FOREIGN KEY([PlayId])
REFERENCES [dbo].[Play] ([PlayId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PlayVolunteer] CHECK CONSTRAINT [FK_PlayVolunteer_Play]
GO
/****** Object:  ForeignKey [FK_PlayVolunteer_Volunteer]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[PlayVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_PlayVolunteer_Volunteer] FOREIGN KEY([VolunteerId])
REFERENCES [dbo].[Volunteer] ([VolunteerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PlayVolunteer] CHECK CONSTRAINT [FK_PlayVolunteer_Volunteer]
GO
/****** Object:  ForeignKey [FK_CourseAttendance_Child]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[CourseAttendance]  WITH CHECK ADD  CONSTRAINT [FK_CourseAttendance_Child] FOREIGN KEY([ChildId])
REFERENCES [dbo].[Child] ([ChildId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseAttendance] CHECK CONSTRAINT [FK_CourseAttendance_Child]
GO
/****** Object:  ForeignKey [FK_CourseAttendance_Course]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[CourseAttendance]  WITH CHECK ADD  CONSTRAINT [FK_CourseAttendance_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseAttendance] CHECK CONSTRAINT [FK_CourseAttendance_Course]
GO
/****** Object:  ForeignKey [FK_CourseVolunteer_Course]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[CourseVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_CourseVolunteer_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[CourseVolunteer] CHECK CONSTRAINT [FK_CourseVolunteer_Course]
GO
/****** Object:  ForeignKey [FK_CourseVolunteer_Job]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[CourseVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_CourseVolunteer_Job] FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[CourseVolunteer] CHECK CONSTRAINT [FK_CourseVolunteer_Job]
GO
/****** Object:  ForeignKey [FK_CourseVolunteer_Volunteer]    Script Date: 10/22/2011 12:22:04 ******/
ALTER TABLE [dbo].[CourseVolunteer]  WITH CHECK ADD  CONSTRAINT [FK_CourseVolunteer_Volunteer] FOREIGN KEY([VolunteerId])
REFERENCES [dbo].[Volunteer] ([VolunteerId])
GO
ALTER TABLE [dbo].[CourseVolunteer] CHECK CONSTRAINT [FK_CourseVolunteer_Volunteer]
GO
