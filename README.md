# Foodall
Projects use .Net Core 2.1 

Entity Framework
Foodall.Data holds references to:
Microsoft.EntityFrameworkCore.SqlServer (nuget) – this has all references you need for EF
Microsoft.EntityFrameworkCore.Design – on your UI project to initialise the database
The project’s FoodallContext class implements DbContext which provides all the logic that EF is going to be using to its change-tracing and database interaction tasks.
There are to ways to init DB: manually and programmatically (from UI project)

Manually:
To initialise the DB manually, you have to implement an OnConfiguring method with a link to the localdb  in FoodallContext class. Use the Package Manager  Console at Foodall.Data default project and run database initialisation and update. First, run get-help entityframeworkcore to see if you get an entity framework unicorn😊 

                     _/\__
               ---==/    \\
         ___  ___   |.    \|\
        | __|| __|  |  )   \\\
        | _| | _|   \_/ |  //|\\
        |___||_|       /   \\\/\\ 
If you can see it you good to go with initialisation.
1.	Set you UI to StartupProject (UI also needs references to Data and Domain projects) and Type add-migration init. Once is done you can see the init and snapshot files in you migration folder in Foodall.Data
2.	Run script-migration to investigate deeper the look of your database you can create a script which is a database representation on production. 
3.	Run update-database to apply migration which builds you database at given location (localdb), and it is done! Check SQL Server Object Explorer to see the DB exists there

Programmatically:
Needs UI project which will be Foodall.WebAPI …In Progress


