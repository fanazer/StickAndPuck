create table [Teams](
[Id] int identity(1,1),
[Name] nvarchar(64) null,
[Location] nvarchar(264) null,
[LogoPath] nvarchar(max) null);

go

-- add primary key
alter table [Teams]
add constraint [pk_teamId] primary key([Id]);

