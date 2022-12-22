select [Doctor], [Professor], [Singer] , [Actor] from 
(select ROW_NUMBER() OVER(PARTITION BY Occupation ORDER BY [Name]) As RowNo, * from OCCUPATIONS) Tab1 
PIVOT 
(Max(Name) for Occupation in ([Doctor], [Professor], [Singer] , [Actor])) Tab2 

