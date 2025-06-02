# SAKILA_CRUD_ORM_API
CRUD para emplear un ORM con el consumo de la base de datos sakila

#### Se requiere contar con el modelo de datos siguiente
<p>Es debido cargar en la base de datos mysql el contexto de datos de <b>SCRIPTS/script_sakila_mysql.sql</b></p>

```
├───SAKILA_CRUD_ORM_API
│   │   appsettings.json
│   │   Program.cs
│   ├───Controllers
│   │       CategoriasController.cs
│   ├───Models
│   │       CategoriaUnica.cs
│   │       DBContext.cs
│   └───Services
│           CategoriaUnicaService.cs
└───SCRIPTS
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
