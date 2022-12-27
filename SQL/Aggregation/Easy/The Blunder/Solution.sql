select CEILING(avg(cast(Salary as float)) - AVG(CAST(REPLACE(Salary, '0', '') as float))) from Employees
-- REPLACE() : used to remove 0 from salary.
-- AVG() : used to calculate average salary.
-- CEIL() : used to get next rounded integer.

