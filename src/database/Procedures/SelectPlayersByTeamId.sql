create procedure [SelectPlayersByTeamId]
@TeamId int
as
select [Id],
[FirstName],
[LastName],
[Birthday],
[MaritalStatusId],
[Salary],
[TeamId],
[PhotoPath],
[Rating] from [Players] as [P]
where [P].[TeamId] = @TeamId;
go
