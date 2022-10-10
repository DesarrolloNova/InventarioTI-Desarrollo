USE [NovDBTest]
GO

ALTER TABLE TabUsuario
DROP CONSTRAINT FK__TabUsuari__IdPla__182C9B23
GO

DROP TABLE CatPlanta
GO

/****** Object:  Table [dbo].[CatPlanta]    Script Date: 20/09/2022 10:49:39 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatPlanta](
	[IDSitio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[Empresa] [nvarchar](20) NULL,
	[Planta] [nvarchar](20) NULL,
	[Direccion] [nvarchar](120) NULL,
	[Pais] [nvarchar](20) NULL,
	[Moneda] [nvarchar](10) NULL,
	[Idioma] [nvarchar](10) NULL,
	[BaseDatos] [nvarchar](20) NULL,
 CONSTRAINT [PK_CatPlanta] PRIMARY KEY CLUSTERED 
(
	[IDSitio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE TabUsuario
DROP COLUMN IdPlanta
GO

ALTER TABLE TabUsuario
ADD IDSitio INT
GO

ALTER TABLE TabUsuario
ADD CONSTRAINT FK_TabUsuario_CatPlanta FOREIGN KEY (IDSitio)
REFERENCES CatPlanta (IDSitio)
GO

CREATE TABLE UsuarioAsignacion
(
	idUsuarioAsignacion INT IDENTITY(1,1) NOT NULL,
	idEmpleado INT NOT NULL,
	idAsignacion INT NOT NULL,
	fechaInicioAsignacion DATE NOT NULL,
	fechaFinAsignacion DATE NULL,
	asignado BIT NOT NULL
)
GO

ALTER TABLE UsuarioAsignacion
ADD CONSTRAINT PK_UsuarioAsignacion PRIMARY KEY (idUsuarioAsignacion)
GO

ALTER TABLE UsuarioAsignacion
ADD CONSTRAINT FK_UsuarioAsignacion_Asignacion FOREIGN KEY (IdAsignacion)
REFERENCES InvHisAsignacionEquipo(Id)
GO

CREATE TABLE InvCatTipoConexion
(
	Id INT IDENTITY(1,1) NOT NULL,
	TipoConexion VARCHAR (100) NOT NULL
)
GO

ALTER TABLE InvHisAsignacionEquipo
DROP COLUMN IdPlanta
GO

ALTER TABLE InvHisAsignacionEquipo
ADD ID_Area INT NOT NULL
GO

-- ALTER TABLE InvHisAsignacionEquipo
-- ADD CONSTRAINT FK_InvHisAsignacionEquipo_CatPlanta FOREIGN KEY (IDSitio)
-- REFERENCES CatPlanta(IDSitio)
-- GO

ALTER TABLE InvTabEquipo
DROP COLUMN Estatus
GO

ALTER TABLE InvTabEquipo
DROP COLUMN Activo
GO

ALTER TABLE InvTabEquipo
ADD idEstatus INT NOT NULL
GO

ALTER TABLE InvTabEquipo
ADD CONSTRAINT FK_InvTabEquipo_InvCatEstatusEquipo FOREIGN KEY (idEstatus) 
REFERENCES InvCatEstatusEquipo (Id)
GO

ALTER TABLE InvTabEquipo
DROP COLUMN UbicacionEquipo
GO

ALTER TABLE InvTabEquipo
ADD IDSitio INT NOT NULL
GO

-- ALTER TABLE InvTabEquipo
-- ADD CONSTRAINT FK_InvTabEquipo_CatPlanta FOREIGN KEY (IDSitio)
-- REFERENCES CatPlanta (IDSitio)

ALTER TABLE InvHisAccionEquipo
DROP CONSTRAINT FK_InvHisAccionEquipo_InvHisPosesionEquipo
GO

ALTER TABLE InvHisAccionEquipo
DROP CONSTRAINT FK_InvHisAccionEquipo_TabUsuario
GO

ALTER TABLE InvHisAccionEquipo
ADD CONSTRAINT FK_InvHisAccionEquipo_InvHisAsignacionEquipo FOREIGN KEY (IdAsignacion)
REFERENCES InvHisAsignacionEquipo (Id)
GO

ALTER TABLE InvHisAccionEquipo
DROP CONSTRAINT FK_InvHisAccionEquipo_InvHisAsignacionEquipo
GO

ALTER TABLE InvHisAccionEquipo
DROP CONSTRAINT FK_InvHisAccionEquipo_InvTabEquipo
GO

ALTER TABLE InvHisPlantillaMantenimiento
DROP CONSTRAINT FK_InvHisPlantillaMantenimiento_InvHisAccionEquipo
GO

ALTER TABLE InvHisPlantillaInstalacion
DROP CONSTRAINT FK_InvHisPlantillaInstalacion_InvHisAccionEquipo
GO


DROP TABLE InvHisAccionEquipo
GO

CREATE TABLE InvHisAccionEquipo
(
	Id INT IDENTITY(1,1) NOT NULL,
	FechaInicio DATE NOT NULL,
	FechaFin DATE NOT NULL,
	TipoProceso VARCHAR(20) NOT NULL,
	IdAsignacion INT NULL,
	IdEquipo INT NULL,
	IdUsuarioRegistro INT NULL,
CONSTRAINT [PK_InvHisAccionEquipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE InvHisAccionEquipo
ADD CONSTRAINT FK_InvHisAccionEquipo_InvHisAsignacionEquipo FOREIGN KEY (IdAsignacion)
REFERENCES InvHisAsignacionEquipo (Id)
GO

ALTER TABLE InvHisAccionEquipo
ADD CONSTRAINT FK_InvHisAccionEquipo_InvTabEquipo FOREIGN KEY (IdEquipo)
REFERENCES InvTabEquipo (Id)
GO

DROP TABLE 
GO InvHisPlantillaInstalacion

CREATE TABLE [dbo].[InvHisPlantillaInstalacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AntivirusInstalado] [bit] NOT NULL,
	[Antivirus] [nvarchar](100) NULL,
	[PaqueteriaOfficeInstalado] [bit] NOT NULL,
	[PaqueteriaOffice] [nvarchar](100) NULL,
	[OtrasAplicaciones] [bit] NOT NULL,
	[UsoPortales] [bit] NOT NULL,
	[SeEliminaronAplicaciones] [bit] NOT NULL,
	[HddDisponible] [float] NOT NULL,
	[Observaciones] [nvarchar](250) NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[IdAccionEquipo] [int] NOT NULL,
 CONSTRAINT [PK__InvHisPl__3214EC0706CD2A2F] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE InvTabEquipo
DROP COLUMN TipoEquipo
GO

ALTER TABLE InvTabEquipo
DROP COLUMN SO
GO

ALTER TABLE InvTabEquipo
ADD IdTipoEquipo INT NOT NULL
GO

ALTER TABLE InvTabEquipo
ADD IdSO INT NOT NULL
GO

ALTER TABLE InvTabEquipo
ADD CONSTRAINT FK_InvTabEquipo_TipoEquipo FOREIGN KEY (IdTipoEquipo)
REFERENCES InvCatTipoEquipo (Id)
GO

ALTER TABLE InvTabEquipo
ADD CONSTRAINT FK_InvTabEquipo_SO FOREIGN KEY (IdSO)
REFERENCES InvCatSO (Id)
GO
