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
