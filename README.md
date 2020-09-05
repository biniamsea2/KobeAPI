# KobeAPI
*Author: Biniam Tesfamariam*

----

## Program Summary 
In honor of the late great Kobe Bryant I decided to create a Kobe Bryant API for Mamba Day. This application was created using Visual Studio and written in C#. This application has three get methods:  

[HttpGet] Gets one random Kobe Bryant record from the database
[HttpGet("{id}")] Gets one Kobe Bryant record from the database based on the ID given from the user. 
[HttpGet("all")] Grabs all the Kobe Bryant records from the database.


## Application Specifications
###### This application includes the following:  

#### 1) Startup File 
- DBContext registered in ConfigureServices  
- Service registered in ConfigureServices    
- Use of static files accepted  

#### 2) Controller  
- KobeController  
#### 3) Data  
- DBContext present and properly configured  
- DB Tables for each entity model (DbSet<Kobe>)  
- Composite key association present in OnModelCreating override.  
- appsettings.json file present with name of database updated.  
 
#### 4) Models  
- Each Entity from the DB Table converted into a Model  
- Proper naming conventions of Primary keys  
- Navigation properties present in each Model where required  
---

### Getting Started
Clone this repository to your local machine.

```
$ git clone https://github.com/biniamsea2/KobeAPI.git
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```KobeBryant``` directory.

Then select and open ```KobeBryant.sln```

---

### Visuals

### Entity Relationship Diagram
![Image 1]()
### Application Home Page
![Image 1]()
### View of All Hotels
![Image 1]()
### Editing a Hotel
![Image 1]()
### Deleting a Hotel
![Image 1]()
### View of All Amenities
![Image 1]()
### View of All Rooms
![Image 1]()
### Delete a Room
![Image 1]()

---
### Records Table:  
The "Records" table in our KobeDB database consists of all records currently held by Kobe Bryant. Each row has information regarding a primary ID key, name, Team, and Record. address, phone number, and the numer of rooms. 

Records found at: https://en.wikipedia.org/wiki/List_of_career_achievements_by_Kobe_Bryant  

---
