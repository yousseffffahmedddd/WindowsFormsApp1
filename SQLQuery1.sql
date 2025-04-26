
create table  Admin(
Admin_id	int primary key,

Admin_name	 varchar(20),
Admin_email	 varchar(30),
Admin_password varchar(30)


)

create table  Movies(
Mov_name varchar(20),
Mov_rating float,
Mov_duration time,
Mov_category varchar(20),
Mov_year	date,
Mov_language varchar,
Mov_minAge int,
Mov_cast  varchar(20),
Admin_id int foreign key references Admin(Admin_id)


)
create table Show(
Show_start	time primary key,
Show_end time,
Show_date date,
Admin_id int foreign key references Admin(Admin_id)


)
 create table Hall (
 Hall_id int primary key,
 Hall_cap int,
 Show_start time  foreign key references Show(Show_start)



 )

 create table Seat(
 Seat_place	int primary key ,
 Hall_id int  foreign key references Hall(Hall_id)

 )
  create table Payment (
 Payment_id	int primary key ,
 Payment_status binary
 )
 create table Ticket(
 Ticket_id int primary key,
 Ticket_date date,
 Ticket_price money,
 Show_start time foreign key references Show(Show_start) ,
 Payment_id int foreign key references Payment(Payment_id)

 )


 create table Customer (
 Customer_id int,
 Customer_email varchar(30),
 Customer_phoneNum varchar(11),
 Customer_age int,
 Customer_fullName varchar(20)

 )
