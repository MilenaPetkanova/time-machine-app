## Time Machine App

###### Describtion:
This platform is the spacetime, where parents from the present could tell or show anything to theirs children from the future.

###### Prerequisites:


###### Installation:


###### Contributing:
Milena Petkanova

###### License:
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




