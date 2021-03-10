--1
create table Genres (
Id int not null primary key identity,
G_Name nvarchar(50) not null unique check (G_Name<>'')
);
go
--
insert into Genres values
(N'Drama'), (N'Dystopia'),(N'Poetry'),(N'Adventures'),(N'Thriller'),(N'Fantasy'),(N'Fairy tale');
go

--
select * from Genres order by Id;
go

-- 2

create procedure GetAllGenres
as 
begin 
    select * from Genres order by Id;
end;
go
--

exec GetAllGenres