# Time Machine App

This platform is the spacetime, where parents from the present could tell or show anything to theirs children from the future.

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites:


### Installation:



## Running the tests

### Break down into end to end tests

### And coding style tests

## Contributing:
Milena Petkanova

## License:
MIT License

###### Contact
milenapetkanova@gmail.com

###### Authors
- Milena Petkanova

See also the list of contributors who participated in this project.



Roles:
Admin - could list all writers
Writer - crete letters, photos, videos, family tree // could add readers
Guest - could register/login

Models:
User (personal name, child name, email, Letters, Photos) 
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




