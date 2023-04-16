# Pierre's Sweet and Savory Treats
#### By Mike Wilkes
#### A C# MVC application for a bakery to market their products
## Technologies Used

- C#
- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- Razor
- HTML
- Git

## Description

This is a web application that creates a website using the MVC framework and a MySQL database to manage and display data. It is designed to be used by a bakery to market their products. It allows a user to register an account and log in. A registered user can then add products ("Treats") to be displayed on the site. They can also add Flavors (eg, sweet, savory, etc) and the Treats and Flavors can be assigned to each other. Registered users can also add, edit, and delete flavors and treats from the database. Visitors (not registered) can view the lists of flavors and treats and see which treats belong to each flavor.

## Setup instructions
- Clone this repository and open in VS Code

- Navigate to the BakeryTreats directory
- Create an appsettings.json file with the following contents, replacing the values inside brackets [] with your own:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

* Run database migrations to create the needed database tables: 
  * `dotnet ef database update`

- In a terminal window, run:
  - `dotnet restore`
  - `dotnet build`
  - `dotnet run`
- You may be asked to enter your system password
- In a web browser, navigate to https://localhost:5001/ if it does not open automatically.

## Known Bugs
Authorization is not working properly and user cannot add new treat 

## Project Roadmap
Future features could include:
* Styling

## License

MIT License

Copyright (c) _2023_ _Mike Wilkes_