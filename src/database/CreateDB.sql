use [master]
go 

--------delete database--------
drop database[StickAndPuckDB]
go

-------create database--------------------------------------------------------------
create database [StickAndPuckDB]
go

use [StickAndPuckDB]
go
------------------------------------------------Data Base----------------------------

-----Tables--------
create table [Teams](
[Id] int identity(1,1),
[Name] nvarchar(64) null,
[Location] nvarchar(264) null,
[LogoPath] nvarchar(max) null);

go

-- add primary key
alter table [Teams]
add constraint [pk_teamId] primary key([Id]);

go
-----------

create table [Players](
[Id] int identity(1,1),
[LastName] nvarchar(32) null,
[FirstName] nvarchar(32) null,
[Birthday] datetime null,
[TeamId] int null,
[MaritalStatusId] int null,
[Salary] int null,
[PhotoPath] nvarchar(max),
[Rating] int unique);

go

-- add primary key
alter table [Players]
add constraint [pk_playerId] primary key([Id]);

-- add foreign key
alter table[Players]
add constraint [fk_teamId] foreign key ([TeamId]) references [Teams]([Id]) on delete set null;

go


-------Procedures---------

create procedure [SelectPlayerById]
@Id int
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
where [P].[Id] = @Id;
go


-------

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

------------------------
create procedure [SelectTeamById]
@Id int
as 
select [Name],
[Location],
[LogoPath] from [Teams] as [T]
where [T].[Id] = @Id ;

go




-----Insert Data for Test--------

insert into [Teams](
[Name],[Location],[LogoPath])
values
('Vancuver','Canada', null),
('Ottava','Canada', null),
('Pitsburg','USA', null);
go

insert into [Players](
[FirstName],[LastName],[Birthday],[MaritalStatusId],[TeamId],[Salary],[PhotoPath],[Rating])
values
('Dzhon','Ovechkin', cast('1985-05-08 00:00:00.000' as datetime),null, 1, 210, null,12),
('Vovan','Malkin', cast('1986-02-05 00:00:00.000' as datetime),null, 2, 410, null,5),
('Sanek','Crosby', cast('1995-05-07 00:00:00.000' as datetime),null, 3, 510, null,8),
('Tolik','Flery', cast('1985-05-08 00:00:00.000' as datetime),null, 2, 214, null,24),
('Anton','Subban', cast('1985-05-08 00:00:00.000' as datetime),null, 3, 213, null,11),
('Snoy','Carlson', cast('1985-05-08 00:00:00.000' as datetime),null, 1, 212, null,3),
('Oleg','Chara', cast('1985-05-08 00:00:00.000' as datetime),null, 1, 219, null,78),
('Ivan','Letang', cast('1985-05-08 00:00:00.000' as datetime),null, 2, 211, null,9),
('Egor','Kessel', cast('1985-05-08 00:00:00.000' as datetime),null, 2, 218, null,31),
('Bob','Guntzel', cast('1985-05-08 00:00:00.000' as datetime),null, 3, 214, null,16),
('Vano','Voronov', cast('1985-05-08 00:00:00.000' as datetime),null, 3, 216, null,27),
('Kolya','Kuznetsov', cast('1985-05-08 00:00:00.000' as datetime),null, 2, 340, null,47),
('Denis','Croft', cast('1985-05-08 00:00:00.000' as datetime),null, 1, 10, null,112);
go







