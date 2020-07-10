USE MASTER
GO

CREATE DATABASE TiendaVideojuegos
GO

USE TiendaVideojuegos
GO

CREATE TABLE Tipo_Pagos
(
	Cod_TipoPago_TP char(4) PRIMARY KEY NOT NULL,
	Nombre_TipoPago_TP varchar(60) NOT NULL,
)
GO

CREATE TABLE Tipo_Usuarios
(
	Cod_TipoUsuario_TU char(4) PRIMARY KEY NOT NULL,
	Nombre_TipoUsuario_TU varchar(60) NOT NULL,
)
GO

CREATE TABLE Plataformas
(
	Cod_Plataforma_P char(4) PRIMARY KEY NOT NULL,
	Nombre_Plataforma_P varchar(60) NOT NULL,
)
GO

CREATE TABLE Categorias
(
	Cod_Categoria_C char(4) PRIMARY KEY NOT NULL,
	Nombre_Categoria_C varchar(60) NOT NULL,
)
GO

CREATE TABLE Marcas
(
	Cod_Marca_M char(4) PRIMARY KEY NOT NULL,
	Nombre_Marca_M varchar(60) NOT NULL,
	Nombre_Contacto_M varchar(100) NOT NULL,
	Direccion_Marca_M varchar(100) NOT NULL,
	Ciudad_Marca_M varchar(100) NOT NULL,
	Telefono_Marca_M varchar(15) NOT NULL,
	EMail_Marca_M varchar(200) NULL,
	Estado_Marca_M bit NOT NULL
)
GO

CREATE TABLE Generos
(
	Cod_Genero_G char(4) PRIMARY KEY NOT NULL,
	Nombre_Genero_G varchar(60) NOT NULL,
)
GO

CREATE TABLE Usuarios
(
	Cod_Usuario_U char(4) NOT NULL,
	Cod_TipoUsuario_U char(4) NOT NULL,
	Nombre_Usuario_U varchar(60) NOT NULL,
	Apellido_Usuario_U varchar(60) NOT NULL,
	Nickname_Usuario_U varchar(100) NOT NULL,
	Contraseña_Usuario_U varchar(100) NOT NULL,
	DNI_Usuario_U varchar(10) NOT NULL,
	fNacimiento_Usuario_U smalldatetime NOT NULL,
	Telefono_Usuario_U varchar(15) NULL,
	EMail_Usuario_U varchar(100) NULL,
	Direccion_Usuario_U varchar(100) NOT NULL,
	Estado_Usuario_U bit NOT NULL
	CONSTRAINT PK_Usuarios PRIMARY KEY (Cod_Usuario_U,Cod_TipoUsuario_U),
)
GO

CREATE TABLE Productos
(
	Cod_Producto_PR char(4) PRIMARY KEY NOT NULL,
	Nombre_Producto_PR varchar(100) NOT NULL,
	Descripcion_Producto_PR varchar(500) NOT NULL,
	Cod_Marca_PR char(4) NOT NULL,
	Cod_Categoria_PR char(4) NOT NULL,
	Cod_Genero_PR char(4) NULL,
	fPublicacion_Producto_PR smalldatetime NULL,
	Estado_Producto_PR bit NOT NULL,
)
GO

CREATE TABLE PlataformaxProducto
(
	Cod_Producto_PxP char(4) NOT NULL,
	Cod_Plataforma_PxP char(4) NOT NULL,
	Stock_Producto_PxP int NOT NULL,
	PrecioUnitario_Producto_PxP money NOT NULL,
	Imagen_Producto_PxP varchar(100) NULL,
	CONSTRAINT PK_PlataformaxProducto PRIMARY KEY (Cod_Producto_PxP,Cod_Plataforma_PxP)
)
GO

CREATE TABLE Compras
(
	Cod_Compra_CO int PRIMARY KEY NOT NULL identity (1,1),
	Cod_Marca_CO char(4) NOT NULL,
	Fecha_Compra_CO smalldatetime NOT NULL,
)
GO

CREATE TABLE DetalleCompras
(
	Cod_Compra_DC int NOT NULL,
	Cod_Producto_DC char(4) NOT NULL,
	Cod_Plataforma_DC char(4) NOT NULL,
	Cantidad_Producto_DC int NOT NULL,
	PrecioUnitario_Compra_DC money NOT NULL,
	CONSTRAINT PK_DetalleCompras PRIMARY KEY (Cod_Compra_DC, Cod_Producto_DC)
)
GO

