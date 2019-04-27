create procedure [SelectTeamById]
@Id int
as 
select
[Name],
[Location],
[LogoPath] from [Teams] as [T]
where [T].[Id] = @Id ;

go