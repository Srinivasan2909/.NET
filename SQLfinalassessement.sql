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
select c.customer_number,firstname, account_number from customer_master c
join account_master a 
on a.customer_number=c.customer_number
where account_status='TERMINATED'

--answer5
select count(t.transaction_type), t.transaction_type as Trans_Count from transaction_details t join account_master a
on t.account_number=a.account_number
where a.customer_number like '%001'
group by t.transaction_type

--answer6
select count(customer_number) as Count_Customer from customer_master where customer_number not in
(select customer_number from account_master)

--answer7
select account_number , sum(transaction_amount ) as Deposit_Amount
from transaction_details
where transaction_details.transaction_type='DEPOSIT'
group by transaction_details.account_number
order by transaction_details.account_number
