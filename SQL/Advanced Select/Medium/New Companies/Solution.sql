select c.company_code, c.founder, count(distinct l.lead_manager_code),count(distinct s.senior_manager_code),count(distinct m.manager_code),count(distinct e.employee_code) from company c
inner join
lead_manager l
on c.company_code = l.company_code
inner join 
senior_manager s
on c.company_code = s.company_code
inner join
manager m
on c.company_code = m.company_code
inner join
employee e
on c.company_code = e.company_code
group by (c.company_code, c.founder)
