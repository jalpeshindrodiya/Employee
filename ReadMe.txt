Create sample employee and department SQL table:
Create New Project Asp.net WebApplication with MVC
Right Click on the Project and go to Manage NuGet Packages
Click on the browse button then find entity framework.
Right Click on the project -> go to Add -> New Item - >Select ADO.NET Entity Data Model. Give model name.
Click on the  New Connection -> Select Data Source as Microsoft SQL Server
Choose Server Name & Database Name then click OK
By default connection string will be generated -> Select Table Data
Add new controller with the name "Employees" & "Departments"
Select Model Class and Data Context cClass from combo box. Select Generate View Checkbox and give controller a name
Change default "Home" controller to  "Employees" and hit F5 to run the sample.
Add Link "Employees" & "department" in Layout page.
Changes in controller,view and model as per requirements.
