USE [master]
GO
/****** Object:  Database [TestIt]    Script Date: 19/8/2020 09:51:51 ******/
CREATE DATABASE [TestIt]
GO
ALTER DATABASE [TestIt] SET COMPATIBILITY_LEVEL = 150
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
ALTER DATABASE [TestIt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TestIt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TestIt] SET QUERY_STORE = OFF
GO
USE [TestIt]
GO
/****** Object:  Table [dbo].[Campos]    Script Date: 19/8/2020 09:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campos](
	[id] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[tipo_dato] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Campos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CamposxTests]    Script Date: 19/8/2020 09:51:51 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 19/8/2020 09:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportes]    Script Date: 19/8/2020 09:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportes](
	[id] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Deportes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportistas]    Script Date: 19/8/2020 09:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportistas](
	[id] [int] NOT NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Ejecuciones]    Script Date: 19/8/2020 09:51:51 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ejecuciones]    Script Date: 19/8/2020 09:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejecuciones](
	[nro_ejecucion] [int] NOT NULL,
	[id_test] [int] NOT NULL,
	[id_deportista] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[observacion] [varchar](50) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Ejecuciones] PRIMARY KEY CLUSTERED 
(
	[nro_ejecucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 19/8/2020 09:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[id] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 19/8/2020 09:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[id] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](40) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 19/8/2020 09:51:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] NOT NULL,
	[nombre_usuario] [varchar](20) NOT NULL,
	[contraseña] [varchar](20) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categorias] ADD  CONSTRAINT [DF_Categorias_borrado]  DEFAULT ((0)) FOR [borrado]
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
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportistas_Categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportistas_Categorias]
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportistas_Deportes] FOREIGN KEY([id_deporte])
REFERENCES [dbo].[Deportes] ([id])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportistas_Deportes]
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportistas_Equipos] FOREIGN KEY([id_equipo])
REFERENCES [dbo].[Equipos] ([id])
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportistas_Equipos]
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