CREATE TABLE Ventas
(
	Cod_Venta_V int PRIMARY KEY NOT NULL identity (1,1),
	Cod_Usuario_V char(4) NOT NULL,
	Cod_TipoUsuario_V char(4) NOT NULL,
	fVenta_V smalldatetime NOT NULL,
	Cod_TipoPago_V char(4) NOT NULL,
)
GO

CREATE TABLE DetalleVentas
(
	Cod_Venta_DV int NOT NULL,
	Cod_Producto_DV char(4) NOT NULL,
	Cod_Plataforma_DV char(4) NOT NULL,
	Cantidad_Producto_DV int NOT NULL,
	PrecioUnitario_Venta_DV money NOT NULL,
	CONSTRAINT PK_DetalleVentas PRIMARY KEY (Cod_Venta_DV, Cod_Producto_DV)
)
GO

ALTER TABLE PlataformaxProducto
ADD CONSTRAINT FK_PlataformaxProducto_Productos FOREIGN KEY (Cod_Producto_PxP) REFERENCES Productos (Cod_Producto_PR)
GO

ALTER TABLE PlataformaxProducto
ADD CONSTRAINT FK_PlataformaxProducto_Plataformas FOREIGN KEY (Cod_Plataforma_PxP) REFERENCES Plataformas (Cod_Plataforma_P)
GO

ALTER TABLE Productos
ADD CONSTRAINT FK_Productos_Categorias FOREIGN KEY (Cod_Categoria_PR) REFERENCES Categorias (Cod_Categoria_C)
GO

ALTER TABLE Productos
ADD CONSTRAINT FK_Productos_Marcas FOREIGN KEY (Cod_Marca_PR) REFERENCES Marcas (Cod_Marca_M)
GO

ALTER TABLE Productos
ADD CONSTRAINT FK_Productos_Generos FOREIGN KEY (Cod_Genero_PR) REFERENCES Generos (Cod_Genero_G)
GO

ALTER TABLE DetalleCompras
ADD CONSTRAINT FK_DetalleCompras_Compras FOREIGN KEY (Cod_Compra_DC) REFERENCES Compras (Cod_Compra_CO)
GO

ALTER TABLE DetalleCompras
ADD CONSTRAINT FK_DetalleCompras_Productos FOREIGN KEY (Cod_Producto_DC) REFERENCES Productos (Cod_Producto_PR)
GO

ALTER TABLE DetalleVentas
ADD CONSTRAINT FK_DetalleVentas_Ventas FOREIGN KEY (Cod_Venta_DV) REFERENCES Ventas (Cod_Venta_V)
GO

ALTER TABLE DetalleVentas
ADD CONSTRAINT FK_DetalleVentas_Productos FOREIGN KEY (Cod_Producto_DV) REFERENCES Productos (Cod_Producto_PR)
GO

ALTER TABLE Usuarios
ADD CONSTRAINT FK_Usuarios_TipoUsuarios FOREIGN KEY (Cod_TipoUsuario_U) REFERENCES Tipo_Usuarios (Cod_TipoUsuario_TU)
GO

ALTER TABLE Ventas
ADD CONSTRAINT FK_Ventas_Usuarios FOREIGN KEY (Cod_Usuario_V,Cod_TipoUsuario_V) REFERENCES Usuarios (Cod_Usuario_U,Cod_TipoUsuario_U)
GO

ALTER TABLE Ventas
ADD CONSTRAINT FK_Ventas_TipoPagos FOREIGN KEY (Cod_TipoPago_V) REFERENCES Tipo_Pagos (Cod_TipoPago_TP)
GO

-- CARGA DE DATOS --

INSERT INTO Tipo_Pagos (Cod_TipoPago_TP, Nombre_TipoPago_TP)
SELECT 'TP1','Efectivo' UNION
SELECT 'TP2','Tarjeta de Debito' UNION
SELECT 'TP3','Tarjeta de Credito'

