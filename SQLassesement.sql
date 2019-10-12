create table branch_master(
branch_id varchar(6) primary key,
branch_name varchar(30),
branch_city varchar(30),
)
drop table branch_master
drop table loan_details


create table loan_details(
customer_number varchar(6) foreign key references branch_master(branch_id),
branch_id varchar(6) foreign key references customer_master(customer_number),

loan_amount int 
)


create table customer_master(
customer_number varchar(6) primary key,
firstname varchar(30),
middlename varchar(30),
lastname varchar(30),
customer_city varchar(15),
customer_contact_no varchar(10),
occupation varchar(20),
customer_date_of_birth DATE)
drop table customer_master

create table account_master(
account_number varchar(6) primary key,
customer_number varchar(6) foreign key references customer_master(customer_number),
branch_id varchar(6) foreign key references branch_master(branch_id),
opening_balance int,
account_opening_date DATE,
account_type varchar(10),
account_status varchar(10))
drop table account_master

create table transcation_details(
transaction_number varchar(6) primary key,
account_number varchar(6) foreign key references account_master(account_number),
date_of_transcation DATE,
medium_of_transcation varchar(20),
transcation_type varchar(20),
transcation_amount INT)
drop table transcation_details


insert into branch_master values ('B00001','ASAF ALI ROAD','DELHI')
insert into branch_master values ('B00002','NEW DELHI MAIN BRANCH','DELHI')
insert into branch_master values ('B00003','DELHI CANTT','DELHI')
insert into branch_master values ('B00004','JASOLA','DELHI')
insert into branch_master values ('B00005','MAHIM','MUMBAI')
insert into branch_master values ('B00006','VILE PARLE','MUMBAI')
insert into branch_master values ('B00007','MANDVI','MUMBAI')
insert into branch_master values ('B00008','JADAVPUR','KOLKATA')
insert into branch_master values ('B00009','KODAMBAKKAM','CHENNAI')

insert into customer_master values('C00001','RAMESH','CHANDRA','SHARMA','DELHI','9543198345','SERVICE','1976-12-06')
insert into customer_master values('C00002','AVINASH','SUNDER','MINHA','DELHI','9876532109','SERVICE','1974-10-16')
insert into customer_master values('C00003','RAHUL',NULL,'RASTOGI','DELHI','9765178901','STUDENT','1981-09-26')
insert into customer_master values('C00004','PARUL',NULL,'GANDHI','DELHI','9876532109','HOUSEWIFE','1976-11-03')
insert into customer_master values('C00005','NAVEEN','CHANDRA','AEDEKAR','MUMBAI','8976523190','SERVICE','1976-09-19')
insert into customer_master values('C00006','CHITRESH',NULL,'BARWE','MUMBAI','7651298321','STUDENT','1992-11-06')
insert into customer_master values('C00007','AMIT','KUMAR','BORKAR','MUMBAI','9875189761','STUDENT','1981-09-06')
insert into customer_master values('C00008','NISHA',NULL,'DAMLE','MUMBAI','7954198761','SERVICE','1975-12-03')
insert into customer_master values('C00009','ABHISHEK',NULL,'DUTTA','KOLKATA','9856198761','SERVICE','1973-05-22')
insert into customer_master values('C00010','SHANKAR',NULL,'NAIR','CHENNAI','8765489076','SERVICE','1976-07-12')
select * from customer_master
drop table customer_master


insert into loan_details values('C00001','B00001',100000)
insert into loan_details values('C00002','B00002',200000)
insert into loan_details values('C00009','B00008',400000)
insert into loan_details values(null,'B00009',500000)
insert into loan_details values('C00001','B00003',600000)
insert into loan_details values('C00002','B00001',600000)


