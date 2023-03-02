use project_Semester1;
go

create table LogInTest(
ID int not null primary key,
username varchar(max),
pass varchar(max),
)

insert into LogInTest(ID, username, pass)values(1, 'toni', 'toni123')
insert into LogInTest(ID, username, pass)values(2, 'mira', 'mira123')