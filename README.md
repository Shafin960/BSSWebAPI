# Restaurant-Management-WEB API

It's an ASP.NET WEB API-built restaurant management web application with a SQL Server management database. The main functionalities here are employee management, table management, food management and order management. The tables here are Employee, EmployeeTable, Tables, Orders and Foods. Also created the user using Entity Framework Core's Identity.\
[Live Swagger Link](https://testapi.fashionlady.com.bd/swagger/index.html)



Install Restaurant-Managehttps://github.com/Shafin960/BSSWebAPI/issuesment-WEB API

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
**1)Login**- \
**-POST** api/Authentication/login

**2)Employee-**\
**-GET**   api/Employee/get  (Get All Employees Id and Name)\
**-GET**    api/Employee/non-assigned-employees/{table-id}  (Get the list of employees who are not assigned to any tables yet)\
**-GET**    api/Employee/datatable  (Get the details of all the employees such as name, image, contact number etc) \
**-POST**    api/Employee/create  (To create a new emloyee)\
**-PUT**    api/Employee/update/{id}  (Update the designation of any employee)\
**-DELETE**  api/Employee/delete/{id}  (Delete an employee by id)\

**3)EmployeeTable-**\
**-GET** api/EmployeeTable/get (Get which employee assigned to which table) \
**-PUT** api/EmployeeTable/update{id} (Update an employee to another table)\
**-POST** api/EmployeeTable/create-range (Assign multiple emplyoyee to a single table)\
**-DELETE** api/EmployeeTable/delete{id} (Delete an employee from that table)\

**4)Food-**\
**-GET** api/Food/get (Get all the foods id and name) \
**-GET** api/Food/get{id} (Get a single food's all the details like price, image, id, name, discount etc)\
**-GET** api/Food/datatable (Get all the foods details like price, image, id, name, discount etc)\
**-POST** api/Food/create (Create a new food)\
**-PUT** api/Food/update{id} (Update a food's details)\
**-DELETE** api/Food/delete{id} (Delete a food)\

**5)Order-**\
**-GET** api/Order/datatable (Get all the orders details) \
**-GET** api/Order/get (Get all the orders id and name)\
**-POST** api/Order/create (Create a new order)\
**-PUT** api/Order/update-status{id} (Update a order's status from pending, paid, served)\
**-DELETE** api/Order/delete{id} (Delete an order)\

**6)Table-**\
**-GET** api/Table/get (Get all the tables id and name) \
**-GET** api/Table/get{id} (Get a single table's all the details like id, isOccupied, number of seats etc)\
**-GET** api/Table/datatable (Get all the tables details like id, isOccupied, number of seats etc)\
**-POST** api/Table/create (Create a new table)\
**-PUT** api/Table/update{id} (Update a table's details)\
**-DELETE** api/Table/delete{id} (Delete a table)\



## Screenshots
Swagger Screenshots\
![Screenshot (29)](https://github.com/Shafin960/BSSWebAPI/assets/72936822/2add8e75-8a83-4a97-943b-85da0325587f)
![Screenshot (30)](https://github.com/Shafin960/BSSWebAPI/assets/72936822/3e2b41de-1ad6-46b8-a00e-e97ec9e82225)
![Screenshot (31)](https://github.com/Shafin960/BSSWebAPI/assets/72936822/acda8af5-12ee-450d-9e52-37b6e4e76868)





