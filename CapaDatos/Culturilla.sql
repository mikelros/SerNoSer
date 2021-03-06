USE [master]
GO
/****** Object:  Database [Culturilla]    Script Date: 21/12/2016 11:49:45 ******/
CREATE DATABASE [Culturilla]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Culturilla', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Culturilla.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Culturilla_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Culturilla_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Culturilla] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Culturilla].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Culturilla] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Culturilla] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Culturilla] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Culturilla] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Culturilla] SET ARITHABORT OFF 
GO
ALTER DATABASE [Culturilla] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Culturilla] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Culturilla] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Culturilla] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Culturilla] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Culturilla] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Culturilla] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Culturilla] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Culturilla] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Culturilla] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Culturilla] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Culturilla] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Culturilla] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Culturilla] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Culturilla] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Culturilla] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Culturilla] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Culturilla] SET RECOVERY FULL 
GO
ALTER DATABASE [Culturilla] SET  MULTI_USER 
GO
ALTER DATABASE [Culturilla] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Culturilla] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Culturilla] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Culturilla] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Culturilla] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Culturilla', N'ON'
GO
ALTER DATABASE [Culturilla] SET QUERY_STORE = OFF
GO
USE [Culturilla]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Culturilla]
GO
/****** Object:  Table [dbo].[Pregunta]    Script Date: 21/12/2016 11:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pregunta](
	[Id] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Pregunta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Respuesta]    Script Date: 21/12/2016 11:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuesta](
	[Id] [int] NOT NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
	[Explicacion] [nvarchar](100) NULL,
	[IdPregunta] [int] NOT NULL,
 CONSTRAINT [PK_Respuesta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Pregunta] ([Id], [Descripcion]) VALUES (1, N'Premios nobel de la paz')
INSERT [dbo].[Pregunta] ([Id], [Descripcion]) VALUES (2, N'Invasión hunos')
INSERT [dbo].[Pregunta] ([Id], [Descripcion]) VALUES (3, N'1º Guerra Carlista')
INSERT [dbo].[Pregunta] ([Id], [Descripcion]) VALUES (4, N'Nºs != 1, 2, 3 & 4')
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (1, N'1992 Rigoberta Menchú (Guatemala)', NULL, 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (2, N'1993 Nelson Mandela y Willem Klerk', NULL, 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (3, N'1989 Dalai Lama (Tibet)', NULL, 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (4, N'1979 Madre Teresa de Calcuta (India)', NULL, 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (5, N'2003 Shirin Ebadi (Irán)', NULL, 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (6, N'1999 Medicas sin fronteras', NULL, 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (7, N'1984 Desmond Tutú (Sudáfrica)', NULL, 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (8, N'1964 Martin Luther King', NULL, 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (9, N'2005 Campaña internacional contra minas antipersonas', N'Se lo dieron al egipcio Mohamed El-Baradei', 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (10, N'1942 Henderson, Arthur (Gran Bretaña) ', N'Durante la 2a guerra mundial no hubo premios nobel de la paz', 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (11, N'1998 Gabriel García Márquez', N'John Hume y David Trimble por solucionar conflictos en Irlanda del Norte', 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (12, N'1966 John F. Kennedy', N'No hubo porque no', 1)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (13, N'5', NULL, 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (14, N'6', NULL, 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (15, N'7', NULL, 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (16, N'8', NULL, 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (17, N'9', NULL, 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (18, N'10', NULL, 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (19, N'11', NULL, 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (20, N'12', NULL, 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (21, N'1', N'1 = 1', 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (22, N'2', N'2 = 2', 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (23, N'3', N'3 = 3', 4)
INSERT [dbo].[Respuesta] ([Id], [Descripcion], [Explicacion], [IdPregunta]) VALUES (24, N'4', N'4 = 4', 4)
ALTER TABLE [dbo].[Respuesta]  WITH CHECK ADD  CONSTRAINT [FK_Respuesta_Pregunta1] FOREIGN KEY([IdPregunta])
REFERENCES [dbo].[Pregunta] ([Id])
GO
ALTER TABLE [dbo].[Respuesta] CHECK CONSTRAINT [FK_Respuesta_Pregunta1]
GO
USE [master]
GO
ALTER DATABASE [Culturilla] SET  READ_WRITE 
GO
