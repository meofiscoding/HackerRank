-- CITY names starting with vowels (i.e., a, e, i, o, or u)
select distinct City from Station where City like '[aeiou]%'