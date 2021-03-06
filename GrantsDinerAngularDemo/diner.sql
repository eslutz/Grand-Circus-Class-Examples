USE [master]
GO
/****** Object:  Database [GrantsDiner]    Script Date: 10/19/2020 11:04:27 AM ******/
CREATE DATABASE [GrantsDiner]
GO
ALTER DATABASE [GrantsDiner] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GrantsDiner].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GrantsDiner] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GrantsDiner] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GrantsDiner] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GrantsDiner] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GrantsDiner] SET ARITHABORT OFF 
GO
ALTER DATABASE [GrantsDiner] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GrantsDiner] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GrantsDiner] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GrantsDiner] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GrantsDiner] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GrantsDiner] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GrantsDiner] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GrantsDiner] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GrantsDiner] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GrantsDiner] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GrantsDiner] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GrantsDiner] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GrantsDiner] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GrantsDiner] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GrantsDiner] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GrantsDiner] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GrantsDiner] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GrantsDiner] SET RECOVERY FULL 
GO
ALTER DATABASE [GrantsDiner] SET  MULTI_USER 
GO
ALTER DATABASE [GrantsDiner] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GrantsDiner] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GrantsDiner] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GrantsDiner] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GrantsDiner] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GrantsDiner', N'ON'
GO
ALTER DATABASE [GrantsDiner] SET QUERY_STORE = OFF
GO
USE [GrantsDiner]
GO
/****** Object:  User [testuser]    Script Date: 10/19/2020 11:04:27 AM ******/
CREATE USER [testuser] FOR LOGIN [testuser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 10/19/2020 11:04:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuItems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_MenuItem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCart]    Script Date: 10/19/2020 11:04:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCart](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[ItemID] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_ShoppingCart] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MenuItems] ON 

INSERT [dbo].[MenuItems] ([ID], [Name], [Category], [Description], [Price]) VALUES (1, N'Coffee', N'Coffee', N'Dark Roast', 2.5000)
INSERT [dbo].[MenuItems] ([ID], [Name], [Category], [Description], [Price]) VALUES (2, N'Americana', N'Coffee', N'Light Roast', 1.9900)
INSERT [dbo].[MenuItems] ([ID], [Name], [Category], [Description], [Price]) VALUES (3, N'Bagel', N'Snacks', N'Toasted and good', 3.0000)
INSERT [dbo].[MenuItems] ([ID], [Name], [Category], [Description], [Price]) VALUES (4, N'Muffin', N'Snacks', N'Blueberry', 2.5000)
SET IDENTITY_INSERT [dbo].[MenuItems] OFF
GO
SET IDENTITY_INSERT [dbo].[ShoppingCart] ON 

INSERT [dbo].[ShoppingCart] ([ID], [UserID], [ItemID], [Quantity]) VALUES (1, 169425, 1, 1)
INSERT [dbo].[ShoppingCart] ([ID], [UserID], [ItemID], [Quantity]) VALUES (2, 169425, 3, 2)
INSERT [dbo].[ShoppingCart] ([ID], [UserID], [ItemID], [Quantity]) VALUES (3, 642197, 3, 1)
INSERT [dbo].[ShoppingCart] ([ID], [UserID], [ItemID], [Quantity]) VALUES (4, 642197, 4, 1)
SET IDENTITY_INSERT [dbo].[ShoppingCart] OFF
GO
USE [master]
GO
ALTER DATABASE [GrantsDiner] SET  READ_WRITE 
GO
