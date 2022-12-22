select [Doctor], [Professor], [Singer] , [Actor] from 
(select SELECT ROW_NUMBER() OVER(PARTITION BY [Name] ORDER BY Occupation) As RowNo, * from OCCUPATIONS) Tab1 
PIVOT 
(Max(Name) for Occupation in ([Doctor], [Professor], [Singer] , [Actor])) Tab2 