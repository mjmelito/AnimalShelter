# Animal Shelter API

#### A simple C# API built for Animal Shelters to store and display information about animals available for adoption

#### By Matthew Melito

## Technologies Used

* C#
* .NET6
* MySQL
* Asp.NetCore
* Entity Framework Core
* SwaggerUIS

## Description

This API was designed and built using the dotnet new api scaffolding and MySql. It has endpoints for Get, Get by Id, Post, Put, and Delete. 


## Setup/Installation Requirements

#### Installing .NET and MySQL
1. Install .NET6 if you have not done so. Visit [this link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to download the recommended versions of both software packages.
2. Follow the installer prompts to install the software. Use the default settings.
3. In a terminal, install `dotnet-script` by entering the following command: `$ dotnet tool install -g dotnet-script`. You will also need to configure your environment to access this tool. See [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
4. Install MySQL.  Follow the instructions at [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

#### Cloning and Initial Setup

5. Clone project repository from https://github.com/mjmelito/AnimalShelter
6. Navigate to the project's root directory, AnimalShelterApi
7. Install the MySglConnector Package with the following terminal command: dotnet add package MYSqlConnector -v 2.2.0. Then enter 'dotnet restore'.
8. Within the AnimalShelterApi directory, add a file named 'appsettings.json and add the following code to the file:

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_mysqlconnector;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
9. Be sure to add obj, bin, and appsettings.json to your .gitignore file and commit the file to GitHub to protect your Username and Password.

#### Add Migrations, Create Database, and Run Application
10. Navigate to the 'AnimalShelterApi' directory
11. Run the command "dotnet build"
12. Run the command "dotnet tool install --global dotnet-ef --version 6.0.0"
13. Run the command "dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0"
14. Run the command "dotnet ef migrations add Initial"
15. Run "dotnet ef database update" in your command line.
16. Then run the command "dotnet watch run"

#### API Endpoints
* GET  http://localhost:5000/api/Animals
* GET by Id http://localhost:5000/api/Animals/{id}
* POST http://localhost:5000/api/Animals
* PUT http://localhost:5000/api/Animals/{id}
* DELETE http://localhost:5000/api/Animals/{id}

### API Endpoints with Search Parameters
* GET by Species http://localhost:5000/api/animals?species=[string] (Parameter example: Dog, Cat)
* GET by Breed http://localhost:5000/api/animals?species=[string] (Parameter example: Mixed, Terrier, American Shorthair)
* GET by Name http://localhost:5000/api/animals?species=[string] (Parameter example: Barley, Scout, Pancake)
* GET by Age http://localhost:5000/api/animals?species=[positive-int] 
* GET by MinimumAge http://localhost:5000/api/animals?species=[positive-int] 
* GET by MaximumAge http://localhost:5000/api/animals?species=[positive-int] 


## Known Bugs

* Currently working on implementing Authentication. NOT YET FUNCTIONAL

## This project uses the following license: MIT

Please feel free to reach out and report problems or bugs: matt_melito@outlook.com

Copyright (c) 2023 Matthew Melito