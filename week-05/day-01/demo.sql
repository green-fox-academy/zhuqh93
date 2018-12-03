create database BlogApp;

use BlogApp;

create table BlogPosts (
	Id BigInt not null identity,
	Title nvarchar(300),
	Content nvarchar(max)
)

insert into BlogPosts (Title, Content) values ('First blog post', 'This is a nice post')
insert into BlogPosts (Title, Content) values ('Second blog post', 'This is a nice post')
insert into BlogPosts (Title, Content) values ('Third blog post', 'This is a nice post')

select * from BlogPosts
	order by Title desc

update BlogPosts set Content = 'This is much better'
	where Id = 3

delete from BlogPosts
	where Id = 2

create table Users (
	UserId BigInt not null identity,
	Username varchar(80),
	Age Int
);

insert into Users (Username, Age) values
	('john', 30),
	('sarah', 22),
	('jeffrey', 25);

alter table BlogPosts
	add UserId BigInt;

select * from BlogPosts

update BlogPosts set UserId = 1 where Id = 1
update BlogPosts set UserId = 2 where Id = 3

select * from BlogPosts
right join Users on Users.UserId = BlogPosts.UserId

select Title, Content, Username from BlogPosts
inner join Users on Users.UserId = BlogPosts.UserId

select Username, count(BlogPosts.Id) from Users
	left join BlogPosts on BlogPosts.UserId = Users.UserId
	group by Username