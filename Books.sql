-- 1
create table Books (
Id int not null primary key identity,
Title nvarchar(100) not null unique check (Title<>''),
AuthorId int not null foreign key references Authors(Id),
GenreId int not null foreign key references Genres(Id),
ImagePath nvarchar(50) null
);
go
--
insert into Books values
(N'Crime and Punishment',1,1,N'p1.jpg'),(N'Animal Farm',2,2,N'p2.jpg'),(N'Anna Karenina',3,1,N'p3.jpg'),(N'The call of the wild',4,4,N'p4.jpg'),
(N'Romeo and Juliet',5,3,N'p5.jpg'),(N'Christine',6,5,N'p6.jpg'),(N'Harry Potter and the Sorcerers Stone',7,7,N'p7.jpg'),
(N'Harry Potter and the Prisoner of Azkaban',7,7,N'p8.jpg'),
(N'The Green Mile',6,1,N'p9.jpg'),(N'11/22/63',6,6,N'p10.jpg'),(N'1984',2,2,N'p11.jpg'),(N'War and Peace',3,1,N'p12.jpg'),
(N'Idiot',1,1,N'p13.jpg'),(N'Martin Eden',4,1,N'p14.jpg'),(N'The Running Man',6,6,N'p15.jpg'),
(N'Misery',6,5,N'p16.jpg'),(N'White Fang',4,4,N'p17.jpg'),(N'King Lear',5,3,N'p18.jpg')
go

--
select * from Books order by Id;
go

create procedure GetAllBooks
as 
begin 
    select b.Title, a.A_Name, g.G_Name, b.AuthorId, b.GenreId, b.ImagePath
    from Books b, Authors a, Genres g
    where b.AuthorId=a.Id and b.GenreId=g.Id
end;
go
--

exec GetAllBooks

--
create procedure GetBooksByAuthor @authorId int
as
begin
    select b.Title, a.A_Name, g.G_Name, b.AuthorId, b.GenreId, b.ImagePath
    from Books b, Authors a, Genres g
    where b.AuthorId=a.Id and b.GenreId=g.Id
    and b.AuthorId=@authorId
end
go

exec GetBooksByAuthor 6

--
create procedure GetBooksByGenre @genreId int
as
begin
    select b.Title, a.A_Name, g.G_Name, b.AuthorId, b.GenreId, b.ImagePath 
    from Books b, Authors a, Genres g
    where b.AuthorId=a.Id and b.GenreId=g.Id
    and b.GenreId=@genreId
end
go

exec GetBooksByGenre 1