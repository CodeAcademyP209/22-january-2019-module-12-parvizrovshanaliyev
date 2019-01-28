

create table Workers(
WorkerId int not null identity(1,1) primary key,
WorkerName nvarchar(50) not null,
WorkerSurname nvarchar(50) not null,
WorkerEmail nvarchar(50) not null,
WorkerPassword nvarchar(50) not null
)

insert into Workers(WorkerName,WorkerSurname,WorkerEmail,WorkerPassword)
values ('Parviz', 'Aliyev', 'p@a', '123'),
('Celal', 'Aliyev', 'p@a', '123'),
('Ali', 'Alizade', 'a@a', '123'),
('Hikmet', 'Rzazade', 'h@r', '123'),
('Bilal', 'Safarov', 'b@s', '123'),
('Dagbeyi', 'Xelilov', 'd@x', '123')
-------------------------------------------------
create table Meetings(
MeetingId int not null identity(1,1) primary key,
MeetingInfo nvarchar(50) not null,
MeetingDate date not null,
MeetingStartTime time not null,
MeetingEndTime time not null,
MeetingOrganiserId int

)

insert into Meetings(MeetingInfo,MeetingDate,MeetingStartTime,MeetingEndTime,MeetingOrganiserId)
values('gun imeclikdi', convert(date,'01-27-2019',101), convert(time,'15:38:12',108), convert(time,'16:38:12',108),1),
('epidemiya haqqinda ', convert(date,'01-27-2019',101), convert(time,'16:39:12',108), convert(time,'17:38:12',108),2)
--------------------------------------------
create table Chairs(
ChairId int not null identity(1,1) primary key,
ChairName nvarchar(50) not null
)

insert into Chairs(ChairName)
values('1-ci yer'), 
('2-ci yer'), 
('3-cu yer'),
( '4-cu yer'),
( '5-ci yer'),
( '6-ci yer'),
( '7-ci yer'),
( '8-ci yer'),
( '9-cu yer'),
( '10-cu yer')
----------------------------------------
create table Connects(
ConnectId int not null identity(1,1) primary key,
ChairId int not null,
WorkerId int not null,
MeetingId int not null
)

create table Logs(
LogId int not null identity(1,1) primary key,
WorkerId int not null,
LogStatus bit not null,
Log_IN datetime,
Log_OUT datetime 
)


alter table Connects
add constraint const01
foreign key (WorkerId)
references Workers(WorkerId)

alter table Connects
add constraint const02
foreign key (ChairId)
references Chairs(ChairId)

alter table Connects
add constraint const03
foreign key (MeetingId)
references Meetings(MeetingId)

alter table Meetings
add constraint const04
foreign key (MeetingOrganiserId)
references Workers(WorkerId)

alter table Logs
add constraint const05
foreign key (WorkerId)
references Workers(WorkerId)
------------------------------------------------------------------------
select  Meetings.MeetingInfo, Meetings.MeetingStartTime, Meetings.MeetingEndTime, Workers.WorkerName, Workers.WorkerSurname from Meetings join Workers on Meetings.MeetingOrganiserId=Workers.WorkerId

ALTER TABLE Logs
DROP COLUMN Log_OUT;

ALTER TABLE Logs
ADD Log_OUT datetime;


