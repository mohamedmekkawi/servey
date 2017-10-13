create database DbSurvey; 
 
create table RegisterUser( 
numcontrol int not null identity(1,10), 
name varchar(50) not null, 
phone varchar(50) not null, 
gender char(1) not null, 
age int not null, 
userweight float not null, 
userheight float not null,
PRIMARY KEY NONCLUSTERED (NUMCONTROL)
);

insert into RegisterUser (name,phone,gender,age,userweight,userheight) values ('Juan','514-987-6543','M',25,65,68);
insert into RegisterUser (name,phone,gender,age,userweight,userheight) values ('Mohamed','514-967-6543','M',20,75,58);
insert into RegisterUser (name,phone,gender,age,userweight,userheight) values ('Migel','514-957-6553','M',30,85,70);


SELECT * FROM RegisterUser;

update registeruser set age = 60 where name = 'Juan';

delete registeruser where firstname = 'Juan';

Use DbSurvey
GO
create procedure RegisterUserProcedure
@name varchar(50), 
@phone varchar(50), 
@gender char(1), 
@age int, 
@userweight float, 
@userheight float 
AS
BEGIN
insert into registeruser (name,phone,gender,age,userweight,userheight) values (@name,@phone,@gender,@age,@userweight,@userheight)
end
GO

