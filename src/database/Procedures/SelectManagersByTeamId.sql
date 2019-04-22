create procedure [SelectManagersByTeamId]
@TeamId int
as
select [Id],
[FirstName],
[LastName],
[Birthday],
[TeamId],from [Managers] as [M]
where [M].[TeamId] = @TeamId;
go
