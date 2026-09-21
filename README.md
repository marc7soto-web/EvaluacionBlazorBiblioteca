# Evaluación Final Blazor Biblioteca

Proyecto de evaluación desarrollado para la gestión de libros de la Biblioteca de la escuela William Wallace.

La aplicación fue desarrollada inicialmente como un CRUD en Blazor y posteriormente adaptada para utilizar componentes de Blazor Bootstrap, diseño CSS personalizado y características de una aplicación web progresiva PWA.

## Tecnologías utilizadas

- Blazor Web App .NET 8
- Renderizado Interactive Server
- Blazor Bootstrap 4.0.0
- Bootstrap 5
- Entity Framework Core
- SQL Server
- ASP.NET Core Web API
- HttpClient
- DataAnnotations
- JavaScript Interop
- Progressive Web App PWA
- Service Worker
- Git y GitHub

## Funcionalidades CRUD

La aplicación permite realizar las siguientes operaciones:

- Agregar libros.
- Listar libros.
- Buscar libros por ID.
- Actualizar libros mediante búsqueda por ID.
- Actualizar libros desde el listado.
- Eliminar libros.
- Confirmar operaciones de actualización y eliminación.
- Mostrar mensajes de éxito y error.
- Validar la información ingresada en los formularios.

## Validaciones implementadas

Los formularios utilizan DataAnnotations para validar los datos antes de enviarlos a la API.

Las validaciones disponibles son:

- Nombre del libro obligatorio.
- Nombre del autor obligatorio.
- Cantidad de páginas obligatoria.
- Cantidad de páginas mayor que 1.
- Fecha de publicación obligatoria.
- Validación de ID vacío.
- Validación de ID inexistente.

## Integración de Blazor Bootstrap

Se instaló el paquete NuGet: 

**Blazor.Bootstrap 4.0.0**


## Repositorio GitHub

https://github.com/marc7soto-web/EvaluacionBlazorBiblioteca.git
