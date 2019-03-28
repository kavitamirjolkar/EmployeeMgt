CREATE Procedure [dbo].[spAddEmployee]     
(    
    @Name VARCHAR(20),     
    @City VARCHAR(20),    
    @Department VARCHAR(20),    
    @Gender VARCHAR(6)    
)    
as     
Begin     
    Insert into Employee(Name,City,Department, Gender)     
    Values (@Name,@City,@Department, @Gender)     
End
Select * From Employee
