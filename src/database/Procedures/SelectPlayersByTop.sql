create procedure [SelectPlayersByTop]
@Quantity int
as
select top (@Quantity) [Id],
[FirstName],
[LastName],
[Birthday],
[MaritalStatusId],
[Salary],
[TeamId],
[PhotoPath],
[Rating] from [Players] as [P]
order by [P].[Rating] 
go