insert into account_master values('A00001','C00001','B00001',1000,'2012-12-15','SAVING','ACTIVE')
insert into account_master values('A00002','C00002','B00001',1000,'2012-06-12','SAVING','ACTIVE')
insert into account_master values('A00003','C00003','B00002',1000,'2012-05-17','SAVING','ACTIVE')
insert into account_master values('A00004','C00002','B00005',1000,'2013-01-27','SAVING','ACTIVE')
insert into account_master values('A00005','C00006','B00006',1000,'2012-12-17','SAVING','ACTIVE')
insert into account_master values('A00006','C00007','B00007',1000,'2010-08-12','SAVING','ACTIVE')
insert into account_master values('A00007','C00007','B00001',1000,'2012-10-02','SAVING','ACTIVE')
insert into account_master values('A00008','C00001','B00003',1000,'2009-11-09','SAVING','ACTIVE')
insert into account_master values('A00009','C00003','B00007',1000,'2008-11-30','SAVING','ACTIVE')
insert into account_master values('A00010','C00004','B00002',1000,'2013-03-01','SAVING','ACTIVE')
drop table account_master




insert into transcation_details values('T00001','A00001','2013-01-01','CHEQUE','DEPOSIT',2000)
insert into transcation_details values('T00002','A00001','2013-02-01','CASH','WITHDRAWAL',1000)
insert into transcation_details values('T00003','A00002','2013-02-01','CASH','DEPOSIT',3000)
insert into transcation_details values('T00004','A00007','2013-01-11','CASH','DEPOSIT',7000)
insert into transcation_details values('T00005','A00007','2013-01-13','CASH','DEPOSIT',9000)
insert into transcation_details values('T00006','A00001','2013-03-13','CASH','DEPOSIT',4000)
insert into transcation_details values('T00007','A00001','2013-03-14','CHEQUE','DEPOSIT',3000)
insert into transcation_details values('T00008','A00001','2013-03-21','CASH','WITHDRAWAL',9000)
insert into transcation_details values('T00009','A00001','2013-03-22','CASH','WITHDRAWAL',2000)
insert into transcation_details values('T00010','A00002','2013-03-25','CASH','WITHDRAWAL',7000)
insert into transcation_details values('T00011','A00007','2013-03-26','CASH','WITHDRAWAL',2000)

select * from transcation_details
select * from branch_master
select * from loan_details
select * from customer_master
select * from account_master

--answer1
select a.account_number,c.customer_number,c.firstname,c.lastname,
a.account_opening_date from account_master a, customer_master c where 
a.customer_number=c.customer_number;

--answer2
select count(customer_city) as CustomercountfromDelhi from customer_master where customer_city='DELHI'

--answer3
select a.customer_number,c.firstname,a.account_number 
from account_master a,customer_master c
where a.customer_number=c.customer_number and
day(account_opening_date) > 15 order by customer_number

select a.customer_number,c.firstname,a.account_number 
from account_master a,customer_master c
where a.customer_number=c.customer_number and
day(account_opening_date) > 15 order by account_number

--answer4
select c.customer_number,firstname, a.account_number from customer_master c,account_master a
where a.customer_number=c.customer_number and account_status='TERMINATED'
order by customer_number

select c.customer_number,firstname, a.account_number from customer_master c
join account_master a 
on a.customer_number=c.customer_number
where account_status='TERMINATED'


--answer5
select count(t.transcation_type) as total, t.transcation_type as trans_count from transcation_details t join account_master a
on t.account_number=a.account_number
where a.customer_number like '%001'
group by t.transcation_type

select count(t.transcation_type) as total, t.transcation_type as trans_count from transcation_details t,account_master a
where t.account_number=a.account_number and a.customer_number like '%001'
group by t.transcation_type

--answer6
select count(customer_number) as Count_Customer from customer_master where customer_number not in
(select customer_number from account_master)

--answer7
select account_number , sum(transcation_amount ) as Deposit_Amount
from transcation_details
where transcation_type='DEPOSIT'
group by account_number
order by account_number

select account_number , sum(transcation_amount ) as Deposit_Amount
from transcation_details
where transcation_details.transcation_type='DEPOSIT'
group by transcation_details.account_number
order by transcation_details.account_number
select * from transcation_details














