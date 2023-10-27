DROP TABLE IF EXISTS Usuario;
DROP TABLE IF EXISTS Objeto;
DROP TABLE IF EXISTS DatosBancarios;
DROP TABLE IF EXISTS Password;
DROP TABLE IF EXISTS Carrito;
DROP TABLE IF EXISTS Mensaje;


CREATE TABLE Usuario(
	IdUser Int Identity (1,1) primary key,
	Email varchar(50) NOT NULL,
	UserName varchar(50) NOT NULL,
	LastName varchar(50),
	Saldo Decimal NOT NULL
);

CREATE TABLE Objeto(
	IdObjeto Int Identity(1,1) Primary Key,
	Precio Decimal NOT NULL,
	Titulo varchar(25) NOT NULL,
	Descripcion varchar(100),
	Foto varchar(100),
	IdUser Int NOT NULL,
	Foreign Key (IdUser) References Usuario (IdUser) On Delete Cascade On Update Cascade
);

CREATE TABLE DatosBancarios(
	IdCuentaBanco Int Identity (1,1) primary key,
	IdUser Int NOT NULL,
	Entidad varchar(50) NOT NULL,
	NumTarjeta BigInt NOT NULL,
	fCaducidad Date NOT NULL,
	Foreign Key (IdUser) References Usuario (IdUser) On Delete Cascade On Update Cascade
);

CREATE TABLE Password(
	IdPassword Int Identity (1,1) primary key,
	IdUser Int NOT NULL,
	Password varchar(25) NOT NULL,
	Foreign Key (IdUser) References Usuario (IdUser) On Delete Cascade On Update Cascade
);

CREATE TABLE Carrito(
	IdUser Int Identity (1,1) primary key,
	IdObjeto Int NOT NULL,
	TotalPrecio Decimal NOT NULL,
	Foreign Key (IdUser) References Usuario (IdUser),
	Foreign Key (IdObjeto) References Objeto (IdObjeto) On Delete Cascade On Update Cascade
);

CREATE TABLE Mensaje(
	IdEmisor Int Identity (1,1) Primary Key,
	IdReceptor Int NOT NULL,
	Mensaje varchar(100) NOT NULL,
	Foreign Key (IdEmisor) References Usuario (IdUser),
	Foreign Key (IdReceptor) References Usuario (IdUser) 
);
