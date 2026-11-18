IF DB_ID('MaferrerDB') IS NULL
    CREATE DATABASE MaferrerDB;
GO
USE MaferrerDB;
GO

CREATE TABLE dbo.habitantes (
    idHabitantes INT IDENTITY(1,1) NOT NULL,
    [código]     VARCHAR(20)  NOT NULL,
    nombre       VARCHAR(100) NOT NULL,
    direccion    VARCHAR(200) NULL,
    telefono     VARCHAR(20)  NULL,
    CONSTRAINT PK_habitantes PRIMARY KEY CLUSTERED (idHabitantes)
);

CREATE TABLE dbo.aportaciones (
    idAportacion   INT IDENTITY(1,1) NOT NULL,
    idHabitantes   INT NOT NULL,
    fecha          DATE NULL,
    concepto       VARCHAR(150) NOT NULL,
    monto          DECIMAL(10,2) NOT NULL,
    numComprobante VARCHAR(50) NULL,
    estado         VARCHAR(30) NOT NULL,
    CONSTRAINT PK_aportaciones PRIMARY KEY CLUSTERED (idAportacion),
    CONSTRAINT FK_aportaciones_habitantes
        FOREIGN KEY (idHabitantes) REFERENCES dbo.habitantes(idHabitantes)
);

CREATE TABLE dbo.Incidentes (
    Id           INT IDENTITY(1,1) NOT NULL,
    Fecha        DATE NOT NULL,
    Tipo         VARCHAR(100) NOT NULL,
    Lugar        VARCHAR(150) NOT NULL,
    Descripcion  VARCHAR(500) NULL,
    Estado       VARCHAR(50) NOT NULL,
    idHabitantes INT NULL,
    CONSTRAINT PK_Incidentes PRIMARY KEY CLUSTERED (Id),
    CONSTRAINT FK_Incidentes_habitantes
        FOREIGN KEY (idHabitantes) REFERENCES dbo.habitantes(idHabitantes)
);

CREATE TABLE dbo.Visitantes (
    id               INT IDENTITY(1,1) NOT NULL,
    hora_entrada     DATETIME NOT NULL,
    nombre_visitante VARCHAR(100) NOT NULL,
    numero_casa      VARCHAR(30) NOT NULL,
    motivo           VARCHAR(100) NOT NULL,
    hora_salida      DATETIME NULL,
    idHabitantes     INT NULL,
    CONSTRAINT PK_Visitantes PRIMARY KEY CLUSTERED (id),
    CONSTRAINT FK_Visitantes_habitantes
        FOREIGN KEY (idHabitantes) REFERENCES dbo.habitantes(idHabitantes)
);
GO

INSERT INTO dbo.habitantes ([código], nombre, direccion, telefono) VALUES
('H001', 'Juan Perez',  'Casa 1', '7000-0001'),
('H002', 'Maria Lopez', 'Casa 2', '7000-0002');

INSERT INTO dbo.aportaciones (idHabitantes, fecha, concepto, monto, numComprobante, estado) VALUES
(1, '2026-11-01', 'Cuota mensual', 15.00, 'C-001', 'Pagado'),
(2, '2026-11-01', 'Cuota mensual', 15.00, NULL,    'Pendiente');

INSERT INTO dbo.Incidentes (Fecha, Tipo, Lugar, Descripcion, Estado, idHabitantes) VALUES
('2026-11-05', 'Ruido', 'Pasaje 3', 'Musica alta', 'Abierto', 1);

INSERT INTO dbo.Visitantes (hora_entrada, nombre_visitante, numero_casa, motivo, hora_salida, idHabitantes) VALUES
('2026-11-10 14:00', 'Carlos Ruiz', 'Casa 2', 'Visita familiar', NULL, 2);
GO
