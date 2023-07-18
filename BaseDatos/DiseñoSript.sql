USE [PROYECTODISISTEMAS]
GO
/****** Object:  Table [dbo].[ASISTENCIA]    Script Date: 15/7/2023 15:21:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASISTENCIA](
	[ID_EMPLEADO] [int] IDENTITY(1,1) NOT NULL,
	[DIA] [varchar](20) NOT NULL,
	[HORA_ENTRADA] [time](7) NOT NULL,
	[HORA_SALIDA] [time](7) NOT NULL,
	[ESTATUS] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_EMPLEADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEDUCCIONES]    Script Date: 15/7/2023 15:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEDUCCIONES](
	[ID_DEDUCCIONES] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION_DEDUCCION] [varchar](50) NULL,
	[ESTATUS] [bit] NOT NULL,
	[ID_EMPLEADO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_DEDUCCIONES] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 15/7/2023 15:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[ID_EMPLEADO] [int] NOT NULL,
	[PRIMER_NOMBRE] [varchar](50) NOT NULL,
	[SEGUNDO_NOMBRE] [varchar](50) NULL,
	[PRIMER_APELLIDO] [varchar](50) NOT NULL,
	[SEGUNDO_APELLIDO] [varchar](50) NULL,
	[DNI] [int] NOT NULL,
	[DIRECCION] [varchar](50) NOT NULL,
	[TELEFONO] [varchar](10) NOT NULL,
	[FECHA_NACIMIENTO] [datetime] NOT NULL,
	[GENERO] [varchar](10) NULL,
	[FECHA_INGRESO] [datetime] NOT NULL,
	[ID_CARGO] [int] NOT NULL,
	[ID_HORARIO] [int] NOT NULL,
	[ID_USUARIO] [int] NOT NULL,
	[SALARIO_BASE] [int] NOT NULL,
	[ID_TIPO_EMPLEADO] [int] NOT NULL,
	[ID_TIPO_SALARIO] [int] NOT NULL,
	[NUMERO_CUENTA] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_EMPLEADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HORARIOS]    Script Date: 15/7/2023 15:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HORARIOS](
	[ID_HORARIO] [int] IDENTITY(1,1) NOT NULL,
	[TIPO_TURNO] [varchar](20) NOT NULL,
	[ESTATUS] [bit] NOT NULL,
	[JORNADA_LABORAL] [varchar](20) NOT NULL,
	[HORAS_SEMANALES] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_HORARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IMPUESTO]    Script Date: 15/7/2023 15:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IMPUESTO](
	[ID_IMPUESTO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION_IMPUESTO] [varchar](40) NULL,
	[ID_EMPLEADO] [int] NOT NULL,
	[PORCENTAJE_IMPUESTO] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_IMPUESTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISOS]    Script Date: 15/7/2023 15:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISOS](
	[ID_EMPLEADO] [int] IDENTITY(1,1) NOT NULL,
	[TIPO_PERMISO] [varchar](20) NOT NULL,
	[DIA] [date] NOT NULL,
	[HORAS] [time](7) NOT NULL,
	[JUSTIFICADO] [bit] NULL,
	[ID_PERMISOS] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_EMPLEADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_EMPLEADO]    Script Date: 15/7/2023 15:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_EMPLEADO](
	[ID_TIPO_EMPLEADO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION_TIPOEMPLEADO] [varchar](50) NOT NULL,
	[HORAS_EXTRAS] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TIPO_EMPLEADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_SALARIO]    Script Date: 15/7/2023 15:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_SALARIO](
	[ID_TIPO_SALARIO] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION_TIPO_SALARIO] [varchar](50) NOT NULL,
	[ESTATUS] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TIPO_SALARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANSACCION]    Script Date: 15/7/2023 15:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANSACCION](
	[ID_TRANSACCION] [int] IDENTITY(1,1) NOT NULL,
	[ID_DEDUCCIONES] [int] NOT NULL,
	[ID_IMPUESTO] [int] NOT NULL,
	[ID_TIPO_SALARIO] [int] NOT NULL,
	[ID_TIPO_EMPLEADO] [int] NOT NULL,
	[ID_PERMISOS] [int] NOT NULL,
	[ID_HORARIOS] [int] NOT NULL,
	[ID_EMPLEADO] [int] NOT NULL,
	[ID_ASISTENCIA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TRANSACCION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
