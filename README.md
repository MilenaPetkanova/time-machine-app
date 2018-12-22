# Time Machine App

This platform is the spacetime, where parents from the present could tell or show anything to theirs children from the future.

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites:
TODO: What things you need to install the software and how to install them.

### Installation:
TODO: A step by step series of examples that tell you how to get a development env running.

## Running the tests
TODO: Explain how to run the automated tests for this system.

### Break down into end to end tests
TODO: Explain what these tests test and why
```
code examples
```

### And coding style tests
TODO: Explain what these tests test and why.
```
code example
```

## Deployment
TODO: Add additional notes about how to deploy this on a live system.

## Built With
- [ASP.NET Core](https://www.asp.net/core/overview/aspnet-vnext) - The web framework used
- [NuGet](https://www.nuget.org/) - Dependency Management

## Contributing
Please read [CONTRIBUTING.md]() for details on our code of conduct, and the process for submitting pull requests to us.

## Authors
- [Milena Petkanova](https://github.com/MilenaPetkanova)
See also the list of [contributors](https://github.com/MilenaPetkanova/time-machine-app/graphs/contributors) who participated in this project.

## License
This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

## Contact
milenapetkanova@gmail.com

# Documenation
The software architecture pattern used in this app is Model View Controller (MVC).

## Roles
- Admin 
  - Could **read** all User profiles.
  - Could list activity statistics for all Users.
- User  
-- Could **crete**, **read** and **update** stories, photos, videos, family tree. 
- Guest 
-- Could register/login.
-- 

## Models
User (n, , email, Letters, Photos) 
Story (date, age, text)
Photo (title, caption, url, month, year)
Video (title, caption, url, month, year)
Family Tree 
Letter (date, age, sender name, sender relation, text)

Views:
Home page 
Story (CRU)
Photo (CRUD)
Video (CRUD)
Family Tree (CRUD)
Letter (CRUD)

Controllers:
Home (Admin: R, Writer: R, Guest: R)
Stories (Admin: R, Writer: CRU, Guest: NA)
Photos (Admin: R, Writer: CRU, Guest: NA)
Videos (Admin: R, Writer: CRU, Guest: NA)
Family Tree (Admin: R, Writer: CRU, Guest: NA)
Letter (Admin: R, Writer: R, Guest: CRU)




