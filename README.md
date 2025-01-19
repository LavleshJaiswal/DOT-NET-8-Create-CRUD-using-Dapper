<h1>Dapper CRUD Project with HTML UI</h1>
<h3>This document provides a comprehensive overview of the Dapper-based CRUD project, including details about the technologies, libraries, and architecture used to implement it.Dapper CRUD Project with HTML UI</h3>
<h3>Project Overview:</h3>
This project demonstrates a CRUD (Create, Read, Update, Delete) operation using Dapper as the ORM (Object-Relational Mapper) and ASP.NET Core 8 MVC for the backend. It also includes an HTML-based UI for interacting with the data.

<strong>Key Features:</strong>
<ul>
  <li>
Uses Dapper for lightweight and efficient data access.
</li>
  <li>
Follows a repository pattern for data management.
    </li>
<li>
Implements a stored procedure for CRUD operations.
</li>
  <li>
Incorporates HTML-based Razor views for a user-friendly interface.
</li>
  <li>
Follows .NET Core best practices for maintainable and testable code.
</li>
</ul>
<strong>Prerequisites</strong>
Before running the project, ensure you have the following installed:
<ul>
<li>
.NET 8 SDK
</li>
<li>
SQL Server
</li>
<li>  
Visual Studio 2022 (or later) with the ASP.NET and web development workload enabled.
</li>
<li>
NuGet Packages:
<li>
Dapper
  </li>
  <li>
Microsoft.Data.SqlClient
</li>
</li>
</ul>
<strong>
Install these packages using the NuGet Package Manager or the CLI:</strong>
<ul>
  <li>Install-Package Microsoft.Data.SqlClient
</li>
  <li>
    Install-Package Dapper
  </li>
</ul>
<h3>How to Run the Project</h3>
<ol>
  <li>
Clone the repository from GitHub.
</li>
  <li>
Restore NuGet packages by running:<br>
    dotnet restore
</li>
  
<li>

Update the connection string in appsettings.json to point to your SQL Server.
</li>
<li>
Run the SQL script to create the database and stored procedure.
</li>
<li>
Run the application:<br>

dotnet run
</li>
Access the application in your browser at https://localhost:5001 or http://localhost:5000.
</ol>
