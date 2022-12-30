select *, CASE
        when (A + B > C OR A + C > B OR B + C > A) THEN
            CASE
                when (A = B AND B = C) THEN 'Equilateral'
                when (A = B OR B = C OR A = C) THEN 'Isosceles'
                else 'Scalene'
            END
        else 'Not A Triangle'
    END AS TriangleType
from Triangles