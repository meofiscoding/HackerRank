SELECT
    CASE
        WHEN EXISTS (
            SELECT
                T.A,
                T.B INTERSECT
                SELECT
                    T.B,
                    T.C
        ) THEN
            'Isoceles'
        WHEN (A IN (B, C)
        AND B != C ) OR (B IN (A, C)
        AND C != A) THEN
            'Equilateral'
        -- check if sum of 2 column greater than other column
        WHEN (A + B < C AND A + C < B AND B + C < A) THEN
            'Not A Triangle'
        ELSE
            'Scalene'
    END
FROM
    TRIANGLES AS T 
    