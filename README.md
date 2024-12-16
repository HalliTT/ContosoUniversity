
## Author [@Haraldur](https://github.com/HalliTT) 

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)

![Microsoft](https://img.shields.io/badge/Microsoft-0078D4?style=for-the-badge&logo=microsoft&logoColor=white)

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

![MySQL](https://img.shields.io/badge/mysql-4479A1.svg?style=for-the-badge&logo=mysql&logoColor=white)


# Contoso University WebApp
Følge guiden [ef-mvc](https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-8.0)

## Extra Task
1 - Lav  det sådan at når man ser på Student listen, skal man også have vist Courses og Grades for de kurser en Student er tilmeldt.

2 - Når man opretter en ny Student, skal det også være muligt at tilknytte Courses og Grades til denne Student.   

3 - Når man retter en Student, skal det også være muligt at rette Courses/Grades for denne student, slette Courses/Grades for denne student samt til tilføje Courses/Grades for studenten.


## Run Locally

Clone the project

```bash
  git clone https://github.com/HalliTT/ContosoUniversity
```

Go to the project directory

```bash
  cd ContosoUniversity
```

Install dependencies

```bash
  dotnet restore
```

#### Configure the database

1. Update the connection string in [appsettings.json](https://github.com/HalliTT/ContosoUniversity/blob/main/ContosoUniversity/appsettings.json)

```bash
"ConnectionStrings": {
    "DefaultConnection": "Server={SERVER};Integrated Security=true;Database={DATABASE};TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
```
2. Migrate to the database

```bash
  dotnet ef database update
```

Note: Ensure you have the EF Core tools installed. If not, you can install them by running:

```bash
  dotnet tool install --global dotnet-ef

```

Run the project

```bash
  dotnet run
```

OR

```bash
  CTRL+F5
```
