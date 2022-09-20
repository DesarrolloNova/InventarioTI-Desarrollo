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

ALTER TABLE InvHisAsignacionEquipo
DROP COLUMN IdPlanta
GO


