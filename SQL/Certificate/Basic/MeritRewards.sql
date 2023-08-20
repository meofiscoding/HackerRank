SET NOCOUNT ON;


/*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/
-- On the basis of merit, a company decides to promote some of its employee in its HR division at the end of the quarter because of their high performance.
-- Write a query to find the employee IDs along with the names of all its employees who work in the HR department who earned a bonus of 5000 dollars or more in the last quarter.   There are two tables in the database: employee_information and last_quarter_bonus. 
-- Their primary keys are employee_ID.

 select e.employee_ID, e.name from employee_information e inner join last_quarter_bonus l on e.employee_ID = l.employee_ID where e.division = 'HR' and l.bonus >= 5000


go
