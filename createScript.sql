--drop all tables
EXEC sp_MSforeachtable @command1 = "DROP TABLE ?"

create table truckType (
	ID				integer identity(0,1) primary key,
	type			varchar(30),
	manufacturor	varchar(30),
	engineSize		int, --cc
	serviceInterval	int, --km
	maxWeight		int, --kg
	maxVol			int --mm3
)

create table truck (
	ID			integer identity(0,1) primary key,
	vin			varchar(20),
	reg			varchar(20),
	kms			integer,
	availible	bit,
	truckType	int foreign key references truckType(ID) 
)

create table userType (
	ID			integer identity(0,1) primary key,
	userType	varchar(30)
)

create table users (
	ID			integer identity(0,1) primary key,
	username	varchar(30) unique,
	pass		varchar(30),
	userType		int foreign key references userType(ID),
	hours		int,
	fname		varchar(30),
	lname		varchar(30),
	avaliable   bit
)

create table serviceType (
	ID		integer identity(0,1) primary key,
	job		varchar(50),
	cost	money,
	hours	int
)

create table service (
	ID			integer identity(0,1) primary key,
	truckID		integer foreign key references truck(ID),
	mechanic	integer foreign key references users(ID),
	startdate	datetime,
	enddate		datetime
)

create table serviceItem (
	ID			integer identity(0,1) primary key,
	serviceID		integer foreign key references service(ID),
	serviceJob		integer foreign key references serviceType(ID)
)

create table department (
	ID		integer identity(0,1) primary key,
	name	varchar(30)
)

create table customer (
	ID			integer identity(0,1) primary key,
	fname		varchar(30),
	lname		varchar(30),
	email 		varchar(30),
	cell		varchar(20)
)

create table routes (
	ID			integer identity(0,1) primary key,
	departure	integer foreign key references department(ID),
	destination	integer foreign key references department(ID),
	kms			integer
)

create table tripStatus (
	ID		integer identity(0,1) primary key,
	status	varchar(30),
)

create table trip (
	ID			integer identity(0,1) primary key,
	truckID		integer foreign key references truck(ID),
	clientID	integer foreign key references customer(ID),
	startDate	datetime,
	endDate		datetime,
	driverID	integer foreign key references users(ID),
	routeID		integer foreign key references routes(ID),
	statusID	integer foreign key references tripStatus(ID)
)

create table incidentType (
	ID			integer identity(0,1) primary key,
	description	varchar(50),
	cost		money,
	repairTime	int
)

create table incident (
	ID				integer identity(0,1) primary key,
	incidentType	integer foreign key references incidentType(ID),
	driverID		integer foreign key references users(ID)
)

insert into truckType(type, manufacturor, engineSize, serviceInterval, maxWeight, maxVol)
values('Bakkie','Isuzu',2500,15000,1174,1564557280),
    ('Panel Van','Isuzu',2500,15000,3300,1564557280),
	('Container Truck','Isuzu',2500,15000,1174,1564557280),
	('Flat Bed Truck', 'Isuzu',2500, 15000, 13995, 1653668391),
	('Drop Side Truck','Isuzu',2500,15000,3520,1653668391),
	('Refrigerated Truck','Isuzu',2500, 15000, 2780, 1653668391),
	('Crane Truck', 'Isuzu', 2500, 15000,5620,1653668391)

insert into truck(vin,reg,kms,availible,truckType)
values('98765432','Bak-1',200,5,0),
    ('3217589', 'Panel-1', 300,5, 1),
	('9873492','Container-1',250,5,2),
	('8743785','FlatBed-1',400,5,3),
	('9837475','DropSide-1',550,5,4),
	('4389349','Refrigerated-1',650,5,5),
	('3348348','Crane-1',800,5,6),
	('8324903','Bak-2',950,5,0),
    ('3217589', 'Panel-2', 700,5,1),
	('6833427','Container-2',1150,5,2),
	('2925329','FlatBed-2',1400,5,3),
	('4859805','DropSide-2',1550,5,4),
	('9258059','Refrigerated-2',1650,5,5),
	('4883490','Crane-2',1800,5,6),
	('7983250','Bak-3',1200,5,0),
    ('8290325', 'Panel-3', 1300,5, 1),
	('9839357','Container-3',1250,5,2),
	('5780598','FlatBed-3',1450,5,3),
	('3278528','DropSide-3',1550,5,4),
	('8325723','Refrigerated-3',1650,5,5),
	('3363360','Crane-3',1850,5,6),
	('3985989','Bak-4',2200,5,0),
    ('5833479', 'Panel-4', 2300,5, 1),
	('3783364','Container-4',2250,5,2),
	('8555935','FlatBed-4',2450,5,3),
	('3463856','DropSide-4',2550,5,4),
	('2798064','Refrigerated-4',2650,5,5),
	('3478283','Crane-4',2850,5,6),
	('2350255','Bak-5',2250,5,0),
    ('5436980','Panel-5', 3300,5, 1),
	('6383636','Container-5',3250,5,2),
	('7328324','FlatBed-5',3400,5,3),
	('3346903','DropSide-5',3550,5,4),
	('9580378','Refrigerated-5',4650,5,5),
	('3469863','Crane-5',4800,5,6)

