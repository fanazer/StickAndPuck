create procedure [SelectPlayerById]
@Id int
as
select [Id],
[FirstName],
[LastName],
[Birthday],
[MaritalStatusId],
[Salary],
[PhotoPath] from [Players] as [P]
where @Id = [P].[Id];
go