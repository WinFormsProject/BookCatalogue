-- 1
create table Authors (
Id int not null primary key identity,
A_Name nvarchar(100) not null unique check (A_Name<>'')
);
go
--
insert into Authors values
(N'Fedor Dostoevsky'), (N'George Orwell'),(N'Leo Tolstoy'),(N'Jack London'),(N'William Shakespeare'),(N'Stephen King'),(N'Joanne Rowling');
go

--
select * from Authors order by Id;
go

-- 2

create procedure GetAllAuthors
as 
begin 
    select * from Authors order by Id;
end;
go
--

exec GetAllAuthors