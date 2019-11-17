CREATE DATABASE [AguilaCurda]
GO

USE [AguilaCurda]
GO

CREATE TABLE [dbo].[Factura](
	[Id] [int] NOT NULL,
	[NroFactura] [int] NULL,
	[Timbrado] [int] NULL,
	[Cliente] [int] NULL,
	[TipoPago] [int] NULL,
	[FechaFactura] [datetime] NULL
) ON [PRIMARY]
GO



CREATE TABLE [dbo].[Cliente](
	[CodCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NULL,
	[NroDocumento] [nchar](23) NULL,
	[Telefono] [nchar](10) NULL,
	[Direccion] [nchar](50) NULL,
	[Sexo] [nchar](10) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[CodCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO




CREATE TABLE [dbo].[Proveedor](
	[CodProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NULL,
	[NroDocumento] [nchar](10) NULL,
	[Telefono] [nchar](10) NULL,
	[Direccion] [nchar](50) NULL,
	[PersonaContacto] [nchar](50) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[CodProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO