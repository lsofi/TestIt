USE [master]
GO
/****** Object:  Database [TestIt]    Script Date: 20/9/2020 13:03:37 ******/
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
/****** Object:  Table [dbo].[Campos]    Script Date: 20/9/2020 13:03:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[tipo_dato] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Campos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CamposxTests]    Script Date: 20/9/2020 13:03:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CamposxTests](
	[id_campo] [int] NOT NULL,
	[id_test] [int] NOT NULL,
 CONSTRAINT [PK_CamposxTests] PRIMARY KEY CLUSTERED 
(
	[id_campo] ASC,
	[id_test] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 20/9/2020 13:03:37 ******/
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
/****** Object:  Table [dbo].[Deportes]    Script Date: 20/9/2020 13:03:37 ******/
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
/****** Object:  Table [dbo].[Deportistas]    Script Date: 20/9/2020 13:03:37 ******/
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
/****** Object:  Table [dbo].[Detalle_Ejecuciones]    Script Date: 20/9/2020 13:03:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Ejecuciones](
	[nro_ejecucion] [int] NOT NULL,
	[id_campo] [int] NOT NULL,
	[valor] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Detalle_Ejecuciones] PRIMARY KEY CLUSTERED 
(
	[nro_ejecucion] ASC,
	[id_campo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejecuciones]    Script Date: 20/9/2020 13:03:37 ******/
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
/****** Object:  Table [dbo].[Equipos]    Script Date: 20/9/2020 13:03:37 ******/
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
/****** Object:  Table [dbo].[Tests]    Script Date: 20/9/2020 13:03:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](40) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/9/2020 13:03:37 ******/
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
SET IDENTITY_INSERT [dbo].[Deportes] OFF
GO
SET IDENTITY_INSERT [dbo].[Deportistas] ON 

INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (1, 40333222, N'Perez', N'Ramon', 180, 75, 0, CAST(N'1995-02-22' AS Date), 1, 1, 1, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (2, 42222456, N'Vilanova', N'Santiago', 173, 72, 0, CAST(N'1999-06-04' AS Date), 1, 1, 1, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (3, 39534778, N'Romero', N'Valentina', 163, 62, 1, CAST(N'1998-01-02' AS Date), 2, 1, 2, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (4, 33587100, N'Mallo', N'Maria', 167, 65, 1, CAST(N'1994-06-04' AS Date), 2, 1, 2, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (5, 44587122, N'Brasiolo', N'Sol', 159, 62, 1, CAST(N'2000-09-17' AS Date), 3, 2, 3, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (6, 42587122, N'Salas', N'Lucrecia', 164, 63, 1, CAST(N'1999-11-11' AS Date), 3, 2, 3, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (7, 38422356, N'Lopez', N'Juan', 183, 78, 1, CAST(N'1996-08-02' AS Date), 3, 2, 4, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (8, 39106225, N'Gonzales', N'Santiago', 179, 74, 0, CAST(N'1997-07-29' AS Date), 3, 2, 4, 0)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (9, 123456, N'Fernandez', N'Dario', 9789, 86, 0, CAST(N'2020-09-13' AS Date), 1, 1, 4, 1)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (10, 44587122, N'Brasiolo', N'Sol', 158, 60, 1, CAST(N'2000-09-17' AS Date), 3, 2, 3, 1)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (11, 123, N'dfdf', N'asd', 123, 23, 1, CAST(N'2020-09-13' AS Date), 2, 1, 2, 1)
INSERT [dbo].[Deportistas] ([id], [dni], [apellido], [nombre], [altura], [peso], [sexo], [fecha_nacimiento], [id_equipo], [id_deporte], [id_categoria], [borrado]) VALUES (12, 654876, N'Perez', N'Juan', 178, 75, 0, CAST(N'2005-01-04' AS Date), 1, 1, 3, 1)
SET IDENTITY_INSERT [dbo].[Deportistas] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipos] ON 

INSERT [dbo].[Equipos] ([id], [nombre], [localidad], [entrenador], [borrado]) VALUES (7, N'FFT', N'Cordoba', N'Luis Gonzales', 0)
INSERT [dbo].[Equipos] ([id], [nombre], [localidad], [entrenador], [borrado]) VALUES (8, N'Atletico VC', N'Villa Maria', N'María Guerrero', 0)
INSERT [dbo].[Equipos] ([id], [nombre], [localidad], [entrenador], [borrado]) VALUES (9, N'HandballGo', N'Rio Ceballos', N'Ruben Salas', 0)
SET IDENTITY_INSERT [dbo].[Equipos] OFF
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
ALTER TABLE [dbo].[Tests] ADD  CONSTRAINT [DF_Tests_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[CamposxTests]  WITH CHECK ADD  CONSTRAINT [FK_CamposxTests_Campos] FOREIGN KEY([id_campo])
REFERENCES [dbo].[Campos] ([id])
GO
ALTER TABLE [dbo].[CamposxTests] CHECK CONSTRAINT [FK_CamposxTests_Campos]
GO
ALTER TABLE [dbo].[CamposxTests]  WITH CHECK ADD  CONSTRAINT [FK_CamposxTests_Tests] FOREIGN KEY([id_test])
REFERENCES [dbo].[Tests] ([id])
GO
ALTER TABLE [dbo].[CamposxTests] CHECK CONSTRAINT [FK_CamposxTests_Tests]
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportistas_Deportes] FOREIGN KEY([id_deporte])
REFERENCES [dbo].[Deportes] ([id])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportistas_Deportes]
GO
ALTER TABLE [dbo].[Detalle_Ejecuciones]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ejecuciones_Campos] FOREIGN KEY([id_campo])
REFERENCES [dbo].[Campos] ([id])
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
USE [master]
GO
ALTER DATABASE [TestIt] SET  READ_WRITE 
GO
