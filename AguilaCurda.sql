CREATE DATABASE [AguilaCurda]
GO

USE [AguilaCurda]
GO

CREATE TABLE [dbo].[Articulo](
	[Id_Articulo] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Marca] [varchar](20) NULL,
	[Costo] [float] NULL,
	[Precio_Unitario] [float] NULL,
	[Proveedor] [varchar](50) NULL,
	[Vencimiento] [varchar](50) NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[Id_Articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
CREATE TABLE [dbo].[Factura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NroFactura] [int] NULL,
	[Timbrado] [int] NULL,
	[Cliente] [int] NULL,
	[TipoPago] [int] NULL,
	[FechaFactura] [datetime] NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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


CREATE TABLE [dbo].[DetalleFactura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[factura_id] [int] NOT NULL,
	[Cantidad] [float] NULL,
	[Articulo] [int] NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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

CREATE TABLE [dbo].[DetalleFactura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [int] NULL,
	[MontoTotal] [nchar](50) NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Devolucion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Motivo_Devolucion] [nchar](50) NULL,
	[Descripcion] [nchar](50) NULL,
	[FechaDevol] [datetime] NULL,
 CONSTRAINT [PK_Devolucion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

