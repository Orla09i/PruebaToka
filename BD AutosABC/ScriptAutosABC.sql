USE [AutosABC]
GO
/****** Object:  Table [dbo].[AUTOS]    Script Date: 26/10/2018 08:11:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AUTOS](
	[IdAuto] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](20) NOT NULL,
	[Modelo] [varchar](20) NOT NULL,
	[Folio] [varchar](20) NOT NULL,
	[Color] [varchar](20) NOT NULL,
	[Transmision] [bit] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK__AUTOS__2C8AA82C70434C22] PRIMARY KEY CLUSTERED 
(
	[IdAuto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SOLICITUD]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOLICITUD](
	[IdSolicitud] [int] IDENTITY(1,1) NOT NULL,
	[IdAuto] [int] NOT NULL,
	[Fecha] [varchar](20) NOT NULL,
	[NumeroLote] [varchar](20) NOT NULL,
 CONSTRAINT [PK_SOLICITUD] PRIMARY KEY CLUSTERED 
(
	[IdSolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[AUTOS] ON 

INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (4, N'Honda', N'Civic', N'HON-9034', N'Rojo', 0, N'Test functional')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (5, N'Ferrari', N'F12', N'FER-9078', N'Amarillo', 0, N'Test')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (7, N'Bentley', N'Mulsanne', N'BEN-6745', N'Negro', 1, N'Test')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (8, N'BMW', N'X3', N'BMW-1456', N'Blanco', 1, N'Test')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (9, N'Chevrolet', N'Aveo', N'CHE-0867', N'Blanco', 0, N'Test')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (10, N'FIAT', N'500X', N'FIA-3454', N'Rojo', 1, N'Test')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (11, N'Hyundai', N'Elantra', N'HYU-1234', N'Negro', 0, N'Test')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (12, N'ISUZU', N'D-Max', N'ISU-7869', N'Blanco', 0, N'Test33')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (13, N'KIA', N'Rio', N'KIA-4523', N'Azul', 1, N'Test1')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (14, N'MASERATI', N'Ghibli', N'MAS-1255', N'Negro', 0, N'Test67')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (15, N'Nissan', N'Altima', N'ALT-2363', N'Gris', 1, N'Test')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (16, N'Chevrolet', N'Aveo', N'CHE-0856', N'Blanco', 1, N'Test789')
INSERT [dbo].[AUTOS] ([IdAuto], [Marca], [Modelo], [Folio], [Color], [Transmision], [Descripcion]) VALUES (17, N'ISUZU', N'D-Max', N'ISU-7239', N'Blanco', 0, N'Test3323')
SET IDENTITY_INSERT [dbo].[AUTOS] OFF
SET IDENTITY_INSERT [dbo].[SOLICITUD] ON 

INSERT [dbo].[SOLICITUD] ([IdSolicitud], [IdAuto], [Fecha], [NumeroLote]) VALUES (8, 11, N'26/10/2018', N'12345')
INSERT [dbo].[SOLICITUD] ([IdSolicitud], [IdAuto], [Fecha], [NumeroLote]) VALUES (9, 4, N'29/10/2018', N'123')
INSERT [dbo].[SOLICITUD] ([IdSolicitud], [IdAuto], [Fecha], [NumeroLote]) VALUES (10, 9, N'27/10/2018', N'1')
INSERT [dbo].[SOLICITUD] ([IdSolicitud], [IdAuto], [Fecha], [NumeroLote]) VALUES (11, 14, N'27/10/2018', N'1')
INSERT [dbo].[SOLICITUD] ([IdSolicitud], [IdAuto], [Fecha], [NumeroLote]) VALUES (12, 10, N'30/10/2018', N'145')
INSERT [dbo].[SOLICITUD] ([IdSolicitud], [IdAuto], [Fecha], [NumeroLote]) VALUES (13, 4, N'01/11/2018', N'345')
SET IDENTITY_INSERT [dbo].[SOLICITUD] OFF
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD  CONSTRAINT [fk_Auto] FOREIGN KEY([IdAuto])
REFERENCES [dbo].[AUTOS] ([IdAuto])
GO
ALTER TABLE [dbo].[SOLICITUD] CHECK CONSTRAINT [fk_Auto]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarAuto]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ActualizarAuto]  
(  
   @IdAuto int,  
   @Marca varchar (50),  
   @Modelo varchar (50),  
   @Folio varchar (50),
   @Color varchar(20),
   @Transmision bit, 
   @Descripcion text  
)  
as  
begin  
   Update AUTOS   
   set Marca = @Marca,  
   Modelo = @Modelo,  
   Folio = @Folio,
   Color = @Color,
   Transmision = @Transmision,
   Descripcion = @Descripcion  
   where IdAuto = @IdAuto  
End 
GO
/****** Object:  StoredProcedure [dbo].[ActualizarSolicitud]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ActualizarSolicitud]  
(  
   @IdSolicitud int, 
   @IdAuto int, 
   @Fecha varchar (50),  
   @NumeroLote varchar (50)

)  
as  
begin  
   Update Solicitud   
   set IdAuto = @IdAuto,  
   Fecha = @Fecha,  
   NumeroLote = @NumeroLote

   where IdSolicitud = @IdSolicitud  
End 

GO
/****** Object:  StoredProcedure [dbo].[AgregarAuto]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[AgregarAuto]  
(  
   @Marca varchar (50),  
   @Modelo varchar (50),  
   @Folio varchar (50),
   @Color varchar(20),
   @Transmision bit, 
   @Descripcion text  
)  
as  
begin  
   Insert into AUTOS (Marca, Modelo, Folio, Color, Transmision, Descripcion) values(@Marca,@Modelo,@Folio,@Color,@Transmision,@Descripcion)  
End 
GO
/****** Object:  StoredProcedure [dbo].[AgregarSolicitud]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[AgregarSolicitud]  
(  
   @Fecha varchar (50),  
   @NumeroLote varchar (50),  
   @IdAuto int
)  
as  
begin  
   Insert into Solicitud (IdAuto, Fecha, NumeroLote) values(@IdAuto,@Fecha,@NumeroLote)  
End  
GO
/****** Object:  StoredProcedure [dbo].[BorrarAuto]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[BorrarAuto]  
(  
   @IdAuto int  
)  
as   
begin  
   Delete from AUTOS where IdAuto = @Idauto  
End
GO
/****** Object:  StoredProcedure [dbo].[BorrarSolicitud]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[BorrarSolicitud]  
(  
   @Idsolicitud int  
)  
as   
begin  
   Delete from SOLICITUD where Idsolicitud = @IdSolicitud  
End  
GO
/****** Object:  StoredProcedure [dbo].[ObtenerAutos]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ObtenerAutos]  
as  
begin  
   select *from AUTOS  
End  
GO
/****** Object:  StoredProcedure [dbo].[ObtenerAutosList]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ObtenerAutosList]  
as  
begin  
   select IdAuto, Folio from AUTOS  
End 
GO
/****** Object:  StoredProcedure [dbo].[ObtenerSolicitud]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ObtenerSolicitud]  
as  
begin  
   select *from Solicitud  
End 
GO
/****** Object:  StoredProcedure [dbo].[ObtenerSolicitudList]    Script Date: 26/10/2018 08:11:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ObtenerSolicitudList]  
as  
begin  
    SELECT S.IdSolicitud, S.Fecha, S.NumeroLote, A.Modelo, A.Marca, A.Folio
	FROM Solicitud as S
	INNER JOIN autos as A ON S.IdAuto = A.IdAuto;
End 
GO
