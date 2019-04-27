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
[PhotoPath] nvarchar(max));

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
[PhotoPath] from [Players] as [P]
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
[PhotoPath] from [Players] as [P]
where [P].[TeamId] = @TeamId;
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
[FirstName],[LastName],[Birthday],[MaritalStatusId],[TeamId],[Salary],[PhotoPath])
values
('Dzhon','Ovechkin', cast('1985-05-08 00:00:00.000' as datetime),null, 1, 210, null),
('Vovan','Malkin', cast('1986-02-05 00:00:00.000' as datetime),null, 2, 410, null),
('Sanek','Crosby', cast('1995-05-07 00:00:00.000' as datetime),null, 3, 510, null),
('Tolik','Flery', cast('1985-05-08 00:00:00.000' as datetime),null, 2, 214, null),
('Anton','Subban', cast('1985-05-08 00:00:00.000' as datetime),null, 3, 213, null),
('Snoy','Carlson', cast('1985-05-08 00:00:00.000' as datetime),null, 1, 212, null),
('Oleg','Chara', cast('1985-05-08 00:00:00.000' as datetime),null, 1, 219, null),
('Ivan','Letang', cast('1985-05-08 00:00:00.000' as datetime),null, 2, 211, null),
('Egor','Kessel', cast('1985-05-08 00:00:00.000' as datetime),null, 2, 218, null),
('Bob','Guntzel', cast('1985-05-08 00:00:00.000' as datetime),null, 3, 214, null),
('Vano','Voronov', cast('1985-05-08 00:00:00.000' as datetime),null, 3, 216, null),
('Kolya','Kuznetsov', cast('1985-05-08 00:00:00.000' as datetime),null, 2, 340, null),
('Denis','Croft', cast('1985-05-08 00:00:00.000' as datetime),null, 1, 10, null);
go







