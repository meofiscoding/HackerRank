SET NOCOUNT ON;


/*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/

select p.sku, p.product_name from product p where p.id not in (select product_id from invoice_item) order by p.sku asc

go