INSERT INTO Tipo_Usuarios (Cod_TipoUsuario_TU, Nombre_TipoUsuario_TU)
SELECT 'TU1','Administrador' UNION
SELECT 'TU2','Cliente'

INSERT INTO Plataformas (Cod_Plataforma_P, Nombre_Plataforma_P)
SELECT 'PF1','Nintendo Switch' UNION
SELECT 'PF2','Nintendo 3DS' UNION
SELECT 'PF3','Playstation 3' UNION
SELECT 'PF4','Playstation 4' UNION
SELECT 'PF5','PS Vita' UNION
SELECT 'PF6','XBOX 360' UNION
SELECT 'PF7','XBOX One' UNION
SELECT 'PF8','PC' UNION
SELECT 'PF9','Playstation Classic'

INSERT INTO Categorias (Cod_Categoria_C, Nombre_Categoria_C)
SELECT 'CA1','Consolas' UNION
SELECT 'CA2','Videojuegos' UNION
SELECT 'CA3','Accesorios' UNION
SELECT 'CA4','Otros'

INSERT INTO Marcas (Cod_Marca_M,Nombre_Marca_M,Nombre_Contacto_M,Direccion_Marca_M,Ciudad_Marca_M,Telefono_Marca_M,EMail_Marca_M,Estado_Marca_M)
SELECT 'M1','Nintendo','Doug B.','10 Rockefeller','New York','1138205845','contact@nintendo.com',1 UNION
SELECT 'M2','Sony','Charles X.','5 Th Avenue','New York','5555555','contact@sony.com',1 UNION
SELECT 'M3','Microsoft','Bob W.','300 Montgomery','New York','57743355','contact@microsoft.com',1 UNION
SELECT 'M4','Electronic Arts','Gary J.','50 Montgomery','New York','53823355','contact@ea.com',1 UNION
SELECT 'M5','Netherrealm Studios','Ed B.','200 Montgomery','New York','56660355','contact@netherrealm.com',1 UNION
SELECT 'M6','Activision','Jay C.','30 Montgomery','New York','56330355','contact@activision.com',1

INSERT INTO Generos (Cod_Genero_G,Nombre_Genero_G)
SELECT 'G0','Sin Genero' UNION
SELECT 'G1','Aventura' UNION
SELECT 'G2','Lucha' UNION
SELECT 'G3','Shoother' UNION
SELECT 'G4','Deportes' UNION
SELECT 'G5','Accion' UNION
SELECT 'G6','Arcade' UNION
SELECT 'G7','Carreras' UNION
SELECT 'G8','Estrategias' UNION
SELECT 'G9','Infantil' UNION
SELECT 'G10','Lucha' UNION
SELECT 'G11','RPG' UNION
SELECT 'G12','Plataformas' UNION
SELECT 'G13','Simulador'

