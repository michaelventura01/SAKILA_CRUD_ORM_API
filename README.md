# SAKILA_CRUD_ORM_API
CRUD para emplear un ORM con el consumo de la base de datos sakila

![endpoints](https://github.com/user-attachments/assets/ed2226a8-c526-4a72-bdb0-c9748fe71307)

#### DIAGRAMA
https://drive.google.com/file/d/1t1WPUW3-M8O4dU4hOzcR62PUecJHnxv5/view?usp=sharing

#### Se requiere contar con el modelo de datos siguiente
<p>Es debido cargar en la base de datos mysql el contexto de datos de <b>SCRIPTS/script_sakila_mysql.sql</b></p>

```
├───SAKILA_CRUD_ORM_API
│   │   appsettings.Development.json
│   │   appsettings.json
│   │   Program.cs
│   │   SAKILA_CRUD_ORM_API.csproj
│   │   SAKILA_CRUD_ORM_API.csproj.user
│   │   SAKILA_CRUD_ORM_API.http
│   ├───Controllers
│   │       CategoriasController.cs
│   │       ClienteDireccionController.cs
│   │       ClientesRentasCategoriasController.cs
│   │       PaisCiudadEriController.cs
│   │       PeliculasRentadasCiudadesController.cs
│   │
│   ├───Models
│   │       CategoriaUnica.cs
│   │       ClienteDireccion.cs
│   │       ClientesRentasCategorias.cs
│   │       DBContext.cs
│   │       PaisCiudadEri.cs
│   │       PeliculasRentadasCiudades.cs
│   └───Services
│           CategoriaUnicaService.cs
│           ClienteDireccionService.cs
│           ClientesRentasCategoriasService.cs
│           PaisCiudadEriService.cs
│           PeliculasRentadasCiudadesService.cs
└───SCRIPTS
        qty01.sql
        qty02.sql
        qty03.sql
        qty04.sql
        qty05.sql
        qty06.sql
        qty07.sql
        qty08.sql
        qty09.sql
        qty10.sql
        script_sakila_dwh_postgree.sql
        script_sakila_mysql.sql
        truncado de esquema.sql

```

<p>Para trabajar en el proyecto</p>

```
  # clonan proyecto
  git clone [enlace del proyecto .git]
  
  # validan todas las ramas remotas
  git fetch origin
  git branch -r
  
  # halan rama con su nombre
   git checkout -b {mi rama} origin/{mi rama}
  
  # actualzan rama con su nombre
  git pull origin/{mi rama}

```

<p>Antes de empezar a trabajar</p>

```
  # actualizar su rama de la principal
  git merge master
```


<p>Una vez los cambios esten en su rama seran integrados manualmente a la rama master</p>
