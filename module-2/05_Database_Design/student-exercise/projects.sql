USE master;
GO

--DROP DATABASE IF EXISTS Project;

Create database Project;
GO

Use Project 
Go 

Begin Transaction; 

Create table Employees 
(
employeeId int identity(1,1),
job_title varchar(100) not null, 
firstName varchar(64) not null,
lastName varchar (64) not null,
gender varchar (24) not null,
date_of_birth date not null, 
date_of_hire date not null,
departmentId int not null,
constraint pk_Employees primary key (employeeId)
);

Create table Department
(
departmentId int identity (1,1),
name varchar (64) not null,
constraint pk_Department primary key (departmentId)
);

Create table Projects
(
projectId int identity (1,1),
name varchar (64) not null,
startDate datetime not null,
constraint pk_Projects primary key (projectId) 
);
create table Project_employee
(
projectId int not null,
employeeId int not null,
constraint pk_Project_employee primary key (projectId, employeeId)

)
alter table Employees add constraint fk_Employees_Department foreign key (departmentId) references Department(departmentId);

alter table Project_employee add constraint fk_Projects_Project_employee foreign key(employeeId) references Employees(employeeId);
alter table Project_employee add constraint fk_Projects_Project_Projects foreign key(projectId) references Projects(projectId);


commit; 

--insert 


insert into Department (name) values ('Gotham')
insert into Department (name) values ('Batcave'), ('Fortress of Solitude')


select * from Department
select * from Employees
select * from Projects


insert into Projects (name, startDate) values ('Wonder Woman', '10-2-2020')
insert into Projects (name, startDate) values ('The Batman', '10-1-2007'), ('Justice League', '7-8-2016'), ('Shazam', '7-1-2018')

select * from Employees


insert into Employees (job_title, firstName, lastName, gender, date_of_birth, date_of_hire, departmentId) values 
('Batman', 'Bruce', 'Wayne', 'Male', '10-5-1969', '10-19-2020', 1)
insert into Employees (job_title, firstName, lastName, gender, date_of_birth, date_of_hire, departmentId) values 
('Catwoman', 'Selina', 'Kyle', 'Female', '12-6-1985', '7-5-2020', 1)
insert into Employees (job_title, firstName, lastName, gender, date_of_birth, date_of_hire, departmentId) values 
('Green Lantern', 'Hal', 'Jordan', 'Male', '6-6-1965', '8-23-2006', 2)
insert into Employees (job_title, firstName, lastName, gender, date_of_birth, date_of_hire, departmentId) values 
('The Flash', 'Barry', 'Allen', 'Male', '9-16-1954', '8-3-1996', 2)
insert into Employees (job_title, firstName, lastName, gender, date_of_birth, date_of_hire, departmentId) values 
('Shazam', 'Billy', 'Batson', 'Male', '10-16-2010', '3-3-2020', 2)
insert into Employees (job_title, firstName, lastName, gender, date_of_birth, date_of_hire, departmentId) values 
('Wonder Woman', 'Diana', 'Prince', 'Female', '8-6-1854', '3-3-1946', 3)
insert into Employees (job_title, firstName, lastName, gender, date_of_birth, date_of_hire, departmentId) values 
('Superman', 'Clark', 'Kent', 'Male', '1-8-1924', '1-6-1956', 3)
insert into Employees (job_title, firstName, lastName, gender, date_of_birth, date_of_hire, departmentId) values 
('Nightwing', 'Dick', 'Grayson', 'Male', '12-17-1999', '5-9-2013', 1)

select * from Project_employee


insert into Project_employee (projectId, employeeId) values (1,6)
insert into Project_employee (projectId, employeeId) values (1,8)
insert into Project_employee (projectId, employeeId) values (2,1)
insert into Project_employee (projectId, employeeId) values (2,2)
insert into Project_employee (projectId, employeeId) values (3,7)
insert into Project_employee (projectId, employeeId) values (3,4)
insert into Project_employee (projectId, employeeId) values (4,5)
insert into Project_employee (projectId, employeeId) values (4,3)