INSERT INTO Productos(Cod_Producto_PR,Nombre_Producto_PR,Descripcion_Producto_PR,Cod_Marca_PR,Cod_Categoria_PR,Cod_Genero_PR,fPublicacion_Producto_PR,Estado_Producto_PR)
SELECT 'A1','Nintendo Switch Gray','Consola de videojuegos Nintendo.','M1','CA1','G0','',1 UNION
SELECT 'A2','Nintendo Switch Neon','Consola de videojuegos Nintendo.','M1','CA1','G0','',1 UNION
SELECT 'A3','Nintendo Switch Lite Gray','Consola de videojuegos Nintendo.','M1','CA1','G0','',1 UNION
SELECT 'A4','Nintendo Switch Lite Turquoise','Consola de videojuegos Nintendo.','M1','CA1','G0','',1 UNION
SELECT 'A5','Super Smash Bros. Ultimate','Videojuego de pelea.','M1','CA2','G2','',1 UNION
SELECT 'A6','The Legend of Zelda: Breath of the wild','Videojuego de la franquicia Legend of Zelda.','M1','CA2','G1','',1 UNION
SELECT 'A7','Super Mario Odyssey','Videojuego de plataformas.','M1','CA2','G12','',1 UNION
SELECT 'A8','Mario Kart 8 Deluxe','Videojuego de carreras.','M1','CA2','G7','',1 UNION
SELECT 'A9','Nintendo Switch Pro Controller','Control/mando para Nintendo Switch.','M1','CA3','G0','',1 UNION
SELECT 'A10','Gamecube Controller Adapter','Adaptador para el Gamecube Controller.','M1','CA3','G0','',1 UNION
SELECT 'A11','Gamecube Controller','Control/mando para Nintendo Switch con el diseño original de Gamecube.','M1','CA3','G0','',1 UNION
SELECT 'A12','Premium protective filter for Nintendo Switch','Protector de pantalla para Nintendo Switch.','M1','CA3','G0','',1 UNION
SELECT 'A13','Playstation 4 Slim','Consola de videojuegos Sony.','M2','CA1','G0','',1 UNION
SELECT 'A14','Playstation 4 Pro','Consola de videojuegos Sony.','M2','CA1','G0','',1 UNION
SELECT 'A15','Playstation Classic','Consola de videojuegos Sony.','M2','CA1','G0','',1 UNION
SELECT 'A16','PS Vita','Consola de videojuegos Sony.','M2','CA1','G0','',1 UNION
SELECT 'A17','God of War','Videojuego de aventura.','M2','CA2','G1','',1 UNION
SELECT 'A18','Days Gone','Videojuego de accion.','M2','CA2','G5','',1 UNION
SELECT 'A19','Uncharted: The Lost Legacy','Videojuego de accion.','M2','CA2','G5','',1 UNION
SELECT 'A20','Spider-Man','Videojuego de accion.','M2','CA2','G5','',1 UNION
SELECT 'A21','Joystick PS4 Dualshock','Control/mando para Playstation 4.','M2','CA3','G0','',1 UNION
SELECT 'A22','Sony PS4 Camera','Camara para Playstation 4.','M2','CA3','G0','',1 UNION
SELECT 'A23','Soporte vertical PS4','Soporte para Playstation 4.','M2','CA3','G0','',1 UNION
SELECT 'A24','Playstation Move Motion Controllers Doble Pack','Control/mando para Playstation 4.','M2','CA3','G0','',1 UNION
SELECT 'A25','Gears 5','Videojuego de accion.','M3','CA2','G5','',1 UNION
SELECT 'A26','Crackdown 3','Videojuego de accion.','M3','CA2','G5','',1 UNION
SELECT 'A27','Halo Infinite','Videojuego de aventura.','M3','CA2','G1','',1 UNION
SELECT 'A28','Forza Horizon 4','Videojuego de carreras.','M3','CA2','G7','',1 UNION
SELECT 'A29','Joystick Xbox One Black','Control/mando para Xbox One.','M3','CA3','G0','',1 UNION
SELECT 'A30','Joystick Xbox One Grey','Control/mando para Xbox One.','M3','CA3','G0','',1 UNION
SELECT 'A31','Microsoft Xbox One S','Consola de videojuegos Microsoft.','M3','CA1','G0','',1 UNION
SELECT 'A32','Star Wars Jedi Fallen Order','Videojuego de aventura.','M4','CA2','G1','',1 UNION
SELECT 'A33','Mortal Kombat 11','Videojuego de peleas.','M5','CA2','G2','',1 UNION
SELECT 'A34','Call of Duty: Modern Warfare','Videojuego de disparos.','M6','CA2','G3','',1

