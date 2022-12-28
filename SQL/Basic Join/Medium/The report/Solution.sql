-- get corresponding Grade in B table for Mark in A table
WITH A AS(
    SELECT
        S.NAME,
        G.GRADE,
        S.MARKS
    FROM
        STUDENTS S
        INNER JOIN GRADES G
        ON S.MARKS BETWEEN G.MIN_MARK
        AND G.MAX_MARK
)
SELECT 
    CASE
        WHEN Grade >= 8 THEN
            NAME
        ELSE
            'NULL'
    END AS STUDENTNAME, Grade, marks
FROM
    A
ORDER BY
    A.GRADE DESC,
    NAME, MARKS