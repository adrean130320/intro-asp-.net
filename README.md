# intro-asp-.net
# IDE
Visual estudio preferiblemente el 2022
# Base de datos
1. Ejecutar los scripts de bdasp en sql server para crear la base de datos y la tabla
# Instalar depedenicias
se instalaran las dependencias de entity framework sql y tools

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools

# ajustar cadena de conexion
en el archivo appsettings.json en el apartado 

"ConnectionStrings": {

    "PubContext": "Server=xxxxxxxxxxxxxxxxxxxx; Database=xxxxxxxxxxxxx; Trusted_Connection=True;"
    
  }
  
ajustar el PubContext con tu cadena de conexion