INSERT INTO PlataformaxProducto(Cod_Producto_PxP,Cod_Plataforma_PxP,Stock_Producto_PxP,PrecioUnitario_Producto_PxP,Imagen_Producto_PxP)
SELECT 'A1','PF1',1000,32500,'IMAGES/switchgris-box.jpg' UNION
SELECT 'A2','PF1',1000,32500,'IMAGES/switchneon-box.jpg' UNION
SELECT 'A3','PF1',1000,22500,'IMAGES/switchlitegris-box.jpg' UNION
SELECT 'A4','PF1',1000,22500,'IMAGES/switchliteturquesa-box.jpg' UNION
SELECT 'A5','PF1',1000,4900,'IMAGES/smash-box.jpg' UNION
SELECT 'A6','PF1',1000,5000,'IMAGES/botw-box.jpg' UNION
SELECT 'A7','PF1',1000,4800,'IMAGES/marioodyssey-box.jpg' UNION
SELECT 'A8','PF1',1000,4900,'IMAGES/mariokart-box.jpg' UNION
SELECT 'A9','PF1',1000,8500,'IMAGES/procontroller-box.jpg' UNION
SELECT 'A10','PF1',1000,2900,'IMAGES/gccadapter-box.jpg' UNION
SELECT 'A11','PF1',1000,10500,'IMAGES/gcc-box.jpg' UNION
SELECT 'A12','PF1',1000,1200,'IMAGES/protectivefilter-box.jpg' UNION
SELECT 'A13','PF4',1000,24500,'IMAGES/ps4slim-box.jpg' UNION
SELECT 'A14','PF4',1000,30000,'IMAGES/ps4pro-box.jpg' UNION
SELECT 'A15','PF9',1000,7000,'IMAGES/psclassic-box.jpg' UNION
SELECT 'A16','PF4',1000,33000,'IMAGES/psvita-box.jpg' UNION
SELECT 'A17','PF4',1000,2800,'IMAGES/gow-box.jpg' UNION
SELECT 'A18','PF4',1000,3900,'IMAGES/daysgone-box.jpg' UNION
SELECT 'A19','PF4',1000,2000,'IMAGES/unchartedtll-box.jpg' UNION
SELECT 'A20','PF4',1000,3700,'IMAGES/spiderman-box.jpg' UNION
SELECT 'A21','PF4',1000,5400,'IMAGES/ps4dualshock-box.jpg' UNION
SELECT 'A22','PF4',1000,5700,'IMAGES/ps4camera-box.jpg' UNION
SELECT 'A23','PF4',1000,1300,'IMAGES/soportevert-box.jpg' UNION
SELECT 'A24','PF4',1000,10600,'IMAGES/ps4move-box.jpg' UNION
SELECT 'A25','PF7',1000,6700,'IMAGES/gears5-box.jpg' UNION
SELECT 'A26','PF7',1000,3000,'IMAGES/crackdown3-box.jpg' UNION
SELECT 'A27','PF7',1000,5400,'IMAGES/haloinfinite-box.jpg' UNION
SELECT 'A28','PF7',1000,3000,'IMAGES/forza4-box.jpg' UNION
SELECT 'A29','PF7',1000,6000,'IMAGES/joystickxboxoneb-box.jpg' UNION
SELECT 'A30','PF7',1000,6000,'IMAGES/joystickxboxoneg-box.jpg' UNION
SELECT 'A31','PF7',1000,35000,'IMAGES/xboxones-box.jpg' UNION
SELECT 'A32','PF4',1000,5300,'IMAGES/starwarsps4-box.jpg' UNION
SELECT 'A32','PF7',1000,6500,'IMAGES/starwarsxboxone-box.jpg' UNION
SELECT 'A33','PF1',1000,4000,'IMAGES/mk11switch-box.jpg' UNION
SELECT 'A33','PF4',1000,4000,'IMAGES/mk11ps4-box.jpg' UNION
SELECT 'A33','PF7',1000,5500,'IMAGES/mk11xboxone-box.jpg' UNION
SELECT 'A34','PF4',1000,5600,'IMAGES/codps4-box.jpg' UNION
SELECT 'A34','PF7',1000,5600,'IMAGES/codxboxone-box.jpg'

INSERT INTO Usuarios(Cod_Usuario_U,Cod_TipoUsuario_U,Nombre_Usuario_U,Apellido_Usuario_U,Nickname_Usuario_U,Contraseña_Usuario_U,DNI_Usuario_U,fNacimiento_Usuario_U,Telefono_Usuario_U,EMail_Usuario_U,Direccion_Usuario_U,Estado_Usuario_U)
SELECT 'U1','TU1','Alexis','Rodriguez','CryoXz','123456','41804277','03/04/1999','44650251','ard@outlook.com','Moreno 362',1 UNION
SELECT 'U2','TU2','Rocio','Favre','Rofavre','123444','35123222','12/07/1994','1546825737','raf@outlook.com','Av Centenario 664',1

INSERT INTO Compras(Cod_Marca_CO, Fecha_Compra_CO)
SELECT 'M1', '08/12/2019' UNION
SELECT 'M2', '08/12/2019'

