USE [master]
GO
/****** Object:  Database [dbRoboMatrixUdla]    Script Date: 9/3/2017 12:39:22 ******/
CREATE DATABASE [dbRoboMatrixUdla]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbRoboMatrix', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RoboMatrixUdla.mdf' , SIZE = 5120000KB , MAXSIZE = UNLIMITED, FILEGROWTH = 0)
 LOG ON 
( NAME = N'dbSistemaCitas_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RoboMatrixUdla_Log.ldf' , SIZE = 1048576KB , MAXSIZE = 2048GB , FILEGROWTH = 0)
GO
ALTER DATABASE [dbRoboMatrixUdla] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbRoboMatrixUdla].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbRoboMatrixUdla] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET RECOVERY FULL 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET  MULTI_USER 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbRoboMatrixUdla] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbRoboMatrixUdla] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbRoboMatrixUdla', N'ON'
GO
USE [dbRoboMatrixUdla]
GO
/****** Object:  Table [dbo].[TblCategoria]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCategoria](
	[idCat] [int] IDENTITY(1,1) NOT NULL,
	[nomCat] [varchar](25) NOT NULL,
	[tipoCat] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblDrones]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblDrones](
	[idBatalla_Drones] [int] IDENTITY(1,1) NOT NULL,
	[idRobot] [int] NOT NULL,
	[estado] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBatalla_Drones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblEquipo]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblEquipo](
	[idEquipo] [int] IDENTITY(1,1) NOT NULL,
	[nomEquipo] [varchar](50) NOT NULL,
	[paisEquipo] [varchar](25) NOT NULL,
	[lugarEquipo] [varchar](50) NULL,
	[imgEquipo] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblLaberinto]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblLaberinto](
	[idBatalla_Laberinto] [int] IDENTITY(1,1) NOT NULL,
	[idRobot] [int] NOT NULL,
	[estado] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBatalla_Laberinto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblLegosumo]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblLegosumo](
	[idBatalla_Legosumo] [int] IDENTITY(1,1) NOT NULL,
	[idRobotUno] [int] NOT NULL,
	[idRobotDos] [int] NOT NULL,
	[estado] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBatalla_Legosumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblMegasumo]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblMegasumo](
	[idBatalla_megasumo] [int] IDENTITY(1,1) NOT NULL,
	[idRobotUno] [int] NOT NULL,
	[idRobotDos] [int] NOT NULL,
	[estado] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBatalla_megasumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblMinisumo]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblMinisumo](
	[idBatalla_minisumo] [int] IDENTITY(1,1) NOT NULL,
	[idRobotUno] [int] NOT NULL,
	[idRobotDos] [int] NOT NULL,
	[estado] [char](2) NOT NULL DEFAULT ('NO'),
PRIMARY KEY CLUSTERED 
(
	[idBatalla_minisumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblPuntajeDrones]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPuntajeDrones](
	[idPuntaje] [int] IDENTITY(1,1) NOT NULL,
	[idBatalla] [int] NOT NULL,
	[tiempo1] [decimal](5, 2) NULL,
	[puntaje] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPuntaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPuntajeLaberinto]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPuntajeLaberinto](
	[idPuntaje] [int] IDENTITY(1,1) NOT NULL,
	[idBatalla] [int] NOT NULL,
	[tiempo1] [decimal](5, 2) NULL,
	[tiempo2] [decimal](5, 2) NULL,
	[tiempo3] [decimal](5, 2) NULL,
	[mejorTiempo] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPuntaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPuntajeSeguidorLinea]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPuntajeSeguidorLinea](
	[idPuntaje] [int] IDENTITY(1,1) NOT NULL,
	[idBatalla] [int] NOT NULL,
	[tiempo1] [decimal](5, 2) NULL,
	[tiempo2] [decimal](5, 2) NULL,
	[tiempo3] [decimal](5, 2) NULL,
	[mejorTiempo] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPuntaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblResultadoLegosumo]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblResultadoLegosumo](
	[idPuntaje] [int] IDENTITY(1,1) NOT NULL,
	[idBatalla] [int] NOT NULL,
	[puntosUno] [int] NOT NULL,
	[puntosDos] [int] NOT NULL,
	[idGanador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPuntaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblResultadoMinisumo]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblResultadoMinisumo](
	[idBatalla] [int] NOT NULL,
	[idPuntaje] [int] IDENTITY(1,1) NOT NULL,
	[puntosUno] [int] NOT NULL,
	[puntosDos] [int] NOT NULL,
	[idGanador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPuntaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblResultadosMegasumo]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblResultadosMegasumo](
	[idPuntaje] [int] IDENTITY(1,1) NOT NULL,
	[idBatalla] [int] NOT NULL,
	[puntosUno] [int] NOT NULL,
	[puntosDos] [int] NOT NULL,
	[idGanador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPuntaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblRobot]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblRobot](
	[idRobot] [int] NOT NULL,
	[nomRobot] [varchar](50) NOT NULL,
	[estadoRobot] [char](2) NULL DEFAULT ('AC'),
	[liderRobot] [varchar](25) NULL,
	[idCategoria] [int] NOT NULL,
	[idEquipo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRobot] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblSeguidorLego]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblSeguidorLego](
	[idBatalla_SeguidorLego] [int] IDENTITY(1,1) NOT NULL,
	[idRobot] [int] NOT NULL,
	[estado] [char](2) NOT NULL DEFAULT ('NO'),
PRIMARY KEY CLUSTERED 
(
	[idBatalla_SeguidorLego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblSeguidorLinea]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblSeguidorLinea](
	[idBatalla_SeguidorLinea] [int] IDENTITY(1,1) NOT NULL,
	[idRobot] [int] NOT NULL,
	[estado] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBatalla_SeguidorLinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TbPuntajeSeguidorLego]    Script Date: 9/3/2017 12:39:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbPuntajeSeguidorLego](
	[idPuntaje] [int] IDENTITY(1,1) NOT NULL,
	[idBatalla] [int] NOT NULL,
	[tiempo1] [decimal](5, 2) NULL,
	[tiempo2] [decimal](5, 2) NULL,
	[tiempo3] [decimal](5, 2) NULL,
	[mejorTiempo] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPuntaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[TblCategoria] ON 

INSERT [dbo].[TblCategoria] ([idCat], [nomCat], [tipoCat]) VALUES (1, N'Minisumo', 1)
INSERT [dbo].[TblCategoria] ([idCat], [nomCat], [tipoCat]) VALUES (2, N'Megasumo', 1)
INSERT [dbo].[TblCategoria] ([idCat], [nomCat], [tipoCat]) VALUES (3, N'Legosumo', 1)
INSERT [dbo].[TblCategoria] ([idCat], [nomCat], [tipoCat]) VALUES (4, N'Seguidor de Línea', 2)
INSERT [dbo].[TblCategoria] ([idCat], [nomCat], [tipoCat]) VALUES (5, N'Seguidor de Línea Lego', 2)
INSERT [dbo].[TblCategoria] ([idCat], [nomCat], [tipoCat]) VALUES (6, N'Dron', 2)
INSERT [dbo].[TblCategoria] ([idCat], [nomCat], [tipoCat]) VALUES (7, N'Laberinto', 2)
SET IDENTITY_INSERT [dbo].[TblCategoria] OFF
SET IDENTITY_INSERT [dbo].[TblEquipo] ON 

INSERT [dbo].[TblEquipo] ([idEquipo], [nomEquipo], [paisEquipo], [lugarEquipo], [imgEquipo]) VALUES (1, N'UITEC', N'ECUADOR', N'Universidad de Las Amercias ', NULL)
INSERT [dbo].[TblEquipo] ([idEquipo], [nomEquipo], [paisEquipo], [lugarEquipo], [imgEquipo]) VALUES (2, N'MecaUte', N'ECUADOR', N'Universidad Tecnologica Equinoccial', NULL)
INSERT [dbo].[TblEquipo] ([idEquipo], [nomEquipo], [paisEquipo], [lugarEquipo], [imgEquipo]) VALUES (3, N'TdRobotica', N'COLOMBIA', N'Universidad Nacional', NULL)
SET IDENTITY_INSERT [dbo].[TblEquipo] OFF
SET IDENTITY_INSERT [dbo].[TblMinisumo] ON 

INSERT [dbo].[TblMinisumo] ([idBatalla_minisumo], [idRobotUno], [idRobotDos], [estado]) VALUES (1, 123465, 127845, N'SI')
SET IDENTITY_INSERT [dbo].[TblMinisumo] OFF
INSERT [dbo].[TblRobot] ([idRobot], [nomRobot], [estadoRobot], [liderRobot], [idCategoria], [idEquipo]) VALUES (117485, N'Micro Mause', N'AC', N'Andre', 7, 1)
INSERT [dbo].[TblRobot] ([idRobot], [nomRobot], [estadoRobot], [liderRobot], [idCategoria], [idEquipo]) VALUES (123465, N'Zigma', N'AC', N'Pablo', 1, 1)
INSERT [dbo].[TblRobot] ([idRobot], [nomRobot], [estadoRobot], [liderRobot], [idCategoria], [idEquipo]) VALUES (127845, N'Rho', N'AC', N'Juan', 7, 1)
INSERT [dbo].[TblRobot] ([idRobot], [nomRobot], [estadoRobot], [liderRobot], [idCategoria], [idEquipo]) VALUES (147369, N'Chimichu', N'AC', N'', 5, 2)
INSERT [dbo].[TblRobot] ([idRobot], [nomRobot], [estadoRobot], [liderRobot], [idCategoria], [idEquipo]) VALUES (159632, N'SeguiRapidin', N'AC', N'', 4, 3)
INSERT [dbo].[TblRobot] ([idRobot], [nomRobot], [estadoRobot], [liderRobot], [idCategoria], [idEquipo]) VALUES (159874, N'JULIO', N'AC', N'', 5, 1)
SET IDENTITY_INSERT [dbo].[TblSeguidorLego] ON 

INSERT [dbo].[TblSeguidorLego] ([idBatalla_SeguidorLego], [idRobot], [estado]) VALUES (3, 147369, N'SI')
INSERT [dbo].[TblSeguidorLego] ([idBatalla_SeguidorLego], [idRobot], [estado]) VALUES (4, 159874, N'SI')
SET IDENTITY_INSERT [dbo].[TblSeguidorLego] OFF
ALTER TABLE [dbo].[TblDrones] ADD  DEFAULT ('NO') FOR [estado]
GO
ALTER TABLE [dbo].[TblLaberinto] ADD  DEFAULT ('NO') FOR [estado]
GO
ALTER TABLE [dbo].[TblLegosumo] ADD  DEFAULT ('NO') FOR [estado]
GO
ALTER TABLE [dbo].[TblMegasumo] ADD  DEFAULT ('NO') FOR [estado]
GO
ALTER TABLE [dbo].[TblSeguidorLinea] ADD  DEFAULT ('NO') FOR [estado]
GO
ALTER TABLE [dbo].[TblDrones]  WITH CHECK ADD FOREIGN KEY([idRobot])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblLaberinto]  WITH CHECK ADD FOREIGN KEY([idRobot])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblLegosumo]  WITH CHECK ADD FOREIGN KEY([idRobotUno])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblLegosumo]  WITH CHECK ADD FOREIGN KEY([idRobotDos])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblMegasumo]  WITH CHECK ADD FOREIGN KEY([idRobotUno])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblMegasumo]  WITH CHECK ADD FOREIGN KEY([idRobotDos])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblMinisumo]  WITH CHECK ADD FOREIGN KEY([idRobotUno])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblMinisumo]  WITH CHECK ADD FOREIGN KEY([idRobotDos])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblPuntajeDrones]  WITH CHECK ADD FOREIGN KEY([idBatalla])
REFERENCES [dbo].[TblDrones] ([idBatalla_Drones])
GO
ALTER TABLE [dbo].[TblPuntajeLaberinto]  WITH CHECK ADD FOREIGN KEY([idBatalla])
REFERENCES [dbo].[TblLaberinto] ([idBatalla_Laberinto])
GO
ALTER TABLE [dbo].[TblPuntajeSeguidorLinea]  WITH CHECK ADD FOREIGN KEY([idBatalla])
REFERENCES [dbo].[TblSeguidorLinea] ([idBatalla_SeguidorLinea])
GO
ALTER TABLE [dbo].[TblResultadoLegosumo]  WITH CHECK ADD FOREIGN KEY([idBatalla])
REFERENCES [dbo].[TblLegosumo] ([idBatalla_Legosumo])
GO
ALTER TABLE [dbo].[TblResultadoLegosumo]  WITH CHECK ADD FOREIGN KEY([idGanador])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblResultadoMinisumo]  WITH CHECK ADD FOREIGN KEY([idBatalla])
REFERENCES [dbo].[TblMinisumo] ([idBatalla_minisumo])
GO
ALTER TABLE [dbo].[TblResultadoMinisumo]  WITH CHECK ADD FOREIGN KEY([idGanador])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblResultadosMegasumo]  WITH CHECK ADD FOREIGN KEY([idBatalla])
REFERENCES [dbo].[TblMegasumo] ([idBatalla_megasumo])
GO
ALTER TABLE [dbo].[TblResultadosMegasumo]  WITH CHECK ADD FOREIGN KEY([idGanador])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblRobot]  WITH CHECK ADD FOREIGN KEY([idCategoria])
REFERENCES [dbo].[TblCategoria] ([idCat])
GO
ALTER TABLE [dbo].[TblRobot]  WITH CHECK ADD FOREIGN KEY([idEquipo])
REFERENCES [dbo].[TblEquipo] ([idEquipo])
GO
ALTER TABLE [dbo].[TblSeguidorLego]  WITH CHECK ADD FOREIGN KEY([idRobot])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TblSeguidorLinea]  WITH CHECK ADD FOREIGN KEY([idRobot])
REFERENCES [dbo].[TblRobot] ([idRobot])
GO
ALTER TABLE [dbo].[TbPuntajeSeguidorLego]  WITH CHECK ADD FOREIGN KEY([idBatalla])
REFERENCES [dbo].[TblSeguidorLego] ([idBatalla_SeguidorLego])
GO
USE [master]
GO
ALTER DATABASE [dbRoboMatrixUdla] SET  READ_WRITE 
GO
