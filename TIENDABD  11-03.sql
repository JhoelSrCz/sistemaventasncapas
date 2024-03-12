CREATE DATABASE TiendaBD

CREATE TABLE Persona (
IdPersona INT IDENTITY (1,1) NOT NULL,
Nombre NVARCHAR (25) NOT NULL,
Apellido NVARCHAR (30) NOT NULL,
Telefono NVARCHAR (15) NOT NULL,
CI NVARCHAR (10) NOT NULL,
Correo NVARCHAR (25) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdPersona),
)

CREATE TABLE Usuario (
IdUsuario INT IDENTITY (1,1) NOT NULL,
IdPersona INT NOT NULL,
NombreUser NVARCHAR (25) NOT NULL,
Contrase�a NVARCHAR (30) NOT NULL,
FechaReg DATETIME NOT NULL,
PRIMARY KEY (IdUsuario),
FOREIGN KEY (IdPersona) REFERENCES Persona (IdPersona)
)

CREATE TABLE Rol (
IdRol INT IDENTITY (1,1) NOT NULL,
Nombre NVARCHAR (25) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdRol),
)

CREATE TABLE UsuarioRol (
IdUsuarioRol INT IDENTITY (1,1) NOT NULL,
IdUsuario INT NOT NULL,
IdRol INT NOT NULL,
FechaAsigna DATETIME NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdUsuarioRol),
FOREIGN KEY (IdUsuario) REFERENCES Usuario (IdUsuario),
FOREIGN KEY (IdRol) REFERENCES Rol (IdRol),
)

CREATE TABLE Cliente (
IdCliente INT IDENTITY (1,1) NOT NULL,
IdPersona INT NOT NULL,
TipoCliente NVARCHAR (25) NOT NULL,
CodigoClie NVARCHAR (25) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdCliente),
FOREIGN KEY (IdPersona) REFERENCES Persona (IdPersona),
)

CREATE TABLE Venta (
IdVenta INT IDENTITY (1,1) NOT NULL,
IdCliente INT NOT NULL,
IdVendedor INT NOT NULL,
Fecha DATETIME NOT NULL,
Total DECIMAL(10,2) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdVenta),
FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente),
FOREIGN KEY (IdVendedor) REFERENCES Usuario (IdUsuario),
)

CREATE TABLE TipoProd (
IdTipoProd INT IDENTITY (1,1) NOT NULL,
Nombre NVARCHAR (25) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdTipoProd),
)

CREATE TABLE Marca (
IdMarca INT IDENTITY (1,1) NOT NULL,
Nombre NVARCHAR (25) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdMarca),
)

CREATE TABLE Producto (
IdProducto INT IDENTITY (1,1) NOT NULL,
IdTipoProd INT NOT NULL,
IdMarca INT NOT NULL,
Nombre NVARCHAR (25) NOT NULL,
CodigoBarra NVARCHAR (25) NOT NULL,
Unidad NVARCHAR (25) NOT NULL,
Descripcion NVARCHAR (100) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdProducto),
FOREIGN KEY (IdTipoProd) REFERENCES TipoProd (IdTipoProd),
FOREIGN KEY (IdMarca) REFERENCES Marca (IdMarca),
)

CREATE TABLE DetalleVent (
IdDetalleVent INT IDENTITY (1,1) NOT NULL,
IdVenta INT NOT NULL,
IdProducto INT NOT NULL,
Cantidad INT NOT NULL,
PrecioVenta DECIMAL(10,2) NOT NULL,
SubTotal DECIMAL(10,2) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdDetalleVent),
FOREIGN KEY (IdVenta) REFERENCES Venta (IdVenta),
FOREIGN KEY (IdProducto) REFERENCES Producto (IdProducto),
)

CREATE TABLE Proveedor (
IdProveedor INT IDENTITY (1,1) NOT NULL,
Nombre NVARCHAR (25) NOT NULL,
Telefono NVARCHAR (15) NOT NULL,
Direccion NVARCHAR (40) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdProveedor),
)

CREATE TABLE Ingreso (
IdIngreso INT IDENTITY (1,1) NOT NULL,
IdProveedor INT NOT NULL,
FechaIngreso DATETIME NOT NULL,
Total DECIMAL(10,2) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdIngreso),
FOREIGN KEY (IdProveedor) REFERENCES Proveedor (IdProveedor),
)

CREATE TABLE Detalleing (
IdDetalleing INT IDENTITY (1,1) NOT NULL,
IdProducto INT NOT NULL,
IdIngreso INT NOT NULL,
FechaVenci DATETIME NOT NULL,
Cantidad INT NOT NULL,
PrecioCosto DECIMAL(10,2) NOT NULL,
PrecioVenta DECIMAL(10,2) NOT NULL,
SubTotal DECIMAL(10,2) NOT NULL,
Estado NVARCHAR (25) NOT NULL,
PRIMARY KEY (IdDetalleing),
FOREIGN KEY (IdProducto) REFERENCES Producto (IdProducto),
FOREIGN KEY (IdIngreso) REFERENCES Ingreso (IdIngreso),
)

CREATE TABLE Provee (
IdProvee INT IDENTITY (1,1) NOT NULL,
IdProducto INT NOT NULL,
IdProveedor INT NOT NULL,
Fecha DATETIME NOT NULL,
Precio DECIMAL(10,2) NOT NULL,
PRIMARY KEY (IdProducto),
FOREIGN KEY (IdProducto) REFERENCES Producto (IdProducto),
FOREIGN KEY (IdProveedor) REFERENCES Proveedor (IdProveedor),
)