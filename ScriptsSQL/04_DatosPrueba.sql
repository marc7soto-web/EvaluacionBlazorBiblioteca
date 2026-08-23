USE BibliotecaDB;
GO

INSERT INTO Libros
(
    NombreLibro,
    Autor,
    NumPaginas,
    FechaPublicacion
)
VALUES
(
    'El ojo del mundo',
    'Robert Jordan',
    824,
    '1990-01-15'
),
(
    'Orgullo o prejuicio',
    'Jane Austen',
    500,
    '1813-01-28'
),
(
    'Juego de tronos',
    'George R.R. Martin',
    800,
    '1996-08-01'
);