INSERT INTO DetalleCompras(Cod_Compra_DC, Cod_Producto_DC, Cod_Plataforma_DC, Cantidad_Producto_DC, PrecioUnitario_Compra_DC)
SELECT 1, 'A5', 'PF1', 1000, 3900 UNION
SELECT 1, 'A6', 'PF1', 1000, 4000 UNION
SELECT 1, 'A7', 'PF1', 1000, 3800 UNION
SELECT 2, 'A17', 'PF4', 1000, 2200

INSERT INTO Ventas(Cod_Usuario_V, Cod_TipoUsuario_V, fVenta_V, Cod_TipoPago_V)
SELECT 'U2', 'TU2', '08/12/2019', 'TP1' UNION
SELECT 'U2', 'TU2', '09/12/2019', 'TP1'

INSERT INTO DetalleVentas(Cod_Venta_DV, Cod_Producto_DV, Cod_Plataforma_DV, Cantidad_Producto_DV, PrecioUnitario_Venta_DV)
SELECT 1, 'A2', 'PF1', 1, 32500 UNION
SELECT 2, 'A5', 'PF1', 1, 4900 UNION
SELECT 2, 'A6', 'PF1', 1, 5000

CREATE PROCEDURE SpAltaCategorias(
	@Cod_Categoria_C char(4),
	@Nombre_Categoria_C varchar(60)
)
AS
	INSERT INTO Categorias(Cod_Categoria_C,Nombre_Categoria_C)
	VALUES(@Cod_Categoria_C,@Nombre_Categoria_C)
	RETURN
	GO

CREATE PROCEDURE SpAltaPLataforma(
		@Cod_Plataforma_P char(4),
		@Nombre_Plataforma_P varchar(60)
	)
	AS
		INSERT INTO Plataformas(Cod_Plataforma_P,Nombre_Plataforma_P)
		VALUES(@Cod_Plataforma_P,@Nombre_Plataforma_P)
		RETURN
		GO

CREATE PROCEDURE spEliminarCategoria(
	  @IDCATEGORIA char(4)
	 )
	 AS
	 DELETE Categorias WHERE Cod_Categoria_C = @IDCATEGORIA
	 RETURN
	 GO

CREATE PROCEDURE spEliminarPlataforma(
    @IDPLATAFORMA char(4)
    )
    AS
    DELETE Plataformas WHERE Cod_Plataforma_P = @IDPLATAFORMA
    RETURN
		GO

CREATE PROCEDURE spModificarCategoria(
			@codigoCategoria char(4),
			@nombreCategoria varchar(60)
		)
		AS
		BEGIN
		    UPDATE Categorias SET Nombre_Categoria_C = @nombreCategoria
			WHERE Cod_Categoria_C = @codigoCategoria
		END
		GO

CREATE PROCEDURE spModificarPlataforma(
			@codigoPlataforma char(4),
			@nombrePlataforma varchar(60)
		)
		AS
		BEGIN
		   UPDATE plataformas SET Nombre_Plataforma_P = @nombrePlataforma
			WHERE Cod_Plataforma_P = @codigoPlataforma
		END
		GO

CREATE PROCEDURE SpAltaVentas(
				@Cod_Usuario_V char(4),
				@Cod_TipoUsuario_V char(4),
				@fVenta_V smalldatetime,
				@Cod_TipoPago_V char(4)
	)
	AS
	INSERT INTO Ventas(Cod_Usuario_V, Cod_TipoUsuario_V, fVenta_V, Cod_TipoPago_V)
	VALUES(@Cod_Usuario_V, @Cod_TipoUsuario_V, @fVenta_V, @Cod_TipoPago_V)
	RETURN
	GO


CREATE PROCEDURE SpAltaDetalleVentas(
					@Cod_Venta_DV int,
					@Cod_Producto_DV char(4),
					@Cod_Plataforma_DV char(4),
					@Cantidad_Producto_DV int,
					@PrecioUnitario_Venta_DV money
		)
		AS
		INSERT INTO DetalleVentas(Cod_Venta_DV, Cod_Producto_DV, Cod_Plataforma_DV, Cantidad_Producto_DV, PrecioUnitario_Venta_DV)
		VALUES(@Cod_Venta_DV, @Cod_Producto_DV, @Cod_Plataforma_DV, @Cantidad_Producto_DV, @PrecioUnitario_Venta_DV)
		RETURN
		GO
