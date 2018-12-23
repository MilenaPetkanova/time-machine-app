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
  - Could **list all** activity statistics for all *Users*.
  - Could **read** all *User* profiles.
- User  
  - Could **crete**, **read** and **update** its onw *UserProfile*. 
  - Could **update** the privacy of its own *UserProfile*.
  - Could **read** *Letter* in its own *UserProfile*.
- Guest 
  - Could register/login as *User*.
  - Could **read** list of all *Users*.
  - Could **read** *UserProfile* if privacy is public.
  - Could **create**, **read**, **update** *Letter*.
  
## Models
- User 
  - FullName
  - CreatorFullName
  - Email
  - Password
  - BirthDate
  - *UserProfile*
- UserProfile
  - *User*
  - List of *Story*
  - List of *Photo*
  - List of *Video*
  - *FamilyTree*
  - List of *Letter*
- Story
  - *UserProfile* 
  - CreatedOn
  - CurrentUserAge
  - TextContent
- Photo 
  - *UserProfile* 
  - Title
  - Caption
  - UploadedOn
  - CapturedOn
  - Url
- Video
  - *UserProfile* 
  - Title
  - Caption
  - UploadedOn
  - CapturedOn
  - Url
- Family Tree 
  - *UserProfile* 
  - Url
  - Text
- Letter 
  - *UserProfile* 
  - CreatedOn
  - CurrentUserAge
  - SenderFullName
  - SenderRelation (optional)
  - TextContent

## Controllers
- Home 
  - Admin: R
  - Writer: R
  - Guest: R
- Stories 
  - Admin: R
  - Writer: CRU
  - Guest: R if *UserProfile* is public
- Photos 
  - Admin: R
  - Writer: CRU
  - Guest: R if *UserProfile* is public
- Videos
  - Admin: R
  - Writer: CRU
  - Guest: R if *UserProfile* is public
- Family Tree
  - Admin: R
  - Writer: CRU
  - Guest: R if *UserProfile* is public
- Letter
  - Admin: R
  - Writer: R
  - Guest: CRU

## Views
- Home
- Story
- Photo
- Video
- FamilyTree
- Letter



