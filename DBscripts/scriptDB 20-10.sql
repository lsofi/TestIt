USE [master]
GO
/****** Object:  Database [TestIt]    Script Date: 20/10/2020 11:01:18 ******/
CREATE DATABASE [TestIt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestIt', FILENAME = N'C:\Users\angel\TestIt.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TestIt_log', FILENAME = N'C:\Users\angel\TestIt_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TestIt] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestIt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestIt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestIt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestIt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestIt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestIt] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestIt] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TestIt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestIt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestIt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestIt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestIt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestIt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestIt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestIt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestIt] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TestIt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestIt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestIt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestIt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestIt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestIt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestIt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestIt] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TestIt] SET  MULTI_USER 
GO
ALTER DATABASE [TestIt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestIt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestIt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestIt] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TestIt]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[edad_min] [int] NULL,
	[edad_max] [int] NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportes]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Deportes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportistas]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportistas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[altura] [float] NOT NULL,
	[peso] [float] NOT NULL,
	[sexo] [bit] NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[id_equipo] [int] NULL,
	[id_deporte] [int] NOT NULL,
	[id_categoria] [int] NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Deportistas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Ejecuciones]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Ejecuciones](
	[nro_ejecucion] [int] NOT NULL,
	[id_campo] [int] NOT NULL,
	[valor] [float] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Detalle_Ejecuciones] PRIMARY KEY CLUSTERED 
(
	[nro_ejecucion] ASC,
	[id_campo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejecuciones]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejecuciones](
	[nro_ejecucion] [int] IDENTITY(1,1) NOT NULL,
	[id_test] [int] NOT NULL,
	[id_deportista] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[observacion] [varchar](50) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Ejecuciones] PRIMARY KEY CLUSTERED 
(
	[nro_ejecucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[localidad] [varchar](20) NOT NULL,
	[entrenador] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mediciones]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mediciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[unidad] [varchar](20) NULL,
	[descripcion] [varchar](100) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Campos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicionesXTests]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicionesXTests](
	[id_campo] [int] NOT NULL,
	[id_test] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_CamposxTests] PRIMARY KEY CLUSTERED 
(
	[id_campo] ASC,
	[id_test] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/10/2020 11:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](20) NOT NULL,
	[contraseña] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([id], [nombre], [edad_min], [edad_max], [borrado]) VALUES (8, N'Infantil', 2, 11, 0)
INSERT [dbo].[Categorias] ([id], [nombre], [edad_min], [edad_max], [borrado]) VALUES (9, N'Menor', 12, 13, 0)
INSERT [dbo].[Categorias] ([id], [nombre], [edad_min], [edad_max], [borrado]) VALUES (10, N'Cadete', 14, 15, 0)
INSERT [dbo].[Categorias] ([id], [nombre], [edad_min], [edad_max], [borrado]) VALUES (11, N'Juvenil', 16, 17, 0)
INSERT [dbo].[Categorias] ([id], [nombre], [edad_min], [edad_max], [borrado]) VALUES (12, N'Reserva', 18, 21, 0)
INSERT [dbo].[Categorias] ([id], [nombre], [edad_min], [edad_max], [borrado]) VALUES (13, N'Primera', 22, 34, 0)
INSERT [dbo].[Categorias] ([id], [nombre], [edad_min], [edad_max], [borrado]) VALUES (14, N'Adulto', 35, 60, 0)
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Deportes] ON 

INSERT [dbo].[Deportes] ([id], [nombre], [borrado]) VALUES (1, N'Futbol', 0)
INSERT [dbo].[Deportes] ([id], [nombre], [borrado]) VALUES (2, N'Handball', 0)
INSERT [dbo].[Deportes] ([id], [nombre], [borrado]) VALUES (3, N'Softball', 0)
INSERT [dbo].[Deportes] ([id], [nombre], [borrado]) VALUES (4, N'Tenis', 0)
INSERT [dbo].[Deportes] ([id], [nombre], [borrado]) VALUES (5, N'Basquet', 0)
INSERT [dbo].[Deportes] ([id], [nombre], [borrado]) VALUES (6, N'Atletismo', 0)
SET IDENTITY_INSERT [dbo].[Deportes] OFF
GO
SET IDENTITY_INSERT [dbo].[Deportistas] ON 

INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (1, 40333222, N'Perez', N'Ramon', 180, 75, 0, CAST(N'1995-02-22' AS Date), 7, 1, 9, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (2, 42222456, N'Vilanova', N'Santiago', 173, 72, 0, CAST(N'1999-06-04' AS Date), 7, 1, 9, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (3, 39534778, N'Romero', N'Valentina', 163, 62, 1, CAST(N'1998-01-02' AS Date), 8, 1, 10, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (4, 33587100, N'Mallo', N'Maria', 167, 65, 1, CAST(N'1994-06-04' AS Date), 8, 1, 10, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (5, 44587122, N'Brasiolo', N'Sol', 159, 62, 1, CAST(N'2000-09-17' AS Date), 9, 2, 11, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (6, 42587122, N'Salas', N'Lucrecia', 164, 63, 1, CAST(N'1999-11-11' AS Date), 9, 2, 11, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (7, 38422356, N'Lopez', N'Juan', 183, 78, 1, CAST(N'1996-08-02' AS Date), 9, 2, 12, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (8, 39106225, N'Gonzales', N'Santiago', 179, 74, 0, CAST(N'1997-07-29' AS Date), 9, 2, 12, 0)
SET IDENTITY_INSERT [dbo].[Deportistas] OFF
GO
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (1, 3, 12, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (1, 4, 45, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (1, 5, 75, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (1, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (2, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (2, 4, 80, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (2, 5, 76, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (2, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (3, 3, 12, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (3, 4, 88, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (3, 5, 70, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (3, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (4, 3, 1, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (4, 4, 1, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (4, 5, 1, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (4, 6, 1, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (23, 2, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (23, 4, 105, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (23, 5, 90, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (23, 6, 4, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (24, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (24, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (24, 5, 96, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (24, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (26, 1, 200, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (26, 5, 12, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (26, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (28, 2, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (28, 4, 102, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (28, 5, 96, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (28, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (29, 3, 1, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (29, 4, 80, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (29, 5, 75, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (29, 6, 1, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (30, 1, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (30, 5, 98, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (30, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (31, 3, 30, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (31, 4, 80, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (31, 5, 85, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (31, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (32, 3, 15, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (32, 4, 103, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (32, 5, 92, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (32, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (33, 3, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (33, 4, 90, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (33, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (33, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (34, 3, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (34, 4, 86, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (34, 5, 111, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (34, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (35, 3, 4, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (35, 4, 78, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (35, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (35, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (36, 3, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (36, 4, 90, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (36, 5, 125, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (36, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (37, 3, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (37, 4, 80, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (37, 5, 115, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (37, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (38, 3, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (38, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (38, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (38, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (39, 3, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (39, 4, 104, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (39, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (39, 6, 3, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (40, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (40, 4, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (40, 5, 125, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (40, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (41, 2, 1200, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (41, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (41, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (42, 2, 1100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (42, 5, 90, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (42, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (43, 2, 1300, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (43, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (43, 6, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (44, 2, 1205, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (44, 5, 121, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (44, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (45, 2, 1000, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (45, 5, 103, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (45, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (46, 2, 1050, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (46, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (46, 6, 1, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (47, 2, 1100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (47, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (47, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (48, 2, 1203, 0)
GO
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (48, 5, 115, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (48, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (49, 2, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (49, 6, 2, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (50, 2, 3, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (50, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (51, 2, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (51, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (52, 2, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (52, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (53, 2, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (53, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (54, 2, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (54, 6, 3, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (55, 2, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (55, 6, 4, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (56, 2, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (56, 6, 2, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (57, 2, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (57, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (58, 1, 245, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (58, 5, 90, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (58, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (59, 1, 290, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (59, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (59, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (60, 1, 238, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (60, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (60, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (61, 1, 210, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (61, 5, 115, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (61, 6, 4, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (62, 1, 199, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (62, 5, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (62, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (63, 1, 276, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (63, 5, 118, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (63, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (64, 1, 288, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (64, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (64, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (65, 1, 256, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (65, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (65, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (66, 3, 18, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (66, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (66, 5, 125, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (66, 6, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (67, 3, 15, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (67, 4, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (67, 5, 119, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (67, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (68, 3, 20, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (68, 4, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (68, 5, 126, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (68, 6, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (69, 3, 15, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (69, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (69, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (69, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (70, 3, 18, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (70, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (70, 5, 115, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (70, 6, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (71, 3, 16, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (71, 4, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (71, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (71, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (72, 3, 20, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (72, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (72, 5, 124, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (72, 6, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (73, 3, 17, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (73, 4, 99, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (73, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (73, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (74, 3, 20, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (74, 5, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (74, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (75, 3, 40, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (75, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (75, 6, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (76, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (76, 5, 80, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (76, 6, 2, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (77, 3, 20, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (77, 5, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (77, 6, 4, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (78, 3, 30, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (78, 5, 102, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (78, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (79, 3, 50, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (79, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (79, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (80, 3, 25, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (80, 5, 119, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (80, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (81, 3, 50, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (81, 5, 125, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (81, 6, 8, 0)
GO
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (82, 3, 30, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (82, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (82, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (83, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (83, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (83, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (84, 3, 20, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (84, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (84, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (85, 3, 15, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (85, 5, 115, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (85, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (86, 3, 25, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (86, 5, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (86, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (87, 3, 40, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (87, 5, 125, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (87, 6, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (88, 3, 20, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (88, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (88, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (89, 3, 25, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (89, 5, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (89, 6, 4, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (90, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (90, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (90, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (90, 6, 5, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (91, 3, 15, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (91, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (91, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (91, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (92, 3, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (92, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (92, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (92, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (93, 3, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (93, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (93, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (93, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (94, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (94, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (94, 5, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (94, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (95, 3, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (95, 4, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (95, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (95, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (96, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (96, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (96, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (96, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (97, 3, 11, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (97, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (97, 5, 109, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (97, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (98, 3, 15, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (98, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (98, 5, 119, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (98, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (99, 3, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (99, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (99, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (99, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (100, 3, 13, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (100, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (100, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (100, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (101, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (101, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (101, 5, 80, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (101, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (102, 3, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (102, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (102, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (102, 6, 7, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (103, 3, 11, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (103, 4, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (103, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (103, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (104, 3, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (104, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (104, 5, 110, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (104, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (105, 3, 11, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (105, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (105, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (105, 6, 4, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (106, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (106, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (106, 5, 115, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (106, 6, 8, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (107, 3, 13, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (107, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (107, 5, 123, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (107, 6, 9, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (108, 3, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (108, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (108, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (108, 6, 5, 0)
GO
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (109, 3, 16, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (109, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (109, 5, 116, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (109, 6, 6, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (110, 3, 10, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (110, 4, 100, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (110, 5, 120, 0)
INSERT [dbo].[Detalle_Ejecuciones] ([nro_ejecucion], [id_campo], [valor], [borrado]) VALUES (110, 6, 6, 0)
GO
SET IDENTITY_INSERT [dbo].[Ejecuciones] ON 

INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (1, 2, 3, 1, CAST(N'2020-10-12' AS Date), N'Obs1', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (2, 2, 2, 1, CAST(N'2020-10-12' AS Date), N'obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (3, 2, 1, 1, CAST(N'2020-10-13' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (4, 2, 1, 1, CAST(N'2020-10-13' AS Date), N'w', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (6, 3, 5, 2, CAST(N'2020-10-12' AS Date), N'Mayor rapidez', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (7, 3, 6, 3, CAST(N'2020-08-01' AS Date), N'Solo 11 vueltas', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (8, 3, 6, 3, CAST(N'2020-09-01' AS Date), N'Observacion', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (9, 3, 5, 2, CAST(N'2019-10-12' AS Date), N'Mayor rapidez', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (10, 3, 6, 3, CAST(N'2020-09-01' AS Date), N'Observacion', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (11, 3, 6, 3, CAST(N'2020-08-01' AS Date), N'Solo 11 vueltas', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (12, 3, 8, 3, CAST(N'2020-09-01' AS Date), N'Observacion', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (13, 3, 6, 4, CAST(N'2020-08-10' AS Date), N'Tiempo mayor al esperado', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (14, 4, 1, 4, CAST(N'2019-01-01' AS Date), N'Tiempo mayor al esperado', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (15, 4, 7, 1, CAST(N'2020-10-01' AS Date), N'Metros superados', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (16, 4, 4, 1, CAST(N'2020-10-01' AS Date), N'Metros no superados', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (17, 5, 8, 1, CAST(N'2020-02-11' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (18, 5, 1, 2, CAST(N'2020-09-01' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (19, 5, 3, 2, CAST(N'2020-01-05' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (20, 6, 8, 1, CAST(N'2020-02-11' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (21, 6, 2, 4, CAST(N'2020-09-01' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (22, 6, 5, 2, CAST(N'2020-01-05' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (23, 7, 6, 1, CAST(N'2020-10-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (24, 2, 1, 1, CAST(N'2020-10-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (25, 4, 2, 1, CAST(N'2020-10-19' AS Date), N'obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (26, 3, 2, 1, CAST(N'2020-10-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (27, 4, 5, 1, CAST(N'2020-10-19' AS Date), N'as', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (28, 7, 4, 1, CAST(N'2020-10-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (29, 2, 1, 1, CAST(N'2020-10-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (30, 3, 2, 1, CAST(N'2020-10-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (31, 6, 6, 1, CAST(N'2020-10-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (32, 6, 6, 1, CAST(N'2020-10-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (33, 2, 1, 1, CAST(N'2020-10-20' AS Date), N'Obs1', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (34, 2, 2, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (35, 2, 3, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (36, 2, 4, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (37, 2, 5, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (38, 2, 6, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (39, 2, 7, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (40, 2, 8, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (41, 3, 1, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (42, 3, 2, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (43, 3, 3, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (44, 3, 4, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (45, 3, 5, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (46, 3, 6, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (47, 3, 7, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (48, 3, 8, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (49, 4, 1, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (50, 4, 2, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (51, 4, 3, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (52, 4, 3, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (53, 4, 4, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (54, 4, 5, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (55, 4, 6, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (56, 4, 7, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (57, 4, 8, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (58, 6, 1, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (59, 6, 2, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (60, 6, 3, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (61, 6, 4, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (62, 6, 5, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (63, 6, 6, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (64, 6, 7, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (65, 6, 8, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (66, 7, 1, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (67, 7, 2, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (68, 7, 3, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (69, 7, 4, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (70, 7, 5, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (71, 7, 6, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (72, 7, 7, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (73, 7, 8, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (74, 9, 1, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (75, 9, 2, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (76, 9, 3, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (77, 9, 4, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (78, 9, 5, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (79, 9, 6, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (80, 9, 7, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (81, 9, 8, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (82, 10, 1, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (83, 10, 2, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (84, 10, 3, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (85, 10, 4, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (86, 10, 5, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (87, 10, 6, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (88, 10, 7, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (89, 10, 8, 1, CAST(N'2020-10-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (90, 2, 1, 1, CAST(N'2020-09-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (91, 2, 1, 1, CAST(N'2020-01-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (92, 2, 1, 1, CAST(N'2020-02-01' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (93, 2, 1, 1, CAST(N'2020-03-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (94, 2, 1, 1, CAST(N'2020-04-01' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (95, 2, 1, 1, CAST(N'2020-05-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (96, 2, 1, 1, CAST(N'2020-06-01' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (97, 2, 1, 1, CAST(N'2020-07-16' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (98, 2, 1, 1, CAST(N'2020-08-19' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (99, 2, 1, 1, CAST(N'2020-09-17' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (100, 2, 1, 1, CAST(N'2020-09-16' AS Date), N'', 0)
GO
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (101, 2, 2, 1, CAST(N'2020-01-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (102, 2, 2, 1, CAST(N'2020-02-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (103, 2, 2, 1, CAST(N'2020-03-21' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (104, 2, 2, 1, CAST(N'2020-04-24' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (105, 2, 2, 1, CAST(N'2020-05-01' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (106, 2, 1, 1, CAST(N'2020-06-18' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (107, 2, 2, 1, CAST(N'2020-07-18' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (108, 2, 2, 1, CAST(N'2020-08-16' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (109, 2, 2, 1, CAST(N'2020-09-20' AS Date), N'', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (110, 2, 2, 1, CAST(N'2020-06-20' AS Date), N'', 0)
SET IDENTITY_INSERT [dbo].[Ejecuciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipos] ON 

INSERT [dbo].[Equipos] ([id], [nombre], [localidad], [entrenador], [borrado]) VALUES (7, N'FFT', N'Cordoba', N'Luis Gonzales', 0)
INSERT [dbo].[Equipos] ([id], [nombre], [localidad], [entrenador], [borrado]) VALUES (8, N'Atletico VC', N'Villa Maria', N'María Guerrero', 0)
INSERT [dbo].[Equipos] ([id], [nombre], [localidad], [entrenador], [borrado]) VALUES (9, N'HandballGo', N'Rio Ceballos', N'Ruben Salas', 0)
SET IDENTITY_INSERT [dbo].[Equipos] OFF
GO
SET IDENTITY_INSERT [dbo].[Mediciones] ON 

INSERT [dbo].[Mediciones] ([id], [nombre], [unidad], [descripcion], [borrado]) VALUES (1, N'Longitud', N'centimetros', N'Distancia en largo de un salto', 0)
INSERT [dbo].[Mediciones] ([id], [nombre], [unidad], [descripcion], [borrado]) VALUES (2, N'Distancia', N'metros', N'Distancia de una carrera', 0)
INSERT [dbo].[Mediciones] ([id], [nombre], [unidad], [descripcion], [borrado]) VALUES (3, N'Repeticiones', N'rep/min', N'Cantidad de repeticiones por minuto', 0)
INSERT [dbo].[Mediciones] ([id], [nombre], [unidad], [descripcion], [borrado]) VALUES (4, N'Oxígeno en sangre', N'mmHg', N'', 0)
INSERT [dbo].[Mediciones] ([id], [nombre], [unidad], [descripcion], [borrado]) VALUES (5, N'Pulsaciones', N'ppm', N'Cantidad de pulsaciones por minuto', 0)
INSERT [dbo].[Mediciones] ([id], [nombre], [unidad], [descripcion], [borrado]) VALUES (6, N'Esfuerzo subjetivo', N'1-10', N'Percepción subjetiva del esfuerzo', 0)
SET IDENTITY_INSERT [dbo].[Mediciones] OFF
GO
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (1, 5, 1)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (1, 6, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (2, 3, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (2, 4, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 2, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 7, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 8, 1)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 9, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 10, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (4, 2, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (4, 7, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 2, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 3, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 5, 1)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 6, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 7, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 8, 1)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 9, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 10, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 2, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 3, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 4, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 5, 1)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 6, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 7, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 8, 1)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 9, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 10, 0)
GO
SET IDENTITY_INSERT [dbo].[Tests] ON 

INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (2, N'Burpees', N'Cantidad de combinaciones de flexiones, sentadillas y saltos en un minuto', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (3, N'Cooper', N'Cubrir la máxima distancia posible durante doce minutos de carrera continua', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (4, N'Salto en largo', N'Distancia de un salto', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (5, N'Burpees', N'Cantidad de combinaciones de flexiones, sentadillas y saltos en un minuto', 1)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (6, N'Salto en alto', N'Altura que se alcanza con un salto', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (7, N'Yoyo', N'Cantidad de recorridos de ida y vuelta sobre un carril de 20 metros', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (8, N'Cooper', N'Distancia alcanzada en un periodo de 12 minutos', 1)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (9, N'Abdominales', N'Cantidad de abdominales en 1 minuto', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (10, N'Flexiones', N'Cantidad de flexiones en 1 minuto', 0)
SET IDENTITY_INSERT [dbo].[Tests] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id], [nombre_usuario], [contraseña], [borrado]) VALUES (1, N'JNeschisi', N'1234', 0)
INSERT [dbo].[Usuarios] ([id], [nombre_usuario], [contraseña], [borrado]) VALUES (2, N'GCarranza', N'1234', 0)
INSERT [dbo].[Usuarios] ([id], [nombre_usuario], [contraseña], [borrado]) VALUES (3, N'ACornejo', N'1234', 0)
INSERT [dbo].[Usuarios] ([id], [nombre_usuario], [contraseña], [borrado]) VALUES (4, N'SJuarez', N'1234', 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Categorias] ADD  CONSTRAINT [DF_Categorias_borrado_1]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Deportes] ADD  CONSTRAINT [DF_Deportes_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Deportistas] ADD  CONSTRAINT [DF_Deportistas_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Detalle_Ejecuciones] ADD  CONSTRAINT [DF_Detalle_Ejecuciones_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Ejecuciones] ADD  CONSTRAINT [DF_Ejecuciones_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Equipos] ADD  CONSTRAINT [DF_Equipos_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Mediciones] ADD  CONSTRAINT [DF_Campos_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[MedicionesXTests] ADD  CONSTRAINT [DF_MedicionesXTests_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Tests] ADD  CONSTRAINT [DF_Tests_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportistas_Deportes] FOREIGN KEY([id_deporte])
REFERENCES [dbo].[Deportes] ([id])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportistas_Deportes]
GO
ALTER TABLE [dbo].[Detalle_Ejecuciones]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ejecuciones_Campos] FOREIGN KEY([id_campo])
REFERENCES [dbo].[Mediciones] ([id])
GO
ALTER TABLE [dbo].[Detalle_Ejecuciones] CHECK CONSTRAINT [FK_Detalle_Ejecuciones_Campos]
GO
ALTER TABLE [dbo].[Detalle_Ejecuciones]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ejecuciones_Ejecuciones] FOREIGN KEY([nro_ejecucion])
REFERENCES [dbo].[Ejecuciones] ([nro_ejecucion])
GO
ALTER TABLE [dbo].[Detalle_Ejecuciones] CHECK CONSTRAINT [FK_Detalle_Ejecuciones_Ejecuciones]
GO
ALTER TABLE [dbo].[Ejecuciones]  WITH CHECK ADD  CONSTRAINT [FK_Ejecuciones_Deportistas] FOREIGN KEY([id_deportista])
REFERENCES [dbo].[Deportistas] ([id])
GO
ALTER TABLE [dbo].[Ejecuciones] CHECK CONSTRAINT [FK_Ejecuciones_Deportistas]
GO
ALTER TABLE [dbo].[Ejecuciones]  WITH CHECK ADD  CONSTRAINT [FK_Ejecuciones_Tests] FOREIGN KEY([id_test])
REFERENCES [dbo].[Tests] ([id])
GO
ALTER TABLE [dbo].[Ejecuciones] CHECK CONSTRAINT [FK_Ejecuciones_Tests]
GO
ALTER TABLE [dbo].[Ejecuciones]  WITH CHECK ADD  CONSTRAINT [FK_Ejecuciones_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Ejecuciones] CHECK CONSTRAINT [FK_Ejecuciones_Usuarios]
GO
ALTER TABLE [dbo].[MedicionesXTests]  WITH CHECK ADD  CONSTRAINT [FK_CamposxTests_Campos] FOREIGN KEY([id_campo])
REFERENCES [dbo].[Mediciones] ([id])
GO
ALTER TABLE [dbo].[MedicionesXTests] CHECK CONSTRAINT [FK_CamposxTests_Campos]
GO
ALTER TABLE [dbo].[MedicionesXTests]  WITH CHECK ADD  CONSTRAINT [FK_CamposxTests_Tests] FOREIGN KEY([id_test])
REFERENCES [dbo].[Tests] ([id])
GO
ALTER TABLE [dbo].[MedicionesXTests] CHECK CONSTRAINT [FK_CamposxTests_Tests]
GO
USE [master]
GO
ALTER DATABASE [TestIt] SET  READ_WRITE 
GO
