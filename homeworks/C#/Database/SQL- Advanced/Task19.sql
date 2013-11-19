--Write SQL statements to insert several records in the Users and Groups tables.


use TelerikAcademy
go
insert into TelerikGroups
values ('Groupe13')
go

insert into TelerikGroups
values ('Group113')
go

insert into TelerikUsers
values ('c',123456,'ccc',GETDATE(),3), ('d',123456,'ddd',GETDATE(),4)
go