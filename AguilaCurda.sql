
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