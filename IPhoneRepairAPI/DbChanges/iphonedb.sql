USE [master]
GO
/****** Object:  Database [IPhoneRepair]    Script Date: 12/20/2021 9:23:56 PM ******/
CREATE DATABASE [IPhoneRepair]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IPhoneRepair', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\IPhoneRepair.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IPhoneRepair_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\IPhoneRepair_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [IPhoneRepair] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IPhoneRepair].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IPhoneRepair] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IPhoneRepair] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IPhoneRepair] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IPhoneRepair] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IPhoneRepair] SET ARITHABORT OFF 
GO
ALTER DATABASE [IPhoneRepair] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [IPhoneRepair] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IPhoneRepair] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IPhoneRepair] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IPhoneRepair] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IPhoneRepair] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IPhoneRepair] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IPhoneRepair] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IPhoneRepair] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IPhoneRepair] SET  ENABLE_BROKER 
GO
ALTER DATABASE [IPhoneRepair] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IPhoneRepair] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IPhoneRepair] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IPhoneRepair] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IPhoneRepair] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IPhoneRepair] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IPhoneRepair] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IPhoneRepair] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IPhoneRepair] SET  MULTI_USER 
GO
ALTER DATABASE [IPhoneRepair] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IPhoneRepair] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IPhoneRepair] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IPhoneRepair] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [IPhoneRepair] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [IPhoneRepair] SET QUERY_STORE = OFF
GO
USE [IPhoneRepair]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [IPhoneRepair]
GO
/****** Object:  Table [dbo].[CompanyMenu]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyMenu](
	[AutoId] [bigint] IDENTITY(1,1) NOT NULL,
	[MenuName] [varchar](250) NULL,
	[MenuUrl] [varchar](500) NULL,
	[IUser] [varchar](100) NULL,
	[Idate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quote_contact]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quote_contact](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[Query] [varchar](max) NULL,
	[Location] [varchar](500) NULL,
	[Repair_type] [varchar](100) NULL,
	[idate] [datetime] NULL,
	[QueryType] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubMenuTb]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubMenuTb](
	[AutoId] [bigint] IDENTITY(1,1) NOT NULL,
	[MenuName] [varchar](250) NULL,
	[SubMenu] [varchar](250) NULL,
	[MenuUrl] [varchar](500) NULL,
	[IUser] [varchar](100) NULL,
	[Idate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CompanyMenu] ON 

INSERT [dbo].[CompanyMenu] ([AutoId], [MenuName], [MenuUrl], [IUser], [Idate]) VALUES (1, N'Nokia', N'CompanyMenu.html', N'', CAST(N'2021-12-19T19:27:25.653' AS DateTime))
INSERT [dbo].[CompanyMenu] ([AutoId], [MenuName], [MenuUrl], [IUser], [Idate]) VALUES (3, N'Samsung', N'ComanyMneu.html', N'', CAST(N'2021-12-19T20:00:44.547' AS DateTime))
INSERT [dbo].[CompanyMenu] ([AutoId], [MenuName], [MenuUrl], [IUser], [Idate]) VALUES (4, N'IPhone', N'ComanyMneu.html', N'', CAST(N'2021-12-19T20:01:20.330' AS DateTime))
INSERT [dbo].[CompanyMenu] ([AutoId], [MenuName], [MenuUrl], [IUser], [Idate]) VALUES (5, N'Redmi', N'ComapnyMenu.html', N'', CAST(N'2021-12-19T20:02:47.090' AS DateTime))
SET IDENTITY_INSERT [dbo].[CompanyMenu] OFF
SET IDENTITY_INSERT [dbo].[Quote_contact] ON 

INSERT [dbo].[Quote_contact] ([Id], [Name], [Phone], [Email], [Query], [Location], [Repair_type], [idate], [QueryType]) VALUES (1, N'string', N'string', N'ashu gmao.com', N'string', N'string', N'string', CAST(N'2021-12-16T21:02:04.917' AS DateTime), NULL)
INSERT [dbo].[Quote_contact] ([Id], [Name], [Phone], [Email], [Query], [Location], [Repair_type], [idate], [QueryType]) VALUES (2, N'sdfds', N'', N'ash@gmail.com', N'hffj', N'sdfhgg', N'', CAST(N'2021-12-19T16:39:51.517' AS DateTime), N'Contact')
SET IDENTITY_INSERT [dbo].[Quote_contact] OFF
SET IDENTITY_INSERT [dbo].[SubMenuTb] ON 

INSERT [dbo].[SubMenuTb] ([AutoId], [MenuName], [SubMenu], [MenuUrl], [IUser], [Idate]) VALUES (1, N'Nokia', N'5233', N'SubMenu.html', N'', CAST(N'2021-12-20T20:21:31.067' AS DateTime))
INSERT [dbo].[SubMenuTb] ([AutoId], [MenuName], [SubMenu], [MenuUrl], [IUser], [Idate]) VALUES (2, N'Samsung', N'Guru', N'SubMenu.html', N'', CAST(N'2021-12-20T20:23:32.310' AS DateTime))
INSERT [dbo].[SubMenuTb] ([AutoId], [MenuName], [SubMenu], [MenuUrl], [IUser], [Idate]) VALUES (3, N'IPhone', N'11', N'SubMenu.html', N'', CAST(N'2021-12-20T20:23:49.750' AS DateTime))
SET IDENTITY_INSERT [dbo].[SubMenuTb] OFF
ALTER TABLE [dbo].[CompanyMenu] ADD  DEFAULT (getdate()) FOR [Idate]
GO
ALTER TABLE [dbo].[Quote_contact] ADD  DEFAULT (getdate()) FOR [idate]
GO
ALTER TABLE [dbo].[SubMenuTb] ADD  DEFAULT (getdate()) FOR [Idate]
GO
/****** Object:  StoredProcedure [dbo].[AddCompanyMenu]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[AddCompanyMenu]
(
@Autoid bigint=null,
@MenuName varchar(250)=null,
@Url varchar(500)=null,
@UserName varchar(100)=null
)
as
Begin
  Insert into CompanyMenu(MenuName,MenuUrl,IUser)
  values(@MenuName,@Url,@UserName)
End
GO
/****** Object:  StoredProcedure [dbo].[AddContact]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddContact]
(
@Id bigint=null,
@Name varchar(100)=null,
@Phone varchar(20)=null,
@Email varchar(50)=null,
@Query varchar(max)=null,
@Location varchar(500)=null,
@Repair_type varchar(100)=null,
@QueryType varchar(50)=null
)
as
Begin
  Insert into Quote_contact(Name,Phone,Email,Query,Location,Repair_type,QueryType)
  values(@Name,@Phone,@Email,@Query,@Location,@Repair_type,@QueryType)
End
GO
/****** Object:  StoredProcedure [dbo].[AddSubMenu]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[AddSubMenu]
(
@Autoid bigint=null,
@MenuName varchar(250)=null,
@SubMenu varchar(250)=null,
@Url varchar(500)=null,
@UserName varchar(100)=null
)
as
Begin
  Insert into SubMenuTb(MenuName,SubMenu,MenuUrl,IUser)
  values(@MenuName,@SubMenu,@Url,@UserName)
End
GO
/****** Object:  StoredProcedure [dbo].[UpdateCompanyMenu]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdateCompanyMenu]
(
@Autoid bigint=null,
@MenuName varchar(250)=null,
@Url varchar(500)=null,
@UserName varchar(100)=null
)
as
Begin
  update CompanyMenu set MenuName=@MenuName,MenuUrl=@Url,IUser=@UserName
  where Autoid=@Autoid
End
GO
/****** Object:  StoredProcedure [dbo].[UpdateContactDetails]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdateContactDetails]
(
@Id bigint=null,
@Name varchar(100)=null,
@Phone varchar(20)=null,
@Email varchar(50)=null,
@Query varchar(max)=null,
@Location varchar(500)=null,
@Repair_type varchar(100)=null
)
as
Begin
  update Quote_contact set Name=@Name,Phone=@Phone,Email=@Email,Query=@Query,Location=@Location,Repair_type=@Repair_type
  where Id=@Id
End
GO
/****** Object:  StoredProcedure [dbo].[UpdateSubMenu]    Script Date: 12/20/2021 9:23:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdateSubMenu]
(
@Autoid bigint=null,
@MenuName varchar(250)=null,
@SubMenu varchar(250)=null,
@Url varchar(500)=null,
@UserName varchar(100)=null
)
as
Begin
  update SubMenutb set MenuName=@MenuName,SubMenu=@SubMenu, MenuUrl=@Url,IUser=@UserName
  where Autoid=@Autoid
End
GO
USE [master]
GO
ALTER DATABASE [IPhoneRepair] SET  READ_WRITE 
GO
