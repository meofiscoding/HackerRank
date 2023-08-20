SET NOCOUNT ON;


/*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/

select 
    u.id,
    u.first_name, 
    u.last_name,
    t.customer_id, 
    c.customer_name, 
    t.contact_count
from 
(select ct.user_account_id, ct.customer_id, count(*) as contact_count from contact ct group by user_account_id, customer_id having count(*) > 1) t
join customer c
on
c.id = t.customer_id
join user_account u
on
u.id = t.user_account_id

go