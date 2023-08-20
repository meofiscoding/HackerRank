-- The four quarters are: January to March, April to June, July to September, and October to December. 
SET NOCOUNT ON;

-- select sum of volumns group by coin_code from transactions table by each quarter of the year 2020
SELECT
    c.algorithm,
    SUM(t.Q1) AS Q1,
    SUM(t.Q2) AS Q2,
    SUM(t.Q3) AS Q3,
    SUM(t.Q4) AS Q4
FROM (
    SELECT
        coin_code,
        SUM(CASE WHEN MONTH(dt) BETWEEN 1 AND 3 THEN volume ELSE 0 END) AS Q1,
        SUM(CASE WHEN MONTH(dt) BETWEEN 4 AND 6 THEN volume ELSE 0 END) AS Q2,
        SUM(CASE WHEN MONTH(dt) BETWEEN 7 AND 9 THEN volume ELSE 0 END) AS Q3,
        SUM(CASE WHEN MONTH(dt) BETWEEN 10 AND 12 THEN volume ELSE 0 END) AS Q4
    FROM transactions
    WHERE YEAR(dt) = 2020
    GROUP BY coin_code
) t
JOIN coins c ON c.code = t.coin_code
GROUP BY c.algorithm
ORDER BY c.algorithm

go