# _Pierre's Treats_

#### _Practice assignment to get experience using ASP.NET Core MVC, Databases, and many-to-many relationships to help a factory owner track their engineers and machines._

#### By _**Curtis Brooks**_

## Technologies Used

* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _dotnet script, REPL_
* _Razor View Engine_
* _MySQL and MySQL Workbench_
* _Git_


## Setup/Installation Requirements

### Application Setup
* _Install .NET 5.0 [here](https://dotnet.microsoft.com/download/dotnet/5.0)_

* _Clone repository from GitHub to desired location using_
  > git clone https://github.com/curtisbrooks678/Factory.Solution.git
* _In the terminal navigate to and open project directory_
  > cd Factory.Solution
* _Navigate to production folder_
  > cd Factory
* _Create a file in production folder called appsettings.json_
  > touch appsettings.json
* _Add the following code to your .json file_
```
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=curtis_brooks;uid=root;pwd=[YOUR PASSWORD];"
}
}
```
* _Make sure that [YOUR PASSWORD] match the database password of your local MySql server._

### Database Setup

* _Download MySQL and MySQL Workbench to set up a local database_

* _Once installed, open MyMql Workbench and open a local server_

* _Go to the top level of the project directory Factory, then enter the command below to initialize the database on your MySQL Workbench._
  >dotnet ef database update

### To Run Application

* _Navigate to HairSalon production folder in terminal_
  > cd Factory

* _To download obj and bin files needed for the program to run, while still in Factory folder type into the terminal:_
  >dotnet restore

* _To run the program, while still in production folder Factory type into the terminal:_
  >dotnet run
#### Note: The server will not open automatically. The user will need to click on the live share link in terminal, or enter 'localhost:5000' URL into browser.


## Known Bugs

* _No Known Bugs_

## License

_[MIT](https://choosealicense.com/licenses/mit/) Copyright (c) 2022 Curtis Brooks_