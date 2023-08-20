-- Write a query to retrieve a list of all customer ids, names, and phone numbers, with their country codes concatenated with their phone numbers with +. 
-- Sort the output in the order of their customer_id.
select c.customer_id, c.name,concat("+" + cc.country_code, c.phone_number) as phone 
from customers c inner join country_codes cc on c.country = cc.country order by c.customer_id;
