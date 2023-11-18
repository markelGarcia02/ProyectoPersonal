DROP TABLE IF EXISTS Usuario;
DROP TABLE IF EXISTS Objeto;
DROP TABLE IF EXISTS DatosBancarios;
DROP TABLE IF EXISTS Password;
DROP TABLE IF EXISTS Carrito;
DROP TABLE IF EXISTS Mensaje;


CREATE TABLE [dbo].[Usuario] (
    [IdUser]   INT          IDENTITY (1, 1) NOT NULL,
    [Email]    VARCHAR (50) NOT NULL,
    [UserName] VARCHAR (20) NOT NULL,
    [LastName] VARCHAR (30) NULL,
    [Password] VARCHAR (20) NOT NULL,
    [Saldo]    FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUser] ASC)
);

CREATE TABLE [dbo].[Objeto] (
    [IdObjeto]    INT           IDENTITY (1, 1) NOT NULL,
    [Precio]      FLOAT (53)    NOT NULL,
    [Titulo]      VARCHAR (25)  NOT NULL,
    [Descripcion] VARCHAR (100) NULL,
    [Foto]        VARCHAR (100) NULL,
    [IdUser]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([IdObjeto] ASC),
    FOREIGN KEY ([IdUser]) REFERENCES [dbo].[Usuario] ([IdUser]) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE [dbo].[Carrito] (
    [IdUser]   INT NOT NULL,
    [IdObjeto] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUser] ASC, [IdObjeto] ASC),
    FOREIGN KEY ([IdObjeto]) REFERENCES [dbo].[Objeto] ([IdObjeto]) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY ([IdUser]) REFERENCES [dbo].[Usuario] ([IdUser])
);

