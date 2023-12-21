# Restaurant-Management-WEB API

It's an ASP.NET WEB API-built restaurant management web application with a SQL Server management database. The main functionalities here are employee management, table management, food management and order management. The tables here are Employee, EmployeeTable, Tables, Orders and Foods. Also created the user using Entity Framework Core's Identity.


Install Restaurant-Management-WEB API

Clone Repository 
```bash
  git clone https://github.com/Shafin960/BSSWebAPI.git
```
Navigate to the project directory
```bash
  cd project-name
```
Restore necessary packages
```bash
  dotnet restore
```
Update database migrations in Data Project after correcting you connection string in appsettings.json
```bash
  update-database
```

## Admin Credentials
Username: admin@mail.com \
Password: Admin@123

    
## Features Of The Project
**1)** CRUD operations for Employee, EmployeeTable,Tables, Orders, and Foods entities.

**2)** Authentication and authorization using Dotnet Identity roles.

**3)** API endpoints for interacting with the tables.

## Frameworks Used

**Backend-** ASP.NET Web Api (7)\
**Database-** SQL Server

## API Endpoints
**1)Login**- POST api/Authentication/login

**2)Employee**- GET api/Employee/get (Get All Employees Id and Name)
            - GET api/Employee/non-assigned-employees/{table-id} (Get the list of employees who are not assigned to any tables yet)

**3)** API endpoints for interacting with the tables.

## Screenshots
Swagger Screenshots\

