USE [master]
GO
/****** Object:  Database [TestIt]    Script Date: 13/10/2020 19:11:04 ******/
CREATE DATABASE [TestIt]
GO
USE [TestIt]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportes]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportistas]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Ejecuciones]    Script Date: 13/10/2020 19:11:04 ******/
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
/****** Object:  Table [dbo].[Ejecuciones]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mediciones]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicionesXTests]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/10/2020 19:11:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
INSERT [dbo].[Deportes] ([id], [nombre], [borrado]) VALUES (3, N'Tenis', 0)
INSERT [dbo].[Deportes] ([id], [nombre], [borrado]) VALUES (4, N'Hockey', 0)
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
SET IDENTITY_INSERT [dbo].[Ejecuciones] ON 

INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (1, 3, 5, 2, CAST(N'2019-10-12' AS Date), N'Mayor rapidez', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (2, 3, 6, 3, CAST(N'2020-09-01' AS Date), N'Observacion', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (3, 3, 6, 3, CAST(N'2020-08-01' AS Date), N'Solo 11 vueltas', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (4, 3, 8, 3, CAST(N'2020-09-01' AS Date), N'Observacion', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (5, 3, 6, 4, CAST(N'2020-08-10' AS Date), N'Tiempo mayor al esperado', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (9, 5, 8, 1, CAST(N'2020-02-11' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (10, 5, 1, 2, CAST(N'2020-09-01' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (11, 5, 3, 2, CAST(N'2020-01-05' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (12, 6, 8, 1, CAST(N'2020-02-11' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (13, 6, 2, 4, CAST(N'2020-09-01' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (14, 6, 5, 2, CAST(N'2020-01-05' AS Date), N'Obs', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (15, 3, 7, 1, CAST(N'2020-10-01' AS Date), N'Metros superados', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (16, 5, 4, 1, CAST(N'2020-10-01' AS Date), N'Metros no superados', 0)
INSERT [dbo].[Ejecuciones] ([nro_ejecucion], [id_test], [id_deportista], [id_usuario], [fecha], [observacion], [borrado]) VALUES (17, 6, 8, 1, CAST(N'2020-02-11' AS Date), N'Obs', 0)
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
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (1, 3, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (1, 5, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (2, 7, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 2, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 6, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 8, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (3, 9, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (4, 6, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (4, 7, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 2, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 3, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 5, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 6, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 7, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 8, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (5, 9, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 2, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 3, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 5, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 6, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 7, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 8, 0)
INSERT [dbo].[MedicionesXTests] ([id_campo], [id_test], [borrado]) VALUES (6, 9, 0)
GO
SET IDENTITY_INSERT [dbo].[Tests] ON 

INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (2, N'Burpees', N'Cantidad de combinaciones de flexiones, sentadillas y saltos en un minuto', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (3, N'Salto en largo', N'Distancia de un salto', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (5, N'Salto en alto', N'Altura que se alcanza con un salto', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (6, N'Yoyo', N'Cantidad de recorridos de ida y vuelta sobre un carril de 20 metros', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (7, N'Cooper', N'Distancia alcanzada en un periodo de 12 minutos', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (8, N'Abdominales', N'Cantidad de abdominales en 1 minuto', 0)
INSERT [dbo].[Tests] ([id], [nombre], [descripcion], [borrado]) VALUES (9, N'Flexiones', N'Cantidad de flexiones en 1 minuto', 0)
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
