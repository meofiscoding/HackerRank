select distinct t1.x, t1.y from 
(select ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS row_number1,* from Functions) t1
inner join
(select ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS row_number2,* from Functions) t2 
on 
t1.x = t2.y and t1.y = t2.x
where t1.row_number1 != t2.row_number2 and (t1.x< t1.y or t1.x= t1.y)
order by t1.x