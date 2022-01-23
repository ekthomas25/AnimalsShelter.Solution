# Animal Shelter API

#### By Liz Thomas

#### _An API for an Animal Shelter._

## Technologies Used

* _C#_
* _.NET 5.0_
* _ASP.NET Core MVC_
* _Entity_
* _NuGet_
* _Git_
* _MySQL_
* _MySQL Workbench_
* _Postman_
* _Swagger - Swashbuckle_
* _Cors_


## Description
An API built for an Animal Shelter that has cats and dogs. Users can search the API for pets using various endpoints, such as age, weight, breed, and more. This API utilizes Swagger for documentation, versioning, and has CORS enabled for use with client-side JavaScript applications.

## Setup/Installation Requirements

### Your computer will need to have the following installed and set up:
* _[GIT](https://docs.github.com/en/get-started/quickstart/set-up-git)_
* _[Visual Studio Code](https://code.visualstudio.com/download)_
* _.NET 5.0 - [Mac](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer) or [Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer)_
* _[MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)_
* _[Postman(Optional)](https://www.postman.com/downloads/)_

### File Setup

* _Once you have VSCode, Node, and GIT set up, you will need to open up your terminal, navigate to your Desktop and type the command:_
`git clone https://github.com/ekthomas25/AnimalsShelter.Solution.git`

* _This will clone the repository to your desktop and you will be able to then open the folder in VSCode._
* _Open the terminal in VSCode and navigate to_ `AnimalsShelter.Solution > AnimalShelter` _and type the following command:_ `touch appsettings.json`
* _Copy and paste the following code into the new file:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=liz_thomas;uid=root;pwd=[YOUR PASSWORD HERE];"
  }
}
```
* _You will need to input your own password where it says_ [YOUR PASSWORD HERE]

* Make sure you are in the project directory folder, run the command `dotnet ef database update`
* Then run the command `dotnet restore` to install project dependencies

### To Launch the API
* Run the command `dotnet run` to view the project in the browser or to access the API via Postman.

* Navigate to http://localhost:5000/ in your browser.

## API Documentation

### Using Swagger documentation

To view the Animal Shelter API with Swashbuckle, launch the API as instructed above and input the following URL into your browser: `http://localhost:5000/index.html`

#### HTTP Requests

```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```

## Known Bugs

* _No known issues_

## License
_[MIT License](https://opensource.org/licenses/MIT)_

_If you have any questions or would like to reach out for any reason, please don't hesitate to send an email to [thomas.elizabeth.k@gmail.com](mailto:thomas.elizabeth.k@gmail.com)._

Copyright (c) 2022 Elizabeth Thomas