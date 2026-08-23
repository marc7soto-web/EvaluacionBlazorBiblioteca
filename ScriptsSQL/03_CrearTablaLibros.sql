USE BibliotecaDB;
GO

CREATE TABLE Libros
(
    Id INT IDENTITY(1,1) PRIMARY KEY,

    NombreLibro VARCHAR(50) NOT NULL,

    Autor VARCHAR(50) NOT NULL,

    NumPaginas INT NOT NULL,

    FechaPublicacion DATE NOT NULL
);
GO