# Sistema de Gestión de Libros (Prueba Técnica)

Aplicación Web Full-Stack desarrollada con ASP.NET y JS.

## Tecnologías
* **Backend:** ASP.NET Core WebAPI (C#)
* **Datos:** Entity Framework Core (In-Memory Database)
* **Frontend:** HTML5, Bootstrap 5, JavaScript (Fetch API)

## Instrucciones de Ejecución
1.  Clonar el repositorio.
2.  Abrir `Libros_Web.sln` en Visual Studio 2022.
3.  Ejecutar el proyecto (Ctrl + F5) con el perfil `https`.
4.  Navegar a `/cliente.html` para acceder a la interfaz de usuario.
    * Ejemplo: `https://localhost:7244/cliente.html`

## Justificación Técnica
* Se utilizó **EF Core In-Memory** para facilitar la ejecución del proyecto sin dependencias externas de SQL Server.
* Se implementó una arquitectura **RESTful** para el Backend.
* El Frontend se construyó con **Vanilla JS** para reducir la sobrecarga de configuración y dependencias para una solución CRUD directa.