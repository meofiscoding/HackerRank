SELECT
 -- scale to 2 decimal value
    CAST(SUM(LAT_N) AS DECIMAL(10,
    2)),
    CAST(SUM(LONG_W) AS DECIMAL(10,
    2))
FROM
    STATION