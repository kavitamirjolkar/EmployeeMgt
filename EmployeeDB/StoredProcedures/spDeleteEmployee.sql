Create procedure [dbo].[spDeleteEmployee]     
(      
   @EmpId int      
)      
as       
begin      
   Delete from Employee where EmployeeId=@EmpId      
End
