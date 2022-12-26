select * from (select top 1 city, len(city) as [length] from Station where len(city) = (select min(len(city)) from Station) order by city) first
union all
SELECT top 1 city, len(city) as [length] from Station where len(city) = (select max(len(city)) from Station) order by city