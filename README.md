# GTR_Assignment_API

This project is an API for managing employee data using C#, .NET Core, MSSQL, and Entity Framework Core. It provides various endpoints to perform operations related to employee management.

## Used
- ASP.NET Core 7
- Swagger
- MSSQL
- Entity Framework Core

## Table of Contents
   - API01: Login
   - API02: Get All User
   - API03: Get User By ID
   - API04: Add User
   - API05: Update User
   - API06: Delete User
   - API07: Get All Product from real API
   - API08: Get Cart by ID
   - API09: Get Cart by User ID
   - API010: Add Cart

## API01: Login
  -  Endpoint:/api/User/Login
  -  Description: Login into user account.

## API02: Get All User
  -  Endpoint:/api/User/GetAllUser
  -  Description: Get all Users.

## API03: Get User By ID
  -  Endpoint:/api/User/GetUser/{id}
  -  Description: Get user by ID.

##  API04: Add User
  - Endpoint://api/User/AddUser
  - Description: Add Users
    Required Data:

    Name
    Email
    Password
    RoleID

## API05: Update User
  -  Endpoint:/api/User/UpdateUser
  -  Description: Update the specified user.
    Required Data:

    ID
    Name
    Email
    Password
    RoleID

## API06: Delete User
  -  Endpoint:/api/User/DeleteUser/{id}
  -  Description: Delete a User by a specified ID.

## API07: Get All Product from real API
  -  Endpoint:/api/RealApiFetch/GetProductListAll
  -  Description: Get all the data from a real API.

## API08: Get Cart by ID
  -  Endpoint:/api/ProductCart/GetCart/{id}
  -  Description: Get cart by ID.

## API09: Get Cart by User ID
  -  Endpoint:/api/ProductCart/GetCartByUser/{id}
  -  Description: Get Cart By a Specific User ID.

## API010: Add Cart
  -  Endpoint:/api/ProductCart/addCart
  -  Description: Add new Cart.

## Installation and Usage
Follow these steps to install and run the Employee Management API:
### Prerequisites
  - Install .NET Core 7: You can download and install .NET Core 7 from the official website: https://dotnet.microsoft.com/download

  - Clone this repository:
  ```bash
    git clone https://github.com/your/repo.git
    cd repo-folder
  ```
  - Configure your MSSQL database connection. Open the appsettings.json file and update the connection string to point to your MSSQL database.
  ```
  mysql instructions
  ```
  - Run the database migrations to create the necessary tables:
  ```
    add-migration "Use any Name"
    update-database
  ```
  - Build the application:
  ```
    dotnet build
  ```
  - Run the application:
  ```
    dotnet run
  ```


  Feel free to reach out if you have any questions or need further assistance with this project.