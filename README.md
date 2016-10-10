# AspNet Core Mvc-Introducción

## Paso 17 - Implemento Entity Framework

1. Instalo paquetes
    * Install-Package Microsoft.EntityFrameworkCore.Sqlite
    * Agrego Microsoft.EntityFrameworkCore.Design en el project.json
    * Agrego Microsoft.EntityFrameworkCore.Tools
    * Probar el comando "dotnet ef --help"
2. Creo mi contexto
3. Agrego nuevas entidades y genero relaciones
4. Agrego nuevo servicio de Members contra Sql
5. Agrego nuevo metodo commit para salvar los cambios
6. Consumo el metodo commit
7. Registro los servicios de EF, y le paso la cadena de conexion
8. Agrego la configuracion database al appsettings.json
9. Modifico el servicio a utilizar
10. Creo una migracion : dotnet ef migrations add MyFirstMigration
11. Actualizo/Creo la DB: dotnet ef database update --verbose


