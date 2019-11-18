USE [AguilaCurda]
GO

/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 17/11/2019 21:31:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DetalleCompra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Articulo] [int] NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [nchar](10) NULL,
	[MontoTotal] [nchar](10) NULL,
 CONSTRAINT [PK_DetalleCompra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Compra]    Script Date: 17/11/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Compra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NroFactura] [int] NULL,
	[Proveedor] [int] NULL,
	[Direccion] [varchar](50) NULL,
	[MedioPago] [int] NULL,
	[FechaCompra] [datetime] NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



