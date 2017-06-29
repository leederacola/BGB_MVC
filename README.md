# BGB_MVC
My First REAL go at a .Net MVC web application using EntityFrameWork.
I have worked through  Pro MVC 5 Sports Store and Microsofts. 

I am typing this with a  wonderful wiggling baby girl is strpped to my chest, watching magic school bus on youtube. 
I hope it isnt rotting her infant brain. Progress will come when time is available. 

Board Game Collection App
Basic Idea:
  Have users, have games, have users add games to their Library.  Sort and query those games.

Data Model
  Game: boar game titles & properties
  User: User Name & ICollection<Collections>
  Collection: User ID and Game ID
As of now a new collection object has to be created to add Game to User.
I have a feeling this can be completed more efficiently probably w/o Collection object but this is also my
first go at databases so Ill stick with similar model to MS tutorial.


As of now(6/29)
Initializer adds Games, Users and Collections(to build user Libraries).
Scaffold CRUD Controllers/Views for Users and Games (edit, delete, details) 
Index for each model list items in a table.
Sorting and Searching for Users and Games

Next Update...
---As of Now only way to add to User Library is with initializer.....this will be updated soon---

