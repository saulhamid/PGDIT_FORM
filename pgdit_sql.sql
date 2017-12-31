use master
If exists(select*from master.sys.databases where name ='StudentDB')
 drop database StudentDB
 create database StudentDB
 go
 use StudentDB
 IF OBJECT_ID(N'dbo.students', N'U') IS NOT NULL
BEGIN
 drop table students
END
  go
  create table students
  (
  Id int primary key identity,
  Name nvarchar(100),
  Roll nvarchar(100),
  Age int,
  Gender nvarchar(100) 
  )
  go
  create  index student_index on dbo.students(Name,Roll,Age,Gender)
