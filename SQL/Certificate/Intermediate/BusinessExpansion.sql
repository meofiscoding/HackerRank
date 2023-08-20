SET NOCOUNT ON;


/*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/

select u.id, u.first_name, u.last_name, c.id, c.customer_name
-- number of contact of each pair of user and customer
from user_account u
join customer c on u.id = c.user_id
join contact ct on c.id = ct.customer_id and u.id = ct.user_account_id
--  get user_account_id and customer_id that have more than 1 contact
where (u.id, c.id) in
(select user_account_id, customer_id as contact_count from contact group by user_account_id, customer_id having count(*) > 1)

go