insert into department(name)
values('Cape Town'),
	  ('Johannesburg'),
	  ('Durban'),
	  ('P.E')

insert into routes(departure, destination,kms)
values(0,1,1400),
      (0,2,1636),
	  (0,3,755)
	 
insert into userType(userType)
values('Driver'),
	('Service Manager'),
	('General Manager'),
	('Mechanic')

insert into users(username, pass, userType, hours, fname, lname,avaliable)
values('jonny', 'walks', 0, 0, 'Johnny', 'Walker',1),
		('Bart', 'simps', 1, 0, 'Bartholomew', 'Simpson',1),
		('MechBob', '1234', 3, 0,'Billy', 'Bob',1),
		('Carlos', 'lostcar',3,0,'Carlos','Taco',1),
		('Suzaan','4321',2,0,'Suzaan','Du Preez',1)

insert into incidentType (description, cost, repairTime)
values ('Burst tyre', 1000, 1),
('Oil leak',3000,2),
('Cracked windscreen',2000,1),
('Fuel leak',800,2),
('Bumper bashing',900,2),
('Blown bulb',350,2),
('Blown radiator',8000,4),
('Low damage',40000,10),
('Medium damage',80000,60),
('Heavy damage',120000,120)

insert into incident(incidentType, driverID)
values(0,0)

insert into customer(fname,lname,email,cell)
values('Bartholomew', 'Simpson','bart@gmail.com','0845998047'),
	  ('Stan','Marsh','smarsh@gmail.com','0832510799'),
	  ('Billy','Bob','bbob@gmail.com','08228880977'),
	  ('Will','Smith','wsmith@gmail.com','0813420944'),
	  ('Arnold','Schwarzenegger','aschwarzenegger@gmail.com','0837810422')

insert into tripStatus(status)
values('Awaiting Departure'),
		('On Route'),
		('Complete')

insert into trip(truckID, clientID, startDate, endDate, driverID, routeID, statusID)
values(0,0,'2017-11-20 10:34:09.000','2017-11-22 10:34:09.000',0,0, 0)

insert into customer(fname, lname, email, cell)
values('jimbo', 'gregson', 'jimbogregsa@gmail.com','0845998047')

insert into serviceType(job,cost,hours)
values('Oil Leak. Repair Leak and Replace Oil',3000,2),
      ('Burst Tyre. Replace Tire',1000,1),
	  ('Cracked Window. Replace Windscreen',2000,1),
	  ('Fuel Leak. Repair Leak and Replace Fuel',800,2),
	  ('Bumper Bashing. Replace Bumper',900,2),
	  ('Blown Bulb. Find and Replace Broken Bulb',350,2),
	  ('Blown Radiator. Replace Radiator',8000,4),
	  ('Low Damage to Truck, Repair Damage to Truck',40000,10),
	  ('Medium Damage to Truck, Repair Damage to Truck',80000,60),
	  ('High Damage to Truck, Repair Damage to Truck',1200000,120)


insert into service(truckID,mechanic, startdate, enddate)
values(0,1,'2017/11/2','2017/11/2'),
      (1,2,'2017/11/3','2017/11/3'),
	  (2,1,'2017/11/3','2017/11/3'),
	  (4,2,'2017/11/4','2017/11/4'),
	  (6,1,'2017/11/4','2017/11/4'),
	  (3,2,'2017/11/5','2017/11/5'),
	  (5,1,'2017/11/5','2017/11/5')
	  
insert into serviceItem(serviceID, serviceJob)
values(0,0),
      (1,1),
	  (2,2),
	  (3,3),
	  (3,4),
	  (5,5),
	  (5,6),
	  (5,7),
	  (5,8),
	  (2,9)


	  --print list of usernames and password 
select * from users
join userType on users.userType = userType.ID 
where users.userType = 0 and avaliable = 1

--------------------------------------------------------------------------------
select * 
from service
where complete = 1

update service
set complete = 1
where id = 3

